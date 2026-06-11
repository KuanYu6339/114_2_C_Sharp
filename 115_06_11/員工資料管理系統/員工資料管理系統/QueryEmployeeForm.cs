using System;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeRoster
{
    public partial class QueryEmployeeForm : Form
    {
        private readonly MainForm mainForm;

        public QueryEmployeeForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        /// <summary>
        /// 依員工編號查詢並顯示完整資料
        /// </summary>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string idText = txtId.Text.Trim();

            if (!int.TryParse(idText, out int id))
            {
                MessageBox.Show("員工編號格式錯誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearResult();
                return;
            }

            Employee employee = mainForm.Employees.FirstOrDefault(emp => emp.IdNumber == id);

            if (employee == null)
            {
                MessageBox.Show("找不到員工", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearResult();
                return;
            }

            lblIdResult.Text = "員工編號：" + employee.IdNumber;
            lblNameResult.Text = "姓名：" + employee.Name;
            lblDeptResult.Text = "部門：" + employee.Department;
            lblPositionResult.Text = "職位：" + employee.Position;
        }

        private void ClearResult()
        {
            lblIdResult.Text = "員工編號：";
            lblNameResult.Text = "姓名：";
            lblDeptResult.Text = "部門：";
            lblPositionResult.Text = "職位：";
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
