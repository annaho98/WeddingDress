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
    public class StockDAL : DBconnection
    {
        public DataTable Import(StockDTO stockDTO)
        {
            DataTable dtStock = new DataTable();
            con.Open();
            string GetDrID = string.Format("SELECT MAX(DressID) AS DressID from dress");
            SqlCommand GetIDcomd = new SqlCommand(GetDrID, con);
            SqlDataReader rd = GetIDcomd.ExecuteReader();
            rd.Read();
            int DrID = Convert.ToInt32(rd["DressID"].ToString());
        
            string SQL = string.Format("Insert into Stock values ({0},{1},SYSDATETIME())",
                DrID, stockDTO.DressQuant);
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL, con);

            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            adt.Fill(dtStock);

            con.Close();
            return dtStock;

        }
    }
}
