using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Facts
{
    public partial class MainForm : Form
    {
        // 主表單建構函式
        public MainForm()
        {
            InitializeComponent();
        }

        // 顯示按鈕的點擊事件處理程式
        private void displayButton_Click(object sender, EventArgs e)
        {
            // 建立 NutritionForm 類別的新執行個體
            NutritionForm nutriForm = new NutritionForm();

            // 尋找選取的單選按鈕，並設定相應的營養資訊
            if (bananaRadioButton.Checked)
            {
                nutriForm.foodLabel.Text = "1 根香蕉";
                nutriForm.caloriesLabel.Text = "100";
                nutriForm.fatLabel.Text = "0.4";
                nutriForm.carbLabel.Text = "27";
            }
            else if (popcornRadioButton.Checked)
            {
                nutriForm.foodLabel.Text = "1 杯空氣炸爆米花";
                nutriForm.caloriesLabel.Text = "31";
                nutriForm.fatLabel.Text = "0.4";
                nutriForm.carbLabel.Text = "6";
            }
            else if (muffinRadioButton.Checked)
            {
                nutriForm.foodLabel.Text = "1 個大藍莓鬆餅";
                nutriForm.caloriesLabel.Text = "385";
                nutriForm.fatLabel.Text = "9";
                nutriForm.carbLabel.Text = "67";
            }

            // 顯示營養資訊表單
            nutriForm.ShowDialog();
        }

        // 結束按鈕的點擊事件處理程式
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
