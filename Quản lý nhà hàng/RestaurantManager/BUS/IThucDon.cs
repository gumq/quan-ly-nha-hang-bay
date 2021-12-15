using System.Data;
using System.Data.SqlClient;

namespace RestaurantManager.BUS
{
    interface IThucDon
    {
        string TenMonAn { get; set; }
        string DonVi { get; set; }
        float DonGia { get; set; }
        int ID { get; set; }
        DataTable LoadThucDon(SqlConnection conn);
        DataTable LoadThucDonByID(SqlConnection conn, int ID);
        void InsertThucDon(SqlConnection conn);
        void UpdateThucDon(SqlConnection conn, string DK);
        DataTable TimKiemMonAn(SqlConnection conn, string Text);
        void DeleteThucDon(SqlConnection conn, string Ten, int ID);
    }
}
