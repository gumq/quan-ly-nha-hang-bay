namespace RestaurantManager.GUI
{
    partial class fPaymenthistory
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPaymenthistory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clKhuVuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTongCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNguoiThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeTu = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDen = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbTheoNgay = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTheoNgay = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dateNgay = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTheoThang = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateNam = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTheoKhoangNgay = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTongDoanhThu = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.grbTheoNgay.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvLichSu);
            this.panel1.Location = new System.Drawing.Point(10, 263);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 483);
            this.panel1.TabIndex = 0;
            // 
            // dgvLichSu
            // 
            this.dgvLichSu.AllowUserToAddRows = false;
            this.dgvLichSu.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clKhuVuc,
            this.clTenBan,
            this.clNgay,
            this.clThoiGian,
            this.clTongCong,
            this.clNguoiThanhToan,
            this.clGhiChu});
            this.dgvLichSu.GridColor = System.Drawing.Color.Chocolate;
            this.dgvLichSu.Location = new System.Drawing.Point(4, 10);
            this.dgvLichSu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.ReadOnly = true;
            this.dgvLichSu.RowHeadersWidth = 51;
            this.dgvLichSu.Size = new System.Drawing.Size(1231, 473);
            this.dgvLichSu.TabIndex = 1;
            // 
            // clSTT
            // 
            this.clSTT.DataPropertyName = "STT";
            this.clSTT.HeaderText = "STT";
            this.clSTT.MinimumWidth = 6;
            this.clSTT.Name = "clSTT";
            this.clSTT.ReadOnly = true;
            this.clSTT.Width = 50;
            // 
            // clKhuVuc
            // 
            this.clKhuVuc.DataPropertyName = "KhuVuc";
            this.clKhuVuc.HeaderText = "Khu vực";
            this.clKhuVuc.MinimumWidth = 6;
            this.clKhuVuc.Name = "clKhuVuc";
            this.clKhuVuc.ReadOnly = true;
            this.clKhuVuc.Width = 150;
            // 
            // clTenBan
            // 
            this.clTenBan.DataPropertyName = "TenBan";
            this.clTenBan.HeaderText = "Tên bàn";
            this.clTenBan.MinimumWidth = 6;
            this.clTenBan.Name = "clTenBan";
            this.clTenBan.ReadOnly = true;
            this.clTenBan.Width = 150;
            // 
            // clNgay
            // 
            this.clNgay.DataPropertyName = "Ngay";
            this.clNgay.HeaderText = "Ngày";
            this.clNgay.MinimumWidth = 6;
            this.clNgay.Name = "clNgay";
            this.clNgay.ReadOnly = true;
            this.clNgay.Width = 150;
            // 
            // clThoiGian
            // 
            this.clThoiGian.DataPropertyName = "ThoiGian";
            this.clThoiGian.HeaderText = "Thời gian";
            this.clThoiGian.MinimumWidth = 6;
            this.clThoiGian.Name = "clThoiGian";
            this.clThoiGian.ReadOnly = true;
            this.clThoiGian.Width = 150;
            // 
            // clTongCong
            // 
            this.clTongCong.DataPropertyName = "TongCong";
            this.clTongCong.HeaderText = "Tổng cộng";
            this.clTongCong.MinimumWidth = 6;
            this.clTongCong.Name = "clTongCong";
            this.clTongCong.ReadOnly = true;
            this.clTongCong.Width = 150;
            // 
            // clNguoiThanhToan
            // 
            this.clNguoiThanhToan.DataPropertyName = "NguoiThanhToan";
            this.clNguoiThanhToan.HeaderText = "Trực ca";
            this.clNguoiThanhToan.MinimumWidth = 6;
            this.clNguoiThanhToan.Name = "clNguoiThanhToan";
            this.clNguoiThanhToan.ReadOnly = true;
            this.clNguoiThanhToan.Width = 200;
            // 
            // clGhiChu
            // 
            this.clGhiChu.DataPropertyName = "GhiChu";
            this.clGhiChu.HeaderText = "Ghi chú";
            this.clGhiChu.MinimumWidth = 6;
            this.clGhiChu.Name = "clGhiChu";
            this.clGhiChu.ReadOnly = true;
            this.clGhiChu.Width = 300;
            // 
            // dateTimeTu
            // 
            this.dateTimeTu.CustomFormat = "MM/dd/yyyy";
            this.dateTimeTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeTu.Location = new System.Drawing.Point(153, 25);
            this.dateTimeTu.Name = "dateTimeTu";
            this.dateTimeTu.Size = new System.Drawing.Size(117, 27);
            this.dateTimeTu.TabIndex = 1;
            this.dateTimeTu.Value = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimeDen
            // 
            this.dateTimeDen.CustomFormat = "MM/dd/yyyy";
            this.dateTimeDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDen.Location = new System.Drawing.Point(153, 73);
            this.dateTimeDen.Name = "dateTimeDen";
            this.dateTimeDen.Size = new System.Drawing.Size(117, 27);
            this.dateTimeDen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến ngày:";
            // 
            // grbTheoNgay
            // 
            this.grbTheoNgay.BackColor = System.Drawing.Color.HotPink;
            this.grbTheoNgay.Controls.Add(this.label3);
            this.grbTheoNgay.Controls.Add(this.btnTheoNgay);
            this.grbTheoNgay.Controls.Add(this.dateNgay);
            this.grbTheoNgay.Location = new System.Drawing.Point(14, 12);
            this.grbTheoNgay.Name = "grbTheoNgay";
            this.grbTheoNgay.Size = new System.Drawing.Size(319, 163);
            this.grbTheoNgay.TabIndex = 3;
            this.grbTheoNgay.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lựa chọn ngày:";
            // 
            // btnTheoNgay
            // 
            this.btnTheoNgay.BackColor = System.Drawing.Color.Tomato;
            this.btnTheoNgay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTheoNgay.ImageIndex = 1;
            this.btnTheoNgay.ImageList = this.imageList1;
            this.btnTheoNgay.Location = new System.Drawing.Point(0, 101);
            this.btnTheoNgay.Name = "btnTheoNgay";
            this.btnTheoNgay.Size = new System.Drawing.Size(319, 62);
            this.btnTheoNgay.TabIndex = 4;
            this.btnTheoNgay.Text = "Thống kê theo ngày";
            this.btnTheoNgay.UseVisualStyleBackColor = false;
            this.btnTheoNgay.Click += new System.EventHandler(this.btnTheoNgay_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "image_preview.png");
            this.imageList1.Images.SetKeyName(1, "calendar.png");
            this.imageList1.Images.SetKeyName(2, "month-png-5.png");
            this.imageList1.Images.SetKeyName(3, "Iconshock-Real-Vista-Text-Print.ico");
            // 
            // dateNgay
            // 
            this.dateNgay.CustomFormat = "MM/dd/yyyy";
            this.dateNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgay.Location = new System.Drawing.Point(186, 29);
            this.dateNgay.Name = "dateNgay";
            this.dateNgay.Size = new System.Drawing.Size(127, 27);
            this.dateNgay.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Controls.Add(this.cbThang);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnTheoThang);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateNam);
            this.groupBox2.Location = new System.Drawing.Point(348, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 163);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // cbThang
            // 
            this.cbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbThang.Location = new System.Drawing.Point(182, 21);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(107, 30);
            this.cbThang.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lựa chọn năm:";
            // 
            // btnTheoThang
            // 
            this.btnTheoThang.BackColor = System.Drawing.Color.Tomato;
            this.btnTheoThang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTheoThang.ImageIndex = 2;
            this.btnTheoThang.ImageList = this.imageList1;
            this.btnTheoThang.Location = new System.Drawing.Point(0, 101);
            this.btnTheoThang.Name = "btnTheoThang";
            this.btnTheoThang.Size = new System.Drawing.Size(316, 62);
            this.btnTheoThang.TabIndex = 4;
            this.btnTheoThang.Text = "Thống kê theo tháng";
            this.btnTheoThang.UseVisualStyleBackColor = false;
            this.btnTheoThang.Click += new System.EventHandler(this.btnTheoThang_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lựa chọn tháng:";
            // 
            // dateNam
            // 
            this.dateNam.CustomFormat = "yyyy";
            this.dateNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNam.Location = new System.Drawing.Point(182, 68);
            this.dateNam.Name = "dateNam";
            this.dateNam.Size = new System.Drawing.Size(107, 27);
            this.dateNam.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Navy;
            this.groupBox3.Controls.Add(this.dateTimeTu);
            this.groupBox3.Controls.Add(this.btnTheoKhoangNgay);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dateTimeDen);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(680, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 163);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // btnTheoKhoangNgay
            // 
            this.btnTheoKhoangNgay.BackColor = System.Drawing.Color.Tomato;
            this.btnTheoKhoangNgay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTheoKhoangNgay.ImageIndex = 0;
            this.btnTheoKhoangNgay.ImageList = this.imageList1;
            this.btnTheoKhoangNgay.Location = new System.Drawing.Point(0, 101);
            this.btnTheoKhoangNgay.Name = "btnTheoKhoangNgay";
            this.btnTheoKhoangNgay.Size = new System.Drawing.Size(330, 62);
            this.btnTheoKhoangNgay.TabIndex = 4;
            this.btnTheoKhoangNgay.Text = "Thống kê theo khoảng ngày";
            this.btnTheoKhoangNgay.UseVisualStyleBackColor = false;
            this.btnTheoKhoangNgay.Click += new System.EventHandler(this.btnTheoKhoangNgay_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(580, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tổng doanh thu:";
            // 
            // lbTongDoanhThu
            // 
            this.lbTongDoanhThu.BackColor = System.Drawing.Color.White;
            this.lbTongDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTongDoanhThu.ForeColor = System.Drawing.Color.Red;
            this.lbTongDoanhThu.Location = new System.Drawing.Point(764, 212);
            this.lbTongDoanhThu.Name = "lbTongDoanhThu";
            this.lbTongDoanhThu.Size = new System.Drawing.Size(246, 31);
            this.lbTongDoanhThu.TabIndex = 4;
            this.lbTongDoanhThu.Text = "0.VNĐ";
            this.lbTongDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.ImageIndex = 3;
            this.btnRefresh.Location = new System.Drawing.Point(12, 181);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(57, 52);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("#9Slide03 Quicksand Bold", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(14, 184);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(279, 64);
            this.label7.TabIndex = 20;
            this.label7.Text = "THỐNG KÊ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fPaymenthistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1259, 760);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbTongDoanhThu);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbTheoNgay);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fPaymenthistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch sử thanh toán";
            this.Load += new System.EventHandler(this.fPaymenthistory_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.grbTheoNgay.ResumeLayout(false);
            this.grbTheoNgay.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvLichSu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTongCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNguoiThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhiChu;
        private System.Windows.Forms.DateTimePicker dateTimeTu;
        private System.Windows.Forms.DateTimePicker dateTimeDen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbTheoNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTheoNgay;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DateTimePicker dateNgay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTheoThang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateNam;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTheoKhoangNgay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTongDoanhThu;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label7;
    }
}