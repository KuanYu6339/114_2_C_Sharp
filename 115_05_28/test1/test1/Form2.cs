using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class SecondForm : Form
    {
        private Form1 mainForm;

        public SecondForm(Form form)
        {
            InitializeComponent();
            mainForm = form as Form1;
        }

        private void SecondForm_Load(object sender, EventArgs e)
        {
            if (mainForm != null)
            {
                label1.Text = mainForm.username;
            }
        }
    }
}
