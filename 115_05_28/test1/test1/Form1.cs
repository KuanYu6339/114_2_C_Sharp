using System;
using System.Windows.Forms;

namespace test1
{
    public partial class Form1 : Form
    {
        public string username = "ChIKuanYu";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SecondForm secondForm = new SecondForm(this);
            secondForm.Show();
        }
    }
}
