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
        //private MainForm1 mainForm;
        private string uname;

        public SecondForm(ref string name)
        {
            InitializeComponent();
            name = "Steve Lee";
            uname = name;
        }

        private void SecondForm_Load(object sender, EventArgs e)
        {
            label1.Text = uname;
        }
    }
}
