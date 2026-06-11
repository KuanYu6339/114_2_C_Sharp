namespace EmployeeRoster
{
    partial class QueryEmployeeForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblIdResult = new System.Windows.Forms.Label();
            this.lblNameResult = new System.Windows.Forms.Label();
            this.lblDeptResult = new System.Windows.Forms.Label();
            this.lblPositionResult = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(30, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(59, 15);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "員工編號";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(120, 27);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(130, 23);
            this.txtId.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(260, 25);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(60, 27);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查詢";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lblIdResult
            // 
            this.lblIdResult.AutoSize = true;
            this.lblIdResult.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdResult.Location = new System.Drawing.Point(30, 80);
            this.lblIdResult.Name = "lblIdResult";
            this.lblIdResult.Size = new System.Drawing.Size(67, 19);
            this.lblIdResult.TabIndex = 3;
            this.lblIdResult.Text = "員工編號：";
            // 
            // lblNameResult
            // 
            this.lblNameResult.AutoSize = true;
            this.lblNameResult.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameResult.Location = new System.Drawing.Point(30, 115);
            this.lblNameResult.Name = "lblNameResult";
            this.lblNameResult.Size = new System.Drawing.Size(43, 19);
            this.lblNameResult.TabIndex = 4;
            this.lblNameResult.Text = "姓名：";
            // 
            // lblDeptResult
            // 
            this.lblDeptResult.AutoSize = true;
            this.lblDeptResult.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDeptResult.Location = new System.Drawing.Point(30, 150);
            this.lblDeptResult.Name = "lblDeptResult";
            this.lblDeptResult.Size = new System.Drawing.Size(43, 19);
            this.lblDeptResult.TabIndex = 5;
            this.lblDeptResult.Text = "部門：";
            // 
            // lblPositionResult
            // 
            this.lblPositionResult.AutoSize = true;
            this.lblPositionResult.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPositionResult.Location = new System.Drawing.Point(30, 185);
            this.lblPositionResult.Name = "lblPositionResult";
            this.lblPositionResult.Size = new System.Drawing.Size(43, 19);
            this.lblPositionResult.TabIndex = 6;
            this.lblPositionResult.Text = "職位：";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(135, 230);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 35);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // QueryEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 280);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.lblIdResult);
            this.Controls.Add(this.lblNameResult);
            this.Controls.Add(this.lblDeptResult);
            this.Controls.Add(this.lblPositionResult);
            this.Controls.Add(this.btnExit);
            this.MaximizeBox = false;
            this.Name = "QueryEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "查詢員工";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label lblIdResult;
        private System.Windows.Forms.Label lblNameResult;
        private System.Windows.Forms.Label lblDeptResult;
        private System.Windows.Forms.Label lblPositionResult;
        private System.Windows.Forms.Button btnExit;
    }
}
