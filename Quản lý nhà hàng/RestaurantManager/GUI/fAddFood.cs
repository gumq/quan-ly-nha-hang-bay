using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RestaurantManager.GUI
{
    public partial class fAddFood : Form
    {
        SqlConnection conn { get; set; }
        private int STTBan {get;set;}
        private string TenBan { get; set; }
        public fAddFood(SqlConnection conn,int STT,string tenBan)
        {
            InitializeComponent();
            STTBan = STT;
            this.conn = conn;
            TenBan = tenBan;
        }
        void loadDanhMuc()
        {
            BUS.clsDanhMuc DM = new BUS.clsDanhMuc();
            DataTable table = DM.LoadDanhMuc(conn);
            cbDanhMuc.DisplayMember = "TenDanhMuc";
            cbDanhMuc.ValueMember = "ID";
            cbDanhMuc.DataSource = table;
        }
        void loadThucDon()
        {
            BUS.clsThucDon TD = new BUS.clsThucDon();
            int ID = Convert.ToInt32(cbDanhMuc.SelectedValue);
            if (ID == 0)
            {
                dgvThucDon.DataSource = TD.LoadThucDon(conn);
            }
            else
            {
                dgvThucDon.DataSource = TD.LoadThucDonByID(conn, ID);
            }
            txtTenMon.DataBindings.Clear();
            txtTenMon.DataBindings.Add("Text", dgvThucDon.DataSource, "TenMonAn");
            txtGia.DataBindings.Clear();
            txtGia.DataBindings.Add("Text", dgvThucDon.DataSource, "DonGia");
        }

        private void AddFood_Load(object sender, EventArgs e)
        {
            lbBan.Text = TenBan;
            loadDanhMuc();
            numSoLuong.Value = 1;
        }

        private void cbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadThucDon();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BUS.clsHoaDon HD = new BUS.clsHoaDon();
            BUS.clsBan Ban = new BUS.clsBan();
            int sl=0,SoLuong;
            if (HD.CheckHoaDon(conn, txtTenMon.Text, STTBan))
            {
                for (int i = 0; i < HD.LoadHoaDon(conn, STTBan).Rows.Count; i++)
                {
                    if (txtTenMon.Text == HD.LoadHoaDon(conn, STTBan).Rows[i]["TenMonAn"].ToString())
                    {
                        sl = int.Parse(HD.LoadHoaDon(conn, STTBan).Rows[i]["SoLuong"].ToString());
                    }
                }
                SoLuong = int.Parse(numSoLuong.Value.ToString()) + sl;
                float ThanhTien = float.Parse(txtGia.Text) * SoLuong;
                BUS.clsHoaDon HD1 = new BUS.clsHoaDon(txtTenMon.Text,SoLuong,0,ThanhTien,STTBan);
                HD1.UpdateHoaDon(conn);
                float TongCong = float.Parse(Ban.LoadTongCong(conn, STTBan).Rows[0][0].ToString());
                Ban.CapNhatTrangThaiBan(conn, "CÓ NGƯỜI", TongCong, lbBan.Text);
               
                AddFood_Load(sender, e);
            }
            else
            {
                int SL = int.Parse(numSoLuong.Value.ToString());
                float DonGia = float.Parse(txtGia.Text);
                float ThanhTien = DonGia * SL;
                BUS.clsHoaDon HD1 = new BUS.clsHoaDon(txtTenMon.Text, SL, DonGia, ThanhTien, STTBan);
                HD1.ThemHoaDon(conn);
                float TongCong = float.Parse(Ban.LoadTongCong(conn, STTBan).Rows[0][0].ToString());
                Ban.CapNhatTrangThaiBan(conn, "CÓ NGƯỜI",TongCong, lbBan.Text);
               
                AddFood_Load(sender, e);
            }
            
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            BUS.clsThucDon TD = new BUS.clsThucDon();
            dgvThucDon.DataSource = TD.TimKiemMonAn(conn, txtTimKiem.Text);
        }
    }
}
