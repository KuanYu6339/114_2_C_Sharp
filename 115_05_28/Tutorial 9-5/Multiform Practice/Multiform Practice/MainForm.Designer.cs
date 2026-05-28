namespace Multiform_Practice
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.displayFormButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayFormButton
            // 
            // 顯示表單按鈕 - 用於開啟新的表單視窗
            this.displayFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.displayFormButton.Location = new System.Drawing.Point(30, 30);
            this.displayFormButton.Name = "displayFormButton";
            this.displayFormButton.Size = new System.Drawing.Size(200, 60);
            this.displayFormButton.TabIndex = 0;
            this.displayFormButton.Text = "顯示表單";
            this.displayFormButton.UseVisualStyleBackColor = true;
            this.displayFormButton.Click += new System.EventHandler(this.displayFormButton_Click);
            // 
            // exitButton
            // 
            // 結束按鈕 - 用於關閉應用程式
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.exitButton.Location = new System.Drawing.Point(30, 110);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(200, 60);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "結束";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            // 主表單 - 應用程式的主視窗
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 200);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayFormButton);
            this.Name = "MainForm";
            this.Text = "多表單練習";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button displayFormButton;
        private System.Windows.Forms.Button exitButton;
    }
}

