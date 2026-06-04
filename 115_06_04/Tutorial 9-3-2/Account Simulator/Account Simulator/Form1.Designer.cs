namespace Account_Simulator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createGroupBox = new System.Windows.Forms.GroupBox();
            this.createButton = new System.Windows.Forms.Button();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.ownerNameTextBox = new System.Windows.Forms.TextBox();
            this.ownerNameLabel = new System.Windows.Forms.Label();
            this.initialBalanceTextBox = new System.Windows.Forms.TextBox();
            this.initialBalanceLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.depositGroupBox = new System.Windows.Forms.GroupBox();
            this.depositButton = new System.Windows.Forms.Button();
            this.depositAmountTextBox = new System.Windows.Forms.TextBox();
            this.depositAmountLabel = new System.Windows.Forms.Label();
            this.withdrawGroupBox = new System.Windows.Forms.GroupBox();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.withdrawAmountTextBox = new System.Windows.Forms.TextBox();
            this.withdrawAmountLabel = new System.Windows.Forms.Label();
            this.accountInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.accountInfoTextBox = new System.Windows.Forms.TextBox();
            this.createGroupBox.SuspendLayout();
            this.depositGroupBox.SuspendLayout();
            this.withdrawGroupBox.SuspendLayout();
            this.accountInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // createGroupBox
            // 
            this.createGroupBox.Controls.Add(this.initialBalanceTextBox);
            this.createGroupBox.Controls.Add(this.initialBalanceLabel);
            this.createGroupBox.Controls.Add(this.ownerNameTextBox);
            this.createGroupBox.Controls.Add(this.ownerNameLabel);
            this.createGroupBox.Controls.Add(this.accountNumberTextBox);
            this.createGroupBox.Controls.Add(this.accountNumberLabel);
            this.createGroupBox.Controls.Add(this.createButton);
            this.createGroupBox.Location = new System.Drawing.Point(12, 12);
            this.createGroupBox.Name = "createGroupBox";
            this.createGroupBox.Size = new System.Drawing.Size(350, 150);
            this.createGroupBox.TabIndex = 0;
            this.createGroupBox.TabStop = false;
            this.createGroupBox.Text = "建立帳戶";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(250, 100);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 6;
            this.createButton.Text = "建立帳戶";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.Location = new System.Drawing.Point(80, 20);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(245, 20);
            this.accountNumberTextBox.TabIndex = 1;
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.AutoSize = true;
            this.accountNumberLabel.Location = new System.Drawing.Point(20, 23);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(44, 13);
            this.accountNumberLabel.TabIndex = 0;
            this.accountNumberLabel.Text = "帳號：";
            // 
            // ownerNameTextBox
            // 
            this.ownerNameTextBox.Location = new System.Drawing.Point(80, 50);
            this.ownerNameTextBox.Name = "ownerNameTextBox";
            this.ownerNameTextBox.Size = new System.Drawing.Size(245, 20);
            this.ownerNameTextBox.TabIndex = 3;
            // 
            // ownerNameLabel
            // 
            this.ownerNameLabel.AutoSize = true;
            this.ownerNameLabel.Location = new System.Drawing.Point(20, 53);
            this.ownerNameLabel.Name = "ownerNameLabel";
            this.ownerNameLabel.Size = new System.Drawing.Size(44, 13);
            this.ownerNameLabel.TabIndex = 2;
            this.ownerNameLabel.Text = "姓名：";
            // 
            // initialBalanceTextBox
            // 
            this.initialBalanceTextBox.Location = new System.Drawing.Point(80, 80);
            this.initialBalanceTextBox.Name = "initialBalanceTextBox";
            this.initialBalanceTextBox.Size = new System.Drawing.Size(245, 20);
            this.initialBalanceTextBox.TabIndex = 5;
            // 
            // initialBalanceLabel
            // 
            this.initialBalanceLabel.AutoSize = true;
            this.initialBalanceLabel.Location = new System.Drawing.Point(20, 83);
            this.initialBalanceLabel.Name = "initialBalanceLabel";
            this.initialBalanceLabel.Size = new System.Drawing.Size(44, 13);
            this.initialBalanceLabel.TabIndex = 4;
            this.initialBalanceLabel.Text = "開戶金額：";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(287, 330);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "關閉";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // depositGroupBox
            // 
            this.depositGroupBox.Controls.Add(this.depositButton);
            this.depositGroupBox.Controls.Add(this.depositAmountTextBox);
            this.depositGroupBox.Controls.Add(this.depositAmountLabel);
            this.depositGroupBox.Location = new System.Drawing.Point(12, 170);
            this.depositGroupBox.Name = "depositGroupBox";
            this.depositGroupBox.Size = new System.Drawing.Size(160, 80);
            this.depositGroupBox.TabIndex = 1;
            this.depositGroupBox.TabStop = false;
            this.depositGroupBox.Text = "存錢";
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(40, 48);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(75, 23);
            this.depositButton.TabIndex = 2;
            this.depositButton.Text = "存入";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // depositAmountTextBox
            // 
            this.depositAmountTextBox.Location = new System.Drawing.Point(70, 20);
            this.depositAmountTextBox.Name = "depositAmountTextBox";
            this.depositAmountTextBox.Size = new System.Drawing.Size(75, 20);
            this.depositAmountTextBox.TabIndex = 1;
            // 
            // depositAmountLabel
            // 
            this.depositAmountLabel.AutoSize = true;
            this.depositAmountLabel.Location = new System.Drawing.Point(20, 23);
            this.depositAmountLabel.Name = "depositAmountLabel";
            this.depositAmountLabel.Size = new System.Drawing.Size(44, 13);
            this.depositAmountLabel.TabIndex = 0;
            this.depositAmountLabel.Text = "金額：";
            // 
            // withdrawGroupBox
            // 
            this.withdrawGroupBox.Controls.Add(this.withdrawButton);
            this.withdrawGroupBox.Controls.Add(this.withdrawAmountTextBox);
            this.withdrawGroupBox.Controls.Add(this.withdrawAmountLabel);
            this.withdrawGroupBox.Location = new System.Drawing.Point(178, 170);
            this.withdrawGroupBox.Name = "withdrawGroupBox";
            this.withdrawGroupBox.Size = new System.Drawing.Size(160, 80);
            this.withdrawGroupBox.TabIndex = 2;
            this.withdrawGroupBox.TabStop = false;
            this.withdrawGroupBox.Text = "提錢";
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(40, 48);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(75, 23);
            this.withdrawButton.TabIndex = 2;
            this.withdrawButton.Text = "提取";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // withdrawAmountTextBox
            // 
            this.withdrawAmountTextBox.Location = new System.Drawing.Point(70, 20);
            this.withdrawAmountTextBox.Name = "withdrawAmountTextBox";
            this.withdrawAmountTextBox.Size = new System.Drawing.Size(75, 20);
            this.withdrawAmountTextBox.TabIndex = 1;
            // 
            // withdrawAmountLabel
            // 
            this.withdrawAmountLabel.AutoSize = true;
            this.withdrawAmountLabel.Location = new System.Drawing.Point(20, 23);
            this.withdrawAmountLabel.Name = "withdrawAmountLabel";
            this.withdrawAmountLabel.Size = new System.Drawing.Size(44, 13);
            this.withdrawAmountLabel.TabIndex = 0;
            this.withdrawAmountLabel.Text = "金額：";
            // 
            // accountInfoGroupBox
            // 
            this.accountInfoGroupBox.Controls.Add(this.accountInfoTextBox);
            this.accountInfoGroupBox.Location = new System.Drawing.Point(12, 260);
            this.accountInfoGroupBox.Name = "accountInfoGroupBox";
            this.accountInfoGroupBox.Size = new System.Drawing.Size(350, 60);
            this.accountInfoGroupBox.TabIndex = 3;
            this.accountInfoGroupBox.TabStop = false;
            this.accountInfoGroupBox.Text = "帳戶資訊：";
            // 
            // accountInfoTextBox
            // 
            this.accountInfoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.accountInfoTextBox.Location = new System.Drawing.Point(10, 15);
            this.accountInfoTextBox.Multiline = true;
            this.accountInfoTextBox.Name = "accountInfoTextBox";
            this.accountInfoTextBox.ReadOnly = true;
            this.accountInfoTextBox.Size = new System.Drawing.Size(330, 40);
            this.accountInfoTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 365);
            this.Controls.Add(this.accountInfoGroupBox);
            this.Controls.Add(this.withdrawGroupBox);
            this.Controls.Add(this.depositGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.createGroupBox);
            this.Name = "Form1";
            this.Text = "Account Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.createGroupBox.ResumeLayout(false);
            this.createGroupBox.PerformLayout();
            this.depositGroupBox.ResumeLayout(false);
            this.depositGroupBox.PerformLayout();
            this.withdrawGroupBox.ResumeLayout(false);
            this.withdrawGroupBox.PerformLayout();
            this.accountInfoGroupBox.ResumeLayout(false);
            this.accountInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox createGroupBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.TextBox ownerNameTextBox;
        private System.Windows.Forms.Label ownerNameLabel;
        private System.Windows.Forms.TextBox initialBalanceTextBox;
        private System.Windows.Forms.Label initialBalanceLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox depositGroupBox;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.TextBox depositAmountTextBox;
        private System.Windows.Forms.Label depositAmountLabel;
        private System.Windows.Forms.GroupBox withdrawGroupBox;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.TextBox withdrawAmountTextBox;
        private System.Windows.Forms.Label withdrawAmountLabel;
        private System.Windows.Forms.GroupBox accountInfoGroupBox;
        private System.Windows.Forms.TextBox accountInfoTextBox;
    }
}

