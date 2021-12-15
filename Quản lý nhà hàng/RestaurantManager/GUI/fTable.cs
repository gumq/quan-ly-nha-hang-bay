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
    public partial class fTable : Form
    {
        SqlConnection conn { get; set; }
        public fTable(SqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }
        private void btnThemDM_Click(object sender, EventArgs e)
        {
            fUpdate f = new fUpdate(conn, "addKV");
            f.ShowDialog();
            fTable_Load(sender, e);
        }

        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbDanhMuc.SelectedValue);
            fUpdate f = new fUpdate(conn, cbDanhMuc.Text, id, "editKV");
            f.ShowDialog();
            fTable_Load(sender, e);
        }

        private void fTable_Load(object sender, EventArgs e)
        {
            BUS.clsKhuVuc KV = new BUS.clsKhuVuc();
            DataTable table = KV.LoadDSKhuVuc(conn);
            cbDanhMuc.ValueMember = "ID";
            cbDanhMuc.DisplayMember = "TenKhuVuc";
            cbDanhMuc.DataSource = table;
            loadBan();
        }
        void loadBan()
        {
            BUS.clsBan ban = new BUS.clsBan();
            int id = Convert.ToInt32(cbDanhMuc.SelectedValue);
            dgvTable.DataSource = ban.LoadBanByID(conn, id);
            for (int i = 0; i < dgvTable.Rows.Count; i++)
            {
                dgvTable.Rows[i].Cells["clSTT"].Value = i + 1;
            }
        }
        private void btnXoaDM_Click(object sender, EventArgs e)
        {
            if (dgvTable.RowCount > 0)
            {
                MessageBox.Show("Khu vực còn dữ liệu không thể xóa!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Xác nhận xóa!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    BUS.clsKhuVuc KV = new BUS.clsKhuVuc();
                    int id = Convert.ToInt32(cbDanhMuc.SelectedValue);
                    KV.DeleteKhuVuc(conn, id);
                   
                    fTable_Load(sender, e);
                }
            }
        }

        private void cbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadBan();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbDanhMuc.SelectedValue);
            fUpdate f = new fUpdate(conn, "addTable", id);
            f.ShowDialog();
            fTable_Load(sender, e);
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string TenBan = dgvTable.Rows[dgvTable.CurrentCell.RowIndex].Cells["clTenBan"].Value.ToString();
            int id = Convert.ToInt32(cbDanhMuc.SelectedValue);
            fUpdate f = new fUpdate(conn, TenBan, id, "editTable");
            f.ShowDialog();
            fTable_Load(sender, e);
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (dgvTable.Rows[dgvTable.CurrentCell.RowIndex].Cells["clTrangThai"].Value.ToString() == "CÓ NGƯỜI")
                {
                    MessageBox.Show("Bàn này chưa thanh toán! không thể xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    BUS.clsBan ban = new BUS.clsBan();
                    string TenBan = dgvTable.Rows[dgvTable.CurrentCell.RowIndex].Cells["clTenBan"].Value.ToString();
                    ban.DeleteBan(conn, TenBan);
                   
                    fTable_Load(sender, e);
                }
            }
        }
    }
}
