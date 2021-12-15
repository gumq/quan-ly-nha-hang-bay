using System.Data;
using System.Data.SqlClient;

namespace RestaurantManager.BUS
{
    class clsHoaDon:IHoaDon
    {
        string tenmonan;
        float dongia,thanhtien;
        int soluong, stt;
        public float DonGia
        {
            get { return dongia; }
            set { dongia = value; }
        }
        public string TenMonAn
        {
            get { return tenmonan; }
            set { tenmonan = value; }
        }
        public float ThanhTien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }
        public int SoLuong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        public int STT
        {
            get { return stt; }
            set { stt = value; }
        }
        public clsHoaDon() { }
        public clsHoaDon(string TenMonAn,int SoLuong,float DonGia,float ThanhTien,int STT)
        {
            this.TenMonAn = TenMonAn;
            this.SoLuong = SoLuong;
            this.DonGia = DonGia;
            this.ThanhTien = ThanhTien;
            this.STT = STT;
        }
        public DataTable LoadHoaDon(SqlConnection conn,int STT)
        {
            conn.Open();
            DataTable table = new DataTable();
            string strSQL = "SELECT DISTINCT [TenMonAn],[SoLuong],[DonGia],[ThanhTien] FROM [dbo].[HOADON] WHERE STT like '"+STT+"'";
            SqlDataAdapter dap = new SqlDataAdapter(strSQL, conn);
            dap.Fill(table);
            conn.Close();
            return table;
        }
        public bool CheckHoaDon(SqlConnection conn, string TenMonAn, int STT)
        {
            string strSQL = "SELECT DISTINCT TenMonAn,STT FROM [dbo].[HOADON] WHERE TenMonAn LIKE N'"+TenMonAn+"' AND STT LIKE '"+STT+"'";
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
        public void UpdateHoaDon(SqlConnection conn)
        {
            string[] par = new string[4] { "@TenMonAn", "@STT", "@SoLuong", "@ThanhTien" };
            string[] value = new string[4] { TenMonAn, STT.ToString(), SoLuong.ToString(), ThanhTien.ToString() };
            Util.ExecuteReader(conn, "sp_UpdateHoaDon", par, value);
        }
        public void ThemHoaDon(SqlConnection conn)
        {
            string[] par = new string[5] { "@TenMonAn", "@SoLuong", "@DonGia", "@ThanhTien", "@STT" };
            string[] value = new string[5] { TenMonAn, SoLuong.ToString(), DonGia.ToString(), ThanhTien.ToString(), STT.ToString() };
            Util.ExecuteNonQuery(conn, "sp_ThemHoaDon", par, value);
        }
        public void XoaHoaDon(SqlConnection conn, int STT)
        {
            string[] par = new string[1] { "@STT" };
            string[] value = new string[1] { STT.ToString() };
            BUS.Util.ExecuteNonQuery(conn, "sp_XoaHoaDon", par, value);
        }
        public void XoaHoaDonTheoTen(SqlConnection conn, int STT, string TenMon)
        {
            string[] par = new string[2] { "@TenMonAn", "@STT" };
            string[] value = new string[2] { TenMon, STT.ToString() };
            BUS.Util.ExecuteNonQuery(conn, "sp_XoaHoaDonTheoTen", par, value);
        }
    }
}
