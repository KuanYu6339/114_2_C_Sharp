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
        /// 格式：學號 分數
        /// </summary>
        private void DisplayScores()
        {
            // 清空 ListBox
            testScoresListBox.Items.Clear();

            // 按照學號排序後顯示
            var sortedScores = studentsScores.OrderBy(x => x.Key);
            
            // 將字典中的每個學號和分數添加到 ListBox，使用空格分隔
            foreach (var kvp in sortedScores)
            {
                testScoresListBox.Items.Add(string.Format("{0} {1}", kvp.Key, kvp.Value));
            }
        }

        /// <summary>
        /// Average 方法：計算所有分數的平均值
        /// </summary>
        private double Average(List<int> scoresList)
        {
            if (scoresList.Count == 0)
                return 0;

            // 計算總和
            int sum = 0;
            foreach (int score in scoresList)
            {
                sum += score;
            }

            // 回傳平均值
            return (double)sum / scoresList.Count;
        }

        /// <summary>
        /// AboveAverage 方法：統計高於平均分的成績數量
        /// </summary>
        private int AboveAverage(List<int> scoresList, double averageScore)
        {
            int count = 0;
            foreach (int score in scoresList)
            {
                if (score > averageScore)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// BelowAverage 方法：統計低於平均分的成績數量
        /// </summary>
        private int BelowAverage(List<int> scoresList)
        {
            double averageScore = Average(scoresList);
            int count = 0;
            foreach (int score in scoresList)
            {
                if (score < averageScore)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// searchButton_Click 方法：搜尋特定學生的成績並顯示排名信息
        /// </summary>
        private void searchButton_Click(object sender, EventArgs e)
        {
            string studentId = searchTextBox.Text.Trim();
            
            if (string.IsNullOrWhiteSpace(studentId))
            {
                MessageBox.Show("請輸入學號。", "警告");
                searchResultLabel.Text = "";
                return;
            }

            if (studentsScores.ContainsKey(studentId))
            {
                int score = studentsScores[studentId];
                
                // 計算排名（高於此分數的人數 + 1）
                int rank = 1;
                foreach (var kvp in studentsScores)
                {
                    if (kvp.Value > score)
                    {
                        rank++;
                    }
                }

                // 顯示搜尋結果在標籤中
                searchResultLabel.Text = string.Format("分數 {0} 位於第 {1} 等", score, rank);
            }
            else
            {
                searchResultLabel.Text = "找不到該學生的成績";
            }
        }
    }
}
