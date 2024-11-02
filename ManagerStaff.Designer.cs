namespace HotelManage
{
    partial class ManagerStaff
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
            groupBox2 = new GroupBox();
            tbSearch = new TextBox();
            btnSearch = new Assets.CusButton();
            label5 = new Label();
            groupBox1 = new GroupBox();
            dtNgay_lam = new DateTimePicker();
            cbLoai_NV = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            tbTen_DN = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            label11 = new Label();
            tbMaNV = new TextBox();
            tbDiaChi = new TextBox();
            label9 = new Label();
            tbSDT = new TextBox();
            label10 = new Label();
            tbCCCD = new TextBox();
            dtNgay_Sinh = new DateTimePicker();
            label8 = new Label();
            cbGioi_tinh = new ComboBox();
            label4 = new Label();
            label6 = new Label();
            tbTen_NV = new TextBox();
            label7 = new Label();
            lstRoom = new GroupBox();
            btnXuat = new Assets.CusButton();
            dtgStaff = new DataGridView();
            groupBox4 = new GroupBox();
            btnQuyenTruyCap = new Assets.CusButton();
            btnDLMK = new Assets.CusButton();
            btnCapNhat = new Assets.CusButton();
            btnThem = new Assets.CusButton();
            pnlTitle.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            lstRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgStaff).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.Controls.Add(lbTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1180, 62);
            pnlTitle.TabIndex = 0;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.Teal;
            lbTitle.Location = new Point(24, 22);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(193, 25);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Quản lý nhân viên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbSearch);
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox2.ForeColor = Color.Teal;
            groupBox2.Location = new Point(24, 77);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(241, 160);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // tbSearch
            // 
            tbSearch.BorderStyle = BorderStyle.FixedSingle;
            tbSearch.Location = new Point(12, 63);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(217, 27);
            tbSearch.TabIndex = 9;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Teal;
            btnSearch.BackgroundColor = Color.Teal;
            btnSearch.BorderColor = Color.PaleVioletRed;
            btnSearch.BorderRadius = 20;
            btnSearch.BorderSize = 0;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(43, 102);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(133, 35);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 31);
            label5.Name = "label5";
            label5.Size = new Size(203, 19);
            label5.TabIndex = 4;
            label5.Text = "Tên nhân viên/ CCCD/SĐT";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtNgay_lam);
            groupBox1.Controls.Add(cbLoai_NV);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbTen_DN);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox1.ForeColor = Color.Teal;
            groupBox1.Location = new Point(24, 243);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(241, 216);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tài khoản nhân viên";
            // 
            // dtNgay_lam
            // 
            dtNgay_lam.CustomFormat = "dd/MM/yyyy";
            dtNgay_lam.Format = DateTimePickerFormat.Custom;
            dtNgay_lam.Location = new Point(10, 166);
            dtNgay_lam.Name = "dtNgay_lam";
            dtNgay_lam.Size = new Size(217, 27);
            dtNgay_lam.TabIndex = 15;
            // 
            // cbLoai_NV
            // 
            cbLoai_NV.FormattingEnabled = true;
            cbLoai_NV.Location = new Point(10, 109);
            cbLoai_NV.Name = "cbLoai_NV";
            cbLoai_NV.Size = new Size(217, 27);
            cbLoai_NV.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 144);
            label3.Name = "label3";
            label3.Size = new Size(107, 19);
            label3.TabIndex = 12;
            label3.Text = "Ngày vào làm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(117, 19);
            label2.TabIndex = 10;
            label2.Text = "Loại nhân viên";
            // 
            // tbTen_DN
            // 
            tbTen_DN.BorderStyle = BorderStyle.FixedSingle;
            tbTen_DN.Location = new Point(10, 53);
            tbTen_DN.Name = "tbTen_DN";
            tbTen_DN.Size = new Size(217, 27);
            tbTen_DN.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 31);
            label1.Name = "label1";
            label1.Size = new Size(114, 19);
            label1.TabIndex = 4;
            label1.Text = "Tên đăng nhập";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(tbMaNV);
            groupBox3.Controls.Add(tbDiaChi);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(tbSDT);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(tbCCCD);
            groupBox3.Controls.Add(dtNgay_Sinh);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(cbGioi_tinh);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(tbTen_NV);
            groupBox3.Controls.Add(label7);
            groupBox3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox3.ForeColor = Color.Teal;
            groupBox3.Location = new Point(271, 77);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(902, 160);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin nhân viên";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 31);
            label11.Name = "label11";
            label11.Size = new Size(107, 19);
            label11.TabIndex = 25;
            label11.Text = "Mã nhân viên";
            // 
            // tbMaNV
            // 
            tbMaNV.BorderStyle = BorderStyle.FixedSingle;
            tbMaNV.Location = new Point(11, 53);
            tbMaNV.Name = "tbMaNV";
            tbMaNV.Size = new Size(212, 27);
            tbMaNV.TabIndex = 24;
            // 
            // tbDiaChi
            // 
            tbDiaChi.BorderStyle = BorderStyle.FixedSingle;
            tbDiaChi.Location = new Point(679, 53);
            tbDiaChi.Name = "tbDiaChi";
            tbDiaChi.Size = new Size(212, 27);
            tbDiaChi.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(679, 31);
            label9.Name = "label9";
            label9.Size = new Size(62, 19);
            label9.TabIndex = 21;
            label9.Text = "Địa chỉ";
            // 
            // tbSDT
            // 
            tbSDT.BorderStyle = BorderStyle.FixedSingle;
            tbSDT.Location = new Point(454, 53);
            tbSDT.Name = "tbSDT";
            tbSDT.Size = new Size(212, 27);
            tbSDT.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(454, 31);
            label10.Name = "label10";
            label10.Size = new Size(105, 19);
            label10.TabIndex = 19;
            label10.Text = "Số điện thoại";
            // 
            // tbCCCD
            // 
            tbCCCD.BorderStyle = BorderStyle.FixedSingle;
            tbCCCD.Location = new Point(450, 110);
            tbCCCD.Name = "tbCCCD";
            tbCCCD.Size = new Size(212, 27);
            tbCCCD.TabIndex = 18;
            // 
            // dtNgay_Sinh
            // 
            dtNgay_Sinh.CustomFormat = "dd/MM/yyyy";
            dtNgay_Sinh.Format = DateTimePickerFormat.Custom;
            dtNgay_Sinh.Location = new Point(232, 110);
            dtNgay_Sinh.Name = "dtNgay_Sinh";
            dtNgay_Sinh.Size = new Size(212, 27);
            dtNgay_Sinh.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(229, 86);
            label8.Name = "label8";
            label8.Size = new Size(81, 19);
            label8.TabIndex = 16;
            label8.Text = "Ngày sinh";
            // 
            // cbGioi_tinh
            // 
            cbGioi_tinh.FormattingEnabled = true;
            cbGioi_tinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbGioi_tinh.Location = new Point(232, 53);
            cbGioi_tinh.Name = "cbGioi_tinh";
            cbGioi_tinh.Size = new Size(212, 27);
            cbGioi_tinh.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(232, 31);
            label4.Name = "label4";
            label4.Size = new Size(78, 19);
            label4.TabIndex = 12;
            label4.Text = "Giới tính";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(454, 86);
            label6.Name = "label6";
            label6.Size = new Size(114, 19);
            label6.TabIndex = 10;
            label6.Text = "CCCD/CMND";
            // 
            // tbTen_NV
            // 
            tbTen_NV.BorderStyle = BorderStyle.FixedSingle;
            tbTen_NV.Location = new Point(11, 110);
            tbTen_NV.Name = "tbTen_NV";
            tbTen_NV.Size = new Size(212, 27);
            tbTen_NV.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 86);
            label7.Name = "label7";
            label7.Size = new Size(110, 19);
            label7.TabIndex = 4;
            label7.Text = "Tên nhân viên";
            // 
            // lstRoom
            // 
            lstRoom.Controls.Add(btnXuat);
            lstRoom.Controls.Add(dtgStaff);
            lstRoom.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstRoom.ForeColor = Color.Teal;
            lstRoom.Location = new Point(271, 243);
            lstRoom.Name = "lstRoom";
            lstRoom.Size = new Size(902, 524);
            lstRoom.TabIndex = 22;
            lstRoom.TabStop = false;
            lstRoom.Text = "Danh sách nhân viên";
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.Teal;
            btnXuat.BackgroundColor = Color.Teal;
            btnXuat.BorderColor = Color.Teal;
            btnXuat.BorderRadius = 20;
            btnXuat.BorderSize = 1;
            btnXuat.FlatAppearance.BorderSize = 0;
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.ForeColor = Color.White;
            btnXuat.Location = new Point(775, 21);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(104, 32);
            btnXuat.TabIndex = 12;
            btnXuat.Text = "Xuất";
            btnXuat.TextColor = Color.White;
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // dtgStaff
            // 
            dtgStaff.BackgroundColor = SystemColors.GradientInactiveCaption;
            dtgStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgStaff.Location = new Point(11, 64);
            dtgStaff.Name = "dtgStaff";
            dtgStaff.RowHeadersWidth = 51;
            dtgStaff.Size = new Size(856, 449);
            dtgStaff.TabIndex = 0;
            dtgStaff.CellClick += dtgStaff_CellClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnQuyenTruyCap);
            groupBox4.Controls.Add(btnDLMK);
            groupBox4.Controls.Add(btnCapNhat);
            groupBox4.Controls.Add(btnThem);
            groupBox4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox4.ForeColor = Color.Teal;
            groupBox4.Location = new Point(24, 475);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(241, 281);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chức năng";
            // 
            // btnQuyenTruyCap
            // 
            btnQuyenTruyCap.BackColor = Color.Teal;
            btnQuyenTruyCap.BackgroundColor = Color.Teal;
            btnQuyenTruyCap.BorderColor = Color.PaleVioletRed;
            btnQuyenTruyCap.BorderRadius = 20;
            btnQuyenTruyCap.BorderSize = 0;
            btnQuyenTruyCap.FlatAppearance.BorderSize = 0;
            btnQuyenTruyCap.FlatStyle = FlatStyle.Flat;
            btnQuyenTruyCap.ForeColor = Color.White;
            btnQuyenTruyCap.Location = new Point(26, 218);
            btnQuyenTruyCap.Name = "btnQuyenTruyCap";
            btnQuyenTruyCap.Size = new Size(186, 35);
            btnQuyenTruyCap.TabIndex = 11;
            btnQuyenTruyCap.Text = "Quyền truy cập";
            btnQuyenTruyCap.TextColor = Color.White;
            btnQuyenTruyCap.UseVisualStyleBackColor = false;
            btnQuyenTruyCap.Click += btnAccessRole_Click;
            // 
            // btnDLMK
            // 
            btnDLMK.BackColor = Color.Teal;
            btnDLMK.BackgroundColor = Color.Teal;
            btnDLMK.BorderColor = Color.PaleVioletRed;
            btnDLMK.BorderRadius = 20;
            btnDLMK.BorderSize = 0;
            btnDLMK.FlatAppearance.BorderSize = 0;
            btnDLMK.FlatStyle = FlatStyle.Flat;
            btnDLMK.ForeColor = Color.White;
            btnDLMK.Location = new Point(27, 158);
            btnDLMK.Name = "btnDLMK";
            btnDLMK.Size = new Size(186, 35);
            btnDLMK.TabIndex = 10;
            btnDLMK.Text = "Đặt lại mật khẩu ";
            btnDLMK.TextColor = Color.White;
            btnDLMK.UseVisualStyleBackColor = false;
            btnDLMK.Click += btnDLMK_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.Teal;
            btnCapNhat.BackgroundColor = Color.Teal;
            btnCapNhat.BorderColor = Color.PaleVioletRed;
            btnCapNhat.BorderRadius = 20;
            btnCapNhat.BorderSize = 0;
            btnCapNhat.FlatAppearance.BorderSize = 0;
            btnCapNhat.FlatStyle = FlatStyle.Flat;
            btnCapNhat.ForeColor = Color.White;
            btnCapNhat.Location = new Point(27, 96);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(186, 35);
            btnCapNhat.TabIndex = 9;
            btnCapNhat.Text = "Cập nhật nhân viên";
            btnCapNhat.TextColor = Color.White;
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Teal;
            btnThem.BackgroundColor = Color.Teal;
            btnThem.BorderColor = Color.PaleVioletRed;
            btnThem.BorderRadius = 20;
            btnThem.BorderSize = 0;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(27, 36);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(186, 35);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm nhân viên";
            btnThem.TextColor = Color.White;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // ManagerStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(groupBox4);
            Controls.Add(lstRoom);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(pnlTitle);
            Name = "ManagerStaff";
            Size = new Size(1180, 746);
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            lstRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgStaff).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitle;
        private Label lbTitle;
        private GroupBox groupBox2;
        private TextBox tbSearch;
        private Assets.CusButton btnSearch;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox tbTen_DN;
        private Label label1;
        private DateTimePicker dtNgay_lam;
        private ComboBox cbLoai_NV;
        private Label label3;
        private Label label2;
        private GroupBox groupBox3;
        private TextBox tbCCCD;
        private DateTimePicker dtNgay_Sinh;
        private Label label8;
        private ComboBox cbGioi_tinh;
        private Label label4;
        private Label label6;
        private TextBox tbTen_NV;
        private Label label7;
        private TextBox tbDiaChi;
        private Label label9;
        private TextBox tbSDT;
        private Label label10;
        private GroupBox lstRoom;
        private Assets.CusButton btnXuat;
        private DataGridView dtgStaff;
        private GroupBox groupBox4;
        private Assets.CusButton btnQuyenTruyCap;
        private Assets.CusButton btnDLMK;
        private Assets.CusButton btnCapNhat;
        private Assets.CusButton btnThem;
        private TextBox tbMaNV;
        private Label label11;
    }
}
