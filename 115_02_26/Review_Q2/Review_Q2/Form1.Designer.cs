namespace Review_Q2
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
            lblOilLube = new Label();
            chkOilChange = new CheckBox();
            chkLubeJob = new CheckBox();
            lblFlushes = new Label();
            chkRadiatorFlush = new CheckBox();
            chkTransFlush = new CheckBox();
            lblOther = new Label();
            chkInspection = new CheckBox();
            chkMuffler = new CheckBox();
            chkTireRotation = new CheckBox();
            lblParts = new Label();
            lblPartsLabel = new Label();
            txtParts = new TextBox();
            lblLaborLabel = new Label();
            txtLabor = new TextBox();
            grpSummary = new GroupBox();
            lblServiceLabel = new Label();
            txtService = new TextBox();
            lblPartsOutLabel = new Label();
            txtPartsOut = new TextBox();
            lblTaxLabel = new Label();
            txtTax = new TextBox();
            lblTotalLabel = new Label();
            txtTotal = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnClose = new Button();
            grpSummary.SuspendLayout();
            SuspendLayout();
            // 
            // lblOilLube
            // 
            lblOilLube.AutoSize = true;
            lblOilLube.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblOilLube.Location = new Point(28, 20);
            lblOilLube.Margin = new Padding(4, 0, 4, 0);
            lblOilLube.Name = "lblOilLube";
            lblOilLube.Size = new Size(100, 23);
            lblOilLube.TabIndex = 0;
            lblOilLube.Text = "機油和潤滑";
            // 
            // chkOilChange
            // 
            chkOilChange.AutoSize = true;
            chkOilChange.Location = new Point(28, 54);
            chkOilChange.Margin = new Padding(4, 4, 4, 4);
            chkOilChange.Name = "chkOilChange";
            chkOilChange.Size = new Size(190, 27);
            chkOilChange.TabIndex = 1;
            chkOilChange.Text = "更換機油 (NT$780)";
            // 
            // chkLubeJob
            // 
            chkLubeJob.AutoSize = true;
            chkLubeJob.Location = new Point(28, 88);
            chkLubeJob.Margin = new Padding(4, 4, 4, 4);
            chkLubeJob.Name = "chkLubeJob";
            chkLubeJob.Size = new Size(190, 27);
            chkLubeJob.TabIndex = 2;
            chkLubeJob.Text = "潤滑保養 (NT$540)";
            // 
            // lblFlushes
            // 
            lblFlushes.AutoSize = true;
            lblFlushes.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblFlushes.Location = new Point(316, 20);
            lblFlushes.Margin = new Padding(4, 0, 4, 0);
            lblFlushes.Name = "lblFlushes";
            lblFlushes.Size = new Size(82, 23);
            lblFlushes.TabIndex = 3;
            lblFlushes.Text = "清洗服務";
            // 
            // chkRadiatorFlush
            // 
            chkRadiatorFlush.AutoSize = true;
            chkRadiatorFlush.Location = new Point(316, 54);
            chkRadiatorFlush.Margin = new Padding(4, 4, 4, 4);
            chkRadiatorFlush.Name = "chkRadiatorFlush";
            chkRadiatorFlush.Size = new Size(190, 27);
            chkRadiatorFlush.TabIndex = 4;
            chkRadiatorFlush.Text = "水箱清洗 (NT$900)";
            // 
            // chkTransFlush
            // 
            chkTransFlush.AutoSize = true;
            chkTransFlush.Location = new Point(316, 88);
            chkTransFlush.Margin = new Padding(4, 4, 4, 4);
            chkTransFlush.Name = "chkTransFlush";
            chkTransFlush.Size = new Size(222, 27);
            chkTransFlush.TabIndex = 5;
            chkTransFlush.Text = "變速箱清洗 (NT$2,400)";
            // 
            // lblOther
            // 
            lblOther.AutoSize = true;
            lblOther.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblOther.Location = new Point(28, 135);
            lblOther.Margin = new Padding(4, 0, 4, 0);
            lblOther.Name = "lblOther";
            lblOther.Size = new Size(82, 23);
            lblOther.TabIndex = 6;
            lblOther.Text = "其他服務";
            // 
            // chkInspection
            // 
            chkInspection.AutoSize = true;
            chkInspection.Location = new Point(28, 169);
            chkInspection.Margin = new Padding(4, 4, 4, 4);
            chkInspection.Name = "chkInspection";
            chkInspection.Size = new Size(154, 27);
            chkInspection.TabIndex = 7;
            chkInspection.Text = "檢驗 (NT$450)";
            // 
            // chkMuffler
            // 
            chkMuffler.AutoSize = true;
            chkMuffler.Location = new Point(28, 203);
            chkMuffler.Margin = new Padding(4, 4, 4, 4);
            chkMuffler.Name = "chkMuffler";
            chkMuffler.Size = new Size(222, 27);
            chkMuffler.TabIndex = 8;
            chkMuffler.Text = "更換消音器 (NT$3,000)";
            // 
            // chkTireRotation
            // 
            chkTireRotation.AutoSize = true;
            chkTireRotation.Location = new Point(28, 237);
            chkTireRotation.Margin = new Padding(4, 4, 4, 4);
            chkTireRotation.Name = "chkTireRotation";
            chkTireRotation.Size = new Size(190, 27);
            chkTireRotation.TabIndex = 9;
            chkTireRotation.Text = "輪胎換位 (NT$600)";
            // 
            // lblParts
            // 
            lblParts.AutoSize = true;
            lblParts.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblParts.Location = new Point(316, 135);
            lblParts.Margin = new Padding(4, 0, 4, 0);
            lblParts.Name = "lblParts";
            lblParts.Size = new Size(100, 23);
            lblParts.TabIndex = 10;
            lblParts.Text = "零件和工時";
            // 
            // lblPartsLabel
            // 
            lblPartsLabel.AutoSize = true;
            lblPartsLabel.Location = new Point(316, 173);
            lblPartsLabel.Margin = new Padding(4, 0, 4, 0);
            lblPartsLabel.Name = "lblPartsLabel";
            lblPartsLabel.Size = new Size(93, 23);
            lblPartsLabel.TabIndex = 11;
            lblPartsLabel.Text = "零件(NT$)";
            // 
            // txtParts
            // 
            txtParts.Location = new Point(440, 169);
            txtParts.Margin = new Padding(4, 4, 4, 4);
            txtParts.Name = "txtParts";
            txtParts.Size = new Size(108, 30);
            txtParts.TabIndex = 12;
            // 
            // lblLaborLabel
            // 
            lblLaborLabel.AutoSize = true;
            lblLaborLabel.Location = new Point(316, 214);
            lblLaborLabel.Margin = new Padding(4, 0, 4, 0);
            lblLaborLabel.Name = "lblLaborLabel";
            lblLaborLabel.Size = new Size(117, 23);
            lblLaborLabel.TabIndex = 13;
            lblLaborLabel.Text = "工時數 (小時)";
            // 
            // txtLabor
            // 
            txtLabor.Location = new Point(440, 210);
            txtLabor.Margin = new Padding(4, 4, 4, 4);
            txtLabor.Name = "txtLabor";
            txtLabor.Size = new Size(108, 30);
            txtLabor.TabIndex = 14;
            // 
            // grpSummary
            // 
            grpSummary.Controls.Add(lblServiceLabel);
            grpSummary.Controls.Add(txtService);
            grpSummary.Controls.Add(lblPartsOutLabel);
            grpSummary.Controls.Add(txtPartsOut);
            grpSummary.Controls.Add(lblTaxLabel);
            grpSummary.Controls.Add(txtTax);
            grpSummary.Controls.Add(lblTotalLabel);
            grpSummary.Controls.Add(txtTotal);
            grpSummary.Location = new Point(28, 284);
            grpSummary.Margin = new Padding(4, 4, 4, 4);
            grpSummary.Name = "grpSummary";
            grpSummary.Padding = new Padding(4, 4, 4, 4);
            grpSummary.Size = new Size(522, 203);
            grpSummary.TabIndex = 15;
            grpSummary.TabStop = false;
            grpSummary.Text = "費用摘要";
            // 
            // lblServiceLabel
            // 
            lblServiceLabel.AutoSize = true;
            lblServiceLabel.Location = new Point(21, 34);
            lblServiceLabel.Margin = new Padding(4, 0, 4, 0);
            lblServiceLabel.Name = "lblServiceLabel";
            lblServiceLabel.Size = new Size(100, 23);
            lblServiceLabel.TabIndex = 0;
            lblServiceLabel.Text = "服務與工資";
            // 
            // txtService
            // 
            txtService.Location = new Point(138, 30);
            txtService.Margin = new Padding(4, 4, 4, 4);
            txtService.Name = "txtService";
            txtService.ReadOnly = true;
            txtService.Size = new Size(356, 30);
            txtService.TabIndex = 1;
            // 
            // lblPartsOutLabel
            // 
            lblPartsOutLabel.AutoSize = true;
            lblPartsOutLabel.Location = new Point(21, 74);
            lblPartsOutLabel.Margin = new Padding(4, 0, 4, 0);
            lblPartsOutLabel.Name = "lblPartsOutLabel";
            lblPartsOutLabel.Size = new Size(46, 23);
            lblPartsOutLabel.TabIndex = 2;
            lblPartsOutLabel.Text = "零件";
            // 
            // txtPartsOut
            // 
            txtPartsOut.Location = new Point(138, 70);
            txtPartsOut.Margin = new Padding(4, 4, 4, 4);
            txtPartsOut.Name = "txtPartsOut";
            txtPartsOut.ReadOnly = true;
            txtPartsOut.Size = new Size(356, 30);
            txtPartsOut.TabIndex = 3;
            // 
            // lblTaxLabel
            // 
            lblTaxLabel.AutoSize = true;
            lblTaxLabel.Location = new Point(21, 115);
            lblTaxLabel.Margin = new Padding(4, 0, 4, 0);
            lblTaxLabel.Name = "lblTaxLabel";
            lblTaxLabel.Size = new Size(99, 23);
            lblTaxLabel.TabIndex = 4;
            lblTaxLabel.Text = "稅金 (零件)";
            // 
            // txtTax
            // 
            txtTax.Location = new Point(138, 111);
            txtTax.Margin = new Padding(4, 4, 4, 4);
            txtTax.Name = "txtTax";
            txtTax.ReadOnly = true;
            txtTax.Size = new Size(356, 30);
            txtTax.TabIndex = 5;
            // 
            // lblTotalLabel
            // 
            lblTotalLabel.AutoSize = true;
            lblTotalLabel.Location = new Point(21, 156);
            lblTotalLabel.Margin = new Padding(4, 0, 4, 0);
            lblTotalLabel.Name = "lblTotalLabel";
            lblTotalLabel.Size = new Size(64, 23);
            lblTotalLabel.TabIndex = 6;
            lblTotalLabel.Text = "總費用";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(138, 152);
            txtTotal.Margin = new Padding(4, 4, 4, 4);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(356, 30);
            txtTotal.TabIndex = 7;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(82, 507);
            btnCalculate.Margin = new Padding(4, 4, 4, 4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(138, 41);
            btnCalculate.TabIndex = 16;
            btnCalculate.Text = "計算總額";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += BtnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(248, 507);
            btnClear.Margin = new Padding(4, 4, 4, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 41);
            btnClear.TabIndex = 17;
            btnClear.Text = "清除";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(385, 507);
            btnClose.Margin = new Padding(4, 4, 4, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(110, 41);
            btnClose.TabIndex = 18;
            btnClose.Text = "離開";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += BtnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 574);
            Controls.Add(lblOilLube);
            Controls.Add(chkOilChange);
            Controls.Add(chkLubeJob);
            Controls.Add(lblFlushes);
            Controls.Add(chkRadiatorFlush);
            Controls.Add(chkTransFlush);
            Controls.Add(lblOther);
            Controls.Add(chkInspection);
            Controls.Add(chkMuffler);
            Controls.Add(chkTireRotation);
            Controls.Add(lblParts);
            Controls.Add(lblPartsLabel);
            Controls.Add(txtParts);
            Controls.Add(lblLaborLabel);
            Controls.Add(txtLabor);
            Controls.Add(grpSummary);
            Controls.Add(btnCalculate);
            Controls.Add(btnClear);
            Controls.Add(btnClose);
            Font = new Font("Microsoft JhengHei UI", 9F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "汽車維修服務";
            grpSummary.ResumeLayout(false);
            grpSummary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // 機油和潤滑
        private Label lblOilLube;
        private CheckBox chkOilChange;
        private CheckBox chkLubeJob;

        // 清洗服務
        private Label lblFlushes;
        private CheckBox chkRadiatorFlush;
        private CheckBox chkTransFlush;

        // 其他服務
        private Label lblOther;
        private CheckBox chkInspection;
        private CheckBox chkMuffler;
        private CheckBox chkTireRotation;

        // 零件和工時
        private Label lblParts;
        private Label lblPartsLabel;
        private TextBox txtParts;
        private Label lblLaborLabel;
        private TextBox txtLabor;

        // 費用摘要
        private GroupBox grpSummary;
        private Label lblServiceLabel;
        private TextBox txtService;
        private Label lblPartsOutLabel;
        private TextBox txtPartsOut;
        private Label lblTaxLabel;
        private TextBox txtTax;
        private Label lblTotalLabel;
        private TextBox txtTotal;

        // 按鈕
        private Button btnCalculate;
        private Button btnClear;
        private Button btnClose;
    }
}
