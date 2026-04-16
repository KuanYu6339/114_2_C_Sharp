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
    /// Form1 表單類別
    /// 主要負責 CSV 讀取器的使用者介面邏輯及事件處理
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// 表單建構函式 - 初始化所有設計工具生成的元件
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 計算平均值的私有方法
        /// 接收一個整數清單，計算並回傳其中所有數值的平均值
        /// </summary>
        /// <param name="scores">成績清單</param>
        /// <returns>平均值</returns>
        private double CalculateAverage(List<int> scores)
        {
            // 如果清單為空，回傳 0
            if (scores.Count == 0)
                return 0;

            // 計算所有成績的總和
            int total = 0;
            foreach (int score in scores)
            {
                total += score;
            }

            // 回傳平均值（總和除以成績數量）
            return (double)total / scores.Count;
        }

        /// <summary>
        /// 計算最高分的私有方法
        /// 接收一個整數清單，找出其中的最高分
        /// </summary>
        /// <param name="scores">成績清單</param>
        /// <returns>最高分</returns>
        private int FindHighestScore(List<int> scores)
        {
            // 如果清單為空，回傳 0
            if (scores.Count == 0)
                return 0;

            // 初始化最高分為清單中的第一個值
            int highest = scores[0];

            // 遍歷清單中的每個成績
            foreach (int score in scores)
            {
                // 如果目前成績大於最高分，更新最高分
                if (score > highest)
                    highest = score;
            }

            // 回傳最高分
            return highest;
        }

        /// <summary>
        /// 計算最低分的私有方法
        /// 接收一個整數清單，找出其中的最低分
        /// </summary>
        /// <param name="scores">成績清單</param>
        /// <returns>最低分</returns>
        private int FindLowestScore(List<int> scores)
        {
            // 如果清單為空，回傳 0
            if (scores.Count == 0)
                return 0;

            // 初始化最低分為清單中的第一個值
            int lowest = scores[0];

            // 遍歷清單中的每個成績
            foreach (int score in scores)
            {
                // 如果目前成績小於最低分，更新最低分
                if (score < lowest)
                    lowest = score;
            }

            // 回傳最低分
            return lowest;
        }

        /// <summary>
        /// 「讀取成績」按鈕點擊事件處理方法
        /// 此方法負責從 CSV 檔案中讀取成績資料，並將其顯示在列表框中
        /// 同時計算並顯示各種統計資訊（平均值、最高分、最低分等）
        /// </summary>
        /// <param name="sender">觸發事件的物件</param>
        /// <param name="e">事件參數</param>
        private void getScoresButton_Click(object sender, EventArgs e)
        {
        
            try
            {
                // 使用 StreamReader 開啟選定的檔案進行讀取
                using (inputFile = File.OpenText("Grades.csv"))
                

                

        /// <summary>
        /// 「離開」按鈕點擊事件處理方法
        /// 此方法用於關閉表單，結束程式執行
        /// </summary>
        /// <param name="sender">觸發事件的物件</param>
        /// <param name="e">事件參數</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}   