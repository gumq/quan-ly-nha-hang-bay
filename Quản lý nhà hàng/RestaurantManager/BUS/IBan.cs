using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.BUS
{
    interface IBan
    {
        string TenBan { get; set; }
        string TrangThai { get; set; }
        float TongCong { get; set; }
        int ID { get; set; }
        DataTable LoadBan(SqlConnection conn);
        DataTable LoadBanByID(SqlConnection conn, int ID);
        void CapNhatTrangThaiBan(SqlConnection conn, string TT, float TongCong, string TenBan);
        DataTable LaySTTBan(SqlConnection conn, string TenBan);
        DataTable LoadTongCong(SqlConnection conn, int STT);
        DataTable LoadBanByTrangThai(SqlConnection conn, string TrangThai, string TenBan);
        void InsertBan(SqlConnection conn, string TenBan, int iD);
        void UpdateBan(SqlConnection conn, string TenBan, string DieuKien);
        void DeleteBan(SqlConnection conn, string TenBan);
    }
}
