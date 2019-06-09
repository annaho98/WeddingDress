using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using BUS;
using DAL;
using DTO;


namespace GUI
{
    public partial class Rent : Form
    {
        Thread th;
        OrderLineBUS bus;
        public Rent()
        {
            InitializeComponent();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            int dressID = bus.GetDressID(cbxDressName.Text);
            if (rentQuant.Value < bus.GetStockQuant(dressID))
            {
                MessageBox.Show("Not enough dress");
            }
            else
            {
                DressDTO dressDTO = new DressDTO(dressID, cbxDressName.Text);
                bus.ReduceStockQuant(dressID);
                bus.InsertOrderLine(dressDTO);
            }
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnOkOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openCusForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openCusForm(object obj)
        {
            Application.Run(new CustomerManagement());
        }

        private void cbxDressName_MouseClick(object sender, MouseEventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-J08O5A1J\SQLEXPRESS;Initial Catalog=RentDressManagement;Integrated Security=True"))
            {
                connect.Open();
                SqlCommand comd = new SqlCommand("SELECT DISTINCT DressName FROM dress", connect);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    string DName = dr["DressName"].ToString();
                    if (!cbxDressName.Items.Contains(DName))
                        cbxDressName.Items.Add(DName);
                }
                connect.Close();
            }
        }
    }
}
