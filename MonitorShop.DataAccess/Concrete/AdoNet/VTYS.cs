using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonitorShop.DataAccess.Concrete.AdoNet
{
    public class VTYS
    {
        private static string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MonitorShopDB;Integrated Security=True";
        public static bool SqlExecuteNonQuery(SqlCommand cmd)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();
                    conn.Dispose();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static SqlDataReader SqlExecuteReader(SqlCommand cmd)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            cmd.Connection = conn;
            return cmd.ExecuteReader();
        }
    }
}
