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
        // 宣告類別層級的 FoodItem 變數，用來儲存選取的食物物件。
        public FoodItem selectedFood;

        // 主表單建構函式
        public MainForm()
        {
            InitializeComponent();
        }

        // 顯示按鈕的點擊事件處理程式
        private void displayButton_Click(object sender, EventArgs e)
        {
            // 找出被選取的單選按鈕。
            if (bananaRadioButton.Checked)
            {
                selectedFood = new FoodItem("1 根香蕉", 100, 0.4, 27);
            }
            else if (popcornRadioButton.Checked)
            {
                selectedFood = new FoodItem("3 杯爆米花", 93, 1.1, 18);
            }
            else if (muffinRadioButton.Checked)
            {
                selectedFood = new FoodItem("1 個大藍莓鬆餅", 385, 9, 67);
            }

            // 建立 NutritionForm 類別的實例，並將選取的食物物件傳遞過去。
            NutritionForm nutriForm = new NutritionForm(selectedFood);

            // 顯示營養資訊表單
            nutriForm.ShowDialog();
        }

        // 結束按鈕的點擊事件處理程式
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
