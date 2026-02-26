namespace Review_Q1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            stoneButton = new Button();
            paperButton = new Button();
            scissorButton = new Button();
            exitButton = new Button();
            lblPlayerTitle = new Label();
            lblComputerTitle = new Label();
            playerPictureBox = new PictureBox();
            computerPictureBox = new PictureBox();
            lblResult = new Label();
            lblScore = new Label();
            ((System.ComponentModel.ISupportInitialize)playerPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)computerPictureBox).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft JhengHei UI", 22F, FontStyle.Bold);
            lblTitle.Location = new Point(250, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(332, 56);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "石頭剪刀布遊戲";
            // 
            // stoneButton
            // 
            stoneButton.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold);
            stoneButton.Location = new Point(100, 420);
            stoneButton.Name = "stoneButton";
            stoneButton.Size = new Size(120, 50);
            stoneButton.TabIndex = 7;
            stoneButton.Text = "石頭";
            stoneButton.UseVisualStyleBackColor = true;
            stoneButton.Click += stoneButton_Click;
            // 
            // paperButton
            // 
            paperButton.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold);
            paperButton.Location = new Point(250, 420);
            paperButton.Name = "paperButton";
            paperButton.Size = new Size(120, 50);
            paperButton.TabIndex = 8;
            paperButton.Text = "布";
            paperButton.UseVisualStyleBackColor = true;
            paperButton.Click += paperButton_Click;
            // 
            // scissorButton
            // 
            scissorButton.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold);
            scissorButton.Location = new Point(400, 420);
            scissorButton.Name = "scissorButton";
            scissorButton.Size = new Size(120, 50);
            scissorButton.TabIndex = 9;
            scissorButton.Text = "剪刀";
            scissorButton.UseVisualStyleBackColor = true;
            scissorButton.Click += scissorButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold);
            exitButton.ForeColor = Color.Red;
            exitButton.Location = new Point(550, 420);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(150, 50);
            exitButton.TabIndex = 10;
            exitButton.Text = "結束遊戲";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // lblPlayerTitle
            // 
            lblPlayerTitle.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold);
            lblPlayerTitle.Location = new Point(80, 70);
            lblPlayerTitle.Name = "lblPlayerTitle";
            lblPlayerTitle.Size = new Size(200, 30);
            lblPlayerTitle.TabIndex = 1;
            lblPlayerTitle.Text = "玩家";
            lblPlayerTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblComputerTitle
            // 
            lblComputerTitle.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold);
            lblComputerTitle.Location = new Point(520, 70);
            lblComputerTitle.Name = "lblComputerTitle";
            lblComputerTitle.Size = new Size(200, 30);
            lblComputerTitle.TabIndex = 2;
            lblComputerTitle.Text = "電腦";
            lblComputerTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playerPictureBox
            // 
            playerPictureBox.BackColor = Color.White;
            playerPictureBox.BorderStyle = BorderStyle.FixedSingle;
            playerPictureBox.Image = Properties.Resources.stone_player;
            playerPictureBox.Location = new Point(55, 105);
            playerPictureBox.Name = "playerPictureBox";
            playerPictureBox.Size = new Size(250, 250);
            playerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            playerPictureBox.TabIndex = 3;
            playerPictureBox.TabStop = false;
            // 
            // computerPictureBox
            // 
            computerPictureBox.BackColor = Color.White;
            computerPictureBox.BorderStyle = BorderStyle.FixedSingle;
            computerPictureBox.Image = Properties.Resources.stone_computer1;
            computerPictureBox.Location = new Point(495, 105);
            computerPictureBox.Name = "computerPictureBox";
            computerPictureBox.Size = new Size(250, 250);
            computerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            computerPictureBox.TabIndex = 4;
            computerPictureBox.TabStop = false;
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold);
            lblResult.ForeColor = Color.Blue;
            lblResult.Location = new Point(310, 150);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(180, 80);
            lblResult.TabIndex = 5;
            lblResult.Text = "VS";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            lblScore.Font = new Font("Microsoft JhengHei UI", 13F);
            lblScore.Location = new Point(50, 370);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(700, 30);
            lblScore.TabIndex = 6;
            lblScore.Text = "玩家勝: 0  |  電腦勝: 0";
            lblScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(exitButton);
            Controls.Add(scissorButton);
            Controls.Add(paperButton);
            Controls.Add(stoneButton);
            Controls.Add(lblScore);
            Controls.Add(lblResult);
            Controls.Add(computerPictureBox);
            Controls.Add(playerPictureBox);
            Controls.Add(lblComputerTitle);
            Controls.Add(lblPlayerTitle);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "石頭剪刀布遊戲";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)playerPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)computerPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblPlayerTitle;
        private Label lblComputerTitle;
        private PictureBox playerPictureBox;
        private PictureBox computerPictureBox;
        private Label lblResult;
        private Label lblScore;
        private Button stoneButton;
        private Button paperButton;
        private Button scissorButton;
        private Button exitButton;
    }
}
