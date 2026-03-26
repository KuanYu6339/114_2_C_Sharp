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
    /// <summary>
    /// 主表單 - 用於顯示和處理測試成績數據
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// 用於存儲成績列表的私有欄位
        /// </summary>
        private List<int> scoresList = new List<int>();

        /// <summary>
        /// 表單初始化方法
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 從檔案中讀取成績的方法
        /// 將檔案中的每一行數值轉換為整數並添加到列表中
        /// </summary>
        private void ReadScores(List<int> scoresList)
        {
            string filePath = "TestScores.txt";
            // 從檔案中讀取成績並添加到列表中
            try
            {
                using (StreamReader reader = File.OpenText(filePath))
                {
                    string line;
                    while (!reader.EndOfStream)
                    {
                        // 讀取每一行並轉換為整數
                        scoresList.Add(int.Parse(reader.ReadLine()));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"讀取成績時發生錯誤: {ex.Message}");
            }
        }

        /// <summary>
        /// 在列表框中顯示所有成績的方法
        /// 將成績列表中的每個成績添加到列表框控制項中
        /// </summary>
        private void DisplayScores(List<int> scoresList)
        {
            int index = 1;
            // 清空列表框中的現有項目
            testScoresListBox.Items.Clear();

            // 遍歷成績列表中的每個成績
            foreach (int score in scoresList)
            {
                // 將成績添加到列表框中，格式為 "序號:成績"
                testScoresListBox.Items.Add((index++) + ":" + score);
            }
        }

        /// <summary>
        /// 計算平均成績的方法
        /// 回傳所有成績的平均值
        /// </summary>
        private double Average(List<int> scoresList)
        {
            // 用於累加所有成績
            int total = 0;

            // 累加所有成績
            foreach (int score in scoresList)
            {
                // 將成績添加到累加值
                total += score;
            }

            // 回傳平均值（總和除以成績數量）
            return (double)total / scoresList.Count;
        }

        /// <summary>
        /// 計算高於平均成績數量的方法
        /// 回傳高於平均值的成績數量
        /// </summary>
        private int AboveAverage(List<int> scoresList, double avg)
        {
            // 用於計算高於平均成績的數量
            int count = 0;

            // 遍歷成績列表中的每個成績
            foreach (int score in scoresList)
            {
                // 若成績大於平均值，數量加 1
                if (score > avg)
                    count++;
            }

            // 回傳高於平均成績的數量
            return count;
        }

        /// <summary>
        /// 計算低於平均成績數量的方法
        /// 回傳低於平均值的成績數量
        /// </summary>
        private int BelowAverage(List<int> scoresList)
        {
            // 先計算平均成績
            double avg = Average(scoresList);

            // 用於計算低於平均成績的數量
            int count = 0;

            // 遍歷成績列表中的每個成績
            foreach (int score in scoresList)
            {
                // 若成績小於平均值，數量加 1
                if (score < avg)
                    count++;
            }

            // 回傳低於平均成績的數量
            return count;
        }

        /// <summary>
        /// 「取得成績」按鈕點擊事件處理器
        /// 負責讀取成績、計算平均值、顯示成績及統計數據
        /// </summary>
        private void getScoresButton_Click(object sender, EventArgs e)
        {
            // 用於存儲平均成績的變數
            double averageScore;    

            // 用於存儲高於平均成績的數量
            int numAboveAverage;    

            // 用於存儲低於平均成績的數量
            int numBelowAverage;    

            // 建立一個用於存放成績的列表
            scoresList = new List<int>();

            // 從檔案中讀取成績並放入列表中
            ReadScores(scoresList);

            // 在列表框中顯示所有成績
            DisplayScores(scoresList);

            // 計算並顯示平均成績
            averageScore = Average(scoresList);
            averageLabel.Text = averageScore.ToString("n1");

            // 計算並顯示高於平均成績的數量
            numAboveAverage = AboveAverage(scoresList, averageScore);
            aboveAverageLabel.Text = numAboveAverage.ToString();

            // 計算並顯示低於平均成績的數量
            numBelowAverage = BelowAverage(scoresList);
            belowAverageLabel.Text = numBelowAverage.ToString();

            // 清空搜尋結果
            searchResultLabel.Text = "";
            searchScoreTextBox.Text = "";
        }

        /// <summary>
        /// 「搜尋」按鈕點擊事件處理器
        /// 負責在成績列表中搜尋指定的成績並顯示所在位置
        /// 搜尋成功則輸出所在位置，搜尋失敗則輸出「分數不存在」
        /// </summary>
        private void searchButton_Click(object sender, EventArgs e)
        {
            // 用於存儲搜尋輸入的成績
            int searchScore;

            // 用於存儲搜尋結果的位置
            int position;

            // 檢查輸入的文字是否為有效的整數，若無效則提示使用者
            if (!int.TryParse(searchScoreTextBox.Text, out searchScore))
            {
                searchResultLabel.Text = "請輸入有效的整數成績";
                return;
            }

            // 在成績列表中搜尋指定的成績，取得其位置
            position = scoresList.IndexOf(searchScore);

            // 判斷搜尋結果，若位置不為 -1 則搜尋成功
            if (position != -1)
            {
                // 搜尋成功，顯示所在位置（位置從 1 開始計算）
                searchResultLabel.Text = $"分數 {searchScore} 位於第 {position + 1} 筆";
                return;
            }
            else
            {
                // 搜尋失敗，顯示「分數不存在'
                searchResultLabel.Text = "分數不存在";
                return;
            }
        }

        /// <summary>
        /// 「結束」按鈕點擊事件處理器
        /// 負責關閉應用程式表單
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
