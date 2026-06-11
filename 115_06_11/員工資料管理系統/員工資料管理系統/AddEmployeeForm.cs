using System;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeRoster
{
    public partial class AddEmployeeForm : Form
    {
        private readonly MainForm mainForm;

        public AddEmployeeForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string idText = txtId.Text.Trim();
            string name = txtName.Text.Trim();
            string department = txtDept.Text.Trim();
            string position = txtPosition.Text.Trim();

            // 員工編號必須能轉成整數
            if (!int.TryParse(idText, out int id))
            {
                MessageBox.Show("員工編號格式錯誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 姓名不可為空
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("姓名不可為空，請輸入姓名", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 員工編號不可重複
            if (mainForm.Employees.Any(emp => emp.IdNumber == id))
            {
                MessageBox.Show("此員工編號已存在，無法新增", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Employee newEmployee = new Employee(name, id, department, position);
            mainForm.Employees.Add(newEmployee);
            mainForm.RefreshListBox();

            MessageBox.Show("新增成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 清空欄位，方便繼續新增下一筆
            txtId.Clear();
            txtName.Clear();
            txtDept.Clear();
            txtPosition.Clear();
            txtId.Focus();
        }

        /// <summary>
        /// 關閉本表單，返回主畫面
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
