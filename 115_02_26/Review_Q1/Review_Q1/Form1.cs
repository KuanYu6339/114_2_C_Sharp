namespace Review_Q1
{
    public partial class Form1 : Form
    {
        private int playerWins = 0;
        private int computerWins = 0;
        private string playerChoice = "";
        private string computerChoice = "";
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        // 6. Form1_Load() - 初始化表單，清空圖片和結果顯示
        private void Form1_Load(object sender, EventArgs e)
        {
            playerPictureBox.Image = null;
            computerPictureBox.Image = null;
            lblResult.Text = "VS";
            lblResult.ForeColor = Color.Blue;
            lblScore.Text = "玩家勝: 0  |  電腦勝: 0";
        }

        // 1. getCompChoice() - 產生電腦的隨機選擇（石頭/布/剪刀），並儲存到變數中
        private void getCompChoice()
        {
            int choice = random.Next(0, 3);
            switch (choice)
            {
                case 0:
                    computerChoice = "石頭";
                    break;
                case 1:
                    computerChoice = "布";
                    break;
                case 2:
                    computerChoice = "剪刀";
                    break;
            }
        }

        // 2. showComputerImage() - 根據電腦的選擇，在對應的 PictureBox 中顯示正確的圖片
        private void showComputerImage()
        {
            computerPictureBox.Image = computerChoice switch
            {
                "石頭" => Properties.Resources.stone_computer,
                "布" => Properties.Resources.paper_computer,
                "剪刀" => Properties.Resources.scissor_computer,
                _ => null
            };
        }

        // 3. showPlayerImage() - 根據玩家的選擇，在對應的 PictureBox 中顯示正確的圖片
        private void showPlayerImage()
        {
            playerPictureBox.Image = playerChoice switch
            {
                "石頭" => Properties.Resources.stone_player,
                "布" => Properties.Resources.paper_player,
                "剪刀" => Properties.Resources.scissor_player,
                _ => null
            };
        }

        // 4. showWinner() - 比較玩家和電腦的選擇，判斷輸贏，更新勝場計數，並顯示結果
        private void showWinner()
        {
            if (playerChoice == computerChoice)
            {
                lblResult.Text = "平手！";
                lblResult.ForeColor = Color.Orange;
                // 平手不計入勝負
            }
            else if ((playerChoice == "石頭" && computerChoice == "剪刀") ||
                     (playerChoice == "剪刀" && computerChoice == "布") ||
                     (playerChoice == "布" && computerChoice == "石頭"))
            {
                playerWins++;
                lblResult.Text = "你贏了！";
                lblResult.ForeColor = Color.Green;
            }
            else
            {
                computerWins++;
                lblResult.Text = "你輸了！";
                lblResult.ForeColor = Color.Red;
            }

            lblScore.Text = $"玩家勝: {playerWins}  |  電腦勝: {computerWins}";
        }

        // 5. 事件處理方法

        // stoneButton_Click() - 處理玩家選擇石頭
        private void stoneButton_Click(object sender, EventArgs e)
        {
            playerChoice = "石頭";
            showPlayerImage();
            getCompChoice();
            showComputerImage();
            showWinner();
        }

        // paperButton_Click() - 處理玩家選擇布
        private void paperButton_Click(object sender, EventArgs e)
        {
            playerChoice = "布";
            showPlayerImage();
            getCompChoice();
            showComputerImage();
            showWinner();
        }

        // scissorButton_Click() - 處理玩家選擇剪刀
        private void scissorButton_Click(object sender, EventArgs e)
        {
            playerChoice = "剪刀";
            showPlayerImage();
            getCompChoice();
            showComputerImage();
            showWinner();
        }

        // exitButton_Click() - 處理結束遊戲並顯示統計
        private void exitButton_Click(object sender, EventArgs e)
        {
            string finalResult = playerWins > computerWins ? "你是最終贏家！🏆"
                               : playerWins < computerWins ? "電腦獲勝！💻"
                               : "最終平手！🤝";

            MessageBox.Show(
                $"遊戲結束！\n\n" +
                $"玩家勝場：{playerWins}\n" +
                $"電腦勝場：{computerWins}\n\n" +
                $"{finalResult}",
                "遊戲統計",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Application.Exit();
        }
    }
}
