using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class EmpDAL:DBconnection
    {

        public int CheckAccount(EmpDTO emp)
        {
            con.Open();
            string SQL = string.Format("SELECT * FROM employee WHERE EmployeeID = {0} AND [Password] = {1}", emp.EID, emp.Epass);
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataReader rd = cmd.ExecuteReader();
            int loginSuccessful;
            rd.Read();
            if (rd.HasRows)
            {
                if (rd["IsAdmin"].ToString() == "Admin")
                {
                    loginSuccessful = 2;
                }
                else
                {
                    loginSuccessful = 1;
                }
            }
            else
            {
                loginSuccessful = 0;
            }
            con.Close();
            return loginSuccessful;
        }

        /* Insert employee */
        public bool InsertEmp(EmpDTO emp)
        {
            try
            {
                con.Open();

                string SQL = string.Format("Insert into Employee(EmployeeName,[Password],[Status],IsAdmin) values ('{0}','{1}','{2}','{3}')", emp.EName, emp.Epass, emp.Status, emp.Role);

                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception e)
            { }

            finally
            {
                con.Close();
            }

            return false;
        }

        /*Update Employee*/
        public bool UpdateEmp(EmpDTO emp)
        {
            try
            {
                con.Open();

                string SQL = string.Format("Update Employee(EmployeeName,[Status],IsAdmin) " + "set EmployeeName = '{0}', [Status] = '{1}', IsAdmin = '{2}' where EmployeeID = {3}",
                    emp.EName, emp.Status, emp.Role, emp.EID);

                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception e)
            { }
            finally
            {
                con.Close();
            }
            return false;
        }

        public DataTable Display(string sql)
        {
            DataTable tbemp = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                adt.SelectCommand = cmd;
                adt.Fill(tbemp);
                return tbemp;
            }

            catch (Exception e) { }

            finally
            { con.Close(); }

            return null;
        }
    }
}
