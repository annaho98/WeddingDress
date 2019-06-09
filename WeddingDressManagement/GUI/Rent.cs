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
        OrderLineBUS OrdLine_BUS;
        OrderBUS orderBUS;
        DressBUS dressBUS;
        public Rent()
        {
            InitializeComponent();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            int dressID = dressBUS.GetDressID(cbxDressName.Text);
            if (rentQuant.Value < OrdLine_BUS.GetStockQuant(dressID))
            {
                MessageBox.Show("Not enough dress");
            }
            else
            {
                int dressQuant = Convert.ToInt32(rentQuant.Value);
                DressDTO dressDTO = new DressDTO(dressID, cbxDressName.Text);
                int eID = Convert.ToInt32(txtEmpID.Text);
                int cusID = Convert.ToInt32(txtCID.Text);
                OrderDTO orderDTO = new OrderDTO(eID, cusID);

                OrdLine_BUS.ReduceStockQuant(dressID);

                orderBUS.InsertOrder(orderDTO);

                OrdLine_BUS.InsertOrderLine(dressID,dressQuant);
            }
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            int dressID = dressBUS.GetDressID(cbxDressName.Text);
            int quant = Convert.ToInt32(rentQuant.Value);
            OrdLine_BUS.UpdateOrderLine(dressID, quant);
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

        private void Rent_Load(object sender, EventArgs e)
        {
            DataTable tblOrdLine = new DataTable();
            tblOrdLine = OrdLine_BUS.Display(" select OrderLine.OrderID, dress.DressName, dress.Price," +
                                            " OrderLine.Quantity, OrderLine.[Sum] from OrderLine " +
                                            "join dress on OrderLine.DressID = dress.DressID");

            GridViewOrdLine.DataSource = tblOrdLine;
            GridViewOrdLine.AllowUserToAddRows = false;
            if (tblOrdLine.Rows.Count == 0)
            {
                MessageBox.Show("Don't have any employees in the table!");
            }
            else
            {
                cbxDressName.SelectedItem = GridViewOrdLine.CurrentRow.Cells["EmployeeID"].Value.ToString();
                
            }
        }
    }
}
