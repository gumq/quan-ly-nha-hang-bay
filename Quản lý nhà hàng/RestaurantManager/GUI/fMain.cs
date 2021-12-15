using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RestaurantManager.GUI
{
    public partial class fMain : Form
    {
        private SqlConnection conn { get; set; }
        int STTBan = 0;
        private string pass { get; set; }
        public fMain(SqlConnection conn,string pass,int id)
        {
            InitializeComponent();
            this.conn = conn;
            this.pass = pass;
            if (id==0)
            {
                menuToolStripMenuItem.Visible = false;
            }
        }
        void loadTable()
        {
            BUS.clsBan Ban = new BUS.clsBan();
            pnlTable.Controls.Clear();
            int ID = Convert.ToInt32(cbKhuVuc.SelectedValue);
            DataTable table = new DataTable();
            if (ID == 0)
            {
                table = Ban.LoadBan(conn);
            }
            else
            {
                table = Ban.LoadBanByID(conn,ID);
            }
            int x = 10;
            int y = 10;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                Button btn = new Button()
                {
                    Name = "btnTable" + i,
                    Text = table.Rows[i]["TenBan"].ToString(), //ten ban
                    Tag = table.Rows[i]["TongCong"].ToString(), //tong tien
                    Width = 100,
                    Height = 50,
                    Location = new Point(x, y),
                };
                btn.BackColor = Color.White;
                btn.BackgroundImage = Properties.Resources.lgtable;
                btn.BackgroundImageLayout = ImageLayout.Zoom;
                btn.TextAlign = ContentAlignment.BottomCenter;
                if (x < pnlTable.Width - 220)
                {
                    x += 110;
                }
                else
                {
                    x = 10;
                    y += 60;
                }
                if (table.Rows[i]["TrangThai"].ToString() == "TRỐNG")
                {
                    btn.BackColor = Color.White;
                    btn.ContextMenuStrip = CMSTrong;
                }
                else if (table.Rows[i]["TrangThai"].ToString() == "CÓ NGƯỜI")
                {
                    btn.BackColor = Color.LimeGreen;
                    btn.ContextMenuStrip = CMSCoNguoi;
                }
                else if (table.Rows[i]["TrangThai"].ToString() == "ĐẶT TRƯỚC")
                {
                    btn.BackColor = Color.Yellow;
                    btn.ContextMenuStrip = CMSDatTruoc;
                }
                btn.Click += btn_Click;
                btn.MouseHover += btn_MouseHover;
                pnlTable.Controls.Add(btn);
            }
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

        }
        private void fMain_Load(object sender, EventArgs e)
        {
            loadCBMuc();
            loadTable();
            loadThucDon();
 
            lbTenQL.Text = @"";

        }
        void loadCBMuc()
        {
            BUS.clsKhuVuc KV = new BUS.clsKhuVuc();
            BUS.clsDanhMuc DM = new BUS.clsDanhMuc();
            DataTable table = KV.LoadKhuVuc(conn);
            cbKhuVuc.DisplayMember = "TenKhuVuc";
            cbKhuVuc.ValueMember = "ID";
            cbKhuVuc.DataSource = table;
            DataTable table2 = DM.LoadDanhMuc(conn);
            cbDanhMuc.DisplayMember = "TenDanhMuc";
            cbDanhMuc.ValueMember = "ID";
            cbDanhMuc.DataSource = table2;
        }
      

        private void cbKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTable();
        }

        private void cbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadThucDon();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            loadChuot(sender, e);
        }
        private void btn_MouseHover(object sender, EventArgs e)
        {
            loadChuot(sender, e);
        }
        private float TongCong { get; set; }
        void loadChuot(object sender, EventArgs e)
        {
            BUS.clsBan ban = new BUS.clsBan();
            lbBan.Text = ((Button)sender).Text;
            STTBan = int.Parse(ban.LaySTTBan(conn, lbBan.Text).Rows[0][0].ToString());
            if (((Button)sender).BackColor == Color.White)
            {
                lbTrangThai.Text = "TRỐNG";
            }
            else if (((Button)sender).BackColor == Color.LimeGreen)
            {
                lbTrangThai.Text = "CÓ NGƯỜI";
            }
            else if (((Button)sender).BackColor == Color.Yellow)
            {
                lbTrangThai.Text = "ĐẶT TRƯỚC";
            }
            lbTongCong.Text = ((Button)sender).Tag.ToString() + " VNĐ";
            TongCong = float.Parse(((Button)sender).Tag.ToString());
            loadHoaDon();
            loadTenKV();
        }
        void loadTenKV()
        {
            BUS.clsKhuVuc KV = new BUS.clsKhuVuc();
            lbKhuVuc.Text = KV.LayTenKV(conn,lbBan.Text).Rows[0][0].ToString();
        }
        void loadHoaDon()
        {
            BUS.clsHoaDon HD = new BUS.clsHoaDon();
            dgvHoaDon.DataSource = HD.LoadHoaDon(conn,STTBan);
            for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
            {
                dgvHoaDon.Rows[i].Cells["clSTT"].Value = i + 1;
            }
        }
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void lịchSửThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.fPaymenthistory f = new fPaymenthistory(conn);
            f.ShowDialog();
        }

        private void đặtGiữBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BUS.clsBan ban = new BUS.clsBan();
            ban.CapNhatTrangThaiBan(conn, "ĐẶT TRƯỚC", 0, lbBan.Text);
            loadTable();
        }
        void ThemMon(object sender, EventArgs e)
        {
            fAddFood f = new fAddFood(conn, STTBan,lbBan.Text);
            f.ShowDialog();
            fMain_Load(sender, e);
        }
        private void thêmMónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThemMon(sender, e);
        }

        private void thêmMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemMon(sender, e);
        }

        private void chuyểnBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNextTable f = new fNextTable(conn, lbBan.Text, TongCong,STTBan);
            f.ShowDialog();
            fMain_Load(sender, e);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            fAddFood f = new fAddFood(conn,STTBan, lbBan.Text);
            f.ShowDialog();
            fMain_Load(sender, e);
        }

        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BUS.clsBan Ban = new BUS.clsBan();
            if (MessageBox.Show("Bàn này đã có người đặt! bạn xác nhận mở khóa!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Ban.CapNhatTrangThaiBan(conn, "TRỐNG", 0, lbBan.Text);
            }
            fMain_Load(sender, e);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gộpBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPutTable f = new fPutTable(conn, lbBan.Text,STTBan);
            f.ShowDialog();
            fMain_Load(sender, e);
        }

        private void trảMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBackFood f = new fBackFood(conn, lbBan.Text, TongCong,STTBan);
            f.ShowDialog();
            fMain_Load(sender, e);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (CheckThanhToan())
            {
                fPay f = new fPay(conn, lbKhuVuc.Text, lbBan.Text, date.Text.ToString(), lbTime.Text, TongCong, lbTenQL.Text,STTBan);
                f.ShowDialog();
                fMain_Load(sender, e);
            }
        }
        bool CheckThanhToan()
        {
            if (lbKhuVuc.Text == "" && lbBan.Text == "" && lbTrangThai.Text == "")
            {
                MessageBox.Show("Bạn chưa lựa chọn bàn để thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (lbTrangThai.Text == "TRỐNG" || lbTrangThai.Text == "ĐẶT TRƯỚC")
            {
                MessageBox.Show("Bàn hiện tại trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string HoaDon = "";
           
            HoaDon += "\tQUẢN LÝ NHÀ HÀNG\n";
            HoaDon += "\n\t          HÓA ĐƠN \n" + lbBan.Text + "\n";
            HoaDon += "Thời gian: " + lbTime.Text + ". " + date.Text + "\n";
            HoaDon += "--------------------------------------------------------------\n";
            HoaDon += "STT  TÊN\t\tSỐ LƯỢNG\tĐƠN GIÁ\tTHÀNH TIỀN\n";
            HoaDon += "--------------------------------------------------------------\n";
            HoaDon += printFood();
            HoaDon += "\nTổng cộng: " + lbTongCong.Text+"\n";
            e.Graphics.DrawString(HoaDon, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 100, 200);
        }
        string printFood()
        {
            string pr = "";
            for(int i = 0; i < dgvHoaDon.RowCount; i++)
            {
                pr += (i+1) +"\t"+ dgvHoaDon.Rows[i].Cells["clTenMon"].Value.ToString()+"\t"+
                    dgvHoaDon.Rows[i].Cells["clSoLuong"].Value.ToString() +" "+
                    dgvHoaDon.Rows[i].Cells["clDonGia"].Value.ToString() +" "+
                    dgvHoaDon.Rows[i].Cells["clThanhTien"].Value.ToString() + "\n";
            }
            return pr;
        }
        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckThanhToan())
            {
                fPay f = new fPay(conn, lbKhuVuc.Text, lbBan.Text, date.Text.ToString(), lbTime.Text, TongCong, lbTenQL.Text,STTBan);
                f.ShowDialog();
                fMain_Load(sender, e);
            }
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fEmployees f = new fEmployees(conn);
            f.ShowDialog();
        }

        private void quảnLýDanhSáchBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTable f = new fTable(conn);
            f.ShowDialog();
            fMain_Load(sender, e);
        }

        private void quảnLýThựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fFood f = new fFood(conn);
            f.ShowDialog();
            fMain_Load(sender, e);
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            fBlock f = new fBlock(pass,lbTenQL.Text);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                printDialog1.Document = printDocument1;
                if (printDialog1.ShowDialog()== DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
            catch
            {
                MessageBox.Show("Không thể in hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            fgioithieu gioithieu = new fgioithieu();
            gioithieu.ShowDialog();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
           
        }

        private void lbTime_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pnlTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pHẢNHỒIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fphanhoi phanhoi = new fphanhoi();
            phanhoi.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK)
            {
                Application.Exit();
            }
           
        }
    }
}
