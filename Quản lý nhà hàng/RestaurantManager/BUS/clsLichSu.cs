using System.Data;
using System.Data.SqlClient;

namespace RestaurantManager.BUS
{
    class clsLichSu:ILichSu
    {
        string khuVuc, tenBan, ngay, thoiGian, tongCong, nguoiThanhToan, ghiChu;
        public string KhuVuc { get => khuVuc; set => khuVuc = value; }
        public string TenBan { get => tenBan; set => tenBan = value; }
        public string Ngay { get => ngay; set => ngay = value; }
        public string ThoiGian { get => thoiGian; set => thoiGian = value; }
        public string TongCong { get => tongCong; set => tongCong = value; }
        public string NguoiThanhToan { get => nguoiThanhToan; set => nguoiThanhToan = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public clsLichSu() { }
        public clsLichSu(string khuVuc, string tenBan, string ngay, string thoiGian, string tongCong, string nguoiThanhToan, string ghiChu)
        {
            KhuVuc = khuVuc;
            TenBan = tenBan;
            Ngay = ngay;
            ThoiGian = thoiGian;
            TongCong = tongCong;
            NguoiThanhToan = nguoiThanhToan;
            GhiChu = ghiChu;
        }

        public DataTable LoadLichSu(SqlConnection conn)
        {
            conn.Open();
            DataTable table = new DataTable();
            string strSQL = "SELECT DISTINCT * FROM LICHSU";
            SqlDataAdapter dap = new SqlDataAdapter(strSQL, conn);
            dap.Fill(table);
            conn.Close();
            return table;
        }
        public void InsertLichSu(SqlConnection conn)
        {
            string[] par = new string[7] { "@KhuVuc", "@TenBan", "@Ngay", "@ThoiGian", "@TongCong", "@NguoiThanhToan", "@GhiChu" };
            string[] value = new string[7] { KhuVuc, TenBan, Ngay, ThoiGian, TongCong.ToString(), NguoiThanhToan, GhiChu };
            Util.ExecuteNonQuery(conn, "sp_ThemLichSu", par, value);
        }
        public DataTable ThongKeTheoNgay(SqlConnection conn,string Ngay)
        {
            string[] par = new string[1] { "@Ngay" };
            string[] value = new string[1] { Ngay };
            return Util.FillData(conn, "sp_ThongKeTheoNgay", par, value);
        }
        public DataTable ThongKeTheoThang(SqlConnection conn, string Thang,string Nam)
        {
            string[] par = new string[2] { "@Thang","@Nam" };
            string[] value = new string[2] { Thang,Nam };
            return Util.FillData(conn, "sp_ThongKeTheoThang", par, value);
        }
        public DataTable ThongKeTheoKhoangNgay(SqlConnection conn, string TuNgay, string DenNgay)
        {
            string[] par = new string[2] { "@TuNgay", "@DenNgay" };
            string[] value = new string[2] { TuNgay, DenNgay };
            return Util.FillData(conn, "sp_ThongKeTheoKhoangNgay", par, value);
        }
    }
}
