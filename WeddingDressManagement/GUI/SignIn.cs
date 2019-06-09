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
using DAL;
using DTO;
using System.Threading;

namespace GUI
{
    public partial class SignIn : Form
    {
        EmpBUS bus = new EmpBUS();
        Thread th;
        public SignIn()
        {
            InitializeComponent();
        }

        private void butnSignIn_Click(object sender, EventArgs e)
        {
            if (textUserName.Text == "")
            {
                MessageBox.Show("Please enter username");
            }
            else if (textPassword.Text == "")
            {
                MessageBox.Show("Please enter password");
            }
            else
            {
                int EmpID = Convert.ToInt32(textUserName.Text);
                EmpDTO emp = new EmpDTO(EmpID, textPassword.Text);
                if (bus.CheckAccount(emp) == 1)
                {
                    this.Close();
                    th = new Thread(openNextForm);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else if (bus.CheckAccount(emp) == 2)
                {
                    this.Close();
                    th = new Thread(openAdminForm);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    MessageBox.Show("Wrong password or username");
                }
            }
        }

        private void openNextForm(object obj)
        {
            Application.Run(new Main());
        }

        private void openAdminForm(object obj)
        {
            Application.Run(new AdminMain());
        }

        private void SignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
