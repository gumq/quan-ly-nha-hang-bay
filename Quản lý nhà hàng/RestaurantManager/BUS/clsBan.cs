using System.Data;
using System.Data.SqlClient;

namespace RestaurantManager.BUS
{
    class clsBan:IBan
    {
        string tenban, trangthai;
        float tongcong;
        int id;
        public string TenBan
        {
            get { return tenban; }
            set { tenban = value; }
        }
        public string TrangThai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }
        public float TongCong
        {
            get { return tongcong; }
            set { tongcong = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public clsBan() { }
        public clsBan(string TenBan,string TrangThai,float TongCong,int ID)
        {
            this.TenBan = TenBan;
            this.TrangThai = TrangThai;
            this.TongCong = TongCong;
            this.ID = ID;
        }
        public DataTable LoadBan(SqlConnection conn)
        {
            conn.Open();
            DataTable table = new DataTable();
            string strSQL = "SELECT DISTINCT * FROM BAN";
            SqlDataAdapter dap = new SqlDataAdapter(strSQL, conn);
            dap.Fill(table);
            conn.Close();
            return table;
        }
        public DataTable LoadBanByID(SqlConnection conn, int ID)
        {
            conn.Open();
            DataTable table = new DataTable();
            string strSQL = "SELECT DISTINCT * FROM BAN WHERE ID LIKE '"+ID+"'";
            SqlDataAdapter dap = new SqlDataAdapter(strSQL, conn);
            dap.Fill(table);
            conn.Close();
            return table;
        }
        public void CapNhatTrangThaiBan(SqlConnection conn, string TT, float TongCong, string TenBan)
        {
            string[] par = new string[3] { "@TrangThai", "@TongCong", "@TenBan" };
            string[] value = new string[3] { TT, TongCong.ToString(), TenBan };
            BUS.Util.ExecuteNonQuery(conn, "sp_CapNhatTrangThaiBan", par, value);
        }
        public DataTable LaySTTBan(SqlConnection conn, string TenBan)
        {
            conn.Open();
            DataTable table = new DataTable();
            string strSQL = "select DISTINCT STT from BAN where TenBan='"+TenBan+"'";
            SqlDataAdapter dap = new SqlDataAdapter(strSQL, conn);
            dap.Fill(table);
            conn.Close();
            return table;
        }
        public DataTable LoadTongCong(SqlConnection conn, int STT)
        {
            conn.Open();
            DataTable table = new DataTable();
            string strSQL = "SELECT DISTINCT SUM(ThanhTien) FROM HOADON Where STT = '"+STT+"'";
            SqlDataAdapter dap = new SqlDataAdapter(strSQL, conn);
            dap.Fill(table);
            conn.Close();
            return table;
        }
        public DataTable LoadBanByTrangThai(SqlConnection conn, string TrangThai, string TenBan)
        {
            conn.Open();
            DataTable table = new DataTable();
            string strSQL = "SELECT DISTINCT * FROM BAN WHERE TrangThai LIKE N'"+TrangThai+"' and TenBan != N'"+TenBan+"'";
            SqlDataAdapter dap = new SqlDataAdapter(strSQL, conn);
            dap.Fill(table);
            conn.Close();
            return table;
        }
        public void InsertBan(SqlConnection conn, string TenBan, int iD)
        {
            string[] par = new string[2] { "@TenBan", "@ID" };
            string[] value = new string[2] { TenBan, iD.ToString() };
            BUS.Util.ExecuteNonQuery(conn, "sp_ThemBan", par, value);
        }
        public void UpdateBan(SqlConnection conn, string TenBan, string DieuKien)
        {
            string[] par = new string[2] { "@TenBan", "@DieuKien" };
            string[] value = new string[2] { TenBan, DieuKien };
            BUS.Util.ExecuteNonQuery(conn, "sp_UpdateBan", par, value);
        }
        public void DeleteBan(SqlConnection conn, string TenBan)
        {
            string[] par = new string[1] { "@TenBan" };
            string[] value = new string[1] { TenBan };
            BUS.Util.ExecuteNonQuery(conn, "sp_XoaBan", par, value);
        }
    }
}
