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
    public class EmpBUS
    {
        EmpDAL dal = new EmpDAL();
        public int CheckAccount(EmpDTO emp)
        {
            return dal.CheckAccount(emp);
        }

        public bool InsertEmp(EmpDTO emp)
        {
            return dal.InsertEmp(emp);
        }

        public bool UpdateEmp(EmpDTO emp)
        {
            return dal.UpdateEmp(emp);
        }

        public DataTable Display(string sql)
        {
            return dal.Display(sql);
        }
    }
}
