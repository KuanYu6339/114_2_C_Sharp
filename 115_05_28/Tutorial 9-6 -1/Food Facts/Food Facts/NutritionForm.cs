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
        // 營養資訊表單建構函式
        public NutritionForm()
        {
            InitializeComponent();
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
            // 此事件在表單載入時觸發，可用於初始化表單狀態
        }
    }
}
