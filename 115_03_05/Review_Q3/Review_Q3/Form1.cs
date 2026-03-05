namespace Review_Q3
{
    public partial class Form1 : Form
    {
        private readonly Random _random = new Random();
        private int[] _myNumbers = new int[5];   // 使用者產生的號碼
        private int[] _drawNumbers = new int[5]; // 開獎號碼

        public Form1()
        {
            InitializeComponent();
        }

        // 產生號碼：產生 5 個不重複的 1~69 亂數
        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            _myNumbers = GenerateUniqueNumbers(5, 1, 69);

            txtNum1.Text = _myNumbers[0].ToString();
            txtNum2.Text = _myNumbers[1].ToString();
            txtNum3.Text = _myNumbers[2].ToString();
            txtNum4.Text = _myNumbers[3].ToString();
            txtNum5.Text = _myNumbers[4].ToString();

            // 清除上次比對結果
            ClearMatchLabels();
        }

        // 開獎號碼：開啟檔案讀取開獎號碼並進行中獎比對
        private void BtnDraw_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "選擇開獎號碼檔案",
                Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*"
            };

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            if (!LoadDrawNumbers(ofd.FileName))
                return;

            DisplayDrawResult();
            CompareNumbers();
        }

        // 離開
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 產生不重複亂數
        private int[] GenerateUniqueNumbers(int count, int min, int max)
        {
            HashSet<int> set = new HashSet<int>();
            while (set.Count < count)
                set.Add(_random.Next(min, max + 1));

            int[] result = new int[count];
            set.CopyTo(result);
            Array.Sort(result);
            return result;
        }

        // 從檔案讀取開獎號碼（每行一個數字，共五行）
        private bool LoadDrawNumbers(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                if (lines.Length < 5)
                {
                    MessageBox.Show("檔案格式錯誤：行數不足，需要至少 5 行。", "格式錯誤",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                int[] numbers = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    if (!int.TryParse(lines[i].Trim(), out int num))
                    {
                        MessageBox.Show($"格式錯誤：第 {i + 1} 行「{lines[i]}」不是有效數字。",
                            "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    if (num < 1 || num > 69)
                    {
                        MessageBox.Show($"數字超出範圍：第 {i + 1} 行的數字 {num} 不在 1~69 之間。",
                            "範圍錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    numbers[i] = num;
                }

                _drawNumbers = numbers;
                return true;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("找不到指定的檔案，請確認檔案路徑。", "檔案不存在",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"讀取檔案時發生錯誤：{ex.Message}", "錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // 在 ListBox 顯示開獎號碼
        private void DisplayDrawResult()
        {
            lstDrawResult.Items.Clear();
            lstDrawResult.Items.Add("本期開獎號碼:");
            for (int i = 0; i < 5; i++)
                lstDrawResult.Items.Add($"第{i + 1}個號碼:{_drawNumbers[i]}");
        }

        // 中獎比對：比較使用者號碼與開獎號碼
        private void CompareNumbers()
        {
            if (_myNumbers.All(n => n == 0))
            {
                MessageBox.Show("請先按「產生號碼」產生您的號碼。", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Label[] matchLabels = { lblMatch1, lblMatch2, lblMatch3, lblMatch4, lblMatch5 };
            HashSet<int> drawSet = new HashSet<int>(_drawNumbers);

            for (int i = 0; i < 5; i++)
            {
                bool isMatch = drawSet.Contains(_myNumbers[i]);
                matchLabels[i].Text = $"號碼 {_myNumbers[i]}：{(isMatch ? "? 中獎" : "? 未中")}}";
                matchLabels[i].ForeColor = isMatch ? Color.Green : Color.Red;
            }
        }

        // 清除比對結果
        private void ClearMatchLabels()
        {
            lblMatch1.Text = "";
            lblMatch2.Text = "";
            lblMatch3.Text = "";
            lblMatch4.Text = "";
            lblMatch5.Text = "";
        }
    }
}
