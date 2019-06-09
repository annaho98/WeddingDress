using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class DressBUS
    {
        DressDAL dal = new DressDAL();
        public DataTable InsertDress(DressDTO dress)
        {
            return dal.InsertDress(dress);
        }

        public bool UpdateDress(DressDTO dress)
        {
            return dal.UpdateDress(dress);
        }

        public DataTable ShowAllDress()
        {
            return dal.ShowAllDress();
        }

        public DataTable Display(string sql)
        {
            return dal.Display(sql);
        }
    }
}
