using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MyKtv
{
    class DBHelper
    {
        private string connstring = @"Data Source=.;Initial Catalog=MyKTV;User ID=sa;pwd=123456";


        private SqlConnection conn;

        public SqlConnection Conn
        {
            get
            {
                if (conn == null)
                {
                    conn = new SqlConnection(connstring);
                }
                return conn;
            }
        }
        public void OpenConn()
        {
            if (Conn.State == ConnectionState.Closed)
            {
                Conn.Open();

            }
            else if (Conn.State == ConnectionState.Broken)
            {
                Conn.Close();
                Conn.Open();
            }
        }
        public void CloseConn()
        {
            if (Conn.State == ConnectionState.Open || Conn.State == ConnectionState.Broken)
            {
                Conn.Close();
            }
        }

    }
}
