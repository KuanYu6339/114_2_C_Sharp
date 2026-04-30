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

namespace CSV_Reader
{
    /// <summary>
    /// 定義 Student 結構用於儲存學生資訊
    /// 包含班級、學號、姓名及多個成績
    /// </summary>
    public struct Student
    {
        /// <summary>班級名稱</summary>
        public string Class;

        /// <summary>學號</summary>
        public string Id;

        /// <summary>姓名</summary>
        public string Name;

        /// <summary>成績陣列</summary>
        public int[] scores;
    }

    public partial class Form1 : Form
    {
        /// <summary>宣告全域學生列表用於存放所有學生資訊</summary>
        private List<Student> studentList = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 取得成績按鈕的點擊事件處理程序
        /// 讀取 Grades.csv 檔案，格式為：學號、班級、姓名、多次成績
        /// 計算所有成績的平均值，並以「班級、學號、姓名、平均成績」格式加入列表方塊
        /// </summary>
        private void getScoresButton_Click(object sender, EventArgs e)
        {
            try
            {
                // 清空列表方塊中的舊資料
                averagesListBox.Items.Clear();

                // 清空學生列表
                studentList.Clear();

                // 使用 UTF-8 編碼（支援中文）開啟 CSV 檔案進行讀取
                using (StreamReader inputFile = new StreamReader("Grades.csv", Encoding.UTF8))
                {
                    // 定義分隔符號為逗號
                    char[] delim = { ',' };

                    // 逐行讀取檔案，直到檔案結束
                    string line;
                    while (!inputFile.EndOfStream)
                    {
                        // 讀取一行資料
                        line = inputFile.ReadLine();

                        // 檢查是否為空行或 null
                        if (string.IsNullOrEmpty(line))
                        {
                            continue;
                        }

                        // 使用逗號分隔符號將該行分割成欄位陣列
                        string[] fields = line.Split(delim);

                        // 檢查欄位數量是否大於等於 4（學號、班級、姓名、至少一個成績）
                        if (fields.Length >= 4)
                        {
                            // 建立 Student 結構變數
                            Student student = new Student();

                            // 設定學號（第一個欄位）
                            student.Id = fields[0].Trim();

                            // 設定班級（第二個欄位）
                            student.Class = fields[1].Trim();

                            // 設定姓名（第三個欄位）
                            student.Name = fields[2].Trim();

                            // 宣告臨時列表用於存放所有成績
                            List<int> tempScores = new List<int>();

                            // 從第四個欄位開始逐個解析成績
                            for (int i = 3; i < fields.Length; i++)
                            {
                                int score;
                                // 嘗試將欄位轉換為整數
                                if (int.TryParse(fields[i].Trim(), out score))
                                {
                                    // 將有效的成績加入臨時列表
                                    tempScores.Add(score);
                                }
                            }

                            // 檢查是否至少有一個有效的成績
                            if (tempScores.Count > 0)
                            {
                                // 將臨時列表轉換為陣列並儲存在 Student 結構中
                                student.scores = tempScores.ToArray();

                                // 將學生物件加入全域學生列表
                                studentList.Add(student);

                                // 計算平均成績
                                double average = student.scores.Average();

                                // 組合輸出格式：「班級、學號、姓名、平均成績」
                                string displayText = $"{student.Class}、{student.Id}、{student.Name}、{average:F2}";

                                // 將格式化的資訊加入列表方塊
                                averagesListBox.Items.Add(displayText);
                            }
                            else
                            {
                                // 若無有效成績，顯示警告訊息
                                MessageBox.Show($"學號 {student.Id} 無有效成績", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            // 若欄位數量不足，顯示錯誤訊息
                            MessageBox.Show("檔案解析失敗，欄位數量不足：" + line, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                // 顯示成功讀取的訊息
                if (averagesListBox.Items.Count > 0)
                {
                    MessageBox.Show($"成功讀取 {averagesListBox.Items.Count} 筆學生成績", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FileNotFoundException)
            {
                // 若檔案不存在，顯示錯誤訊息
                MessageBox.Show("找不到 Grades.csv 檔案", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // 若發生其他錯誤，顯示錯誤訊息
                MessageBox.Show("發生錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 結束按鈕的點擊事件處理程序
        /// 關閉應用程式視窗
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉視窗
            this.Close();
        }

        /// <summary>
        /// 搜尋成績按鈕的點擊事件處理程序
        /// 從列表方塊中搜尋使用者輸入的學號、姓名或成績
        /// 搜尋成功則顯示該筆記錄所在的位置，失敗則顯示「分數不存在」
        /// </summary>
        private void searchButton_Click(object sender, EventArgs e)
        {
            // 取得使用者輸入的搜尋文字
            string searchText = searchTextBox.Text.Trim();

            // 驗證搜尋框是否為空
            if (string.IsNullOrEmpty(searchText))
            {
                // 若搜尋框為空，提示使用者輸入搜尋條件
                MessageBox.Show("請輸入要搜尋的內容（學號、姓名或成績）", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resultLabel.Text = "";
                return;
            }

            // 宣告旗標用於記錄是否找到符合項目
            bool found = false;
            int foundIndex = -1;

            // 逐項搜尋列表方塊中的每一筆記錄
            for (int i = 0; i < averagesListBox.Items.Count; i++)
            {
                // 取得目前項目的完整文字
                string item = averagesListBox.Items[i].ToString();

                // 檢查項目文字是否包含搜尋文字（不分大小寫）
                if (item.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    // 找到符合項目
                    found = true;
                    foundIndex = i;
                    break;
                }
            }

            // 判斷搜尋結果
            if (found)
            {
                // 搜尋成功 - 顯示記錄所在的位置
                resultLabel.Text = $"記錄位置：第 {foundIndex + 1} 筆";
                resultLabel.ForeColor = Color.Green;

                // 在列表方塊中選中該項目
                averagesListBox.SelectedIndex = foundIndex;
            }
            else
            {
                // 搜尋失敗 - 顯示分數不存在的訊息
                resultLabel.Text = "分數不存在";
                resultLabel.ForeColor = Color.Red;

                // 清除列表方塊中的選取
                averagesListBox.SelectedIndex = -1;
            }
        }
    }
}
