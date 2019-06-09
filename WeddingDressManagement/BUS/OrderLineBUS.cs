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

        public int GetDressID(string dressName)
        {
            return dal.GetDressID(dressName);
        }

        public void ReduceStockQuant(int dressID)
        {
            dal.ReduceStockQuant(dressID);
        }

        public DataTable InsertOrderLine(DressDTO dress)
        {
            return dal.InsertOrderLine(dress);
        }
    }
}
