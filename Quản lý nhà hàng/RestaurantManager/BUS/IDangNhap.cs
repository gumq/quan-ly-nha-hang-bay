using System.Data;
using System.Data.SqlClient;

namespace RestaurantManager.BUS
{
    interface IDangNhap
    {
        string TenDangNhap { get; set; }
        string MatKhau { get; set; }
        bool CheckDangNhap(SqlConnection conn, int ID);
        void NhoMK(SqlConnection conn);
        void HuyNhoMK(SqlConnection conn);
        DataTable LoadNhoMatKhau(SqlConnection conn);

    }
}
