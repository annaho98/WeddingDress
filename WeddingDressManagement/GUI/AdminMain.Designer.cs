namespace GUI
{
    partial class AdminMain
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
            this.btnViewReport = new System.Windows.Forms.Button();
            this.btnStockManage = new System.Windows.Forms.Button();
            this.btnCusManage = new System.Windows.Forms.Button();
            this.btnEmpManage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewReport
            // 
            this.btnViewReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnViewReport.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnViewReport.Location = new System.Drawing.Point(496, 258);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(204, 46);
            this.btnViewReport.TabIndex = 5;
            this.btnViewReport.Text = "View Report";
            this.btnViewReport.UseVisualStyleBackColor = false;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // btnStockManage
            // 
            this.btnStockManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStockManage.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockManage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStockManage.Location = new System.Drawing.Point(496, 151);
            this.btnStockManage.Name = "btnStockManage";
            this.btnStockManage.Size = new System.Drawing.Size(204, 46);
            this.btnStockManage.TabIndex = 4;
            this.btnStockManage.Text = "Stock Management";
            this.btnStockManage.UseVisualStyleBackColor = false;
            this.btnStockManage.Click += new System.EventHandler(this.btnStockManage_Click);
            // 
            // btnCusManage
            // 
            this.btnCusManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCusManage.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusManage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCusManage.Location = new System.Drawing.Point(496, 47);
            this.btnCusManage.Name = "btnCusManage";
            this.btnCusManage.Size = new System.Drawing.Size(204, 46);
            this.btnCusManage.TabIndex = 3;
            this.btnCusManage.Text = "Customer Management";
            this.btnCusManage.UseVisualStyleBackColor = false;
            this.btnCusManage.Click += new System.EventHandler(this.btnCusManage_Click);
            // 
            // btnEmpManage
            // 
            this.btnEmpManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEmpManage.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpManage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEmpManage.Location = new System.Drawing.Point(496, 360);
            this.btnEmpManage.Name = "btnEmpManage";
            this.btnEmpManage.Size = new System.Drawing.Size(204, 61);
            this.btnEmpManage.TabIndex = 6;
            this.btnEmpManage.Text = "Employee Management";
            this.btnEmpManage.UseVisualStyleBackColor = false;
            this.btnEmpManage.Click += new System.EventHandler(this.btnEmpManage_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 460);
            this.Controls.Add(this.btnEmpManage);
            this.Controls.Add(this.btnViewReport);
            this.Controls.Add(this.btnStockManage);
            this.Controls.Add(this.btnCusManage);
            this.Name = "AdminMain";
            this.Text = "AdminMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.Button btnStockManage;
        private System.Windows.Forms.Button btnCusManage;
        private System.Windows.Forms.Button btnEmpManage;
    }
}