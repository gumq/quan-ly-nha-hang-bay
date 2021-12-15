using System.Data;
using System.Data.SqlClient;

namespace RestaurantManager.BUS
{
    interface IHoaDon
    {
        string TenMonAn { get; set; }
        float DonGia { get; set; }
        float ThanhTien { get; set; }
        int SoLuong { get; set; }
        int STT { get; set; }
        DataTable LoadHoaDon(SqlConnection conn, int STT);
        bool CheckHoaDon(SqlConnection conn, string TenMonAn, int STT);
        void UpdateHoaDon(SqlConnection conn);
        void ThemHoaDon(SqlConnection conn);
        void XoaHoaDon(SqlConnection conn, int STT);
        void XoaHoaDonTheoTen(SqlConnection conn, int STT, string TenMon);
    }
}
