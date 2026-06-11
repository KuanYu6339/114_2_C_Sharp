using System;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeRoster
{
    public partial class EditEmployeeForm : Form
    {
        private readonly MainForm mainForm;
        private Employee currentEmployee = null;

        public EditEmployeeForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        /// <summary>
        /// 依員工編號查詢，並將資料載入到欄位中以供編輯
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string idText = txtId.Text.Trim();

            if (!int.TryParse(idText, out int id))
            {
                MessageBox.Show("員工編號格式錯誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                currentEmployee = null;
                return;
            }

            currentEmployee = mainForm.Employees.FirstOrDefault(emp => emp.IdNumber == id);

            if (currentEmployee == null)
            {
                MessageBox.Show("找不到員工", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Clear();
                txtDept.Clear();
                txtPosition.Clear();
                return;
            }

            txtName.Text = currentEmployee.Name;
            txtDept.Text = currentEmployee.Department;
            txtPosition.Text = currentEmployee.Position;
        }

        /// <summary>
        /// 將欄位中的資料儲存回目前查詢到的員工物件
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (currentEmployee == null)
            {
                MessageBox.Show("請先輸入員工編號並按下查詢", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = txtName.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("姓名不可為空", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            currentEmployee.Name = name;
            currentEmployee.Department = txtDept.Text.Trim();
            currentEmployee.Position = txtPosition.Text.Trim();

            mainForm.RefreshListBox();

            MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
