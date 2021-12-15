using System.Data;
using System.Data.SqlClient;

namespace RestaurantManager.BUS
{
    class clsNhanVien:INhanVien
    {
        string maNV, hoNV, tenNV, gioiTinh, ngaySinh, sDT, diaChi;
        public string MaNV { get => maNV; set => maNV = value; }
        public string HoNV { get => hoNV; set => hoNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public clsNhanVien() { }
        public clsNhanVien(string maNV, string hoNV, string tenNV, string gioiTinh, string ngaySinh, string sDT, string diaChi)
        {
            MaNV = maNV;
            HoNV = hoNV;
            TenNV = tenNV;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            SDT = sDT;
            DiaChi = diaChi;
        }
        public DataTable LoadNhanVien(SqlConnection conn)
        {
            conn.Open();
            DataTable table = new DataTable();
            string strSQL = "SELECT DISTINCT * FROM NHANVIEN";
            SqlDataAdapter dap = new SqlDataAdapter(strSQL, conn);
            dap.Fill(table);
            conn.Close();
            return table;
        }
        public void InsertNhanVien(SqlConnection conn)
        {
            string[] par = new string[7] { "@MaNV", "@HoNV", "@TenNV", "@GioiTinh", "@NGAYSINH", "@SDT", "@DiaChi" };
            string[] value = new string[7] { MaNV, HoNV, TenNV, GioiTinh, NgaySinh, SDT, DiaChi };
            BUS.Util.ExecuteNonQuery(conn, "sp_InsertNhanVien", par, value);
        }
        public void UpdateNhanVien(SqlConnection conn,string DieuKien)
        {
            string[] par = new string[8] { "@MaNV", "@HoNV", "@TenNV", "@GioiTinh", "@NGAYSINH", "@SDT", "@DiaChi","@DieuKien" };
            string[] value = new string[8] { MaNV, HoNV, TenNV, GioiTinh, NgaySinh, SDT, DiaChi,DieuKien };
            BUS.Util.ExecuteNonQuery(conn, "sp_UpdateNhanVien", par, value);
        }
        public void DeleteNhanVien(SqlConnection conn,string Manv)
        {
            string[] par = new string[1] { "@MaNV" };
            string[] value = new string[1] { Manv };
            BUS.Util.ExecuteNonQuery(conn, "sp_XoaNhanVien", par, value);
        }
        public DataTable TimKiemTheoMaNV(SqlConnection conn, string MaNV)
        {
            string[] par = new string[1] { "@MaNV" };
            string[] value = new string[1] { MaNV };
            return BUS.Util.FillData(conn, "sp_TimKiemTheoMaNV", par, value);
        }
        public DataTable TimKiemTheoTenNV(SqlConnection conn, string TenNV)
        {
            string[] par = new string[1] { "@TenNV" };
            string[] value = new string[1] { TenNV };
            return BUS.Util.FillData(conn, "sp_TimKiemTheoTenNV", par, value);
        }
    }
}
