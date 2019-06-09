using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using BUS;
using DTO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class CustomerManagement : Form
    {
        CustomerBUS customer_bus = new CustomerBUS();
        Thread th;
        public CustomerManagement()
        {
            InitializeComponent();
        }

        private void btnRentDress_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openRentForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openRentForm(object obj)
        {
            Application.Run(new Rent());
        }

        private void btnAddCus_Click(object sender, EventArgs e)
        {
            if (txtCName.Text != "" && txtCPhone.Text != "" && txtCEmail.Text != "" && txtCAddress.Text != "")
            {
                CustomerDTO customer_DTO = new CustomerDTO(txtCName.Text, txtCPhone.Text, txtCEmail.Text, txtCAddress.Text);
                if (customer_bus.InsertCustomer(customer_DTO))
                {

                    MessageBox.Show("Adding success");
                }
                else
                    MessageBox.Show("Adding fail");
            }
            else
            {
                MessageBox.Show("Please fill required data");
            }
            CustomerManagement_Load(sender, e);
            ClearData();
        }

        private void btnUpdateCus_Click(object sender, EventArgs e)
        {
            if (txtCName.Text != "" && txtCPhone.Text != "" && txtCEmail.Text != "" && txtCAddress.Text != "")
            {
                int CustomerID = Convert.ToInt32(txtCID.Text);
                string CutomerName = txtCName.Text;
                string PhoneNumber = txtCPhone.Text;
                string Email = txtCEmail.Text;
                string Address = txtCAddress.Text;

                //CustomerDTO customer_DTO = new CustomerDTO(txtCName.Text, txtCPhone.Text, txtCEmail.Text, txtCAddress.Text);

                if (customer_bus.UpdateCustomer(CustomerID, CutomerName, PhoneNumber, Email, Address))
                {
                    MessageBox.Show("Editing success");
                    CustomerManagement_Load(sender, e);
                    ClearData();
                }
                else
                    MessageBox.Show("Editing fail");
            }
            else
            {
                MessageBox.Show("Please fill required data");
            }
        }

        private void btnReturnDress_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openMainForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openMainForm(object obj)
        {
            Application.Run(new Main());
        }

        private void ClearData()
        {
            txtCName.Text = "";
            txtCPhone.Text = "";
            txtCID.Text = "";
            txtCEmail.Text = "";
            txtCAddress.Text = "";
        }

        private void btnSearchCus_Click(object sender, EventArgs e)
        {
            DataTable tblCustomer = new DataTable();
            tblCustomer = customer_bus.Display("Select * from Customer where CustomerName like +'%" + txtSearchCus.Text + "%'");
            dataGridViewCustomer.DataSource = tblCustomer;
        }

        private void btnShowAllCustomer_Click(object sender, EventArgs e)
        {
            DataTable tblCustomer = new DataTable();
            tblCustomer = customer_bus.Display("Select *from Customer");
            dataGridViewCustomer.DataSource = tblCustomer;
        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            DataTable tblCustomer = new DataTable();
            tblCustomer = customer_bus.Display("Select *from  Customer");
            dataGridViewCustomer.DataSource = tblCustomer;
            dataGridViewCustomer.AllowUserToAddRows = false;

            if (tblCustomer.Rows.Count == 0)
            {
                MessageBox.Show("There are no customers in list");
            }
            else
            {
                txtCID.Text = dataGridViewCustomer.CurrentRow.Cells["CustomerID"].Value.ToString();
                txtCName.Text = dataGridViewCustomer.CurrentRow.Cells["CustomerName"].Value.ToString();
                txtCPhone.Text = dataGridViewCustomer.CurrentRow.Cells["PhoneNumber"].Value.ToString();
                txtCEmail.Text = dataGridViewCustomer.CurrentRow.Cells["Email"].Value.ToString();
                txtCAddress.Text = dataGridViewCustomer.CurrentRow.Cells["Address"].Value.ToString();
            }
        }

        private void dataGridViewCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCustomer.Rows.Count == 0)
            {

            }
            else
            {
                txtCID.Text = dataGridViewCustomer.CurrentRow.Cells["CustomerID"].Value.ToString();
                txtCName.Text = dataGridViewCustomer.CurrentRow.Cells["CustomerName"].Value.ToString();
                txtCPhone.Text = dataGridViewCustomer.CurrentRow.Cells["PhoneNumber"].Value.ToString();
                txtCEmail.Text = dataGridViewCustomer.CurrentRow.Cells["Email"].Value.ToString();
                txtCAddress.Text = dataGridViewCustomer.CurrentRow.Cells["Address"].Value.ToString();
            }
        }
    }
}
