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
        private double Average(int[] sArray)
        {
            int total = 0;
            for (int i = 0; i < sArray.Length; i++)
            {
                total += sArray[i];
            }
            return (double)total / sArray.Length;
        }

        // Highest 方法接受一個整數陣列參數，
        // 並回傳該陣列中的最高分。
        private int Highest(int[] sArray)
        {
            int[] scoreCopy = new int[sArray.Length];
            for (int i = 0; i < sArray.Length; i++)
            {
                scoreCopy[i] = sArray[i];
            }   
            // sArray.CopyTo(scoreCopy, 0);
            Array.Sort(scoreCopy);
            Array.Reverse(scoreCopy);
            return sArray[sArray.Length - 1];
            
        }

        // Lowest 方法接受一個整數陣列參數，
        // 並回傳該陣列中的最低分。
        private int Lowest(int[] sArray)
        {
            int[] scoreCopy = new int[sArray.Length];
            for (int i = 0; i < sArray.Length; i++)
            {
                scoreCopy[i] = sArray[i];
            }   
            Array.Sort(sArray);
            return sArray[0];
        }

        private int GetFileScoreCount()
        {
            int count = 0;

            try
            {
                using (StreamReader inputFile = File.OpenText("TestScores.txt"))
                {
                    while (!inputFile.EndOfStream)
                    {
                        inputFile.ReadLine();
                        count++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return count;
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            int size = GetFileScoreCount();
            int[] scores = new int[size];
            int index = 0;

            try
            {
                using (StreamReader inputFile = File.OpenText("TestScores.txt"))
                {
                    while (!inputFile.EndOfStream && index < scores.Length)
                    {
                        scores[index] = int.Parse(inputFile.ReadLine());
                        index++;
                    }
                }

                testScoresListBox.Items.Clear();

                // 顯示人數
                testScoresListBox.Items.Add("學生人數：" + index + " 人");

                foreach (int value in scores)
                {
                    testScoresListBox.Items.Add(value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (index > 0)
            {
                // 修正呼叫方法名稱
                averageScoreLabel.Text = Average(scores).ToString("n1");
                highScoreLabel.Text = Highest(scores).ToString();
                lowScoreLabel.Text = Lowest(scores).ToString();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
