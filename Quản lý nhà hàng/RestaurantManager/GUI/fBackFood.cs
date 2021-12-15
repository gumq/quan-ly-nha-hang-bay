using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RestaurantManager.GUI
{
    public partial class fBackFood : Form
    {
        private SqlConnection conn { get; set; }
        private string TenBan { get; set; }
        private float TongCong { get; set; }
        private int STTBan { get; set; }
        public fBackFood(SqlConnection conn,string TenBan,float TongCong,int STT)
        {
            InitializeComponent();
            this.conn = conn;
            this.TenBan = TenBan;
            this.TongCong = TongCong;
            STTBan = STT;
        }
        void loadHoaDon()
        {
            BUS.clsHoaDon HD = new BUS.clsHoaDon();
            lbBan.Text = TenBan;
            dgvHoaDon.DataSource = HD.LoadHoaDon(conn, STTBan);
            for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
            {
                dgvHoaDon.Rows[i].Cells["clSTT"].Value = i + 1;
            }
            txtTenMon.DataBindings.Clear();
            txtTenMon.DataBindings.Add("Text", dgvHoaDon.DataSource, "TenMonAn");
            txtGia.DataBindings.Clear();
            txtGia.DataBindings.Add("Text", dgvHoaDon.DataSource, "DonGia");
            numSoLuong.DataBindings.Clear();
            numSoLuong.DataBindings.Add("Value", dgvHoaDon.DataSource, "SoLuong");
            numHoanTra.Maximum = numSoLuong.Value;
        }

        private void fBackFood_Load(object sender, EventArgs e)
        {
            loadHoaDon();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numHoanTra.Maximum = numSoLuong.Value;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BUS.clsHoaDon HD = new BUS.clsHoaDon();
            if (MessageBox.Show("Xác nhận hoàn trả", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int SoLuong = int.Parse(numSoLuong.Value.ToString()) - int.Parse(numHoanTra.Value.ToString());
                float DonGia = float.Parse(txtGia.Text);
                float ThanhTien = DonGia * SoLuong;
                if (SoLuong == 0)
                {
                    HD.XoaHoaDonTheoTen(conn, STTBan, txtTenMon.Text);  
                }
                else
                {
                    BUS.clsHoaDon HD1 = new BUS.clsHoaDon(txtTenMon.Text,SoLuong,DonGia,ThanhTien,STTBan);
                    HD1.UpdateHoaDon(conn);
                }
                fBackFood_Load(sender, e);
                dgvHoaDon.RefreshEdit();
                BUS.clsBan ban = new BUS.clsBan();
              
                if (dgvHoaDon.DataSource == null || dgvHoaDon.CurrentCell == null)
                {
                    ban.CapNhatTrangThaiBan(conn, "TRỐNG", 0, lbBan.Text);
                }
                else
                {
                    TongCong = float.Parse(ban.LoadTongCong(conn, STTBan).Rows[0][0].ToString());
                    ban.CapNhatTrangThaiBan(conn, "CÓ NGƯỜI", TongCong, lbBan.Text);
                }
                
                
            }
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void lbBan_Click(object sender, EventArgs e)
        {

        }
    }
}
