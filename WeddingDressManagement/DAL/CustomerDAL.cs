using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class CustomerDAL : DBconnection
    {
        public bool InsertCustomer(CustomerDTO Customer)
        {
            try
            {
                con.Open();
                string SQL = string.Format("Insert into Customer values ('{0}','{1}','{2}','{3}')",
                     Customer.CustomerName, Customer.PhoneNumber, Customer.Email, Customer.Address);

                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            { }

            finally
            {
                con.Close();
            }

            return false;

        }


        public bool UpdateCustomer(int CustomerID, string CustomerName, string PhoneNumber, string Email, string Address)
        {
            try
            {
                con.Open();
                string SQL = string.Format("Update Customer set CustomerName='{0}', PhoneNumber='{1}', Email='{2}', [Address]='{3}' where CustomerID ='{4}'",
                  CustomerName, PhoneNumber, Email, Address, CustomerID);
                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            { }

            finally
            {
                con.Close();
            }

            return false;
        }

        public DataTable Display(string sql)
        {
            DataTable tblCustomer = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblCustomer);  //Fill vào một biến kiểu Datatable
                return tblCustomer;
            }

            catch (Exception e) { }

            finally
            { con.Close(); }

            return null;
        }
    }
}
