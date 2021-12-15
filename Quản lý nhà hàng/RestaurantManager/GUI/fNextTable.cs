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
    public partial class fNextTable : Form
    {
        private SqlConnection conn { get; set; }
        private string TenBan { get; set; }
        private float TongCong { get; set; }
        private int STTBan { get; set; }
        public fNextTable(SqlConnection conn,string TenBan,float TongCong,int STT)
        {
            InitializeComponent();
            this.TenBan = TenBan;
            this.conn = conn;
            this.TongCong = TongCong;
            STTBan = STT;
        }
        void LoadTable()
        {
            BUS.clsBan Ban = new BUS.clsBan();
            DataTable table = Ban.LoadBanByTrangThai(conn,"TRỐNG",TenBan);
            cbToTalbe.DisplayMember = "TenBan";
            cbToTalbe.ValueMember = "ID";
            cbToTalbe.DataSource = table;
            lbBan.Text = TenBan;
        }
        void loadHoaDon()
        {
            BUS.clsHoaDon HD = new BUS.clsHoaDon();
            dgvHoaDon.DataSource = HD.LoadHoaDon(conn, STTBan);
            for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
            {
                dgvHoaDon.Rows[i].Cells["clSTT"].Value = i + 1;
            }
        }
        private void fNextTable_Load(object sender, EventArgs e)
        {
            LoadTable();
            loadHoaDon();
        }
        bool CheckSelect()
        {
            if (lbBan.Text == cbToTalbe.Text)
            {
                MessageBox.Show("Lựa chọn bàn không hợp lệ!\nVui lòng chọn lại!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            if (CheckSelect())
            {
                if (CheckTrangThai())
                {
                    BUS.clsBan ban = new BUS.clsBan();
                    BUS.clsHoaDon HD = new BUS.clsHoaDon();
                    if (MessageBox.Show("Bạn có chắc chắn chuyển từ ( " + TenBan + " ) đến bàn ( " + cbToTalbe.Text + " )", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    {
                        int STTBanGop = int.Parse(ban.LaySTTBan(conn, cbToTalbe.Text).Rows[0][0].ToString());
                        DataTable table = HD.LoadHoaDon(conn, STTBan);
                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            int SL = int.Parse(table.Rows[i][1].ToString());
                            float DonGia = float.Parse(table.Rows[i][2].ToString());
                            float ThanhTien = DonGia * SL;
                            string TenMon = table.Rows[i][0].ToString();
                            BUS.clsHoaDon hd = new BUS.clsHoaDon(TenMon, SL, DonGia, ThanhTien,STTBanGop);
                            hd.ThemHoaDon(conn);
                        }
                        ban.CapNhatTrangThaiBan(conn, "CÓ NGƯỜI", TongCong, cbToTalbe.Text);
                        ban.CapNhatTrangThaiBan(conn, "TRỐNG", 0, lbBan.Text);
                        HD.XoaHoaDon(conn, STTBan);
                        MessageBox.Show("Chuyển bàn thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }
        bool CheckTrangThai()
        {
            BUS.clsBan ban = new BUS.clsBan();
            DataTable table = ban.LoadBan(conn);
            string TrangThai="";
            for(int i = 0; i < table.Rows.Count; i++)
            {
                if (cbToTalbe.Text == table.Rows[i]["TenBan"].ToString())
                    TrangThai = table.Rows[i]["TrangThai"].ToString();
            }
            if (TrangThai=="CÓ NGƯỜI")
            {
                MessageBox.Show("Bàn này đã có người, không thể chuyển!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }else if (TrangThai == "ĐẶT TRƯỚC")
            {
                MessageBox.Show("Bàn này đã có người đặt, không thể chuyển!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
