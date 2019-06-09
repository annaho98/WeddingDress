namespace GUI
{
    partial class Rent
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxDressName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rentQuant = new System.Windows.Forms.NumericUpDown();
            this.GridViewOrdLine = new System.Windows.Forms.DataGridView();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnOkOrder = new System.Windows.Forms.Button();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rentQuant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewOrdLine)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(139, 14);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.ReadOnly = true;
            this.txtEmpID.Size = new System.Drawing.Size(188, 20);
            this.txtEmpID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer ID";
            // 
            // txtCID
            // 
            this.txtCID.Location = new System.Drawing.Point(456, 14);
            this.txtCID.Name = "txtCID";
            this.txtCID.ReadOnly = true;
            this.txtCID.Size = new System.Drawing.Size(187, 20);
            this.txtCID.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dress Name";
            // 
            // cbxDressName
            // 
            this.cbxDressName.FormattingEnabled = true;
            this.cbxDressName.Location = new System.Drawing.Point(139, 107);
            this.cbxDressName.Name = "cbxDressName";
            this.cbxDressName.Size = new System.Drawing.Size(188, 21);
            this.cbxDressName.TabIndex = 8;
            this.cbxDressName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbxDressName_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantity";
            // 
            // rentQuant
            // 
            this.rentQuant.Location = new System.Drawing.Point(456, 108);
            this.rentQuant.Name = "rentQuant";
            this.rentQuant.Size = new System.Drawing.Size(187, 20);
            this.rentQuant.TabIndex = 10;
            this.rentQuant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GridViewOrdLine
            // 
            this.GridViewOrdLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewOrdLine.Location = new System.Drawing.Point(12, 215);
            this.GridViewOrdLine.Name = "GridViewOrdLine";
            this.GridViewOrdLine.Size = new System.Drawing.Size(764, 244);
            this.GridViewOrdLine.TabIndex = 11;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(12, 172);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(75, 23);
            this.btnAddOrder.TabIndex = 12;
            this.btnAddOrder.Text = "Add";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Location = new System.Drawing.Point(169, 172);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateOrder.TabIndex = 13;
            this.btnUpdateOrder.Text = "Update";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Location = new System.Drawing.Point(325, 172);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteOrder.TabIndex = 14;
            this.btnDeleteOrder.Text = "Delete";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(660, 172);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnOkOrder
            // 
            this.btnOkOrder.Location = new System.Drawing.Point(496, 172);
            this.btnOkOrder.Name = "btnOkOrder";
            this.btnOkOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOkOrder.TabIndex = 16;
            this.btnOkOrder.Text = "OK";
            this.btnOkOrder.UseVisualStyleBackColor = true;
            this.btnOkOrder.Click += new System.EventHandler(this.btnOkOrder_Click);
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(140, 62);
            this.txtCName.Name = "txtCName";
            this.txtCName.ReadOnly = true;
            this.txtCName.Size = new System.Drawing.Size(187, 20);
            this.txtCName.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Customer Name";
            // 
            // Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 471);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOkOrder);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.GridViewOrdLine);
            this.Controls.Add(this.rentQuant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxDressName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.label1);
            this.Name = "Rent";
            this.Text = "Rent";
            this.Load += new System.EventHandler(this.Rent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentQuant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewOrdLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxDressName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown rentQuant;
        private System.Windows.Forms.DataGridView GridViewOrdLine;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnOkOrder;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.Label label5;
    }
}