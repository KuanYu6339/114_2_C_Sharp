using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Linq;

namespace test1150507
{
    public partial class Form1 : Form
    {
        // 程式狀態變數
        private Random rand = new Random();
        private int n1, n2, n3;
        private int prize = 0;
        private int balance = 0;
        private int totalDeposited = 0;
        private int totalSpins = 0;
        private int winCount = 0;

        // 進階版變數
        private bool isSpinning = false;
        private System.Windows.Forms.Timer spinTimer;
        private int spinFrameCount = 0;
        private const int SPIN_DURATION = 20; // 旋轉幀數
        private List<GameRecord> gameRecords = new List<GameRecord>();
        private const string SAVE_FILE = "savegame.txt";

        public Form1()
        {
            InitializeComponent();

            // 初始化旋轉計時器
            spinTimer = new System.Windows.Forms.Timer();
            spinTimer.Interval = 50; // 50ms 更新一次
            spinTimer.Tick += SpinTimer_Tick;
        }

        // 程式啟動
        private void Form1_Load(object sender, EventArgs e)
        {
            // ImageList 設定
            imageList1.ImageSize = new Size(128, 128);
            imageList1.ColorDepth = ColorDepth.Depth32Bit;

            // 圖片資料夾位置 - 改為尋找 .bmp 檔案
            string imagePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Fruit Symbols"
            );

            // 如果找不到，嘗試上層目錄
            if (!Directory.Exists(imagePath))
            {
                imagePath = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "..", "..", "..",
                    "Fruit Symbols"
                );
            }

            string[] fileNames =
            {
                "Apple",
                "Banana",
                "Cherries",
                "Grapes",
                "Lemon",
                "Lime",
                "Orange",
                "Pear",
                "Strawberry",
                "Watermelon"
            };

            imageList1.Images.Clear();

