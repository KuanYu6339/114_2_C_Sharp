using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Toss
{
    /// <summary>
    /// 擲硬幣遊戲主程式
    /// 實現擲硬幣 5 次並顯示結果的功能
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 擲硬幣按鈕的點擊事件處理程式
        /// 按下時會擲硬幣 5 次，並將結果顯示在清單方塊中
        /// </summary>
        private void tossButton_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 結束按鈕的點擊事件處理程式
        /// 按下時會關閉程式
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉主程式視窗
            this.Close();
        }
    }
}
