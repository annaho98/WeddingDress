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
    public partial class DressManagement : Form
    {
        Thread th;
        DressBUS dressBUS = new DressBUS();
        StockBUS stockBUS = new StockBUS();
        public DressManagement()
        {
            InitializeComponent();
        }

        private void openMainForm(object obj)
        {
            Application.Run(new Main());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openMainForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            DressDTO dressDTO = new DressDTO(txtDressName.Text, txtDressDesc.Text, int.Parse(txtPriceDress.Text));
            StockDTO stockDTO = new StockDTO(Convert.ToInt32(quantity.Value));
            dressBUS.InsertDress(dressDTO);
            stockBUS.Import(stockDTO);
            DressManagement_Load(sender, e);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = dressBUS.ShowAllDress();
            GridViewDress.DataSource = dt;
        }

        private void btnUpdateDress_Click(object sender, EventArgs e)
        {
            if (txtDressName.Text != "" && txtPriceDress.Text != "" && txtDressDesc.Text != "" )
            { 
                int DressID = Convert.ToInt32(txtDressID.Text);
                string DressName = txtDressName.Text;
                string DressDesc = txtDressDesc.Text;
                int Price = Convert.ToInt32(txtPriceDress.Text);

                DressDTO dressDTO = new DressDTO(DressName, DressDesc, Price, DressID);

                if (dressBUS.UpdateDress(dressDTO))
                {
                    MessageBox.Show("Editing success");
                    DressManagement_Load(sender, e);
                }
                else
                    MessageBox.Show("Editing fail");
            }
            else
            {
                MessageBox.Show("Please fill required data");
            }
        }

        private void GridViewDress_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtDressID.Text = GridViewDress.CurrentRow.Cells["DressID"].Value.ToString();
            txtDressName.Text = GridViewDress.CurrentRow.Cells["DressName"].Value.ToString();
            txtDressDesc.Text = GridViewDress.CurrentRow.Cells["DressDecription"].Value.ToString();
            txtPriceDress.Text = GridViewDress.CurrentRow.Cells["Price"].Value.ToString();
            string quant = GridViewDress.CurrentRow.Cells["DressQuant"].Value.ToString();
            quantity.Value = Convert.ToInt32(quant);
        }

        private void DressManagement_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = dressBUS.ShowAllDress();
            GridViewDress.DataSource = dt;
        }

        private void btnSearchDress_Click(object sender, EventArgs e)
        {
            DataTable tblDress = new DataTable();
            tblDress = dressBUS.Display("select dress.DressID, dress.DressName, dress.DressDecription, dress.Price, Stock.DressQuant from Stock join dress on Stock.DressID = dress.DressID where dress.DressName like '%" + txtSearchDress.Text + "%'");
            GridViewDress.DataSource = tblDress;
        }
    }
}
