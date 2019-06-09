namespace GUI
{
    partial class DressManagement
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdateDress = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.txtPriceDress = new System.Windows.Forms.TextBox();
            this.txtDressDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDressName = new System.Windows.Forms.TextBox();
            this.GridViewDress = new System.Windows.Forms.DataGridView();
            this.btnSearchDress = new System.Windows.Forms.Button();
            this.txtSearchDress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDressID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "DRESS MANAGEMENT";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(598, 206);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdateDress
            // 
            this.btnUpdateDress.Location = new System.Drawing.Point(225, 206);
            this.btnUpdateDress.Name = "btnUpdateDress";
            this.btnUpdateDress.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateDress.TabIndex = 27;
            this.btnUpdateDress.Text = "Update";
            this.btnUpdateDress.UseVisualStyleBackColor = true;
            this.btnUpdateDress.Click += new System.EventHandler(this.btnUpdateDress_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(28, 206);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 26;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // txtPriceDress
            // 
            this.txtPriceDress.Location = new System.Drawing.Point(116, 148);
            this.txtPriceDress.Name = "txtPriceDress";
            this.txtPriceDress.Size = new System.Drawing.Size(184, 20);
            this.txtPriceDress.TabIndex = 24;
            // 
            // txtDressDesc
            // 
            this.txtDressDesc.Location = new System.Drawing.Point(499, 104);
            this.txtDressDesc.Multiline = true;
            this.txtDressDesc.Name = "txtDressDesc";
            this.txtDressDesc.Size = new System.Drawing.Size(199, 23);
            this.txtDressDesc.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Dress Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Dress Name";
            // 
            // txtDressName
            // 
            this.txtDressName.Location = new System.Drawing.Point(119, 107);
            this.txtDressName.Name = "txtDressName";
            this.txtDressName.Size = new System.Drawing.Size(181, 20);
            this.txtDressName.TabIndex = 18;
            // 
            // GridViewDress
            // 
            this.GridViewDress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDress.Location = new System.Drawing.Point(12, 235);
            this.GridViewDress.Name = "GridViewDress";
            this.GridViewDress.Size = new System.Drawing.Size(712, 236);
            this.GridViewDress.TabIndex = 17;
            this.GridViewDress.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridViewDress_CellMouseDoubleClick);
            // 
            // btnSearchDress
            // 
            this.btnSearchDress.Location = new System.Drawing.Point(261, 25);
            this.btnSearchDress.Name = "btnSearchDress";
            this.btnSearchDress.Size = new System.Drawing.Size(75, 23);
            this.btnSearchDress.TabIndex = 16;
            this.btnSearchDress.Text = "Search";
            this.btnSearchDress.UseVisualStyleBackColor = true;
            this.btnSearchDress.Click += new System.EventHandler(this.btnSearchDress_Click);
            // 
            // txtSearchDress
            // 
            this.txtSearchDress.Location = new System.Drawing.Point(28, 25);
            this.txtSearchDress.Name = "txtSearchDress";
            this.txtSearchDress.Size = new System.Drawing.Size(206, 20);
            this.txtSearchDress.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Quantity";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(499, 149);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(199, 20);
            this.quantity.TabIndex = 31;
            this.quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(403, 206);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 23);
            this.btnShowAll.TabIndex = 32;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Dress ID";
            // 
            // txtDressID
            // 
            this.txtDressID.Cursor = System.Windows.Forms.Cursors.No;
            this.txtDressID.Location = new System.Drawing.Point(119, 69);
            this.txtDressID.Name = "txtDressID";
            this.txtDressID.ReadOnly = true;
            this.txtDressID.Size = new System.Drawing.Size(181, 20);
            this.txtDressID.TabIndex = 33;
            // 
            // DressManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 483);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDressID);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdateDress);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtPriceDress);
            this.Controls.Add(this.txtDressDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDressName);
            this.Controls.Add(this.GridViewDress);
            this.Controls.Add(this.btnSearchDress);
            this.Controls.Add(this.txtSearchDress);
            this.Name = "DressManagement";
            this.Text = "DressManagement";
            this.Load += new System.EventHandler(this.DressManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdateDress;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox txtPriceDress;
        private System.Windows.Forms.TextBox txtDressDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDressName;
        private System.Windows.Forms.DataGridView GridViewDress;
        private System.Windows.Forms.Button btnSearchDress;
        private System.Windows.Forms.TextBox txtSearchDress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDressID;
    }
}