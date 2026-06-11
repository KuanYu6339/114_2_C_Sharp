using System;

namespace EmployeeRoster
{
    /// <summary>
    /// 員工資料類別
    /// </summary>
    public class Employee
    {
        public string Name { get; set; }
        public int IdNumber { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }

        /// <summary>
        /// 無參數建構子：Name、Department、Position 預設為空字串，IdNumber 預設為 0
        /// </summary>
        public Employee()
        {
            Name = "";
            IdNumber = 0;
            Department = "";
            Position = "";
        }

        /// <summary>
        /// 兩參數建構子：可設定 Name、IdNumber，Department、Position 預設為空字串
        /// </summary>
        public Employee(string name, int idNumber)
        {
            Name = name;
            IdNumber = idNumber;
            Department = "";
            Position = "";
        }

        /// <summary>
        /// 四參數建構子：可設定 Name、IdNumber、Department、Position
        /// </summary>
        public Employee(string name, int idNumber, string department, string position)
        {
            Name = name;
            IdNumber = idNumber;
            Department = department;
            Position = position;
        }

        /// <summary>
        /// 用於主畫面 ListBox 顯示的格式化字串
        /// </summary>
        public string ToListBoxString()
        {
            return $"{IdNumber}\t{Name}";
        }

        /// <summary>
        /// 用於寫入 txt 的檔案格式
        /// </summary>
        public string ToFileString()
        {
            return $"{IdNumber}|{Name}|{Department}|{Position}";
        }
    }
}
