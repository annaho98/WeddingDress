using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StockDTO
    {
        private int _StockID;
        private int _DressID;
        private int _DressQuant;
        private DateTime _ImportDate;

        public int StockID
        {
            get
            {
                return _StockID;
            }
            set
            {
                _StockID = value;
            }
        }

        public int DressID
        {
            get
            {
                return _DressID;
            }
            set
            {
                _DressID = value;
            }
        }
        
        public int DressQuant
        {
            get
            {
                return _DressQuant;
            }
            set
            {
                _DressQuant = value;
            }
        }

        public DateTime ImportDate
        {
            get
            {
                return _ImportDate;
            }
            set
            {
                _ImportDate = value;
            }
        }

        public StockDTO() { }

        public StockDTO(int quant)
        {
            this.DressQuant = quant;
        }
    }
}
