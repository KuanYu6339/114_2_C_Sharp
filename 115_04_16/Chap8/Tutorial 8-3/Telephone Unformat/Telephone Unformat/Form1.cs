using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Unformat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // IsValidFormat 方法接受一個字串參數
        // 用來判斷是否符合台灣電話號碼格式
        // 格式要求: (XX)XXXX-XXXX
        // 如果符合格式則傳回 true，否則傳回 false
        private bool IsValidFormat(string str)
        {
            // 檢查字串是否為空或長度不符
            if (string.IsNullOrEmpty(str) || str.Length != 13)
                return false;

            // 檢查第一個字元是否為左括號
            if (str[0] != '(')
                return false;

            // 檢查前三個字元的格式: (XX)
            if (str[3] != ')')
                return false;

            // 檢查第八個字元是否為連字符
            if (str[8] != '-')
                return false;

            // 檢查位置 1-2、4-7、9-12 是否都是數字
            for (int i = 0; i < str.Length; i++)
            {
                // 跳過括號和連字符的位置
                if (i == 0 || i == 3 || i == 8)
                    continue;

                // 檢查是否為數字
                if (!char.IsDigit(str[i]))
                    return false;
            }

            return true;
        }

        // Unformat 方法接受一個以參考方式傳遞的字串
        // 該字串應包含符合以下格式的電話號碼: (XXX)XXX-XXXX
        // 方法會透過移除括號和連字符來解除電話號碼的格式
        private void Unformat(ref string str)
        {
            // 移除所有非數字的字元（括號和連字符）
            str = str.Replace("(", "").Replace(")", "").Replace("-", "");
        }

        // 轉換按鈕點擊事件處理程式
        // 執行電話號碼的格式驗證和轉換
        private void unformatButton_Click(object sender, EventArgs e)
        {
            // 取得文字框中輸入的電話號碼
            string phoneNumber = numberTextBox.Text;

            // 檢查電話號碼格式是否正確
            if (IsValidFormat(phoneNumber))
            {
                // 格式正確，執行轉換
                Unformat(ref phoneNumber);

                // 將轉換後的號碼顯示在文字框中
                numberTextBox.Text = phoneNumber;

                // 顯示成功訊息
                MessageBox.Show("電話號碼轉換成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // 格式不正確，顯示錯誤訊息
                MessageBox.Show("電話號碼格式不正確！\r\n請輸入格式: (XX)XXXX-XXXX", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 結束按鈕點擊事件處理程式
        // 關閉表單視窗
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
