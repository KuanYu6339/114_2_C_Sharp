using System;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeRoster
{
    public partial class DeleteEmployeeForm : Form
    {
        private readonly MainForm mainForm;

        public DeleteEmployeeForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        /// <summary>
        /// 依員工編號查詢，並顯示姓名供確認
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string idText = txtId.Text.Trim();

            if (!int.TryParse(idText, out int id))
            {
                MessageBox.Show("員工編號格式錯誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblNameResult.Text = "姓名：";
                return;
            }

            Employee employee = mainForm.Employees.FirstOrDefault(emp => emp.IdNumber == id);

            if (employee == null)
            {
                MessageBox.Show("找不到員工", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblNameResult.Text = "姓名：";
                return;
            }

            lblNameResult.Text = "姓名：" + employee.Name;
        }

        /// <summary>
        /// 依員工編號刪除員工
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string idText = txtId.Text.Trim();

            if (!int.TryParse(idText, out int id))
            {
                MessageBox.Show("員工編號格式錯誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Employee employee = mainForm.Employees.FirstOrDefault(emp => emp.IdNumber == id);

            if (employee == null)
            {
                MessageBox.Show("找不到員工", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string deletedName = employee.Name;
            int deletedId = employee.IdNumber;

            mainForm.Employees.Remove(employee);
            mainForm.RefreshListBox();

            MessageBox.Show($"已刪除員工\n員工編號：{deletedId}\n姓名：{deletedName}", "刪除成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtId.Clear();
            lblNameResult.Text = "姓名：";
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
