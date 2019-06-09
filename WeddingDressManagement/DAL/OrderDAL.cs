using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class OrderDAL:DBconnection
    {
        public void InsertOrder (OrderDTO orderDTO)
        {
            con.Open();
            string SQL = string.Format("Insert into OrderLine values ('{0}','{1}',SYSDATE())",
                orderDTO.OrdCusID, orderDTO.OrdEmpID);
            SqlCommand cmd = new SqlCommand(SQL, con);
            int o = cmd.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateOrder(int dressID)
        {
            con.Open();
            string SQL = string.Format("Update dress set DressID = '{0}',",
                orderDTO.OrdCusID, orderDTO.OrdEmpID);
            SqlCommand cmd = new SqlCommand(SQL, con);
            int o = cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
