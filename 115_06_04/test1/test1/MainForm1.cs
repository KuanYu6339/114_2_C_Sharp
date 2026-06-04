using System;
using System.Windows.Forms;

namespace test1
{
    public partial class MainForm1 : Form
    {
        private string username = "Chuckhu";

        //public string Username
        //{
        //    get { return username; }
        //}

        public MainForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SecondForm secondForm = new SecondForm(ref username);
            secondForm.ShowDialog();
            MessageBox.Show("Welcome back, " + username);
        }
    }
}
