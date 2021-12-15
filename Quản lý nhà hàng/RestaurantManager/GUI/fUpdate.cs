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
    public partial class fUpdate : Form
    {
        SqlConnection conn { get; set; }
        string flag = "";
        int id { get; set; }
        string TenBan { get; set; }
        public fUpdate(SqlConnection conn,string flag)
        {
            InitializeComponent();
            this.conn = conn;
            this.flag = flag;
        }
        public fUpdate(SqlConnection conn, string flag,int id)
        {
            InitializeComponent();
            this.conn = conn;
            this.flag = flag;
            this.id = id;
        }
        public fUpdate(SqlConnection conn, string text, int id,string flag)
        {
            InitializeComponent();
            this.conn = conn;
            this.flag = flag;
            txtName.Text = text;
            this.TenBan = text;
            this.id = id;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Bạn vui nhập nhập tên mới có thể lưu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (flag == "addKV")
                {
                    BUS.clsKhuVuc KV = new BUS.clsKhuVuc(txtName.Text); 
                    KV.InsertKhuVuc(conn);
                    //MessageBox.Show("Thêm khu vực thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    
                }
                if (flag == "editKV")
                {
                    BUS.clsKhuVuc KV = new BUS.clsKhuVuc(txtName.Text);
                    KV.UpdateKhuVuc(conn,id);
                    //MessageBox.Show("Cập nhật khu vực thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                if (flag == "addTable")
                {
                    BUS.clsBan ban = new BUS.clsBan();
                    ban.InsertBan(conn, txtName.Text,id);
                   // MessageBox.Show("Thêm bàn thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                if (flag == "editTable")
                {
                    BUS.clsBan ban = new BUS.clsBan();
                    ban.UpdateBan(conn, txtName.Text,TenBan);
                    //MessageBox.Show("Cập nhật Tên bàn thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                if (flag == "addDM")
                {
                    BUS.clsDanhMuc DM = new BUS.clsDanhMuc(txtName.Text);
                    DM.InsertDanhMuc(conn);
                   // MessageBox.Show("Thêm danh mục thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                if (flag == "editDM")
                {
                    BUS.clsDanhMuc DM = new BUS.clsDanhMuc(txtName.Text);
                    DM.UpdateDanhMuc(conn,id);
                    // cffMessageBox.Show("Cập nhật danh mục thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
