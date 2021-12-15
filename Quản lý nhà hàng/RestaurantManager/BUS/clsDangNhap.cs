using System.Data;
using System.Data.SqlClient;

namespace RestaurantManager.BUS
{
    class clsDangNhap:IDangNhap
    {
        string tendangnhap, matkhau;
        public string TenDangNhap
        {
            get { return tendangnhap; }
            set { tendangnhap = value; }
        }
        public string MatKhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }
        public clsDangNhap()
        {

        }
        public clsDangNhap(string TenDangNhap,string MatKhau)
        {
            this.TenDangNhap = TenDangNhap;
            this.MatKhau = MatKhau;
        }
        public bool CheckDangNhap(SqlConnection conn,int ID)
        {
            string strSQL = "SELECT TenDangNhap,MatKhau FROM[TAIKHOAN] Where TenDangNhap = '" + TenDangNhap + "' and MatKhau = '" + MatKhau + "' and ID = '" + ID + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }
        public void NhoMK(SqlConnection conn)
        {
            conn.Open();
            var cmdupdate = new SqlCommand("Update LUUTAIKHOAN set TenDangNhap = '" + TenDangNhap + "', MatKhau = '" + MatKhau + "'", conn);
            cmdupdate.ExecuteNonQuery();
            conn.Close();
        }
        public void HuyNhoMK(SqlConnection conn)
        {
            conn.Open();
            var cmdupdate = new SqlCommand("Update LUUTAIKHOAN set TenDangNhap = 'qwerasdfzxcv', MatKhau = 'qwerasdfzxcv'", conn);
            cmdupdate.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable LoadNhoMatKhau(SqlConnection conn)
        {
            conn.Open();
            DataTable table = new DataTable();
            string strSQL = "SELECT DISTINCT * FROM LUUTAIKHOAN";
            SqlDataAdapter dap = new SqlDataAdapter(strSQL, conn);
            dap.Fill(table);
            conn.Close();
            return table;
        }
    }
}
