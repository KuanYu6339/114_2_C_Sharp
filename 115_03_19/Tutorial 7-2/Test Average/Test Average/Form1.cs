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
        private double Average(int[] sArray)
        {
            int total = 0; // 累加器
            for (int index = 0; index < sArray.Length; index++)
            {
                total += sArray[index];
            }
            return (double)total / sArray.Length;
        }

        // Highest 方法接受一個整數陣列參數，
        // 並回傳該陣列中的最高分。
        private int Highest(int[] sArray)
        {
            int highScore = sArray[0];
            for (int i = 1; i < sArray.Length; i++)
            {
                if (sArray[i] > highScore)
                {
                    highScore = sArray[i]; // 修正：將 highest 改為 highScore
                }
            }
            return highScore;
        }

        // Lowest 方法接受一個整數陣列參數，
        // 並回傳該陣列中的最低分。
        private int Lowest(int[] sArray)
        {
            int lowScore = sArray[0];
            for (int i = 1; i < sArray.Length; i++)
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
            const int SIZE = 5; // 測驗成績的數量
            int[] scores = new int[SIZE]; // 用來儲存測驗成績的陣列
            StreamReader inputFile = null; // 修正：給予初始值 null，防範編譯器報錯
            int index = 0; // 修正：宣告並初始化 index 變數

            try
            {
                inputFile = File.OpenText("TestScores.txt");

                while (!inputFile.EndOfStream && index < scores.Length)
                {
                    scores[index] = int.Parse(inputFile.ReadLine());
                    index++;
                }

                // 將成績顯示在列表區塊中
                foreach (int score in scores)
                {
                    testScoresListBox.Items.Add(score);
                }
            }
            catch (Exception ex)
            {
                // 顯示錯誤訊息
                MessageBox.Show("發生錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
                // 修正：確保檔案有被成功開啟後再關閉，避免發生 NullReferenceException
                if (inputFile != null)
                {
                    inputFile.Close();
                }
            }

            // 計算平均值並顯示在 Label 上
            averageScoreDescriptionLabel.Text = Average(scores).ToString("n1");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
