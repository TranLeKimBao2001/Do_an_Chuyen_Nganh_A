using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHONGKHAM
{
    public class DatabaseSQLExecute
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        public DatabaseSQLExecute()
        {
            string constr = @"Data Source=.;Initial Catalog=QUANLYPHONGKHAM;Integrated Security=True;TrustServerCertificate=True";
            conn = new SqlConnection(constr);
            adapter = new SqlDataAdapter();
        }

        private SqlConnection OpenConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

        public DataTable ExecuteSelectAllQuery(string _query)
        {
            SqlCommand myCommand = new SqlCommand();
            DataTable dataTable = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                myCommand.Connection = OpenConnection();
                myCommand.CommandText = _query;
                adapter.SelectCommand = myCommand;
                adapter.Fill(ds);
                dataTable = ds.Tables[0];
            }
            catch
            {
                Console.WriteLine("Error " + _query);
            }
            return dataTable;
        }
        public bool ExecuteCRUDQuery(string _query)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = OpenConnection();
                myCommand.CommandText = _query;
                if (myCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return true;
            }
            catch
            {
                Console.WriteLine("Error" + _query);
            }
            return false;
        }

    }
}

