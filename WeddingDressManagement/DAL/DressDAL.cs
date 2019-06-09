﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DressDAL:DBconnection
    {
        public DataTable InsertDress(DressDTO dress)
        {
            DataTable dtDress = new DataTable();
            con.Open();
            string SQL = string.Format("Insert into dress values ('{0}','{1}','{2}')",
                 dress.DressName, dress.DressDecription, dress.DressPrice);
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            adt.Fill(dtDress);
            con.Close();
            return dtDress;
        }

        public void UpdateDress(DressDTO dress)
        {
            con.Open();
            string SQL = string.Format("Update dress set DressName = {0}, DressDecription = {1}, DressPrice = {2} where DressID = {3})",
                 dress.DressName, dress.DressDecription, dress.DressPrice, dress.DressID);
            SqlCommand cmd = new SqlCommand(SQL, con);
            con.Close();
        }

        public DataTable ShowAllDress()
        {
            DataTable dtDress = new DataTable();
            con.Open();
            string SQL = string.Format("select dress.DressName, dress.DressDecription, dress.Price, Stock.DressQuant from dress join Stock on dress.DressID = Stock.DressID;");
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            adt.Fill(dtDress);
            con.Close();
            return dtDress;
        }

        public DataTable Display(string sql)
        {
            DataTable tblDress = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblDress);  //Fill vào một biến kiểu Datatable
                return tblDress;
            }

            catch (Exception e) { }

            finally
            { con.Close(); }

            return null;
        }
    }
}
