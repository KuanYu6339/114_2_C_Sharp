using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace morse_code
{
    /// <summary>
    /// Form1 是摩斯密碼轉換應用程式的主要表單
    /// 功能：讀取摩斯密碼表，將用戶輸入的文本轉換為摩斯密碼
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// MorseRecord 結構體：用於記錄單一摩斯密碼項目
        /// 包含字元及其對應的摩斯密碼
        /// </summary>
        public struct MorseRecord
        {
            /// <summary>英文字元或符號</summary>
            public char Character;
            
            /// <summary>該字元對應的摩斯密碼（使用點 . 與線 -）</summary>
            public string Code;
        }

        /// <summary>
        /// 儲存完整摩斯密碼表的 List
        /// 使用 List 而非 Dictionary，以滿足特定需求
        /// </summary>
        private List<MorseRecord> morseList = new List<MorseRecord>();

        /// <summary>
        /// Form1 建構函式
        /// 初始化 UI 元件並載入摩斯密碼表
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            LoadMorseCodeTable();
        }

        /// <summary>
        /// LoadMorseCodeTable 方法
        /// 功能：
        /// 1. 設定摩斯密碼表檔案路徑
        /// 2. 新增空白字元預設對應（防範檔案缺失）
        /// 3. 檢查檔案是否存在
        /// 4. 使用 StreamReader 逐行讀取 Markdown 格式的摩斯密碼表
        /// 5. 解析表格格式，萃取字元與密碼的映射關係
        /// 6. 處理特殊字元名稱（如 "space"、"comma"、"period"）
        /// 7. 將所有有效資料新增至 morseList
        /// </summary>
        private void LoadMorseCodeTable()
        {
            // 設定摩斯密碼表檔案名稱
            string filePath = "morse_code_table.md";

            // 預先新增空白字元對應（Code 為 "/"），防止外部檔案未提供此映射
            morseList.Add(new MorseRecord { Character = ' ', Code = "/" });

            // 檢查摩斯密碼表檔案是否存在於程式執行目錄
            if (!File.Exists(filePath))
            {
                MessageBox.Show($"找不到 {filePath}，請確定該字典檔放置於程式執行目錄中。", "提示");
                return;
            }

            try
            {
                // 開啟檔案並使用 StreamReader 讀取
                // using 確保在讀取完成後自動關閉檔案資源
                using (StreamReader inputFile = File.OpenText(filePath))
                {
                    // 逐行讀取檔案，直到到達檔案末尾
                    while (!inputFile.EndOfStream)
                    {
                        // 讀取一行並去除前後空白
                        string line = inputFile.ReadLine()?.Trim();

                        // 若該行為空或只含空白，略過此行
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        // 使用 "|" 符號分割該行各欄位，移除空欄位
                        string[] cols = line.Split('|', StringSplitOptions.RemoveEmptyEntries);

                        // 若欄位數少於 2 個，不足以形成字元-密碼配對，略過
                        if (cols.Length < 2) continue;

                        // 略過 Markdown 表格的標題行（第一欄通常為 "Character"）
                        if (cols[0].Trim() == "Character") continue;

                        // 略過 Markdown 表格的分隔線（由 ":" 和 "-" 組成）
                        if (cols[0].Trim().Replace("-", "").Replace(":", "").Trim().Length == 0) continue;

                        // 一行內每相鄰的兩個欄位構成一組字元-密碼配對
                        // 迴圈步進為 2，以便成對處理
                        for (int i = 0; i + 1 < cols.Length; i += 2)
                        {
                            // 取得字元部分並去除前後空白
                            string charPart = cols[i].Trim();
                            
                            // 取得密碼部分、去除前後空白及反引號 (`
                            // 反引號可能用於 Markdown 程式碼格式標記
                            string codePart = cols[i + 1].Trim().Trim('`');

                            // 若字元或密碼為空，略過此配對
                            if (string.IsNullOrEmpty(charPart) || string.IsNullOrEmpty(codePart)) continue;

                            // 宣告變數以儲存將要新增的字元
                            char c;

                            // 根據字元名稱進行相應處理
                            // 某些欄位使用名稱而非實際字元（如 "comma" 表示逗號）
                            switch (charPart.ToLower())
                            {
                                case "space":
                                    // "space" 已有預設對應，不需重複新增，直接略過
                                    continue;
                                    
                                case "comma":
                                    // 將特殊名稱 "comma" 轉換為實際的逗號字元
                                    c = ',';
                                    break;
                                    
                                case "period":
                                    // 將特殊名稱 "period" 轉換為實際的句號字元
                                    c = '.';
                                    break;
                                    
                                default:
                                    // 對於其他字元，取第一個字並轉為大寫
                                    c = char.ToUpper(charPart[0]);
                                    break;
                            }

                            // 新增摩斯密碼記錄至 List
                            morseList.Add(new MorseRecord { Character = c, Code = codePart });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // 若在讀取或解析過程中發生異常，顯示錯誤訊息
                MessageBox.Show($"讀取格式錯誤：{ex.Message}", "錯誤");
            }
        }  

        /// <summary>
        /// FindMorseCode 方法
        /// 功能：在 morseList 中循序搜尋指定字元，傳回其對應的摩斯密碼
        /// </summary>
        /// <param name="target">要搜尋的目標字元</param>
        /// <returns>
        /// 若找到目標字元，傳回其摩斯密碼字串；
        /// 若未找到，傳回 null
        /// </returns>
        private string FindMorseCode(char target)
        {
            // 逐一遍歷 morseList 中的所有記錄
            foreach (var record in morseList)
            {
                // 比對目標字元與記錄中的字元
                if (record.Character == target)
                {
                    // 找到匹配的字元，立即傳回其摩斯密碼
                    return record.Code;
                }
            }
            
            // 若遍歷完整個 List 都未找到匹配字元，傳回 null
            return null;
        }

        /// <summary>
        /// button1_Click 事件處理方法
        /// 功能：處理轉換按鈕的點擊事件
        /// 流程：
        /// 1. 驗證輸入文本是否為空
        /// 2. 將輸入轉為大寫（符合需求：小寫英文轉大寫處理）
        /// 3. 逐字遍歷輸入，查詢對應摩斯密碼
        /// 4. 在 ListBox 中顯示字元與密碼的逐字對照
        /// 5. 在 TextBox2 中顯示完整摩斯密碼序列（以空格隔開）
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            // 若輸入文本為空或 null，直接返回，不執行轉換
            if (string.IsNullOrEmpty(textBox1.Text)) return;

            // 將使用者輸入的文本轉為大寫
            // 需求：小寫英文字會統一轉成大寫處理
            string input = textBox1.Text.ToUpper();
            
            // 建立 List 用於儲存所有有效的摩斯密碼
            List<string> fullMorseCodes = new List<string>();
            
            // 清空 ListBox，準備顯示新的逐字對照結果
            listBox1.Items.Clear();

            // 逐字遍歷輸入文本的每個字元
            foreach (char c in input)
            {
                // 查詢目前字元在摩斯密碼表中的對應密碼
                string code = FindMorseCode(c);
                
                // 若字元在摩斯密碼表中有定義
                if (code != null)
                {
                    // 將該摩斯密碼新增至 List
                    // 需求：未定義在 morse_code_table.md 的字元會被忽略
                    fullMorseCodes.Add(code);
                    
                    // 準備在 ListBox 中顯示的字元文本
                    // 需求：空白字元需顯示為 "空白" 文字
                    string displayChar = (c == ' ') ? "空白" : c.ToString();
                    
                    // 在 ListBox 中新增一筆紀錄，顯示字元與對應密碼
                    // 字元與密碼之間以多個空格隔開，便於閱讀
                    listBox1.Items.Add($"{displayChar}    {code}");
                }
            }

            // 將所有摩斯密碼以空格隔開後，顯示在 textBox2
            // 最終產出為完整的摩斯密碼序列
            textBox2.Text = string.Join(" ", fullMorseCodes);
        }

        /// <summary>
        /// button2_Click 事件處理方法
        /// 功能：處理清除按鈕的點擊事件
        /// 流程：
        /// 1. 清空 TextBox1（輸入框）
        /// 2. 清空 TextBox2（輸出框）
        /// 3. 清空 ListBox1（逐字對照清單）
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            // 清空輸入文本框
            textBox1.Clear();
            
            // 清空輸出摩斯密碼文本框
            textBox2.Clear();
            
            // 清空逐字對照的 ListBox
            listBox1.Items.Clear();
        }
    }
}
