using System;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace RestaurantManager.GUI
{
    public partial class fAddMenu : Form
    {
        SqlConnection conn { get; set; }
        string flag = "";
        int ID { get; set; }
        string DK { get; set; }
        public fAddMenu(SqlConnection conn,int ID)
        {
            InitializeComponent();
            this.conn = conn;
            flag = "add";
            this.ID = ID;
        }
        public fAddMenu(SqlConnection conn,string Text,string Gia,string DonVi,int ID)
        {
            InitializeComponent();
            this.conn = conn;
            flag = "edit";
            this.ID = ID;
            txtTen.Text = Text;
            numGia.Value = int.Parse(Gia);
            txtDonVi.Text = DonVi;
            DK = Text;

        }
        bool CheckNhap()
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTen.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDonVi.Text))
            {
                MessageBox.Show("Bạn chưa nhập Đơn vị!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDonVi.Focus();
                return false;
            }
            return true;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (CheckNhap())
            {
                BUS.clsThucDon TD = new BUS.clsThucDon(txtTen.Text, float.Parse(numGia.Value.ToString()),txtDonVi.Text,ID);
                if (flag == "add")
                {
                    TD.InsertThucDon(conn);
                  
                    this.Close();
                }
                if (flag == "edit")
                {
                    TD.UpdateThucDon(conn, DK);
                    
                    this.Close();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fAddMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
