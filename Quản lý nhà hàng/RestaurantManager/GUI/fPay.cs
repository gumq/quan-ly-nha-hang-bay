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
    public partial class fPay : Form
    {
        SqlConnection conn { get; set; }
        string TenBan { get; set; }
        string date { get; set; }
        string time { get; set; }
        string KhuVuc { get; set; }
        float tc { get; set; }
        string TrucCa { get; set; }
        int STTBan { get; set; }
        public fPay(SqlConnection conn,string KhuVuc,string TenBan,string date,string time,float tc,string TrucCa,int STT)
        {
            InitializeComponent();
            this.conn = conn;
            this.TenBan = TenBan;
            this.date = date;
            this.time = time;
            this.KhuVuc = KhuVuc;
            this.tc = tc;
            this.TrucCa = TrucCa;
            STTBan = STT;
        }

        private void fPay_Load(object sender, EventArgs e)
        {
            BUS.clsHoaDon HD = new BUS.clsHoaDon();
            lbBan.Text += TenBan;
            lbTime.Text += time;
            lbDate.Text += date;
            dgvHoaDon.DataSource = HD.LoadHoaDon(conn, STTBan);
            for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
            {
                dgvHoaDon.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Xác nhận thanh toán!","Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                BUS.clsHoaDon HD = new BUS.clsHoaDon();
                BUS.clsBan ban = new BUS.clsBan();
                BUS.clsLichSu LS = new BUS.clsLichSu(KhuVuc,TenBan,date,time,tc.ToString(),TrucCa,txtGhiChu.Text);
                LS.InsertLichSu(conn);
                HD.XoaHoaDon(conn, STTBan);
                ban.CapNhatTrangThaiBan(conn,"TRỐNG",0,TenBan);
                
            }
            this.Close();
        }
    }
}
