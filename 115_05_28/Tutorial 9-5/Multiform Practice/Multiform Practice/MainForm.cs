using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiform_Practice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void displayFormButton_Click(object sender, EventArgs e)
        {
            // 建立 MessageForm 類別的實例
            MessageForm myMessageForm = new MessageForm();

            // 顯示表單
            myMessageForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
