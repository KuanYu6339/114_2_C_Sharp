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
using System.Data.SqlTypes;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Average 方法接受一個整數陣列參數，
        // 並回傳該陣列中所有數值的平均值。
        private double Average(int[] sArray, int count)
        {
            if (count == 0) return 0; // 避免除以零

            int total = 0; // 累加器
            for (int i = 0; i < count; i++)
            {
                total += sArray[i]; // 修正：將 index 改為 i
            }
            return (double)total / count; // 修正：除以實際讀取的筆數 count，而非總長度
        }

        // Highest 方法接受一個整數陣列參數，
        // 並回傳該陣列中的最高分。
        private int Highest(int[] sArray, int count)
        {
            if (count == 0) return 0; 

            int highScore = sArray[0];
            for (int i = 1; i < count; i++)
            {
                if (sArray[i] > highScore)
                {
                    highScore = sArray[i]; 
                }
            }
            return highScore;
        }

        // Lowest 方法接受一個整數陣列參數，
        // 並回傳該陣列中的最低分。
        private int Lowest(int[] sArray, int count)
        {
            if (count == 0) return 0;

            int lowScore = sArray[0];
            for (int i = 1; i < count; i++)
            {
                if (sArray[i] < lowScore)
                {
                    lowScore = sArray[i];
                }
            }
            return lowScore;
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            const int SIZE = 60; // 測驗成績的數量
            int[] scores = new int[SIZE]; // 用來儲存測驗成績的陣列
            StreamReader inputFile = null; // 修正：給予初始值 null，防範編譯器報錯
            int index = 0; // 宣告並初始化 index 變數

            try
            {
                inputFile = File.OpenText("TestScores.txt");

                while (!inputFile.EndOfStream && index < scores.Length)
                {
                    scores[index] = int.Parse(inputFile.ReadLine());
                    index++;
                }

                // 清空舊清單，避免重複點按鈕時資料疊加
                testScoresListBox.Items.Clear();

                // 將成績顯示在列表區塊中
                for (int j = 0; j < index; j++)
                {
                    testScoresListBox.Items.Add(scores[j]); // 修正：將 score[i] 改為 scores[j]
                }
            }
            catch (Exception ex)
            {
                // 顯示錯誤訊息
                MessageBox.Show("發生錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
                // 確保檔案有被成功開啟後再關閉，避免發生 NullReferenceException
                if (inputFile != null)
                {
                    inputFile.Close();
                }
            }

            // 確認有讀取到資料才進行運算顯示
            if (index > 0)
            {
                // 計算平均值並顯示在 Label 上
                averageLabel.Text = Average(scores, index).ToString("n1");
                highnLabel.Text = Highest(scores, index).ToString();
                lowScoreLabel.Text = Lowest(scores, index).ToString();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
