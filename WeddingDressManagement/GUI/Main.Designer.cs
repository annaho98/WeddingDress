namespace GUI
{
    partial class Main
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
            this.btnCusManage = new System.Windows.Forms.Button();
            this.btnStockManage = new System.Windows.Forms.Button();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCusManage
            // 
            this.btnCusManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCusManage.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusManage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCusManage.Location = new System.Drawing.Point(506, 61);
            this.btnCusManage.Name = "btnCusManage";
            this.btnCusManage.Size = new System.Drawing.Size(204, 46);
            this.btnCusManage.TabIndex = 0;
            this.btnCusManage.Text = "Customer Management";
            this.btnCusManage.UseVisualStyleBackColor = false;
            this.btnCusManage.Click += new System.EventHandler(this.btnCusManage_Click);
            // 
            // btnStockManage
            // 
            this.btnStockManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStockManage.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockManage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStockManage.Location = new System.Drawing.Point(506, 165);
            this.btnStockManage.Name = "btnStockManage";
            this.btnStockManage.Size = new System.Drawing.Size(204, 46);
            this.btnStockManage.TabIndex = 1;
            this.btnStockManage.Text = "Stock Management";
            this.btnStockManage.UseVisualStyleBackColor = false;
            this.btnStockManage.Click += new System.EventHandler(this.btnStockManage_Click);
            // 
            // btnViewReport
            // 
            this.btnViewReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnViewReport.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnViewReport.Location = new System.Drawing.Point(506, 272);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(204, 46);
            this.btnViewReport.TabIndex = 2;
            this.btnViewReport.Text = "View Report";
            this.btnViewReport.UseVisualStyleBackColor = false;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewReport);
            this.Controls.Add(this.btnStockManage);
            this.Controls.Add(this.btnCusManage);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCusManage;
        private System.Windows.Forms.Button btnStockManage;
        private System.Windows.Forms.Button btnViewReport;
    }
}