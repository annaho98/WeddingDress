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
    public class OrderLineDAL:DBconnection
    {
        public int GetStockQuant(int dressID)
        {
            int stockQuant;
            con.Open();
            string SQL = string.Format("Select DressQuant from Stock where DressID = '{0}'", dressID);
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            stockQuant = Convert.ToInt32(rd["DressQuant"].ToString());
            con.Close();
            return stockQuant;
        }

        public DataTable InsertOrderLine(int dressID, int dressQuant)
        {
            DataTable dtOrderLine = new DataTable();
            con.Open();
            string SQL = string.Format("Insert into OrderLine values ('{0}','{1}')",
                 dressID, dressQuant);
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            adt.Fill(dtOrderLine);
            con.Close();
            return dtOrderLine;
        }
                
        public void ReduceStockQuant(int dressID)
        {
            con.Open();
            string SQL = string.Format("update Stock set DressQuant = DressQuant - 1 where DressID = '{0}'", 
                dressID);
            SqlCommand cmd = new SqlCommand(SQL, con);
            int obj = cmd.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateOrderLine(int dressID, int dressQuant)
        {
            con.Open();
            string SQL = string.Format("update dress set DressID ='{0}', Quantity = '{1}'", 
                dressID, dressQuant);
            SqlCommand cmd = new SqlCommand(SQL, con);
            int obj = cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable Display(string sql)
        {
            DataTable tblOrdLine = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblOrdLine);  //Fill vào một biến kiểu Datatable
                return tblOrdLine;
            }

            catch (Exception e) { }

            finally
            { con.Close(); }

            return null;
        }
    }
}
