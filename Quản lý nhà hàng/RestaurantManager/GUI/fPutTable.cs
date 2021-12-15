using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager.GUI
{
    public partial class fPutTable : Form
    {
        private SqlConnection conn { get; set; }
        private string TenBan { get; set; }
        private int STTBan { get; set; }
        public fPutTable(SqlConnection conn,string TenBan,int STT)
        {
            InitializeComponent();
            this.conn = conn;
            this.TenBan = TenBan;
            STTBan = STT;
        }
        void loadTable()
        {
            BUS.clsBan ban = new BUS.clsBan();
            DataTable table = ban.LoadBanByTrangThai(conn, "CÓ NGƯỜI",TenBan);
            cbGop.DisplayMember = "TenBan";
            cbGop.ValueMember = "ID";
            cbGop.DataSource = table;
            lbBan.Text = TenBan;
        }
        void loadHoaDon()
        {
            BUS.clsBan ban = new BUS.clsBan();
            BUS.clsHoaDon HD = new BUS.clsHoaDon();
            dgvHoaDon.DataSource = HD.LoadHoaDon(conn, STTBan);
            for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
            {
                dgvHoaDon.Rows[i].Cells["clSTT"].Value = i + 1;
            }
            int STTBanGop = int.Parse(ban.LaySTTBan(conn, cbGop.Text).Rows[0][0].ToString());
            dgvHoaDonGop.DataSource = HD.LoadHoaDon(conn,STTBanGop);
            for (int i = 0; i < dgvHoaDonGop.Rows.Count; i++)
            {
                dgvHoaDonGop.Rows[i].Cells["STT"].Value = i + 1;
            }
        }

        private void PutTable_Load(object sender, EventArgs e)
        {
            loadTable();
            loadHoaDon();
        }

        private void cbGop_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadHoaDon();
        }

        private void btnGop_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn gộp hóa đơn bàn ("+TenBan+") vào bàn ("+cbGop.Text+") ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                BUS.clsBan ban = new BUS.clsBan();
                BUS.clsHoaDon HD = new BUS.clsHoaDon();
                int sl = 0, SoLuong;
                float TongCong = 0;
                for (int j = 0; j < dgvHoaDon.Rows.Count; j++)
                {
                    
                    int STTBanGop = int.Parse(ban.LaySTTBan(conn, cbGop.Text).Rows[0][0].ToString());
                    if (HD.CheckHoaDon(conn, dgvHoaDon.Rows[j].Cells["clTenMon"].Value.ToString(), STTBanGop))
                    {
                        //lấy ra vị trí món ăn đã tồn tại trong hóa đơn
                        for (int i = 0; i < dgvHoaDonGop.Rows.Count; i++)
                        {
                            if (dgvHoaDon.Rows[j].Cells["clTenMon"].Value.ToString() == dgvHoaDonGop.Rows[i].Cells["TenMon"].Value.ToString())
                            {
                                sl = int.Parse(dgvHoaDonGop.Rows[i].Cells["SoLuong"].Value.ToString());
                            }
                        }
                        
                        SoLuong = int.Parse(dgvHoaDon.Rows[j].Cells["clSoLuong"].Value.ToString()) + sl;
                        float ThanhTien = float.Parse(dgvHoaDon.Rows[j].Cells["clDonGia"].Value.ToString()) * SoLuong;
                        BUS.clsHoaDon hd = new BUS.clsHoaDon(dgvHoaDon.Rows[j].Cells["clTenMon"].Value.ToString(), SoLuong, 0, ThanhTien, STTBanGop);
                        hd.UpdateHoaDon(conn);
                        TongCong = float.Parse(ban.LoadTongCong(conn, STTBanGop).Rows[0][0].ToString());
                    }
                    else
                    {
                        int SL = int.Parse(dgvHoaDon.Rows[j].Cells["clSoLuong"].Value.ToString());
                        float DonGia = float.Parse(dgvHoaDon.Rows[j].Cells[3].Value.ToString());
                        float ThanhTien = DonGia * SL;
                        BUS.clsHoaDon hd = new BUS.clsHoaDon(dgvHoaDon.Rows[j].Cells["clTenMon"].Value.ToString(), SL, DonGia, ThanhTien, STTBanGop);
                        hd.ThemHoaDon(conn);
                        TongCong = float.Parse(ban.LoadTongCong(conn, STTBanGop).Rows[0][0].ToString());
                    }

                }
                HD.XoaHoaDon(conn, STTBan);
                ban.CapNhatTrangThaiBan(conn, "TRỐNG", 0, lbBan.Text);
                ban.CapNhatTrangThaiBan(conn, "CÓ NGƯỜI", TongCong, cbGop.Text);
                
                this.Close();
                PutTable_Load(sender, e);
            }
        }
    }
}
