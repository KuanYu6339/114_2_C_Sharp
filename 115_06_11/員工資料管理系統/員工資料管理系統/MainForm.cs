using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace EmployeeRoster
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 所有員工資料，供子表單共用存取
        /// </summary>
        public List<Employee> Employees { get; set; } = new List<Employee>();

        // employees.txt 路徑：與執行檔（bin/Debug...）放在同一目錄
        private readonly string filePath = Path.Combine(Application.StartupPath, "employees.txt");

        public MainForm()
        {
            InitializeComponent();
            LoadEmployees();
            RefreshListBox();
        }

        /// <summary>
        /// 從 employees.txt 讀取資料，格式：IdNumber|Name|Department|Position
        /// </summary>
        private void LoadEmployees()
        {
            Employees.Clear();

            if (!File.Exists(filePath))
            {
                return;
            }

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                string[] parts = line.Split('|');

                if (parts.Length >= 4 && int.TryParse(parts[0].Trim(), out int id))
                {
                    Employee emp = new Employee(parts[1].Trim(), id, parts[2].Trim(), parts[3].Trim());
                    Employees.Add(emp);
                }
            }
        }

        /// <summary>
        /// 將目前的員工清單寫回 employees.txt
        /// </summary>
        private void SaveEmployees()
        {
            List<string> lines = new List<string>();

            foreach (Employee emp in Employees)
            {
                lines.Add($"{emp.IdNumber}|{emp.Name}|{emp.Department}|{emp.Position}");
            }

            File.WriteAllLines(filePath, lines);
        }

        /// <summary>
        /// 重新整理主畫面 ListBox，顯示格式：IdNumber<TAB>Name
        /// </summary>
        public void RefreshListBox()
        {
            listBoxEmployees.Items.Clear();

            foreach (Employee emp in Employees)
            {
                listBoxEmployees.Items.Add($"{emp.IdNumber}\t{emp.Name}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (AddEmployeeForm form = new AddEmployeeForm(this))
            {
                form.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (DeleteEmployeeForm form = new DeleteEmployeeForm(this))
            {
                form.ShowDialog();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (EditEmployeeForm form = new EditEmployeeForm(this))
            {
                form.ShowDialog();
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            using (QueryEmployeeForm form = new QueryEmployeeForm(this))
            {
                form.ShowDialog();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 程式關閉時，將員工清單寫回 employees.txt
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveEmployees();
        }
    }
}
