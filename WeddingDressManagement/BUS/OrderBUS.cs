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
    public class OrderBUS
    {
        OrderDAL dal = new OrderDAL();
        public void InsertOrder(OrderDTO orderDTO)
        {
            dal.InsertOrder(orderDTO);
        }
    }
}
