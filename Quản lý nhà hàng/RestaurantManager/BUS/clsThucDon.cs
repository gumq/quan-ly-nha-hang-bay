using System.Data;
using System.Data.SqlClient;

namespace RestaurantManager.BUS
{
    class clsThucDon:IThucDon
    {
        string tenmonan,donvi;
        float dongia;
        int id;
        public string TenMonAn
        {
            get { return tenmonan; }
            set { tenmonan = value; }
        }
        public string DonVi
        {
            get { return donvi; }
            set { donvi = value; }
        }
        public float DonGia
        {
            get { return dongia; }
            set { dongia = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public clsThucDon() { }
        public clsThucDon(string TenMonAn,float DonGia,string DonVi,int ID)
        {
            this.TenMonAn = TenMonAn;
            this.DonGia = DonGia;
            this.DonVi = DonVi;
            this.ID = ID;
        }
        public DataTable LoadThucDon(SqlConnection conn)
        {
            conn.Open();
            DataTable table = new DataTable();
            string strSQL = "SELECT DISTINCT * FROM THUCDON";
            SqlDataAdapter dap = new SqlDataAdapter(strSQL, conn);
            dap.Fill(table);
            conn.Close();
            return table;
        }
        public DataTable LoadThucDonByID(SqlConnection conn,int ID)
        {
            conn.Open();
            DataTable table = new DataTable();
            string strSQL = "SELECT DISTINCT * FROM THUCDON WHERE ID LIKE '" + ID + "'";
            SqlDataAdapter dap = new SqlDataAdapter(strSQL, conn);
            dap.Fill(table);
            conn.Close();
            return table;
        }
        public void InsertThucDon(SqlConnection conn)
        {
            string[] par = new string[4] { "@TenMonAn", "@DonGia", "@DonVi", "@ID" };
            string[] value = new string[4] { TenMonAn, DonGia.ToString(), DonVi, ID.ToString() };
            BUS.Util.ExecuteNonQuery(conn, "sp_ThemThucDon", par, value);
        }
        public void UpdateThucDon(SqlConnection conn, string DK)
        {
            string[] par = new string[4] { "@TenMonAn", "@DonGia", "@DonVi", "@DieuKien" };
            string[] value = new string[4] { TenMonAn, DonGia.ToString(), DonVi, DK };
            BUS.Util.ExecuteNonQuery(conn, "sp_UpdateThucDon", par, value);
        }
        public DataTable TimKiemMonAn(SqlConnection conn, string Text)
        {
            string[] par = new string[1] { "@TenMonAn" };
            string[] value = new string[1] { Text };
            return BUS.Util.FillData(conn, "sp_TimKiemMonAn", par, value);
        }
        public void DeleteThucDon(SqlConnection conn, string Ten, int ID)
        {
            string[] par = new string[2] { "@TenMonAn", "@ID" };
            string[] value = new string[2] { Ten, ID.ToString() };
            BUS.Util.ExecuteNonQuery(conn, "sp_XoaThucDon", par, value);
        }
    }
}
