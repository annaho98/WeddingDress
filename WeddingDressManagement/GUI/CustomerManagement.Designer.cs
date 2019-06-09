namespace GUI
{
    partial class CustomerManagement
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
            this.txtSearchCus = new System.Windows.Forms.TextBox();
            this.btnSearchCus = new System.Windows.Forms.Button();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCPhone = new System.Windows.Forms.TextBox();
            this.txtCEmail = new System.Windows.Forms.TextBox();
            this.txtCAddress = new System.Windows.Forms.TextBox();
            this.btnAddCus = new System.Windows.Forms.Button();
            this.btnUpdateCus = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRentDress = new System.Windows.Forms.Button();
            this.btnReturnDress = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.btnShowAllCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchCus
            // 
            this.txtSearchCus.Location = new System.Drawing.Point(12, 18);
            this.txtSearchCus.Name = "txtSearchCus";
            this.txtSearchCus.Size = new System.Drawing.Size(181, 20);
            this.txtSearchCus.TabIndex = 0;
            // 
            // btnSearchCus
            // 
            this.btnSearchCus.Location = new System.Drawing.Point(221, 18);
            this.btnSearchCus.Name = "btnSearchCus";
            this.btnSearchCus.Size = new System.Drawing.Size(75, 23);
            this.btnSearchCus.TabIndex = 1;
            this.btnSearchCus.Text = "Search";
            this.btnSearchCus.UseVisualStyleBackColor = true;
            this.btnSearchCus.Click += new System.EventHandler(this.btnSearchCus_Click);
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(12, 244);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.Size = new System.Drawing.Size(712, 236);
            this.dataGridViewCustomer.TabIndex = 2;
            this.dataGridViewCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomer_CellClick);
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(106, 110);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(181, 20);
            this.txtCName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address";
            // 
            // txtCPhone
            // 
            this.txtCPhone.Location = new System.Drawing.Point(106, 154);
            this.txtCPhone.Name = "txtCPhone";
            this.txtCPhone.Size = new System.Drawing.Size(181, 20);
            this.txtCPhone.TabIndex = 8;
            // 
            // txtCEmail
            // 
            this.txtCEmail.Location = new System.Drawing.Point(450, 107);
            this.txtCEmail.Name = "txtCEmail";
            this.txtCEmail.Size = new System.Drawing.Size(181, 20);
            this.txtCEmail.TabIndex = 9;
            // 
            // txtCAddress
            // 
            this.txtCAddress.Location = new System.Drawing.Point(450, 154);
            this.txtCAddress.Name = "txtCAddress";
            this.txtCAddress.Size = new System.Drawing.Size(181, 20);
            this.txtCAddress.TabIndex = 10;
            // 
            // btnAddCus
            // 
            this.btnAddCus.Location = new System.Drawing.Point(15, 207);
            this.btnAddCus.Name = "btnAddCus";
            this.btnAddCus.Size = new System.Drawing.Size(75, 23);
            this.btnAddCus.TabIndex = 11;
            this.btnAddCus.Text = "Add";
            this.btnAddCus.UseVisualStyleBackColor = true;
            this.btnAddCus.Click += new System.EventHandler(this.btnAddCus_Click);
            // 
            // btnUpdateCus
            // 
            this.btnUpdateCus.Location = new System.Drawing.Point(143, 207);
            this.btnUpdateCus.Name = "btnUpdateCus";
            this.btnUpdateCus.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCus.TabIndex = 12;
            this.btnUpdateCus.Text = "Update";
            this.btnUpdateCus.UseVisualStyleBackColor = true;
            this.btnUpdateCus.Click += new System.EventHandler(this.btnUpdateCus_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(649, 207);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "CUSTOMER MANAGEMENT";
            // 
            // btnRentDress
            // 
            this.btnRentDress.Location = new System.Drawing.Point(274, 207);
            this.btnRentDress.Name = "btnRentDress";
            this.btnRentDress.Size = new System.Drawing.Size(75, 23);
            this.btnRentDress.TabIndex = 15;
            this.btnRentDress.Text = "Rent";
            this.btnRentDress.UseVisualStyleBackColor = true;
            this.btnRentDress.Click += new System.EventHandler(this.btnRentDress_Click);
            // 
            // btnReturnDress
            // 
            this.btnReturnDress.Location = new System.Drawing.Point(405, 207);
            this.btnReturnDress.Name = "btnReturnDress";
            this.btnReturnDress.Size = new System.Drawing.Size(75, 23);
            this.btnReturnDress.TabIndex = 16;
            this.btnReturnDress.Text = "Return";
            this.btnReturnDress.UseVisualStyleBackColor = true;
            this.btnReturnDress.Click += new System.EventHandler(this.btnReturnDress_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Customer ID";
            // 
            // txtCID
            // 
            this.txtCID.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCID.Location = new System.Drawing.Point(106, 70);
            this.txtCID.Name = "txtCID";
            this.txtCID.ReadOnly = true;
            this.txtCID.Size = new System.Drawing.Size(181, 20);
            this.txtCID.TabIndex = 21;
            // 
            // btnShowAllCustomer
            // 
            this.btnShowAllCustomer.Location = new System.Drawing.Point(528, 207);
            this.btnShowAllCustomer.Name = "btnShowAllCustomer";
            this.btnShowAllCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnShowAllCustomer.TabIndex = 20;
            this.btnShowAllCustomer.Text = "Show all";
            this.btnShowAllCustomer.UseVisualStyleBackColor = true;
            this.btnShowAllCustomer.Click += new System.EventHandler(this.btnShowAllCustomer_Click);
            // 
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 492);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCID);
            this.Controls.Add(this.btnShowAllCustomer);
            this.Controls.Add(this.btnReturnDress);
            this.Controls.Add(this.btnRentDress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdateCus);
            this.Controls.Add(this.btnAddCus);
            this.Controls.Add(this.txtCAddress);
            this.Controls.Add(this.txtCEmail);
            this.Controls.Add(this.txtCPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.dataGridViewCustomer);
            this.Controls.Add(this.btnSearchCus);
            this.Controls.Add(this.txtSearchCus);
            this.Name = "CustomerManagement";
            this.Text = "CustomerManagement";
            this.Load += new System.EventHandler(this.CustomerManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchCus;
        private System.Windows.Forms.Button btnSearchCus;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCPhone;
        private System.Windows.Forms.TextBox txtCEmail;
        private System.Windows.Forms.TextBox txtCAddress;
        private System.Windows.Forms.Button btnAddCus;
        private System.Windows.Forms.Button btnUpdateCus;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRentDress;
        private System.Windows.Forms.Button btnReturnDress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.Button btnShowAllCustomer;
    }
}