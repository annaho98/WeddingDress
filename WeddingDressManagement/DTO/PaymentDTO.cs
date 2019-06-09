using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PaymentDTO
    {
        private int _PayID;
        private int _OrdID;
        private int _EmpID;
        private int _Amount;
        private int _Change;
        private DateTime _PayDate;

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

        public int PayID
        {
            get
            {
                return _PayID;
            }
            set
            {
                _PayID = value;
            }
        }

        public int EmpID
        {
            get
            {
                return _EmpID;
            }
            set
            {
                _EmpID = value;
            }
        }

        public int Amount
        {
            get
            {
                return _Amount;
            }
            set
            {
                _Amount = value;
            }
        }

        public int Change
        {
            get
            {
                return _Change;
            }
            set
            {
                _Change = value;
            }
        }

        public DateTime PayDate
        {
            get
            {
                return _PayDate;
            }
            set
            {
                _PayDate = value;
            }
        }

        public PaymentDTO() { }
    }
}
