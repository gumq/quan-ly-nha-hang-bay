using System.Data;
using System.Data.SqlClient;

namespace RestaurantManager.BUS
{
    class clsDanhMuc:IDanhMuc
    {
        string tenDM;
        public string TenDM
        {
            get { return tenDM; }
            set { tenDM = value; }
        }
        public clsDanhMuc()
        {

        }
        public clsDanhMuc(string TenDM)
        {
            this.TenDM = TenDM;
        }
        public DataTable LoadDanhMuc(SqlConnection conn)
        {
            conn.Open();
            DataTable table = new DataTable();
            string strSQL = "SELECT DISTINCT * FROM DANHMUC";
            SqlDataAdapter dap = new SqlDataAdapter(strSQL, conn);
            dap.Fill(table);
            conn.Close();
            return table;
        }
        public DataTable LoadDSDanhMuc(SqlConnection conn)
        {
            conn.Open();
            DataTable table = new DataTable();
            string strSQL = "SELECT DISTINCT * FROM DANHMUC WHERE ID != 0";
            SqlDataAdapter dap = new SqlDataAdapter(strSQL, conn);
            dap.Fill(table);
            conn.Close();
            return table;
        }
        public void InsertDanhMuc(SqlConnection conn)
        {
            string[] par = new string[1] { "@TenDanhMuc" };
            string[] value = new string[1] { TenDM };
            BUS.Util.ExecuteNonQuery(conn, "sp_ThemDanhMuc", par, value);
        }
        public void UpdateDanhMuc(SqlConnection conn,int id)
        {
            string[] par = new string[2] { "@TenDanhMuc", "@ID" };
            string[] value = new string[2] { TenDM, id.ToString() };
            BUS.Util.ExecuteNonQuery(conn, "sp_UpdateDanhMuc", par, value);
        }
        public void DeleteDanhMuc(SqlConnection conn, int id)
        {
            string[] par = new string[1] { "@ID" };
            string[] value = new string[1] { id.ToString() };
            BUS.Util.ExecuteNonQuery(conn, "sp_XoaDanhMuc", par, value);
        }
    }
}
