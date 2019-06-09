using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CustomerBUS
    {
        CustomerDAL dal = new CustomerDAL();
        public bool InsertCustomer(CustomerDTO Customer)
        {
            return dal.InsertCustomer(Customer);
        }

        public bool UpdateCustomer(int CustomerID, string CustomerName, string PhoneNumber, string Email, string Address)
        {
            return dal.UpdateCustomer(CustomerID, CustomerName, PhoneNumber, Email, Address);
        }

        public DataTable Display(string sql)
        {
            return dal.Display(sql);
        }
    }
}
