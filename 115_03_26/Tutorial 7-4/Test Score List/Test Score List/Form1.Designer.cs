namespace Test_Score_List
{
    partial class Form1
    {
        /// <summary>
        /// 所需的設計工具變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除正在使用的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受管資源，則為 true；否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// 設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改此方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.testScoresListBox = new System.Windows.Forms.ListBox();
            this.avgScoreDescriptionLabel = new System.Windows.Forms.Label();
            this.aboveAvgDescriptionLabel = new System.Windows.Forms.Label();
            this.belowAvgDescriptionLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.aboveAverageLabel = new System.Windows.Forms.Label();
            this.belowAverageLabel = new System.Windows.Forms.Label();
            this.getScoresButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.searchScoreLabel = new System.Windows.Forms.Label();
            this.searchScoreTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // testScoresListBox
            // 
            this.testScoresListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.testScoresListBox.FormattingEnabled = true;
            this.testScoresListBox.ItemHeight = 40;
            this.testScoresListBox.Location = new System.Drawing.Point(18, 17);
            this.testScoresListBox.Margin = new System.Windows.Forms.Padding(4);
            this.testScoresListBox.Name = "testScoresListBox";
            this.testScoresListBox.Size = new System.Drawing.Size(304, 404);
            this.testScoresListBox.TabIndex = 0;
            // 
            // avgScoreDescriptionLabel
            // 
            this.avgScoreDescriptionLabel.AutoSize = true;
            this.avgScoreDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.avgScoreDescriptionLabel.Location = new System.Drawing.Point(330, 48);
            this.avgScoreDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.avgScoreDescriptionLabel.Name = "avgScoreDescriptionLabel";
            this.avgScoreDescriptionLabel.Size = new System.Drawing.Size(171, 40);
            this.avgScoreDescriptionLabel.TabIndex = 1;
            this.avgScoreDescriptionLabel.Text = "平均成績:";
            // 
            // aboveAvgDescriptionLabel
            // 
            this.aboveAvgDescriptionLabel.AutoSize = true;
            this.aboveAvgDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.aboveAvgDescriptionLabel.Location = new System.Drawing.Point(330, 132);
            this.aboveAvgDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aboveAvgDescriptionLabel.Name = "aboveAvgDescriptionLabel";
            this.aboveAvgDescriptionLabel.Size = new System.Drawing.Size(315, 40);
            this.aboveAvgDescriptionLabel.TabIndex = 2;
            this.aboveAvgDescriptionLabel.Text = "高於平均的成績數:";
            // 
            // belowAvgDescriptionLabel
            // 
            this.belowAvgDescriptionLabel.AutoSize = true;
            this.belowAvgDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.belowAvgDescriptionLabel.Location = new System.Drawing.Point(330, 215);
            this.belowAvgDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.belowAvgDescriptionLabel.Name = "belowAvgDescriptionLabel";
            this.belowAvgDescriptionLabel.Size = new System.Drawing.Size(315, 40);
            this.belowAvgDescriptionLabel.TabIndex = 3;
            this.belowAvgDescriptionLabel.Text = "低於平均的成績數:";
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.averageLabel.Location = new System.Drawing.Point(653, 41);
            this.averageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(209, 55);
            this.averageLabel.TabIndex = 4;
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aboveAverageLabel
            // 
            this.aboveAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aboveAverageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.aboveAverageLabel.Location = new System.Drawing.Point(653, 125);
            this.aboveAverageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aboveAverageLabel.Name = "aboveAverageLabel";
            this.aboveAverageLabel.Size = new System.Drawing.Size(209, 55);
            this.aboveAverageLabel.TabIndex = 5;
            this.aboveAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // belowAverageLabel
            // 
            this.belowAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.belowAverageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.belowAverageLabel.Location = new System.Drawing.Point(653, 208);
            this.belowAverageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.belowAverageLabel.Name = "belowAverageLabel";
            this.belowAverageLabel.Size = new System.Drawing.Size(209, 55);
            this.belowAverageLabel.TabIndex = 6;
            this.belowAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // getScoresButton
            // 
            this.getScoresButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.getScoresButton.Location = new System.Drawing.Point(351, 496);
            this.getScoresButton.Margin = new System.Windows.Forms.Padding(4);
            this.getScoresButton.Name = "getScoresButton";
            this.getScoresButton.Size = new System.Drawing.Size(180, 62);
            this.getScoresButton.TabIndex = 7;
            this.getScoresButton.Text = "取得成績";
            this.getScoresButton.UseVisualStyleBackColor = true;
            this.getScoresButton.Click += new System.EventHandler(this.getScoresButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.exitButton.Location = new System.Drawing.Point(682, 496);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(180, 62);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "結束";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // searchScoreLabel
            // 
            this.searchScoreLabel.AutoSize = true;
            this.searchScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.searchScoreLabel.Location = new System.Drawing.Point(344, 296);
            this.searchScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchScoreLabel.Name = "searchScoreLabel";
            this.searchScoreLabel.Size = new System.Drawing.Size(171, 40);
            this.searchScoreLabel.TabIndex = 9;
            this.searchScoreLabel.Text = "搜尋成績:";
            // 
            // searchScoreTextBox
            // 
            this.searchScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.searchScoreTextBox.Location = new System.Drawing.Point(551, 293);
            this.searchScoreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchScoreTextBox.Name = "searchScoreTextBox";
            this.searchScoreTextBox.Size = new System.Drawing.Size(125, 48);
            this.searchScoreTextBox.TabIndex = 10;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.searchButton.Location = new System.Drawing.Point(727, 285);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(180, 62);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "搜尋";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchResultLabel
            // 
            this.searchResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.searchResultLabel.Location = new System.Drawing.Point(443, 374);
            this.searchResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchResultLabel.Name = "searchResultLabel";
            this.searchResultLabel.Size = new System.Drawing.Size(322, 62);
            this.searchResultLabel.TabIndex = 12;
            this.searchResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 614);
            this.Controls.Add(this.searchResultLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchScoreTextBox);
            this.Controls.Add(this.searchScoreLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getScoresButton);
            this.Controls.Add(this.belowAverageLabel);
            this.Controls.Add(this.aboveAverageLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.belowAvgDescriptionLabel);
            this.Controls.Add(this.aboveAvgDescriptionLabel);
            this.Controls.Add(this.avgScoreDescriptionLabel);
            this.Controls.Add(this.testScoresListBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "測試成績列表";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox testScoresListBox;
        private System.Windows.Forms.Label avgScoreDescriptionLabel;
        private System.Windows.Forms.Label aboveAvgDescriptionLabel;
        private System.Windows.Forms.Label belowAvgDescriptionLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label aboveAverageLabel;
        private System.Windows.Forms.Label belowAverageLabel;
        private System.Windows.Forms.Button getScoresButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label searchScoreLabel;
        private System.Windows.Forms.TextBox searchScoreTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchResultLabel;
    }
}

