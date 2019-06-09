using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DAL
{
    public class DBconnection
    {
        protected SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-J08O5A1J\SQLEXPRESS;Initial Catalog=RentDressManagement;Integrated Security=True");
    }
}
