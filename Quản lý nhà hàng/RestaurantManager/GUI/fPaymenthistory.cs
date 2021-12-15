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
    public partial class fPaymenthistory : Form
    {
        SqlConnection conn { get; set; }
        public fPaymenthistory(SqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }
        void LoadTable()
        {
            BUS.clsLichSu LS = new BUS.clsLichSu();
            dgvLichSu.DataSource = LS.LoadLichSu(conn);
            loadSTT();
        }
        void loadSTT()
        {
            for (int i = 0; i < dgvLichSu.Rows.Count; i++)
            {
                dgvLichSu.Rows[i].Cells[0].Value = i + 1;
            }
        }
        float TongDoanhThu()
        {
            float Tong=0;
            for(int j = 0; j < dgvLichSu.RowCount; j++)
            {
                Tong += float.Parse(dgvLichSu.Rows[j].Cells[5].Value.ToString());
            }
            return Tong;
        }
        private void fPaymenthistory_Load(object sender, EventArgs e)
        {
            LoadTable();
            lbTongDoanhThu.Text = TongDoanhThu().ToString()+".VND";
        }

        private void btnTheoNgay_Click(object sender, EventArgs e)
        {
            BUS.clsLichSu LS = new BUS.clsLichSu();
            dgvLichSu.DataSource = LS.ThongKeTheoNgay(conn, dateNgay.Text);
            loadSTT();
            lbTongDoanhThu.Text = TongDoanhThu().ToString() + ".VND";
        }

        private void btnTheoThang_Click(object sender, EventArgs e)
        {
            BUS.clsLichSu LS = new BUS.clsLichSu();
            dgvLichSu.DataSource = LS.ThongKeTheoThang(conn, cbThang.Text,dateNam.Text);
            loadSTT();
            lbTongDoanhThu.Text = TongDoanhThu().ToString() + ".VND";
        }

        private void btnTheoKhoangNgay_Click(object sender, EventArgs e)
        {
            BUS.clsLichSu LS = new BUS.clsLichSu();
            dgvLichSu.DataSource = LS.ThongKeTheoKhoangNgay(conn, dateTimeTu.Text,dateTimeDen.Text);
            loadSTT();
            lbTongDoanhThu.Text = TongDoanhThu().ToString() + ".VND";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            fPaymenthistory_Load(sender, e);
        }

        private void btnInThongKe_Click(object sender, EventArgs e)
        {

        }

       
    }
}
