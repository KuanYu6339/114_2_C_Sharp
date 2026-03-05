namespace Review_Q2
{
    public partial class Form1 : Form
    {
        // ×A°ָ¶O¥־±`¼ֶ
        private const decimal OilChangePrice    = 780m;
        private const decimal MixedOilPrice     = 540m;
        private const decimal WaterBoxWashPrice = 900m;
        private const decimal GearboxWashPrice  = 2400m;
        private const decimal InspectionPrice   = 450m;
        private const decimal MufflerPrice      = 3000m;
        private const decimal TireReplacePrice  = 600m;

        // ₪u¸ך²v»Pµ|²v
        private const decimal LABOR_RATE_PER_HOUR = 600m;
        private const decimal TAX_RATE            = 0.06m;

        public Form1()
        {
            InitializeComponent();
        }

        // שששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששש
        // ¶O¥־­p÷ג₪ט×k
        // שששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששש

        /// <summary>­p÷ג¾ק×o©M¼ם·ֶ×A°ָ¶O¥־</summary>
        private decimal OilLubeCharges()
        {
            decimal total = 0m;
            if (chkOilChange.Checked) total += OilChangePrice;
            if (chkMixedOil.Checked)  total += MixedOilPrice;
            return total;
        }

        /// <summary>­p÷ג²M¬~×A°ָ¶O¥־</summary>
        private decimal FlushCharges()
        {
            decimal total = 0m;
            if (chkWaterBoxWash.Checked) total += WaterBoxWashPrice;
            if (chkGearboxWash.Checked)  total += GearboxWashPrice;
            return total;
        }

        /// <summary>­p÷ג¨ה¥L×A°ָ¶O¥־</summary>
        private decimal MiscCharges()
        {
            decimal total = 0m;
            if (chkInspection.Checked)     total += InspectionPrice;
            if (chkMufflerReplace.Checked) total += MufflerPrice;
            if (chkTireReplace.Checked)    total += TireReplacePrice;
            return total;
        }

        /// <summary>­p÷ג¹s¥ף©M₪u®ֹ¶O¥־</summary>
        private decimal OtherCharges()
        {
            decimal partsCost = 0m;
            decimal laborCost = 0m;

            if (decimal.TryParse(txtParts.Text, out decimal parts) && parts >= 0)
                partsCost = parts;

            if (decimal.TryParse(txtHours.Text, out decimal hours) && hours >= 0)
                laborCost = hours * LABOR_RATE_PER_HOUR;

            return partsCost + laborCost;
        }

        /// <summary>¨ת±o¹s¥ף¶O¥־¡]¥־©ףµ|×ק­p÷ג¡^</summary>
        private decimal GetPartsCost()
        {
            if (decimal.TryParse(txtParts.Text, out decimal parts) && parts >= 0)
                return parts;
            return 0m;
        }

        /// <summary>­p÷גµ|×ק¡]¹s¥ף6%µ|²v¡^</summary>
        private decimal TaxCharges()
        {
            return GetPartsCost() * TAX_RATE;
        }

        /// <summary>­p÷ג©ׂ¦³¶O¥־ֱ`©M</summary>
        private decimal TotalCharges()
        {
            return OilLubeCharges() + FlushCharges() + MiscCharges()
                 + OtherCharges() + TaxCharges();
        }

        // שששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששש
        // ¨ֶ¥ף³B²z₪ט×k
        // שששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששש

        /// <summary>­p÷גֱ`ֳB«צ¶sֲIְ»¨ֶ¥ף</summary>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            decimal serviceCost = OilLubeCharges() + FlushCharges() + MiscCharges();
            decimal laborCost   = OtherCharges() - GetPartsCost();
            decimal partsCost   = GetPartsCost();
            decimal tax         = TaxCharges();
            decimal total       = TotalCharges();

            lblServiceLaborVal.Text = $"NT${serviceCost + laborCost:N0}";
            lblPartsTotalVal.Text   = $"NT${partsCost:N0}";
            lblTaxVal.Text          = $"NT${tax:N0}";
            lblTotalVal.Text        = $"NT${total:N0}";

            // ­p÷ג§¹¦¨«ב¦Û°Êְx¦s©ת²׃¦Ü₪ו¦rְֹ
            SaveServiceDetailsToFile();
        }

        /// <summary>²M°£«צ¶sֲIְ»¨ֶ¥ף</summary>
        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }

        /// <summary>ֲק¶}«צ¶sֲIְ»¨ֶ¥ף</summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // שששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששש
        // ¸ך®ֶ²M°£₪ט×k
        // שששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששש

        /// <summary>²M°£¾ק×o¼ם·ֶ¿ן¶µ</summary>
        private void ClearOilLube()
        {
            chkOilChange.Checked = false;
            chkMixedOil.Checked  = false;
        }

        /// <summary>²M°£²M¬~×A°ָ¿ן¶µ</summary>
        private void ClearFlushes()
        {
            chkWaterBoxWash.Checked = false;
            chkGearboxWash.Checked  = false;
        }

        /// <summary>²M°£¨ה¥L×A°ָ¿ן¶µ</summary>
        private void ClearMisc()
        {
            chkInspection.Checked     = false;
            chkMufflerReplace.Checked = false;
            chkTireReplace.Checked    = false;
        }

        /// <summary>²M°£¹s¥ף©M₪u®ֹ¿י₪J</summary>
        private void ClearOther()
        {
            txtParts.Clear();
            txtHours.Clear();
        }

        /// <summary>²M°£¶O¥־ֵד¥Ü</summary>
        private void ClearFees()
        {
            lblServiceLaborVal.Text = string.Empty;
            lblPartsTotalVal.Text   = string.Empty;
            lblTaxVal.Text          = string.Empty;
            lblTotalVal.Text        = string.Empty;
        }

        // שששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששש
        // ְֹ®׳³B²z₪ט×k
        // שששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששש

        /// <summary>ְx¦s÷û­׳©ת²׃¨לְֹ®׳</summary>
        private void SaveServiceDetailsToFile()
        {
            using SaveFileDialog dlg = new()
            {
                Title      = "ְx¦s÷û­׳©ת²׃",
                Filter     = "₪ו¦rְֹ®׳ (*.txt)|*.txt|©ׂ¦³ְֹ®׳ (*.*)|*.*",
                DefaultExt = "txt",
                FileName   = "÷û­׳©ת²׃"
            };

            if (dlg.ShowDialog() != DialogResult.OK) return;

            try
            {
                using StreamWriter writer = new(
                    dlg.FileName,
                    append: false,
                    System.Text.Encoding.UTF8);

                writer.WriteLine("שששששששששששששששששששששש ¨T¨®÷û­׳©ת²׃ שששששששששששששששששששששש");
                writer.WriteLine($"₪י´ֱ¡G{DateTime.Now:yyyy/MM/dd HH:mm}");
                writer.WriteLine();
                writer.WriteLine("¡i×A°ָ¶µ¥״¡j");
                if (chkOilChange.Checked)      writer.WriteLine($"  §ף´«¾ק×o        NT${OilChangePrice:N0}");
                if (chkMixedOil.Checked)       writer.WriteLine($"  ²V¦X«O¾i        NT${MixedOilPrice:N0}");
                if (chkWaterBoxWash.Checked)   writer.WriteLine($"  ₪פ½c²M¬~        NT${WaterBoxWashPrice:N0}");
                if (chkGearboxWash.Checked)    writer.WriteLine($"  ֵÜ³t½c²M¬~      NT${GearboxWashPrice:N0}");
                if (chkInspection.Checked)     writer.WriteLine($"  ְֵֻח            NT${InspectionPrice:N0}");
                if (chkMufflerReplace.Checked) writer.WriteLine($"  §ף´«®ר­µ¾¹      NT${MufflerPrice:N0}");
                if (chkTireReplace.Checked)    writer.WriteLine($"  ½ü­L´«¦ל        NT${TireReplacePrice:N0}");
                writer.WriteLine();
                writer.WriteLine("¡i¶O¥־÷K­n¡j");
                writer.WriteLine($"  ×A°ָ»P₪u¸ך¡G  {lblServiceLaborVal.Text}");
                writer.WriteLine($"  ¹s¥ף¡G        {lblPartsTotalVal.Text}");
                writer.WriteLine($"  µ|×ק (¹s¥ף)¡G {lblTaxVal.Text}");
                writer.WriteLine($"  ֱ`¶O¥־¡G      {lblTotalVal.Text}");
                writer.WriteLine("שששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששש");

                MessageBox.Show("÷û­׳©ת²׃₪w¦¨¥\ְx¦s¡I", "ְx¦s¦¨¥\",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ְx¦s¥¢±ׁ¡G{ex.Message}", "¿ש»~",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // שששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששש
        // ¸ך®ֵֶחֳׂ
        // שששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששששש

        /// <summary>ֵחֳׂ¿י₪J½d³ע×÷¦X²z©Ê¡]₪£¥i¬°­t¼ֶ¡^</summary>
        private bool ValidateInput()
        {
            if (txtParts.Text.Trim() != string.Empty)
            {
                if (!decimal.TryParse(txtParts.Text, out decimal parts) || parts < 0)
                {
                    MessageBox.Show("¹s¥ף¶O¥־½׀¿י₪J¦³®ִ×÷«D­t¼ֶ­ָ¡C", "¿י₪J¿ש»~",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtParts.Focus();
                    return false;
                }
            }

            if (txtHours.Text.Trim() != string.Empty)
            {
                if (!decimal.TryParse(txtHours.Text, out decimal hours) || hours < 0)
                {
                    MessageBox.Show("₪u®ֹ¼ֶ½׀¿י₪J¦³®ִ×÷«D­t¼ֶ­ָ¡C", "¿י₪J¿ש»~",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHours.Focus();
                    return false;
                }
            }

            return true;
        }
    }
}
