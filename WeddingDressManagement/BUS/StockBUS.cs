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
    public class StockBUS
    {
        StockDAL stockDAL = new StockDAL();
        public DataTable Import(StockDTO stockDTO)
        {
            return stockDAL.Import(stockDTO);
        }
    }
}
