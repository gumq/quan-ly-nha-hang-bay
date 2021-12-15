namespace RestaurantManager.GUI
{
    partial class fConnect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fConnect));
            this.lbTen = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMK = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbXacThuc = new System.Windows.Forms.ComboBox();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.btnKetNoi = new System.Windows.Forms.Button();
            this.txbTenNguoiDung = new System.Windows.Forms.TextBox();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.txbTenMayChu = new System.Windows.Forms.TextBox();
            this.txbCSDL = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(4, 225);
            this.lbTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(155, 25);
            this.lbTen.TabIndex = 1;
            this.lbTen.Text = "Tên người dùng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 168);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Xác thực:";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên CSDL:";
            // 
            // lbMK
            // 
            this.lbMK.AutoSize = true;
            this.lbMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMK.Location = new System.Drawing.Point(68, 282);
            this.lbMK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMK.Name = "lbMK";
            this.lbMK.Size = new System.Drawing.Size(99, 25);
            this.lbMK.TabIndex = 1;
            this.lbMK.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên máy chủ:";
            // 
            // cbXacThuc
            // 
            this.cbXacThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbXacThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbXacThuc.FormattingEnabled = true;
            this.cbXacThuc.Items.AddRange(new object[] {
            "Windows authentication",
            "SQL sever authentication"});
            this.cbXacThuc.Location = new System.Drawing.Point(181, 162);
            this.cbXacThuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbXacThuc.Name = "cbXacThuc";
            this.cbXacThuc.Size = new System.Drawing.Size(328, 33);
            this.cbXacThuc.TabIndex = 2;
            this.cbXacThuc.SelectedIndexChanged += new System.EventHandler(this.cbXacThuc_SelectedIndexChanged);
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMatKhau.Location = new System.Drawing.Point(181, 279);
            this.txbMatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(328, 30);
            this.txbMatKhau.TabIndex = 4;
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnKetNoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKetNoi.FlatAppearance.BorderSize = 0;
            this.btnKetNoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetNoi.Location = new System.Drawing.Point(379, 335);
            this.btnKetNoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(132, 52);
            this.btnKetNoi.TabIndex = 6;
            this.btnKetNoi.Text = "Kết nối";
            this.btnKetNoi.UseVisualStyleBackColor = false;
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // txbTenNguoiDung
            // 
            this.txbTenNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenNguoiDung.Location = new System.Drawing.Point(181, 220);
            this.txbTenNguoiDung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbTenNguoiDung.Name = "txbTenNguoiDung";
            this.txbTenNguoiDung.Size = new System.Drawing.Size(328, 30);
            this.txbTenNguoiDung.TabIndex = 3;
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnKiemTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKiemTra.Location = new System.Drawing.Point(181, 335);
            this.btnKiemTra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(132, 52);
            this.btnKiemTra.TabIndex = 5;
            this.btnKiemTra.Text = "kiểm tra";
            this.btnKiemTra.UseVisualStyleBackColor = false;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // txbTenMayChu
            // 
            this.txbTenMayChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenMayChu.Location = new System.Drawing.Point(181, 48);
            this.txbTenMayChu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbTenMayChu.Name = "txbTenMayChu";
            this.txbTenMayChu.Size = new System.Drawing.Size(328, 30);
            this.txbTenMayChu.TabIndex = 0;
            // 
            // txbCSDL
            // 
            this.txbCSDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCSDL.Location = new System.Drawing.Point(181, 108);
            this.txbCSDL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbCSDL.Name = "txbCSDL";
            this.txbCSDL.Size = new System.Drawing.Size(328, 30);
            this.txbCSDL.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.txbCSDL);
            this.groupBox1.Controls.Add(this.txbTenMayChu);
            this.groupBox1.Controls.Add(this.btnKiemTra);
            this.groupBox1.Controls.Add(this.txbTenNguoiDung);
            this.groupBox1.Controls.Add(this.btnKetNoi);
            this.groupBox1.Controls.Add(this.txbMatKhau);
            this.groupBox1.Controls.Add(this.cbXacThuc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbMK);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbTen);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(-1, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(594, 621);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // fConnect
            // 
            this.AcceptButton = this.btnKetNoi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(588, 615);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "fConnect";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết nối cơ sở dữ liệu";
            this.Load += new System.EventHandler(this.fConnect_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbXacThuc;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.Button btnKetNoi;
        private System.Windows.Forms.TextBox txbTenNguoiDung;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.TextBox txbTenMayChu;
        private System.Windows.Forms.TextBox txbCSDL;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}