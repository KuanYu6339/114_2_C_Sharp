using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Format
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// IsValidNumber 方法接受一個字串參數，
        /// 如果該字串包含10位數字則返回 true，
        /// 否則返回 false。
        /// </summary>
        /// <param name="str">要驗證的字串</param>
        /// <returns>如果是有效的10位數字返回 true，否則返回 false</returns>
        private bool IsValidNumber(string str)
        {
            // 使用正規表達式驗證是否恰好包含10位數字
            return System.Text.RegularExpressions.Regex.IsMatch(str, @"^\d{10}$");
        }

        /// <summary>
        /// TelephoneFormat 方法接受一個字串參數（以參考方式傳遞），
        /// 並將其格式化為電話號碼格式 (XXX) XXXX-XXXX。
        /// 例如：0222368225 -> (02) 2236-8225
        /// </summary>
        /// <param name="str">要格式化的字串，以參考方式傳遞</param>
        private void TelephoneFormat(ref string str)
        {
            // 使用字串的 Substring 方法提取各部分
            // 第一部分：前2位數字（區碼）
            string part1 = str.Substring(0, 2);
            // 第二部分：中間4位數字
            string part2 = str.Substring(2, 4);
            // 第三部分：最後4位數字
            string part3 = str.Substring(6, 4);

            // 將各部分組合成電話號碼格式
            str = "(" + part1 + ") " + part2 + "-" + part3;
        }

        /// <summary>
        /// 格式化按鈕的點擊事件處理程序。
        /// 驗證輸入的號碼，若有效則格式化並顯示結果。
        /// </summary>
        private void formatButton_Click(object sender, EventArgs e)
        {
            // 從文字框中取得使用者輸入的內容
            string number = numberTextBox.Text;

            // 驗證輸入的內容是否為有效的10位數字
            if (!IsValidNumber(number))
            {
                // 如果輸入無效，顯示錯誤對話框給使用者
                MessageBox.Show("請輸入10個數字。", "輸入錯誤");
                // 清空文字框，讓使用者重新輸入
                numberTextBox.Clear();
                // 將焦點設回文字框
                numberTextBox.Focus();
            }
            else
            {
                // 如果輸入有效，調用 TelephoneFormat 方法格式化電話號碼
                // 以引用方式傳遞字串，使其在方法內被修改
                TelephoneFormat(ref number);
                // 將格式化後的電話號碼顯示在文字框中
                numberTextBox.Text = number;
            }
        }

        /// <summary>
        /// 結束按鈕的點擊事件處理程序。
        /// 關閉視窗。
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉視窗
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