            // 載入圖片 - 改為尋找 .bmp 檔案
            int loadedCount = 0;
            foreach (string name in fileNames)
            {
                string filePath = Path.Combine(imagePath, $"{name}.bmp");

                if (File.Exists(filePath))
                {
                    try
                    {
                        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                        {
                            imageList1.Images.Add(Image.FromStream(fs));
                            loadedCount++;
                            System.Diagnostics.Debug.WriteLine($"✓ 成功載入：{name}.bmp");
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"✗ 載入失敗 {name}.bmp：{ex.Message}");
                        MessageBox.Show($"載入圖片失敗：{name}.bmp\n{ex.Message}");
                    }
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"✗ 找不到：{filePath}");
                }
            }

            // 檢查是否成功載入
            if (imageList1.Images.Count == 0)
            {
                MessageBox.Show(
                    $"圖片載入失敗！\n\n搜尋路徑：{imagePath}\n\n請確認 Fruit Symbols 資料夾存在且包含 .bmp 檔案。",
                    "錯誤",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            System.Diagnostics.Debug.WriteLine($"圖片載入完成：{imageList1.Images.Count}/{fileNames.Length} 張");

            // 初始化下注選項
            comboBox_bet.Items.Clear();
            comboBox_bet.Items.AddRange(new object[] { "$1", "$5", "$10", "$50" });
            comboBox_bet.SelectedIndex = 0;

            // 載入遊戲紀錄
            LoadGameRecords();

            getImage();
            UpdateUI();
            UpdateStats();
        }

        // 存入金額
        private void button_deposit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_deposit.Text, out int depositAmount)
                && depositAmount > 0)
            {
                balance += depositAmount;
                totalDeposited += depositAmount;

                textBox_deposit.Clear();

                UpdateUI();
            }
            else
            {
                MessageBox.Show(
                    "請輸入有效的金額（正整數）",
                    "錯誤",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                textBox_deposit.Clear();
            }
        }

        // 切換下注金額
        private void comboBox_bet_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        // 取得下注金額
        private int GetBetAmount()
        {
            if (comboBox_bet.SelectedItem is string text)
            {
                if (text.StartsWith("$"))
                {
                    if (int.TryParse(text.Substring(1), out int bet))
                    {
                        return bet;
                    }
                }
            }

            return 1;
        }

        // 隨機圖片（無動畫版本）
        private void getImage()
        {
            if (imageList1.Images.Count == 0)
            {
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                return;
            }

            n1 = rand.Next(imageList1.Images.Count);
            n2 = rand.Next(imageList1.Images.Count);
            n3 = rand.Next(imageList1.Images.Count);

            pictureBox1.Image = imageList1.Images[n1];
            pictureBox2.Image = imageList1.Images[n2];
            pictureBox3.Image = imageList1.Images[n3];

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // 旋轉動畫
        private void StartSpinAnimation(int betAmount)
        {
            if (isSpinning) return;

            isSpinning = true;
            spinFrameCount = 0;

            // 預先決定結果
            int finalN1 = rand.Next(imageList1.Images.Count);
            int finalN2 = rand.Next(imageList1.Images.Count);
            int finalN3 = rand.Next(imageList1.Images.Count);

            spinTimer.Tag = new[] { finalN1, finalN2, finalN3, betAmount };
            spinTimer.Start();
        }

        private void SpinTimer_Tick(object sender, EventArgs e)
        {
            spinFrameCount++;

            // 隨機顯示圖片製造旋轉效果
            int randomIndex1 = rand.Next(imageList1.Images.Count);
            int randomIndex2 = rand.Next(imageList1.Images.Count);
            int randomIndex3 = rand.Next(imageList1.Images.Count);

            pictureBox1.Image = imageList1.Images[randomIndex1];
            pictureBox2.Image = imageList1.Images[randomIndex2];
            pictureBox3.Image = imageList1.Images[randomIndex3];

            // 旋轉完成
            if (spinFrameCount >= SPIN_DURATION)
            {
                spinTimer.Stop();

                // 取出最終結果
                var finalResult = (int[])spinTimer.Tag;
                n1 = finalResult[0];
                n2 = finalResult[1];
                n3 = finalResult[2];
                int betAmount = finalResult[3];

                // 顯示最終圖片
                pictureBox1.Image = imageList1.Images[n1];
                pictureBox2.Image = imageList1.Images[n2];
                pictureBox3.Image = imageList1.Images[n3];

                // 判斷勝負
                checkWinner(betAmount);

                // 記錄遊戲紀錄
                RecordGameResult(n1, n2, n3, betAmount, prize);

                // 更新介面
                UpdateUI();
                UpdateStats();

                isSpinning = false;
                button1.Enabled = true;
            }
        }

        // 判斷中獎
        private void checkWinner(int bet)
        {
            if (n1 == n2 && n2 == n3)
            {
                // 三個相同
                prize = bet * 10;
            }
            else if (n1 == n2 || n2 == n3 || n1 == n3)
            {
                // 兩個相同
                prize = bet * 2;
            }
            else
            {
                // 沒中
                prize = 0;
            }

            balance += prize;

            if (prize > 0)
            {
                winCount++;
            }
        }

        // 旋轉按鈕
        private void button1_Click(object sender, EventArgs e)
        {
            int currentBet = GetBetAmount();

            if (balance < currentBet)
            {
                MessageBox.Show(
                    "餘額不足！",
                    "提示",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // 扣除下注金額
            balance -= currentBet;
            totalSpins++;

            // 停用按鈕
            button1.Enabled = false;

            // 開始旋轉動畫
            StartSpinAnimation(currentBet);
        }

        // 更新 UI
        private void UpdateUI()
        {
            label_balance.Text = $"餘額：{balance:C0}";
            label_lastWin.Text = $"本次獲得：{prize:C0}";

            int currentBet = GetBetAmount();

            button1.Enabled = (balance >= currentBet) && !isSpinning;
        }

        // 更新統計
        private void UpdateStats()
        {
            label_totalSpins.Text = $"旋轉：{totalSpins} 次";
            label_winCount.Text = $"中獎：{winCount} 次";

            if (totalSpins == 0)
            {
                label_winRate.Text = "勝率：0.0%";
            }
            else
            {
                double winRate =
                    ((double)winCount / totalSpins) * 100;

                label_winRate.Text =
                    $"勝率：{winRate:F1}%";
            }
        }

        // 記錄遊戲結果
        private void RecordGameResult(int index1, int index2, int index3, int bet, int winAmount)
        {
            var record = new GameRecord
            {
                Timestamp = DateTime.Now,
                Spin1 = index1,
                Spin2 = index2,
                Spin3 = index3,
                BetAmount = bet,
                WinAmount = winAmount
            };

            gameRecords.Add(record);
            SaveGameRecords();
        }

        // 儲存遊戲紀錄
        private void SaveGameRecords()
        {
            try
            {
                string content = $"""
balance={balance}
totalDeposited={totalDeposited}
totalSpins={totalSpins}
winCount={winCount}
""";
                File.WriteAllText(SAVE_FILE, content);
            }
            catch (Exception ex)
            {
                // 靜默忽略存檔失敗
                System.Diagnostics.Debug.WriteLine($"存檔失敗：{ex.Message}");
            }
        }

        // 載入遊戲紀錄
        private void LoadGameRecords()
        {
            try
            {
                if (File.Exists(SAVE_FILE))
                {
                    string[] lines = File.ReadAllLines(SAVE_FILE);
                    foreach (string line in lines)
                    {
                        var parts = line.Split('=');
                        if (parts.Length == 2)
                        {
                            string key = parts[0].Trim();
                            if (int.TryParse(parts[1].Trim(), out int value))
                            {
                                switch (key)
                                {
                                    case "balance":
                                        balance = value;
                                        break;
                                    case "totalDeposited":
                                        totalDeposited = value;
                                        break;
                                    case "totalSpins":
                                        totalSpins = value;
                                        break;
                                    case "winCount":
                                        winCount = value;
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // 靜默忽略，重置為 0
                System.Diagnostics.Debug.WriteLine($"讀檔失敗：{ex.Message}");
                balance = 0;
                totalDeposited = 0;
                totalSpins = 0;
                winCount = 0;
            }
        }

        // 離開與結算
        private void button2_Click(object sender, EventArgs e)
        {
            int netGain = balance - totalDeposited;

            string gainLossText =
                netGain >= 0 ? "獲利" : "虧損";

            string summary =
$@"累計存入：{totalDeposited:C0}
目前餘額：{balance:C0}
{gainLossText}：{Math.Abs(netGain):C0}

旋轉次數：{totalSpins} 次
中獎次數：{winCount} 次

遊戲紀錄已自動儲存至 {SAVE_FILE}";

            MessageBox.Show(
                summary,
                "結算摘要",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Close();
        }

        // 新增事件處理常式
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveGameRecords();
        }
    }

    // 遊戲紀錄類別
    public class GameRecord
    {
        public DateTime Timestamp { get; set; }
        public int Spin1 { get; set; }
        public int Spin2 { get; set; }
        public int Spin3 { get; set; }
        public int BetAmount { get; set; }
        public int WinAmount { get; set; }
    }
}