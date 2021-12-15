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

namespace RestaurantManager
{
    public partial class fLogin : Form
    {
        private SqlConnection conn { get; set; }
        public fLogin(SqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
          
        }
        bool CheckNhap()
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK)
            {
                e.Cancel = true;
            } 
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            cbQuyen.Text = "Quản lý";
            BUS.clsDangNhap DN = new BUS.clsDangNhap();
            DataTable table = DN.LoadNhoMatKhau(conn);
            if (table.Rows[0][0].ToString() != "qwerasdfzxcv")
            {
                txtTenDangNhap.Text = table.Rows[0][0].ToString();
                txtMatKhau.Text = table.Rows[0][1].ToString();
                CheckRemember.Checked = true;

            }
            else
            {
                txtTenDangNhap.Text = "";
                txtMatKhau.Text = "";
                CheckRemember.Checked = false;
            }
            
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
                    }

        private void btnDangNhap1_Click(object sender, EventArgs e)
        {
            BUS.clsDangNhap DN = new BUS.clsDangNhap(txtTenDangNhap.Text, txtMatKhau.Text);
            if (CheckNhap())
            {
                int ID;
                if (cbQuyen.Text == "Quản lý")
                    ID = 1;
                else
                {
                    ID = 0;
                }
                if (DN.CheckDangNhap(conn, ID) == true)
                {
                    if (CheckRemember.Checked == true)
                    {
                        DN.NhoMK(conn);
                    }
                    else
                    {
                        DN.HuyNhoMK(conn);
                    }
                    GUI.fMain f = new GUI.fMain(conn, txtMatKhau.Text, ID);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                    fLogin_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thông tin tài khoản hoặc mật khẩu không chính xác!", "Thất bại!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
