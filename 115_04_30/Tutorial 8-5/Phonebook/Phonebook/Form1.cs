using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Phonebook
{
    /// <summary>
    /// 電話簿應用程式的資料結構
    /// </summary>
    struct PhoneBookEntry
    {
        public string name;      // 聯絡人名字
        public string phone;     // 聯絡人電話號碼
    }

    public partial class Form1 : Form
    {
        // 用於儲存電話簿項目的集合
        private List<PhoneBookEntry> phoneList = 
            new List<PhoneBookEntry>();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ReadFile 方法讀取 PhoneList.txt 檔案的內容
        /// 並將其儲存為 phoneList 中的 PhoneBookEntry 物件
        /// </summary>
        private void ReadFile()
        {
            try
            {
                StreamReader inputFile;                           // 用於讀取檔案的 StreamReader 物件
                string line;                                      // 用於儲存從檔案讀取的一行文字
                char[] delimiter = { ',' };                       // 用於分割名字和電話號碼的分隔符
                PhoneBookEntry entry;                             // 用於儲存從檔案讀取的聯絡人資訊

                // 開啟檔案
                inputFile = File.OpenText("PhoneList.txt");

                // 逐行讀取檔案內容
                while ((line = inputFile.ReadLine()) != null)
                {
                    // 使用逗號將每一行分割成子字串陣列（名字和電話號碼）
                    string[] tokens = line.Split(delimiter);

                    // 確保每行有正確的兩個欄位（名字和電話號碼）
                    if (tokens.Length == 2)
                    {
                        entry.name = tokens[0].Trim();            // 去除名字前後的空白
                        entry.phone = tokens[1].Trim();           // 去除電話號碼前後的空白
                        // 將 entry 加入 phoneList 列表中
                        phoneList.Add(entry);
                    }
                }

                // 關閉檔案
                inputFile.Close();
            }
            catch (Exception ex)
            {
                // 若發生錯誤，顯示錯誤訊息
                MessageBox.Show("讀取檔案時發生錯誤：" + ex.Message, "錯誤");
            }
        }

        /// <summary>
        /// DisplayNames 方法在 nameListBox 控制項中顯示名字清單
        /// </summary>
        private void DisplayNames()
        {
            // 清空列表框中的所有項目
            nameListBox.Items.Clear();

            // 遍歷 phoneList 中的每個項目
            foreach (PhoneBookEntry entry in phoneList)
            {
                // 將每個聯絡人的名字加入列表框
                nameListBox.Items.Add(entry.name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 在表單載入時讀取電話簿檔案
            ReadFile();

            // 在表單載入時顯示所有名字
            DisplayNames();
        }

        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 檢查是否有選中的項目
            if (nameListBox.SelectedIndex != -1)
            {
                // 取得選中項目的索引
                int selectedIndex = nameListBox.SelectedIndex;

                // 從 phoneList 中取得對應的電話簿項目
                PhoneBookEntry entry = phoneList[selectedIndex];

                // 將選中聯絡人的電話號碼顯示在 phoneLabel 中
                phoneLabel.Text = entry.phone;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉應用程式視窗
            this.Close();
        }
    }
}
