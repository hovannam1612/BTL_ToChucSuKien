using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BTL_ToChucSuKien.Admin.DataUtil
{
    public class Connect
    {
        public static SqlConnection connect()
        {
            String sqlConn = @"Data Source=DESKTOP-0MTS6DU\SQLEXPRESS;Initial Catalog=ToChucSuKien;Integrated Security=True";
            SqlConnection conn = new SqlConnection(sqlConn);
            return conn;
        }
    }
}