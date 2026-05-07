namespace test1150507
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label_depositPrompt = new Label();
            textBox_deposit = new TextBox();
            button_deposit = new Button();
            label_balance = new Label();
            label_lastWin = new Label();
            label_betPrompt = new Label();
            comboBox_bet = new ComboBox();
            label_totalSpins = new Label();
            label_winCount = new Label();
            label_winRate = new Label();
            button1 = new Button();
            button2 = new Button();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label_depositPrompt
            // 
            label_depositPrompt.AutoSize = true;
            label_depositPrompt.Location = new Point(2, 21);
            label_depositPrompt.Name = "label_depositPrompt";
            label_depositPrompt.Size = new Size(221, 45);
            label_depositPrompt.TabIndex = 14;
            label_depositPrompt.Text = "存入金額：$";
            // 
            // textBox_deposit
            // 
            textBox_deposit.Location = new Point(229, 18);
            textBox_deposit.Name = "textBox_deposit";
            textBox_deposit.Size = new Size(153, 55);
            textBox_deposit.TabIndex = 13;
            // 
            // button_deposit
            // 
            button_deposit.Location = new Point(417, 21);
            button_deposit.Name = "button_deposit";
            button_deposit.Size = new Size(100, 42);
            button_deposit.TabIndex = 12;
            button_deposit.Text = "存入";
            button_deposit.UseVisualStyleBackColor = true;
            button_deposit.Click += button_deposit_Click;
            // 
            // label_balance
            // 
            label_balance.AutoSize = true;
            label_balance.Location = new Point(12, 75);
            label_balance.Name = "label_balance";
            label_balance.Size = new Size(220, 45);
            label_balance.TabIndex = 11;
            label_balance.Text = "餘額：$0.00";
            // 
            // label_lastWin
            // 
            label_lastWin.AutoSize = true;
            label_lastWin.Location = new Point(245, 76);
            label_lastWin.Name = "label_lastWin";
            label_lastWin.Size = new Size(292, 45);
            label_lastWin.TabIndex = 10;
            label_lastWin.Text = "本次獲得：$0.00";
            // 
            // label_betPrompt
            // 
            label_betPrompt.AutoSize = true;
            label_betPrompt.Location = new Point(55, 262);
            label_betPrompt.Name = "label_betPrompt";
            label_betPrompt.Size = new Size(200, 45);
            label_betPrompt.TabIndex = 6;
            label_betPrompt.Text = "下注金額：";
            // 
            // comboBox_bet
            // 
            comboBox_bet.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_bet.FormattingEnabled = true;
            comboBox_bet.Location = new Point(305, 259);
            comboBox_bet.Name = "comboBox_bet";
            comboBox_bet.Size = new Size(120, 53);
            comboBox_bet.TabIndex = 5;
            comboBox_bet.SelectedIndexChanged += comboBox_bet_SelectedIndexChanged;
            // 
            // label_totalSpins
            // 
            label_totalSpins.AutoSize = true;
            label_totalSpins.Font = new Font("微軟正黑體", 14F);
            label_totalSpins.Location = new Point(12, 315);
            label_totalSpins.Name = "label_totalSpins";
            label_totalSpins.Size = new Size(150, 35);
            label_totalSpins.TabIndex = 4;
            label_totalSpins.Text = "旋轉：0 次";
            // 
            // label_winCount
            // 
            label_winCount.AutoSize = true;
            label_winCount.Font = new Font("微軟正黑體", 14F);
            label_winCount.Location = new Point(180, 315);
            label_winCount.Name = "label_winCount";
            label_winCount.Size = new Size(150, 35);
            label_winCount.TabIndex = 3;
            label_winCount.Text = "中獎：0 次";
            // 
            // label_winRate
            // 
            label_winRate.AutoSize = true;
            label_winRate.Font = new Font("微軟正黑體", 14F);
            label_winRate.Location = new Point(336, 315);
            label_winRate.Name = "label_winRate";
            label_winRate.Size = new Size(162, 35);
            label_winRate.TabIndex = 2;
            label_winRate.Text = "勝率：0.0%";
            // 
            // button1
            // 
            button1.Location = new Point(87, 365);
            button1.Name = "button1";
            button1.Size = new Size(120, 45);
            button1.TabIndex = 1;
            button1.Text = "旋轉";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(262, 365);
            button2.Name = "button2";
            button2.Size = new Size(120, 45);
            button2.TabIndex = 0;
            button2.Text = "離開";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Apple.bmp");
            imageList1.Images.SetKeyName(1, "Banana.bmp");
            imageList1.Images.SetKeyName(2, "Cherries.bmp");
            imageList1.Images.SetKeyName(3, "Grapes.bmp");
            imageList1.Images.SetKeyName(4, "Lemon.bmp");
            imageList1.Images.SetKeyName(5, "Lime.bmp");
            imageList1.Images.SetKeyName(6, "Orange.bmp");
            imageList1.Images.SetKeyName(7, "Pear.bmp");
            imageList1.Images.SetKeyName(8, "Strawberry.bmp");
            imageList1.Images.SetKeyName(9, "Watermelon.bmp");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Apple;
            pictureBox1.Location = new Point(12, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 124);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Strawberry;
            pictureBox2.Location = new Point(202, 129);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(128, 130);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Cherries;
            pictureBox3.Location = new Point(373, 129);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 124);
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(21F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 430);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label_winRate);
            Controls.Add(label_winCount);
            Controls.Add(label_totalSpins);
            Controls.Add(comboBox_bet);
            Controls.Add(label_betPrompt);
            Controls.Add(label_lastWin);
            Controls.Add(label_balance);
            Controls.Add(button_deposit);
            Controls.Add(textBox_deposit);
            Controls.Add(label_depositPrompt);
            Font = new Font("微軟正黑體", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "吃角子老虎機";
            Load += Form1_Load;
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label_depositPrompt;
        private System.Windows.Forms.TextBox textBox_deposit;
        private System.Windows.Forms.Button button_deposit;
        private System.Windows.Forms.Label label_balance;
        private System.Windows.Forms.Label label_lastWin;
        private System.Windows.Forms.Label label_betPrompt;
        private System.Windows.Forms.ComboBox comboBox_bet;
        private System.Windows.Forms.Label label_totalSpins;
        private System.Windows.Forms.Label label_winCount;
        private System.Windows.Forms.Label label_winRate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
