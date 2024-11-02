namespace HotelManage
{
    partial class ManagerBill
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlTitle = new Panel();
            lbTitle = new Label();
            pnlMain = new Panel();
            lstRoom = new GroupBox();
            btnExport = new Assets.CusButton();
            dtgHoaDon = new DataGridView();
            groupBox1 = new GroupBox();
            cbMaHoaDon = new ComboBox();
            tbThanhTien = new TextBox();
            label9 = new Label();
            tbNgayTao = new TextBox();
            tbGiamGia = new TextBox();
            label6 = new Label();
            tbDonGia = new TextBox();
            label7 = new Label();
            label8 = new Label();
            tbNhanVien = new TextBox();
            label4 = new Label();
            tbTenPhong = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox4 = new GroupBox();
            btnDong = new Assets.CusButton();
            groupBox2 = new GroupBox();
            tbSearch = new TextBox();
            cbTimKiemTheo = new ComboBox();
            btnTimKiem = new Assets.CusButton();
            label5 = new Label();
            pnlTitle.SuspendLayout();
            pnlMain.SuspendLayout();
            lstRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgHoaDon).BeginInit();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BorderStyle = BorderStyle.Fixed3D;
            pnlTitle.Controls.Add(lbTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1180, 51);
            pnlTitle.TabIndex = 0;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.Teal;
            lbTitle.Location = new Point(13, 16);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(179, 25);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Quản lý hóa đơn";
            // 
            // pnlMain
            // 
            pnlMain.AutoScroll = true;
            pnlMain.Controls.Add(lstRoom);
            pnlMain.Controls.Add(groupBox1);
            pnlMain.Controls.Add(groupBox4);
            pnlMain.Controls.Add(groupBox2);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 51);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1180, 682);
            pnlMain.TabIndex = 1;
            // 
            // lstRoom
            // 
            lstRoom.Controls.Add(btnExport);
            lstRoom.Controls.Add(dtgHoaDon);
            lstRoom.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstRoom.ForeColor = Color.Teal;
            lstRoom.Location = new Point(51, 295);
            lstRoom.Name = "lstRoom";
            lstRoom.Size = new Size(1082, 524);
            lstRoom.TabIndex = 13;
            lstRoom.TabStop = false;
            lstRoom.Text = "Danh sách hóa đơn";
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.Teal;
            btnExport.BackgroundColor = Color.Teal;
            btnExport.BorderColor = Color.Teal;
            btnExport.BorderRadius = 20;
            btnExport.BorderSize = 1;
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(944, 26);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(104, 32);
            btnExport.TabIndex = 12;
            btnExport.Text = "Xuất";
            btnExport.TextColor = Color.White;
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnXuat_Click;
            // 
            // dtgHoaDon
            // 
            dtgHoaDon.BackgroundColor = SystemColors.GradientInactiveCaption;
            dtgHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgHoaDon.Location = new Point(21, 64);
            dtgHoaDon.Name = "dtgHoaDon";
            dtgHoaDon.RowHeadersWidth = 51;
            dtgHoaDon.Size = new Size(1041, 370);
            dtgHoaDon.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbMaHoaDon);
            groupBox1.Controls.Add(tbThanhTien);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(tbNgayTao);
            groupBox1.Controls.Add(tbGiamGia);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbDonGia);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(tbNhanVien);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbTenPhong);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox1.ForeColor = Color.Teal;
            groupBox1.Location = new Point(536, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(592, 250);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // cbMaHoaDon
            // 
            cbMaHoaDon.FormattingEnabled = true;
            cbMaHoaDon.Items.AddRange(new object[] { "Mã hóa đơn", "Tên khách hàng", "Số CCCD/CMND", "Số điện thoại" });
            cbMaHoaDon.Location = new Point(16, 54);
            cbMaHoaDon.Name = "cbMaHoaDon";
            cbMaHoaDon.Size = new Size(261, 27);
            cbMaHoaDon.TabIndex = 10;
            // 
            // tbThanhTien
            // 
            tbThanhTien.BorderStyle = BorderStyle.FixedSingle;
            tbThanhTien.Font = new Font("Times New Roman", 10.2F);
            tbThanhTien.Location = new Point(297, 159);
            tbThanhTien.Name = "tbThanhTien";
            tbThanhTien.Size = new Size(268, 27);
            tbThanhTien.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(297, 138);
            label9.Name = "label9";
            label9.Size = new Size(87, 19);
            label9.TabIndex = 18;
            label9.Text = "Thành tiền";
            // 
            // tbNgayTao
            // 
            tbNgayTao.BorderStyle = BorderStyle.FixedSingle;
            tbNgayTao.Font = new Font("Times New Roman", 10.2F);
            tbNgayTao.Location = new Point(16, 213);
            tbNgayTao.Name = "tbNgayTao";
            tbNgayTao.Size = new Size(261, 27);
            tbNgayTao.TabIndex = 17;
            // 
            // tbGiamGia
            // 
            tbGiamGia.BorderStyle = BorderStyle.FixedSingle;
            tbGiamGia.Font = new Font("Times New Roman", 10.2F);
            tbGiamGia.Location = new Point(297, 106);
            tbGiamGia.Name = "tbGiamGia";
            tbGiamGia.Size = new Size(268, 27);
            tbGiamGia.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(297, 84);
            label6.Name = "label6";
            label6.Size = new Size(78, 19);
            label6.TabIndex = 14;
            label6.Text = "Giảm giá";
            // 
            // tbDonGia
            // 
            tbDonGia.BorderStyle = BorderStyle.FixedSingle;
            tbDonGia.Font = new Font("Times New Roman", 10.2F);
            tbDonGia.Location = new Point(297, 53);
            tbDonGia.Name = "tbDonGia";
            tbDonGia.Size = new Size(268, 27);
            tbDonGia.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(297, 31);
            label7.Name = "label7";
            label7.Size = new Size(66, 19);
            label7.TabIndex = 12;
            label7.Text = "Đơn giá";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 190);
            label8.Name = "label8";
            label8.Size = new Size(73, 19);
            label8.TabIndex = 10;
            label8.Text = "Ngày tạo";
            // 
            // tbNhanVien
            // 
            tbNhanVien.BorderStyle = BorderStyle.FixedSingle;
            tbNhanVien.Font = new Font("Times New Roman", 10.2F);
            tbNhanVien.Location = new Point(16, 159);
            tbNhanVien.Name = "tbNhanVien";
            tbNhanVien.Size = new Size(261, 27);
            tbNhanVien.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 136);
            label4.Name = "label4";
            label4.Size = new Size(109, 19);
            label4.TabIndex = 8;
            label4.Text = "Nhân viên tạo";
            // 
            // tbTenPhong
            // 
            tbTenPhong.BorderStyle = BorderStyle.FixedSingle;
            tbTenPhong.Font = new Font("Times New Roman", 10.2F);
            tbTenPhong.Location = new Point(16, 106);
            tbTenPhong.Name = "tbTenPhong";
            tbTenPhong.Size = new Size(261, 27);
            tbTenPhong.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 83);
            label3.Name = "label3";
            label3.Size = new Size(85, 19);
            label3.TabIndex = 6;
            label3.Text = "Tên phòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 31);
            label2.Name = "label2";
            label2.Size = new Size(94, 19);
            label2.TabIndex = 4;
            label2.Text = "Mã hóa đơn";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnDong);
            groupBox4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.Teal;
            groupBox4.Location = new Point(53, 175);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(453, 97);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chức năng";
            // 
            // btnDong
            // 
            btnDong.BackColor = Color.Teal;
            btnDong.BackgroundColor = Color.Teal;
            btnDong.BorderColor = Color.Teal;
            btnDong.BorderRadius = 20;
            btnDong.BorderSize = 1;
            btnDong.FlatAppearance.BorderSize = 0;
            btnDong.FlatStyle = FlatStyle.Flat;
            btnDong.ForeColor = Color.White;
            btnDong.Location = new Point(81, 37);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(291, 35);
            btnDong.TabIndex = 11;
            btnDong.Text = "Đóng";
            btnDong.TextColor = Color.White;
            btnDong.UseVisualStyleBackColor = false;
            btnDong.Click += btnDong_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbSearch);
            groupBox2.Controls.Add(cbTimKiemTheo);
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox2.ForeColor = Color.Teal;
            groupBox2.Location = new Point(53, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(453, 135);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // tbSearch
            // 
            tbSearch.BorderStyle = BorderStyle.FixedSingle;
            tbSearch.Location = new Point(10, 81);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(259, 27);
            tbSearch.TabIndex = 9;
            // 
            // cbTimKiemTheo
            // 
            cbTimKiemTheo.FormattingEnabled = true;
            cbTimKiemTheo.Items.AddRange(new object[] { "Mã hóa đơn", "Tên khách hàng", "Số CCCD/CMND", "Số điện thoại" });
            cbTimKiemTheo.Location = new Point(132, 31);
            cbTimKiemTheo.Name = "cbTimKiemTheo";
            cbTimKiemTheo.Size = new Size(291, 27);
            cbTimKiemTheo.TabIndex = 8;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Teal;
            btnTimKiem.BackgroundColor = Color.Teal;
            btnTimKiem.BorderColor = Color.PaleVioletRed;
            btnTimKiem.BorderRadius = 20;
            btnTimKiem.BorderSize = 0;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(290, 76);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(133, 35);
            btnTimKiem.TabIndex = 7;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.TextColor = Color.White;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 31);
            label5.Name = "label5";
            label5.Size = new Size(116, 19);
            label5.TabIndex = 4;
            label5.Text = "Tìm kiếm theo";
            // 
            // ManagerBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlMain);
            Controls.Add(pnlTitle);
            Name = "ManagerBill";
            Size = new Size(1180, 733);
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            pnlMain.ResumeLayout(false);
            lstRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgHoaDon).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitle;
        private Label lbTitle;
        private Panel pnlMain;
        private GroupBox lstRoom;
        private DataGridView dtgHoaDon;
        private GroupBox groupBox1;
        private TextBox tbGiamGia;
        private Label label6;
        private TextBox tbDonGia;
        private Label label7;
        private Label label8;
        private TextBox tbNhanVien;
        private Label label4;
        private TextBox tbTenPhong;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private Assets.CusButton btnTimKiem;
        private Label label5;
        private TextBox tbSearch;
        private ComboBox cbTimKiemTheo;
        private TextBox tbThanhTien;
        private Label label9;
        private TextBox tbNgayTao;
        private Assets.CusButton btnExport;
        private ComboBox cbMaHoaDon;
        private GroupBox groupBox4;
        private Assets.CusButton btnDong;
    }
}
