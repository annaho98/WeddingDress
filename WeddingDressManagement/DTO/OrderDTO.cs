using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderDTO
    {
        private int _OrdID;
        private int _OrdCusID;
        private int _OrdTotal;
        private int _OrdEmpID;
        private DateTime _OrdDate;

        public int OrdID
        {
            get
            {
                return _OrdID;
            }
            set
            {
                _OrdID = value;
            }
        }

        public int OrdCusID
        {
            get
            {
                return _OrdCusID;
            }
            set
            {
                _OrdCusID = value;
            }
        }

        public int OrdTotal
        {
            get
            {
                return _OrdTotal;
            }
            set
            {
                _OrdTotal = value;
            }
        }

        public int OrdEmpID
        {
            get
            {
                return _OrdEmpID;
            }
            set
            {
                _OrdEmpID = value;
            }
        }

        public DateTime OrdDate
        {
            get
            {
                return _OrdDate;
            }
            set
            {
                _OrdDate = value;
            }
        }

        public OrderDTO() { }

        public OrderDTO( int eID, int cusID)
        {
            this.OrdEmpID = eID;
            this.OrdCusID = cusID;
        }
    }
}
