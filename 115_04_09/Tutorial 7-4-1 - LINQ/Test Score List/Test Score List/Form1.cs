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

namespace Test_Score_List
{
    public partial class Form1 : Form
    {
        // 使用字典存儲學號和分數的對應關係
        private Dictionary<string, int> studentsScores = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            double averageScore;    // To hold the average score
            int numAboveAverage;    // Number of above average scores
            int numBelowAverage;    // Number of below average scores

            // Clear the dictionary
            studentsScores.Clear();

            // Read the scores from the file into the dictionary.
            ReadScores();

            // Display the scores.
            DisplayScores();

            // Get scores list for calculations
            List<int> scoresList = new List<int>(studentsScores.Values);

            // Display the average score.
            averageScore = Average(scoresList);
            averageLabel.Text = averageScore.ToString("n1");

            // Display the number of above average scores.
            numAboveAverage = AboveAverage(scoresList, averageScore);
            aboveAverageLabel.Text = numAboveAverage.ToString();

            // Display the number of below average scores.
            numBelowAverage = BelowAverage(scoresList);
            belowAverageLabel.Text = numBelowAverage.ToString();

            // Clear search result
            searchResultLabel.Text = "";
            searchTextBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        /// <summary>
        /// ReadScores 方法：從 TestScores.txt 文件讀取學號和分數，並加入到字典中
        /// 格式：學號 分數 (例如：A11422055 54)
        /// </summary>
        private void ReadScores()
        {
            string filePath = "TestScores.txt";  // 定義檔案路徑
            try
            {
                // 開啟檔案並讀取數據
                using (StreamReader reader = File.OpenText(filePath))
                {
                    // 逐行讀取檔案內容
                    while (!reader.EndOfStream)
                    {
                        // 從檔案中讀取一行
                        string line = reader.ReadLine();
                        
                        if (string.IsNullOrWhiteSpace(line))
                            continue;

                        // 移除多餘的空白並分割學號和分數
                        line = line.Trim();
                        string[] parts = line.Split(new[] { ' ', '\t' }, System.StringSplitOptions.RemoveEmptyEntries);
                        
                        // 確保有學號和分數兩個部分
                        if (parts.Length >= 2)
                        {
                            string studentId = parts[0].Trim();
                            string scoreStr = parts[parts.Length - 1];  // 取最後一個元素作為分數
                            
                            if (int.TryParse(scoreStr, out int score))
                            {
                                // 如果學號已存在則覆蓋，否則新增
                                studentsScores[studentId] = score;
                            }
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("檔案 TestScores.txt 未找到。", "錯誤");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"讀取檔案時出錯：{ex.Message}", "錯誤");
            }
        }

        /// <summary>
        /// DisplayScores 方法：在 ListBox 中顯示所有學號和分數
        /// 使用 LINQ 查詢語法按照學號排序
        /// 格式：學號 分數
        /// </summary>
        private void DisplayScores()
        {
            // 清空 ListBox
            testScoresListBox.Items.Clear();

            // 使用 LINQ 查詢語法按照學號排序
            var sortedScores = from item in studentsScores
                               orderby item.Key
                               select item;
            
            // 將排序後的結果添加到 ListBox，使用空格分隔
            foreach (var kvp in sortedScores)
            {
                testScoresListBox.Items.Add(string.Format("{0} {1}", kvp.Key, kvp.Value));
            }
        }

        /// <summary>
        /// Average 方法：計算所有分數的平均值
        /// 使用 LINQ 查詢語法計算
        /// </summary>
        private double Average(List<int> scoresList)
        {
            if (scoresList.Count == 0)
                return 0;

            // 使用 LINQ 查詢語法計算總和
            var sum = (from score in scoresList
                       select score).Sum();

            // 回傳平均值
            return (double)sum / scoresList.Count;
        }

        /// <summary>
        /// AboveAverage 方法：統計高於平均分的成績數量
        /// 使用 LINQ 查詢語法統計
        /// </summary>
        private int AboveAverage(List<int> scoresList, double averageScore)
        {
            // 使用 LINQ 查詢語法統計高於平均分的成績數量
            var count = (from score in scoresList
                         where score > averageScore
                         select score).Count();
            
            return count;
        }

        /// <summary>
        /// BelowAverage 方法：統計低於平均分的成績數量
        /// 使用 LINQ 查詢語法統計
        /// </summary>
        private int BelowAverage(List<int> scoresList)
        {
            double averageScore = Average(scoresList);
            
            // 使用 LINQ 查詢語法統計低於平均分的成績數量
            var count = (from score in scoresList
                         where score < averageScore
                         select score).Count();
            
            return count;
        }

        /// <summary>
        /// searchButton_Click 方法：根據分數搜尋排名信息
        /// 使用 LINQ 查詢語法計算排名
        /// </summary>
        private void searchButton_Click(object sender, EventArgs e)
        {
            string inputScore = searchTextBox.Text.Trim();
            
            if (string.IsNullOrWhiteSpace(inputScore))
            {
                MessageBox.Show("請輸入分數。", "警告");
                searchResultLabel.Text = "";
                return;
            }

            // 驗證輸入是否為有效的整數
            if (!int.TryParse(inputScore, out int score))
            {
                MessageBox.Show("請輸入有效的整數分數。", "錯誤");
                searchResultLabel.Text = "";
                return;
            }

            // 使用 LINQ 查詢語法查找具有該分數的學生
            var studentsWithScore = from student in studentsScores
                                    where student.Value == score
                                    select student;

            // 檢查是否找到具有該分數的學生
            if (studentsWithScore.Count() > 0)
            {
                // 計算排名（高於此分數的人數 + 1）
                var rank = (from s in studentsScores
                            where s.Value > score
                            select s).Count() + 1;

                // 計算有多少人具有相同分數
                int countWithSameScore = studentsWithScore.Count();

                // 列出所有具有該分數的學號
                var studentIds = from student in studentsWithScore
                                 orderby student.Key
                                 select student.Key;

                string studentIdList = string.Join(", ", studentIds);

                // 顯示搜尋結果在標籤中
                if (countWithSameScore == 1)
                {
                    searchResultLabel.Text = string.Format("分數 {0} 位於第 {1} 等\n學號：{2}", score, rank, studentIdList);
                }
                else
                {
                    searchResultLabel.Text = string.Format("分數 {0} 位於第 {1} 等\n共 {2} 位學生({3})", score, rank, countWithSameScore, studentIdList);
                }
            }
            else
            {
                searchResultLabel.Text = string.Format("沒有學生獲得 {0} 分", score);
            }
        }
    }
}
