using System.Data;
using System.Data.SqlClient;

namespace RestaurantManager.BUS
{
    interface IDanhMuc
    {
        string TenDM { get; set; }
        DataTable LoadDanhMuc(SqlConnection conn);
        DataTable LoadDSDanhMuc(SqlConnection conn);
        void InsertDanhMuc(SqlConnection conn);
        void UpdateDanhMuc(SqlConnection conn, int id);
        void DeleteDanhMuc(SqlConnection conn, int id);
    }
}
