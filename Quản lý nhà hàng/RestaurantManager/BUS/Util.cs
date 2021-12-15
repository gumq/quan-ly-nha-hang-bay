using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RestaurantManager.BUS
{
    class Util
    {
        public static void ExecuteNonQuery(SqlConnection conn, string store, string[] paramater, string[] values)
        {
            conn.Open();
            var SqlCom = new SqlCommand();
            SqlCom.CommandText = store;
            SqlCom.Connection = conn;
            SqlCom.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < paramater.Length; i++)
            {
                SqlCom.Parameters.AddWithValue(paramater[i], values[i]);
            }
            SqlCom.ExecuteNonQuery();
            conn.Close();
        }
        public static bool ExecuteReader(SqlConnection conn, string store, string[] paramater, string[] values)
        {
            conn.Open();
            var SqlCom = new SqlCommand();
            SqlCom.CommandText = store;
            SqlCom.Connection = conn;
            SqlCom.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < paramater.Length; i++)
            {
                SqlCom.Parameters.AddWithValue(paramater[i], values[i]);
            }
            SqlDataReader dr = SqlCom.ExecuteReader();
            if (dr.Read())
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }
        public static DataTable FillData(SqlConnection conn, string store, string[] paramater, string[] values)
        {
            conn.Open();
            var SqlCom = new SqlCommand();
            var tb = new DataTable();
            SqlCom.CommandText = store;
            SqlCom.Connection = conn;
            SqlCom.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < paramater.Length; i++)
            {
                SqlCom.Parameters.AddWithValue(paramater[i], values[i]);
            }
            SqlDataAdapter dap = new SqlDataAdapter(SqlCom);
            dap.Fill(tb);
            conn.Close();
            return tb;
        }
    }
}
