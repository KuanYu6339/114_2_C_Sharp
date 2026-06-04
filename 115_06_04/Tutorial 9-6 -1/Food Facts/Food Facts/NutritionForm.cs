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
    public partial class NutritionForm : Form
    {
        // 宣告類別層級的 FoodItem 變數，用來儲存傳遞過來的食物物件。
        private FoodItem foodItem;

        // 營養資訊表單建構函式，修改為接收 FoodItem 型別的參數。
        public NutritionForm(FoodItem foodItem)
        {
            InitializeComponent();
            // 將傳入的 foodItem 參數，指派給類別層級的 foodItem 變數。
            this.foodItem = foodItem;
        }

        // 關閉按鈕的點擊事件處理程式
        private void closeButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

        // 營養資訊表單載入事件處理程式
        private void NutritionForm_Load(object sender, EventArgs e)
        {
            foodLabel.Text = foodItem.Name; // 顯示食物名稱
            caloriesLabel.Text = foodItem.Calories.ToString(); // 顯示熱量
            fatLabel.Text = foodItem.Fat.ToString(); // 顯示脂肪含量
            carbLabel.Text = foodItem.Carb.ToString(); // 顯示碳水化合物含量
        }
    }
}
