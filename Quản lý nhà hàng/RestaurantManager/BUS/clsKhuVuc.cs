using System.Data;
using System.Data.SqlClient;

namespace RestaurantManager.BUS
{
    class clsKhuVuc:IKhuVuc
    {
        string tenKV;
        public string TenKV
        {
            get { return tenKV; }
            set { tenKV = value; }
        }
        public clsKhuVuc()
        {

        }
        public clsKhuVuc(string TenKV)
        {
            this.TenKV = TenKV;
        }
        public DataTable LoadKhuVuc(SqlConnection conn)
        {
            conn.Open();
            DataTable table = new DataTable();
            string strSQL = "SELECT DISTINCT * FROM KHUVUC";
            SqlDataAdapter dap = new SqlDataAdapter(strSQL, conn);
            dap.Fill(table);
            conn.Close();
            return table;
        }
        public DataTable LoadDSKhuVuc(SqlConnection conn)
        {
            conn.Open();
            DataTable table = new DataTable();
            string strSQL = "SELECT DISTINCT * FROM KHUVUC WHERE ID != 0";
            SqlDataAdapter dap = new SqlDataAdapter(strSQL, conn);
            dap.Fill(table);
            conn.Close();
            return table;
        }
        public DataTable LayTenKV(SqlConnection conn, string TenBan)
        {
            conn.Open();
            DataTable table = new DataTable();
            string strSQL = "SELECT DISTINCT TenKhuVuc,STT FROM BAN,KHUVUC where KHUVUC.ID=BAN.ID and BAN.TenBan = '"+TenBan+"'";
            SqlDataAdapter dap = new SqlDataAdapter(strSQL, conn);
            dap.Fill(table);
            conn.Close();
            return table;
        }
        public void InsertKhuVuc(SqlConnection conn)
        {
            string[] par = new string[1] { "@TenKhuVuc" };
            string[] value = new string[1] { TenKV };
            BUS.Util.ExecuteNonQuery(conn, "sp_ThemKhuVuc", par, value);
        }
        public void UpdateKhuVuc(SqlConnection conn, int id)
        {
            string[] par = new string[2] { "@TenKhuVuc", "@ID" };
            string[] value = new string[2] { TenKV, id.ToString() };
            BUS.Util.ExecuteNonQuery(conn, "sp_UpdateKhuVuc", par, value);
        }
        public void DeleteKhuVuc(SqlConnection conn, int id)
        {
            string[] par = new string[1] { "@ID" };
            string[] value = new string[1] { id.ToString() };
            BUS.Util.ExecuteNonQuery(conn, "sp_XoaKhuVuc", par, value);
        }
    }
}
