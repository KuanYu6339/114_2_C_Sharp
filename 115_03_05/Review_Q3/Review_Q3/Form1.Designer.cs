namespace Review_Q3
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
            grpLottery = new GroupBox();
            pnlNumbers = new Panel();
            txtNum5 = new TextBox();
            txtNum4 = new TextBox();
            txtNum3 = new TextBox();
            txtNum2 = new TextBox();
            txtNum1 = new TextBox();
            btnGenerate = new Button();
            btnDraw = new Button();
            btnExit = new Button();
            lstDrawResult = new ListBox();
            lblResultTitle = new Label();
            lblMatch1 = new Label();
            lblMatch2 = new Label();
            lblMatch3 = new Label();
            lblMatch4 = new Label();
            lblMatch5 = new Label();
            grpLottery.SuspendLayout();
            pnlNumbers.SuspendLayout();
            SuspendLayout();

            // grpLottery
            grpLottery.Controls.Add(pnlNumbers);
            grpLottery.Controls.Add(btnGenerate);
            grpLottery.Controls.Add(btnDraw);
            grpLottery.Controls.Add(btnExit);
            grpLottery.Controls.Add(lstDrawResult);
            grpLottery.Controls.Add(lblResultTitle);
            grpLottery.Controls.Add(lblMatch1);
            grpLottery.Controls.Add(lblMatch2);
            grpLottery.Controls.Add(lblMatch3);
            grpLottery.Controls.Add(lblMatch4);
            grpLottery.Controls.Add(lblMatch5);
            grpLottery.Font = new Font("Microsoft JhengHei", 11F);
            grpLottery.Location = new Point(30, 60);
            grpLottery.Name = "grpLottery";
            grpLottery.Size = new Size(740, 430);
            grpLottery.TabIndex = 0;
            grpLottery.TabStop = false;
            grpLottery.Text = "樂透號碼產生器";

            // pnlNumbers (紅框區域)
            pnlNumbers.BackColor = Color.White;
            pnlNumbers.BorderStyle = BorderStyle.FixedSingle;
            pnlNumbers.Controls.Add(txtNum1);
            pnlNumbers.Controls.Add(txtNum2);
            pnlNumbers.Controls.Add(txtNum3);
            pnlNumbers.Controls.Add(txtNum4);
            pnlNumbers.Controls.Add(txtNum5);
            pnlNumbers.Location = new Point(20, 35);
            pnlNumbers.Name = "pnlNumbers";
            pnlNumbers.Size = new Size(700, 100);
            pnlNumbers.TabIndex = 0;

            // txtNum1
            txtNum1.Font = new Font("Microsoft JhengHei", 18F, FontStyle.Bold);
            txtNum1.Location = new Point(30, 20);
            txtNum1.Name = "txtNum1";
            txtNum1.ReadOnly = true;
            txtNum1.Size = new Size(100, 60);
            txtNum1.TabIndex = 0;
            txtNum1.TextAlign = HorizontalAlignment.Center;

            // txtNum2
            txtNum2.Font = new Font("Microsoft JhengHei", 18F, FontStyle.Bold);
            txtNum2.Location = new Point(160, 20);
            txtNum2.Name = "txtNum2";
            txtNum2.ReadOnly = true;
            txtNum2.Size = new Size(100, 60);
            txtNum2.TabIndex = 1;
            txtNum2.TextAlign = HorizontalAlignment.Center;

            // txtNum3
            txtNum3.Font = new Font("Microsoft JhengHei", 18F, FontStyle.Bold);
            txtNum3.Location = new Point(290, 20);
            txtNum3.Name = "txtNum3";
            txtNum3.ReadOnly = true;
            txtNum3.Size = new Size(100, 60);
            txtNum3.TabIndex = 2;
            txtNum3.TextAlign = HorizontalAlignment.Center;

            // txtNum4
            txtNum4.Font = new Font("Microsoft JhengHei", 18F, FontStyle.Bold);
            txtNum4.Location = new Point(420, 20);
            txtNum4.Name = "txtNum4";
            txtNum4.ReadOnly = true;
            txtNum4.Size = new Size(100, 60);
            txtNum4.TabIndex = 3;
            txtNum4.TextAlign = HorizontalAlignment.Center;

            // txtNum5
            txtNum5.Font = new Font("Microsoft JhengHei", 18F, FontStyle.Bold);
            txtNum5.Location = new Point(550, 20);
            txtNum5.Name = "txtNum5";
            txtNum5.ReadOnly = true;
            txtNum5.Size = new Size(100, 60);
            txtNum5.TabIndex = 4;
            txtNum5.TextAlign = HorizontalAlignment.Center;

            // btnGenerate
            btnGenerate.Font = new Font("Microsoft JhengHei", 12F);
            btnGenerate.Location = new Point(100, 155);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(130, 45);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "產生號碼";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += BtnGenerate_Click;

            // btnDraw
            btnDraw.Font = new Font("Microsoft JhengHei", 12F);
            btnDraw.Location = new Point(300, 155);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(130, 45);
            btnDraw.TabIndex = 2;
            btnDraw.Text = "開獎號碼";
            btnDraw.UseVisualStyleBackColor = true;
            btnDraw.Click += BtnDraw_Click;

            // btnExit
            btnExit.Font = new Font("Microsoft JhengHei", 12F);
            btnExit.Location = new Point(500, 155);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(130, 45);
            btnExit.TabIndex = 3;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += BtnExit_Click;

            // lstDrawResult
            lstDrawResult.Font = new Font("Microsoft JhengHei", 12F);
            lstDrawResult.FormattingEnabled = true;
            lstDrawResult.ItemHeight = 28;
            lstDrawResult.Location = new Point(20, 220);
            lstDrawResult.Name = "lstDrawResult";
            lstDrawResult.Size = new Size(330, 172);
            lstDrawResult.TabIndex = 4;

            // lblResultTitle
            lblResultTitle.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold);
            lblResultTitle.Location = new Point(400, 215);
            lblResultTitle.Name = "lblResultTitle";
            lblResultTitle.Size = new Size(320, 30);
            lblResultTitle.TabIndex = 5;
            lblResultTitle.Text = "中獎比對結果";
            lblResultTitle.TextAlign = ContentAlignment.MiddleCenter;

            // lblMatch1
            lblMatch1.Font = new Font("Microsoft JhengHei", 12F);
            lblMatch1.Location = new Point(400, 255);
            lblMatch1.Name = "lblMatch1";
            lblMatch1.Size = new Size(320, 28);
            lblMatch1.TabIndex = 6;
            lblMatch1.Text = "";

            // lblMatch2
            lblMatch2.Font = new Font("Microsoft JhengHei", 12F);
            lblMatch2.Location = new Point(400, 290);
            lblMatch2.Name = "lblMatch2";
            lblMatch2.Size = new Size(320, 28);
            lblMatch2.TabIndex = 7;
            lblMatch2.Text = "";

            // lblMatch3
            lblMatch3.Font = new Font("Microsoft JhengHei", 12F);
            lblMatch3.Location = new Point(400, 325);
            lblMatch3.Name = "lblMatch3";
            lblMatch3.Size = new Size(320, 28);
            lblMatch3.TabIndex = 8;
            lblMatch3.Text = "";

            // lblMatch4
            lblMatch4.Font = new Font("Microsoft JhengHei", 12F);
            lblMatch4.Location = new Point(400, 360);
            lblMatch4.Name = "lblMatch4";
            lblMatch4.Size = new Size(320, 28);
            lblMatch4.TabIndex = 9;
            lblMatch4.Text = "";

            // lblMatch5
            lblMatch5.Font = new Font("Microsoft JhengHei", 12F);
            lblMatch5.Location = new Point(400, 395);
            lblMatch5.Name = "lblMatch5";
            lblMatch5.Size = new Size(320, 28);
            lblMatch5.TabIndex = 10;
            lblMatch5.Text = "";

            // Form1
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 520);
            Controls.Add(grpLottery);
            Font = new Font("Microsoft JhengHei", 11F);
            Name = "Form1";
            Text = "樂透號碼產生器";

            grpLottery.ResumeLayout(false);
            pnlNumbers.ResumeLayout(false);
            pnlNumbers.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpLottery;
        private Panel pnlNumbers;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtNum3;
        private TextBox txtNum4;
        private TextBox txtNum5;
        private Button btnGenerate;
        private Button btnDraw;
        private Button btnExit;
        private ListBox lstDrawResult;
        private Label lblResultTitle;
        private Label lblMatch1;
        private Label lblMatch2;
        private Label lblMatch3;
        private Label lblMatch4;
        private Label lblMatch5;
    }
}
