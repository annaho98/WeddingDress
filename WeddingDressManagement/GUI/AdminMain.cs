using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.Threading;

namespace GUI
{
    public partial class AdminMain : Form
    {
        Thread th;
        public AdminMain()
        {
            InitializeComponent();
        }

        private void btnEmpManage_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openEmpManagement);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnCusManage_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openCusForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnStockManage_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openDressManagement);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {

        }

        private void openCusForm(object obj)
        {
            Application.Run(new CustomerManagement());
        }

        private void openDressManagement(object obj)
        {
            Application.Run(new DressManagement());
        }

        private void openEmpManagement(object obj)
        {
            Application.Run(new EmployeeManagement());
        }
    }
}
