using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EmpDTO
    {
        private int _EID;
        private string _Epass;
        private string _EName;
        private string _Role;
        private string _Status;


        public int EID
        {
            get
            {
                return _EID;
            }
            set
            {
                _EID = value;
            }
        }

        public string Epass
        {
            get
            {
                return _Epass;
            }
            set
            {
                _Epass = value;
            }
        }

        public string EName
        {
            get
            {
                return _EName;
            }
            set
            {
                _EName = value;
            }
        }

        public string Role
        {
            get
            {
                return _Role;
            }
            set
            {
                _Role = value;
            }
        }

        public string Status
        {
            get
            {
                return _Status;
            }
            set
            {
                _Status = value;
            }
        }

        public EmpDTO() { }

        public EmpDTO(string EName, string EPass, string Role, string Status)
        {
            this._EName = EName;
            this._Epass = EPass;
            this._Role = Role;
            this._Status = Status;
        }

        public EmpDTO(int EID, string EName, string Role, string Status)
        {
            this._EID = EID;
            this._EName = EName;
            this._Role = Role;
            this._Status = Status;
        }

        public EmpDTO(int EID, string Password)
        {
            this._EID = EID;
            this._Epass = Password;
        }
    }
}
