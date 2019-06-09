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
    public class OrderLineBUS
    {
        OrderLineDAL dal = new OrderLineDAL();
        public int GetStockQuant (int dressID)
        {
            return dal.GetStockQuant(dressID);
        }
                
        public void ReduceStockQuant(int dressID)
        {
            dal.ReduceStockQuant(dressID);
        }

        public DataTable InsertOrderLine(int dressID, int dressQuant)
        {
            return dal.InsertOrderLine(dressID,dressQuant);
        }

        public void UpdateOrderLine(int dressID, int dressQuant)
        {
            dal.UpdateOrderLine(dressID, dressQuant);
        }

        public DataTable Display(string sql)
        {
            return dal.Display(sql);
        }
    }
}
