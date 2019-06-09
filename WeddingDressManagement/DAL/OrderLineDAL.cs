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

        public DataTable InsertOrderLine(DressDTO dress)
        {
            DataTable dtOrderLine = new DataTable();
            con.Open();
            string SQL = string.Format("Insert into OrderLine values ('{0}','{1}','{2}')",
                 dress.DressName, dress.DressDecription, dress.DressPrice);
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            adt.Fill(dtOrderLine);
            con.Close();
            return dtOrderLine;
        }

        public int GetDressID (string dressName)
        {
            int dressID;
            con.Open();
            string SQL = string.Format("select DressID from dress where DressName = '{0}'", dressName);
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            dressID = Convert.ToInt32(rd.["DressID"].ToString());
            con.Close();
            return dressID;
        }

        public void ReduceStockQuant(int dressID)
        {
            con.Open();
            string SQL = string.Format("update Stock set DressQuant = DressQuant - 1 where DressID = '{0}'", dressID);
            SqlCommand cmd = new SqlCommand(SQL, con);
            int obj = cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
