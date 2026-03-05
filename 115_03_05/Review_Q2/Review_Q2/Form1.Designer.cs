namespace Review_Q2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            grpOil            = new GroupBox();
            chkOilChange      = new CheckBox();
            chkMixedOil       = new CheckBox();
            grpWash           = new GroupBox();
            chkWaterBoxWash   = new CheckBox();
            chkGearboxWash    = new CheckBox();
            grpOther          = new GroupBox();
            chkInspection     = new CheckBox();
            chkMufflerReplace = new CheckBox();
            chkTireReplace    = new CheckBox();
            grpParts          = new GroupBox();
            lblParts          = new Label();
            txtParts          = new TextBox();
            lblHours          = new Label();
            txtHours          = new TextBox();
            grpSummary        = new GroupBox();
            lblServiceLabor   = new Label();
            lblServiceLaborVal = new Label();
            lblPartsTotal     = new Label();
            lblPartsTotalVal  = new Label();
            lblTax            = new Label();
            lblTaxVal         = new Label();
            lblTotal          = new Label();
            lblTotalVal       = new Label();
            calculateButton   = new Button();
            clearButton       = new Button();
            exitButton        = new Button();

            grpOil.SuspendLayout();
            grpWash.SuspendLayout();
            grpOther.SuspendLayout();
            grpParts.SuspendLayout();
            grpSummary.SuspendLayout();
            SuspendLayout();

            // ── grpOil ──
            grpOil.Text     = "油油和潤滑";
            grpOil.Location = new Point(16, 16);
            grpOil.Size     = new Size(220, 96);
            grpOil.Controls.Add(chkOilChange);
            grpOil.Controls.Add(chkMixedOil);

            chkOilChange.AutoSize = true;
            chkOilChange.Location = new Point(10, 28);
            chkOilChange.Text     = "更換機油 (NT$780)";

            chkMixedOil.AutoSize = true;
            chkMixedOil.Location = new Point(10, 58);
            chkMixedOil.Text     = "混合保養 (NT$540)";

            // ── grpWash ──
            grpWash.Text     = "清洗服務";
            grpWash.Location = new Point(246, 16);
            grpWash.Size     = new Size(230, 96);
            grpWash.Controls.Add(chkWaterBoxWash);
            grpWash.Controls.Add(chkGearboxWash);

            chkWaterBoxWash.AutoSize = true;
            chkWaterBoxWash.Location = new Point(10, 28);
            chkWaterBoxWash.Text     = "水箱清洗 (NT$900)";

            chkGearboxWash.AutoSize = true;
            chkGearboxWash.Location = new Point(10, 58);
            chkGearboxWash.Text     = "變速箱清洗 (NT$2,400)";

            // ── grpOther ──
            grpOther.Text     = "其他服務";
            grpOther.Location = new Point(16, 122);
            grpOther.Size     = new Size(220, 108);
            grpOther.Controls.Add(chkInspection);
            grpOther.Controls.Add(chkMufflerReplace);
            grpOther.Controls.Add(chkTireReplace);

            chkInspection.AutoSize = true;
            chkInspection.Location = new Point(10, 28);
            chkInspection.Text     = "檢驗 (NT$450)";

            chkMufflerReplace.AutoSize = true;
            chkMufflerReplace.Location = new Point(10, 58);
            chkMufflerReplace.Text     = "更換消音器 (NT$3,000)";

            chkTireReplace.AutoSize = true;
            chkTireReplace.Location = new Point(10, 88);
            chkTireReplace.Text     = "輪胎換位 (NT$600)";

            // ── grpParts ──
            grpParts.Text     = "零件和工時";
            grpParts.Location = new Point(246, 122);
            grpParts.Size     = new Size(230, 108);
            grpParts.Controls.Add(lblParts);
            grpParts.Controls.Add(txtParts);
            grpParts.Controls.Add(lblHours);
            grpParts.Controls.Add(txtHours);

            lblParts.AutoSize = true;
            lblParts.Location = new Point(10, 31);
            lblParts.Text     = "零件 (NT$)";

            txtParts.Location = new Point(110, 28);
            txtParts.Size     = new Size(106, 23);

            lblHours.AutoSize = true;
            lblHours.Location = new Point(10, 69);
            lblHours.Text     = "工時數 (小時)";

            txtHours.Location = new Point(110, 66);
            txtHours.Size     = new Size(106, 23);

            // ── grpSummary ──
            grpSummary.Text     = "費用摘要";
            grpSummary.Location = new Point(16, 240);
            grpSummary.Size     = new Size(460, 160);
            grpSummary.Controls.Add(lblServiceLabor);
            grpSummary.Controls.Add(lblServiceLaborVal);
            grpSummary.Controls.Add(lblPartsTotal);
            grpSummary.Controls.Add(lblPartsTotalVal);
            grpSummary.Controls.Add(lblTax);
            grpSummary.Controls.Add(lblTaxVal);
            grpSummary.Controls.Add(lblTotal);
            grpSummary.Controls.Add(lblTotalVal);

            lblServiceLabor.AutoSize = true;
            lblServiceLabor.Location = new Point(10, 30);
            lblServiceLabor.Text     = "服務與工資";

            lblServiceLaborVal.BorderStyle = BorderStyle.Fixed3D;
            lblServiceLaborVal.Location    = new Point(130, 27);
            lblServiceLaborVal.Size        = new Size(316, 23);
            lblServiceLaborVal.TextAlign   = ContentAlignment.MiddleRight;

            lblPartsTotal.AutoSize = true;
            lblPartsTotal.Location = new Point(10, 62);
            lblPartsTotal.Text     = "零件";

            lblPartsTotalVal.BorderStyle = BorderStyle.Fixed3D;
            lblPartsTotalVal.Location    = new Point(130, 59);
            lblPartsTotalVal.Size        = new Size(316, 23);
            lblPartsTotalVal.TextAlign   = ContentAlignment.MiddleRight;

            lblTax.AutoSize = true;
            lblTax.Location = new Point(10, 94);
            lblTax.Text     = "稅金 (零件)";

            lblTaxVal.BorderStyle = BorderStyle.Fixed3D;
            lblTaxVal.Location    = new Point(130, 91);
            lblTaxVal.Size        = new Size(316, 23);
            lblTaxVal.TextAlign   = ContentAlignment.MiddleRight;

            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(10, 126);
            lblTotal.Text     = "總費用";

            lblTotalVal.BorderStyle = BorderStyle.Fixed3D;
            lblTotalVal.Location    = new Point(130, 123);
            lblTotalVal.Size        = new Size(316, 23);
            lblTotalVal.TextAlign   = ContentAlignment.MiddleRight;

            // ── Buttons ──
            calculateButton.Text     = "計算總額";
            calculateButton.Location = new Point(136, 414);
            calculateButton.Size     = new Size(90, 32);
            calculateButton.Click   += calculateButton_Click;

            clearButton.Text     = "清除";
            clearButton.Location = new Point(236, 414);
            clearButton.Size     = new Size(90, 32);
            clearButton.Click   += clearButton_Click;

            exitButton.Text     = "離開";
            exitButton.Location = new Point(336, 414);
            exitButton.Size     = new Size(90, 32);
            exitButton.Click   += exitButton_Click;

            // ── Form1 ──
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode       = AutoScaleMode.Font;
            ClientSize          = new Size(492, 462);
            FormBorderStyle     = FormBorderStyle.FixedSingle;
            MaximizeBox         = false;
            StartPosition       = FormStartPosition.CenterScreen;
            Text                = "汽車維修服務箱";
            Controls.Add(grpOil);
            Controls.Add(grpWash);
            Controls.Add(grpOther);
            Controls.Add(grpParts);
            Controls.Add(grpSummary);
            Controls.Add(calculateButton);
            Controls.Add(clearButton);
            Controls.Add(exitButton);

            grpOil.ResumeLayout(false);
            grpOil.PerformLayout();
            grpWash.ResumeLayout(false);
            grpWash.PerformLayout();
            grpOther.ResumeLayout(false);
            grpOther.PerformLayout();
            grpParts.ResumeLayout(false);
            grpParts.PerformLayout();
            grpSummary.ResumeLayout(false);
            grpSummary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpOil;
        private CheckBox chkOilChange;
        private CheckBox chkMixedOil;
        private GroupBox grpWash;
        private CheckBox chkWaterBoxWash;
        private CheckBox chkGearboxWash;
        private GroupBox grpOther;
        private CheckBox chkInspection;
        private CheckBox chkMufflerReplace;
        private CheckBox chkTireReplace;
        private GroupBox grpParts;
        private Label    lblParts;
        private TextBox  txtParts;
        private Label    lblHours;
        private TextBox  txtHours;
        private GroupBox grpSummary;
        private Label    lblServiceLabor;
        private Label    lblServiceLaborVal;
        private Label    lblPartsTotal;
        private Label    lblPartsTotalVal;
        private Label    lblTax;
        private Label    lblTaxVal;
        private Label    lblTotal;
        private Label    lblTotalVal;
        private Button   calculateButton;
        private Button   clearButton;
        private Button   exitButton;
    }
}
