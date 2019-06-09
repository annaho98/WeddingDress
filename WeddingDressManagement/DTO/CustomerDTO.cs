using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CustomerDTO
    {
        private int _CustomerID;
        private string _CustomerName;
        private string _PhoneNumber;
        private string _Email;
        private string _Address;

        public int CustomerID
        {
            get
            {
                return _CustomerID;
            }
            set
            {
                _CustomerID = value;
            }

        }
        public string CustomerName
        {
            get
            {
                return _CustomerName;
            }
            set
            {
                _CustomerName = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return _PhoneNumber;
            }
            set
            {
                _PhoneNumber = value;
            }
        }
        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }
        }
        public string Address
        {
            get
            {
                return _Address;
            }
            set
            {
                _Address = value;
            }
        }

        public CustomerDTO()
        {

        }

        public CustomerDTO(string CustomerName, string PhoneNumber, string Email, string Address)
        {
            this.CustomerName = CustomerName;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.Address = Address;
        }
        public CustomerDTO(int CustomerID, string CustomerName, string PhoneNumber, string Email, string Address)
        {
            this.CustomerID = CustomerID;
            this.CustomerName = CustomerName;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.Address = Address;
        }
    }
}
