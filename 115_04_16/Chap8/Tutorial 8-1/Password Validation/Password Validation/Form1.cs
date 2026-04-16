using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // NumberUpperCase 方法接受字串引數，並傳回其包含的大寫字母數。
        private int NumberUpperCase(string str)
        {
            int count = 0; // 初始化計數器
            foreach (char c in str) // 遍歷字串中的每個字元
            {
                if (char.IsUpper(c)) // 如果字元是大寫字母
                {
                    count++; // 增加計數器
                }
            }
            return count; // 返回大寫字母的數量
        }

        // NumberLowerCase 方法接受字串引數，並傳回其包含的小寫字母數。
        private int NumberLowerCase(string str)
        {
            int count = 0; // 初始化計數器
            foreach (char c in str) // 遍歷字串中的每個字元
            {
                if (char.IsLower(c)) // 如果字元是小寫字母
                {
                    count++; // 增加計數器
                }
            }
            return count; // 返回小寫字母的數量
        }

        // NumberDigits 方法接受字串引數，並傳回其包含的數字位數。
        private int NumberDigits(string str)
        {
            int count = 0; // 初始化計數器
            foreach (char c in str) // 遍歷字串中的每個字元
            {
                if (char.IsDigit(c)) // 如果字元是數字
                {
                    count++; // 增加計數器
                }
            }
            return count; // 返回數字的數量
        }

        private void checkPasswordButton_Click(object sender, EventArgs e)
        {
            const int MIN_LENGTH = 8; // 密碼最小長度
            string password = passwordTextBox.Text; // 從文字方塊獲取使用者的密碼
            if (password.Length < MIN_LENGTH)
            {
                MessageBox.Show("密碼長度至少要 " + MIN_LENGTH + " 個字元。");
                return;
            }
            else
            {
                int upperCaseCount = NumberUpperCase(password);
                int lowerCaseCount = NumberLowerCase(password);
                int digitCount = NumberDigits(password);
                if (upperCaseCount == 0)
                {
                    MessageBox.Show("密碼必須至少包含一個大寫字母。");
                    return;
                }
                else if (lowerCaseCount == 0)
                {
                    MessageBox.Show("密碼必須至少包含一個小寫字母。");
                    return;
                }
                else if (digitCount == 0)
                {
                    MessageBox.Show("密碼必須至少包含一個數字。");
                    return;
                }
                else
                {
                    MessageBox.Show("密碼有效！");
                    passwordTextBox.Clear(); // 清除密碼輸入框
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }

        private void instructionsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
