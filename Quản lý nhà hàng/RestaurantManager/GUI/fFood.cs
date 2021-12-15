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
    public partial class fFood : Form
    {
        SqlConnection conn { get; set; }
        public fFood(SqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }
        private void btnThemDM_Click(object sender, EventArgs e)
        {
            fUpdate f = new fUpdate(conn,"addDM");
            f.ShowDialog();
            fFood_Load(sender, e);
        }

        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbDanhMuc.SelectedValue);
            fUpdate f = new fUpdate(conn,cbDanhMuc.Text,id,"editDM");
            f.ShowDialog();
            fFood_Load(sender, e);
        }

        private void fFood_Load(object sender, EventArgs e)
        {
            BUS.clsDanhMuc DM = new BUS.clsDanhMuc();
            DataTable table = DM.LoadDSDanhMuc(conn);
            cbDanhMuc.ValueMember = "ID";
            cbDanhMuc.DisplayMember = "TenDanhMuc";
            cbDanhMuc.DataSource = table;
            loadThucDon();
        }
        void loadThucDon()
        {
            BUS.clsThucDon TD = new BUS.clsThucDon();
            int id = Convert.ToInt32(cbDanhMuc.SelectedValue);
            dgvThucDon.DataSource = TD.LoadThucDonByID(conn, id);
            for (int i = 0; i < dgvThucDon.Rows.Count; i++)
            {
                dgvThucDon.Rows[i].Cells["clSTT"].Value = i + 1;
            }
        }

        private void btnXoaDM_Click(object sender, EventArgs e)
        {
            if (dgvThucDon.Rows.Count > 0)
            {
                MessageBox.Show("Danh mục còn dữ liệu không thể xóa!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Xác nhận xóa!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    BUS.clsDanhMuc DM = new BUS.clsDanhMuc();
                    int id = Convert.ToInt32(cbDanhMuc.SelectedValue);
                    DM.DeleteDanhMuc(conn, id);
                    
                    fFood_Load(sender, e);
                }
            }
        }

        private void cbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadThucDon();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(cbDanhMuc.SelectedValue);
            fAddMenu f = new fAddMenu(conn, ID);
            f.ShowDialog();
            fFood_Load(sender, e);
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(cbDanhMuc.SelectedValue);
            string Ten = dgvThucDon.Rows[dgvThucDon.CurrentCell.RowIndex].Cells["clTenMonAn"].Value.ToString();
            string Gia = dgvThucDon.Rows[dgvThucDon.CurrentCell.RowIndex].Cells["clGia"].Value.ToString();
            string DonVi = dgvThucDon.Rows[dgvThucDon.CurrentCell.RowIndex].Cells["clDonVi"].Value.ToString();
            fAddMenu f = new fAddMenu(conn,Ten,Gia,DonVi,ID);
            f.ShowDialog();
            fFood_Load(sender, e);
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                BUS.clsThucDon TD = new BUS.clsThucDon();
                int ID = Convert.ToInt32(cbDanhMuc.SelectedValue);
                string Ten = dgvThucDon.Rows[dgvThucDon.CurrentCell.RowIndex].Cells["clTenMonAn"].Value.ToString();
                TD.DeleteThucDon(conn, Ten,ID);
               
                fFood_Load(sender, e);
            }
        }

        private void lbBan_Click(object sender, EventArgs e)
        {

        }
    }
}
