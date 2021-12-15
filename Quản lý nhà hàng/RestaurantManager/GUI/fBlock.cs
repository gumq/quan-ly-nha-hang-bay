using System;
using System.Windows.Forms;

namespace RestaurantManager.GUI
{
    public partial class fBlock : Form
    {
        private string pass { get; set; }
        private string name {get;set;}
        public fBlock(string pass,string name)
        {
            InitializeComponent();
            this.pass = pass;
            this.name = name;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text == pass)
            {
                this.Close();
            }
        }

        private void fBlock_Load(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
