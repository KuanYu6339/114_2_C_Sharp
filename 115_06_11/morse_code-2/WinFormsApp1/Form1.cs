namespace WinFormsApp1
{
    /// <summary>
    /// 摩斯密碼對應結構
    /// 儲存單一字元與其對應的摩斯密碼
    /// </summary>
    public struct MorseCode
    {
        public char Character;  // 字元
        public string Code;     // 摩斯密碼
    }

    /// <summary>
    /// 摩斯密碼轉換器主程式
    /// 提供文字轉摩斯密碼的功能
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// 摩斯密碼對應表
        /// 儲存所有字元與摩斯密碼的對應關係
        /// </summary>
        private List<MorseCode> morseTable;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form 載入事件
        /// 程式啟動時自動執行，載入摩斯密碼表
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMorseTable();
        }

        /// <summary>
        /// 從檔案載入摩斯密碼表
        /// 讀取 morse_code_table.md 檔案並解析 Markdown Table 格式
        /// </summary>
        private void LoadMorseTable()
        {
            morseTable = new List<MorseCode>();

            // 定義可能的檔案位置
            string[] possiblePaths = new[]
            {
                "morse_code_table.md",
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "morse_code_table.md"),
                Path.Combine(Directory.GetCurrentDirectory(), "morse_code_table.md")
            };

            string filePath = null;

            // 尋找檔案
            foreach (string path in possiblePaths)
            {
                if (File.Exists(path))
                {
                    filePath = path;
                    break;
                }
            }

            // 檔案不存在時顯示錯誤
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("找不到 morse_code_table.md 檔案！\n\n請確認檔案位置：\n" + 
                    string.Join("\n", possiblePaths), "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 使用 StreamReader 讀取檔案
                using (StreamReader inputFile = File.OpenText(filePath))
                {
                    // Step 1: 逐行讀取檔案
                    while (!inputFile.EndOfStream)
                    {
                        string line = inputFile.ReadLine();

                        // 忽略空行
                        if (string.IsNullOrWhiteSpace(line))
                        {
                            continue;
                        }

                        // Step 2: 忽略表頭行
                        if (line.Contains("Character") || line.Contains(":---"))
                        {
                            continue;
                        }

                        // Step 3: 使用 | 符號切割 Markdown Table 的每列
                        string[] parts = line.Split('|');

                        // Step 4: 每兩個欄位為一組資料（字元 + 摩斯密碼）
                        for (int i = 1; i < parts.Length - 1; i += 2)
                        {
                            if (i + 1 >= parts.Length)
                            {
                                break;
                            }

                            string characterText = parts[i].Trim();
                            string codeText = parts[i + 1].Trim();

                            // 略過空欄位
                            if (string.IsNullOrWhiteSpace(characterText) || string.IsNullOrWhiteSpace(codeText))
                            {
                                continue;
                            }

                            // Step 5: 移除 Markdown 中的反引號符號
                            codeText = codeText.Replace("`", "");

                            char character;
                            string code = codeText;

                            // Step 6: 特殊字元轉換
                            switch (characterText.ToLower())
                            {
                                // 空白字元特殊處理
                                case "space":
                                    character = ' ';
                                    code = "/";
                                    break;
                                // 逗號
                                case "comma":
                                    character = ',';
                                    break;
                                // 句號
                                case "period":
                                    character = '.';
                                    break;
                                // 問號
                                case "?":
                                    character = '?';
                                    break;
                                // 其他字元
                                default:
                                    if (characterText.Length == 1)
                                    {
                                        character = char.ToUpper(characterText[0]);
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                    break;
                            }

                            // Step 7: 加入摩斯密碼表
                            morseTable.Add(new MorseCode { Character = character, Code = code });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // 檔案讀取錯誤時顯示例外訊息
                MessageBox.Show($"讀取檔案時發生錯誤：\n{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 轉換按鈕點擊事件
        /// 將輸入的文字轉換為摩斯密碼
        /// </summary>
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            // 檢查摩斯密碼表是否已正確載入
            if (morseTable == null || morseTable.Count == 0)
            {
                MessageBox.Show("摩斯密碼表未載入，請檢查 morse_code_table.md 檔案。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Step 1: 清空之前的轉換結果
            listBox1.Items.Clear();
            textBox2.Clear();

            // Step 2: 取得使用者輸入並轉換為大寫
            string input = textBox1.Text.ToUpper();

            // 儲存完整摩斯密碼結果
            string result = "";

            // Step 3: 逐字處理輸入文字
            foreach (char currentChar in input)
            {
                // Step 4: 在摩斯密碼表中搜尋對應的摩斯密碼
                string code = null;

                foreach (MorseCode item in morseTable)
                {
                    if (item.Character == currentChar)
                    {
                        code = item.Code;
                        break;
                    }
                }

                // Step 6: 若字元在表中不存在，直接忽略（不顯示錯誤）
                if (code == null)
                {
                    continue;
                }

                // Step 5: 將摩斯密碼加入結果字串
                result += code + " ";

                // 將字元與摩斯密碼對應加入 ListBox 顯示
                if (currentChar == ' ')
                {
                    listBox1.Items.Add($"空白\t{code}");
                }
                else
                {
                    listBox1.Items.Add($"{currentChar}\t{code}");
                }
            }

            // Step 7: 移除最後多餘的空白並顯示完整結果
            result = result.Trim();
            textBox2.Text = result;
        }

        /// <summary>
        /// 清除按鈕點擊事件
        /// 清空所有輸入和輸出欄位
        /// </summary>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();     // 清空輸入文字框
            textBox2.Clear();     // 清空完整摩斯密碼文字框
            listBox1.Items.Clear(); // 清空逐字對照 ListBox
        }
    }
}
