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
    public partial class fEmployees : Form
    {
        string flag = "";
        SqlConnection conn;
        public fEmployees(SqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }
        void loadNhanVien()
        {
            BUS.clsNhanVien NV = new BUS.clsNhanVien();
            dgvNhanVien.DataSource = NV.LoadNhanVien(conn);
            DataBinding();
        }
        void DataBinding()
        {
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", dgvNhanVien.DataSource, "MaNV");
            txtHoNV.DataBindings.Clear();
            txtHoNV.DataBindings.Add("Text", dgvNhanVien.DataSource, "HoNV");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dgvNhanVien.DataSource, "TenNV");
            cbGioiTinh.DataBindings.Clear();
            cbGioiTinh.DataBindings.Add("Text", dgvNhanVien.DataSource, "GioiTinh");
            dateNgaySinh.DataBindings.Clear();
            dateNgaySinh.DataBindings.Add("Text", dgvNhanVien.DataSource, "NgaySinh");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgvNhanVien.DataSource, "SDT");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvNhanVien.DataSource, "DiaChi");
        }
        void LockControl()
        {
            txtMaNV.ReadOnly = true;
            txtTen.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtHoNV.ReadOnly = true;
            cbGioiTinh.Enabled = false;
            dateNgaySinh.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
        void UnlockControl()
        {
            txtMaNV.ReadOnly = false;
            txtTen.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtHoNV.ReadOnly = false;
            cbGioiTinh.Enabled = true;
            dateNgaySinh.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void fManager_Load(object sender, EventArgs e)
        {
            loadNhanVien();
            LockControl();
        }
        void ClearTextBox()
        {
            txtMaNV.Text = "";
            txtHoNV.Text = "";
            txtTen.Text = "";
            cbGioiTinh.Text = "";
            dateNgaySinh.Text = "12/30/1990";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            UnlockControl();
            ClearTextBox();
            txtMaNV.Focus();
            flag = "Add";
        }
        bool CheckNhap()
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtHoNV.Text))
            {
                MessageBox.Show("Bạn chưa nhập họ nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoNV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbGioiTinh.Text))
            {
                MessageBox.Show("Bạn chưa lựa chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbGioiTinh.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return false;
            }
            return true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (CheckNhap())
            {
                BUS.clsNhanVien NV = new BUS.clsNhanVien(txtMaNV.Text, txtHoNV.Text, txtTen.Text, cbGioiTinh.Text, dateNgaySinh.Text, txtSDT.Text, txtDiaChi.Text);
                if (flag == "Add")
                {
                    NV.InsertNhanVien(conn);
                   
                    loadNhanVien();
                }
                if (flag == "Edit")
                {
                    NV.UpdateNhanVien(conn,DK);
                   
                    loadNhanVien();
                }
                LockControl();
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            fManager_Load(sender, e);
        }
        string DK = "";
        private void btnSua_Click(object sender, EventArgs e)
        {
            UnlockControl();
            txtMaNV.Focus();
            flag = "Edit";
            DK = txtMaNV.Text;
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            BUS.clsNhanVien NV = new BUS.clsNhanVien();
            if (radioTheoMa.Checked == true)
            {
                dgvNhanVien.DataSource = NV.TimKiemTheoMaNV(conn, txtTimKiem.Text);
                DataBinding();
            }
            if (radioTheoTen.Checked == true)
            {
                dgvNhanVien.DataSource = NV.TimKiemTheoTenNV(conn, txtTimKiem.Text);
                DataBinding();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                BUS.clsNhanVien NV = new BUS.clsNhanVien();
                NV.DeleteNhanVien(conn, txtMaNV.Text);
                
                fManager_Load(sender, e);
            }
        }
    }
}
