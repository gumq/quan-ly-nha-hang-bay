using System.Data;
using System.Data.SqlClient;

namespace RestaurantManager.BUS
{
    interface IKhuVuc
    {
        string TenKV { get; set; }
        DataTable LoadKhuVuc(SqlConnection conn);
        DataTable LoadDSKhuVuc(SqlConnection conn);
        DataTable LayTenKV(SqlConnection conn, string TenBan);
        void InsertKhuVuc(SqlConnection conn);
        void UpdateKhuVuc(SqlConnection conn, int id);
        void DeleteKhuVuc(SqlConnection conn, int id);
    }
}
