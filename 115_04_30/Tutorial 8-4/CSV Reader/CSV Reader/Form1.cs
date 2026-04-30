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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 取得成績按鈕的點擊事件處理程序
        /// 讀取 Grades.csv 檔案，格式為：學號、班級姓名、多次成績
        /// 計算所有成績的平均值，並以「班級、姓名、學號、平均成績」格式加入列表方塊
        /// </summary>
        private void getScoresButton_Click(object sender, EventArgs e)
        {
            try
            {
                // 清空列表方塊中的舊資料
                averagesListBox.Items.Clear();

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

                        // 檢查欄位數量是否大於等於 3（學號、班級姓名、至少一個成績）
                        if (fields.Length >= 3)
                        {
                            // 取得學號（第一個欄位）
                            string studentId = fields[0].Trim();

                            // 取得班級與姓名（第二個欄位）
                            string classNameInfo = fields[1].Trim();

                            // 解析班級與姓名格式：「資管四甲A」-> 班級：「資管四甲」，姓名：「A」
                            string className = "";
                            string studentName = "";

                            if (classNameInfo.Length > 0)
                            {
                                // 假設班級名稱為前面部分，最後一個字為姓名
                                className = classNameInfo.Substring(0, classNameInfo.Length - 1);
                                studentName = classNameInfo.Substring(classNameInfo.Length - 1);
                            }

                            // 宣告列表用於存放所有成績
                            List<double> scores = new List<double>();

                            // 從第三個欄位開始逐個解析成績
                            for (int i = 2; i < fields.Length; i++)
                            {
                                double score;
                                // 嘗試將欄位轉換為浮點數
                                if (double.TryParse(fields[i].Trim(), out score))
                                {
                                    // 將有效的成績加入列表
                                    scores.Add(score);
                                }
                            }

                            // 檢查是否至少有一個有效的成績
                            if (scores.Count > 0)
                            {
                                // 計算所有成績的平均值
                                double average = scores.Average();

                                // 組合輸出格式：「班級、姓名、學號、平均成績」
                                string displayText = $"{className}、{studentName}、{studentId}、{average:F2}";

                                // 將格式化的資訊加入列表方塊
                                averagesListBox.Items.Add(displayText);
                            }
                            else
                            {
                                // 若無有效成績，顯示警告訊息
                                MessageBox.Show($"第 {studentId} 筆記錄無有效成績", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (found)
            {

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
}