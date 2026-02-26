namespace Review_Q2
{
    public partial class Form1 : Form
    {
        // 服務價格常數
        private const decimal OilChangePrice = 780m;
        private const decimal LubeJobPrice = 540m;
        private const decimal RadiatorFlushPrice = 900m;
        private const decimal TransFlushPrice = 2400m;
        private const decimal InspectionPrice = 450m;
        private const decimal MufflerPrice = 3000m;
        private const decimal TireRotationPrice = 600m;

        // 工時費率與稅率
        private const decimal LaborRate = 500m;
        private const decimal TaxRate = 0.05m;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // 計算服務費用
            decimal serviceTotal = 0m;

            if (chkOilChange.Checked) serviceTotal += OilChangePrice;
            if (chkLubeJob.Checked) serviceTotal += LubeJobPrice;
            if (chkRadiatorFlush.Checked) serviceTotal += RadiatorFlushPrice;
            if (chkTransFlush.Checked) serviceTotal += TransFlushPrice;
            if (chkInspection.Checked) serviceTotal += InspectionPrice;
            if (chkMuffler.Checked) serviceTotal += MufflerPrice;
            if (chkTireRotation.Checked) serviceTotal += TireRotationPrice;

            // 計算工時費用
            if (decimal.TryParse(txtLabor.Text, out decimal laborHours))
            {
                serviceTotal += laborHours * LaborRate;
            }

            // 取得零件費用
            decimal partsTotal = 0m;
            if (decimal.TryParse(txtParts.Text, out decimal partsValue))
            {
                partsTotal = partsValue;
            }

            // 計算稅金 (僅針對零件)
            decimal tax = partsTotal * TaxRate;

            // 計算總費用
            decimal grandTotal = serviceTotal + partsTotal + tax;

            // 顯示結果
            txtService.Text = serviceTotal.ToString("N0");
            txtPartsOut.Text = partsTotal.ToString("N0");
            txtTax.Text = tax.ToString("N0");
            txtTotal.Text = grandTotal.ToString("N0");
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            // 清除所有 CheckBox
            chkOilChange.Checked = false;
            chkLubeJob.Checked = false;
            chkRadiatorFlush.Checked = false;
            chkTransFlush.Checked = false;
            chkInspection.Checked = false;
            chkMuffler.Checked = false;
            chkTireRotation.Checked = false;

            // 清除輸入欄位
            txtParts.Clear();
            txtLabor.Clear();

            // 清除結果欄位
            txtService.Clear();
            txtPartsOut.Clear();
            txtTax.Clear();
            txtTotal.Clear();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
