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
    public partial class Main : Form
    {
        Thread th;
        
        private void openCusForm(object obj)
        {
            Application.Run(new CustomerManagement());
        }
        public Main()
        {
            InitializeComponent();
        }

        private void openDressManagement(object obj)
        {
            Application.Run(new DressManagement());
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
    }
}
