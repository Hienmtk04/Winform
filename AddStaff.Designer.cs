namespace HotelManage
{
    partial class AddStaff
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
            pnlTitle = new Panel();
            lbTitle = new Label();
            pnlMain = new Panel();
            groupBox1 = new GroupBox();
            tbMat_Khau = new TextBox();
            tbTenDN = new TextBox();
            tbTen_NV = new TextBox();
            dtNgayVaoLam = new DateTimePicker();
            label2 = new Label();
            cbGioiTinh = new ComboBox();
            cbLoaiNV = new ComboBox();
            label6 = new Label();
            tbSDT = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label5 = new Label();
            label1 = new Label();
            dtNgaySinh = new DateTimePicker();
            tbDiaChi = new TextBox();
            label9 = new Label();
            label7 = new Label();
            tbCCCD = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tbMaNV = new TextBox();
            label10 = new Label();
            groupBox4 = new GroupBox();
            lbExit = new Label();
            btnExit = new Assets.CusButton();
            btnThem = new Assets.CusButton();
            pnlTitle.SuspendLayout();
            pnlMain.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.Controls.Add(lbTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(800, 48);
            pnlTitle.TabIndex = 3;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.Teal;
            lbTitle.Location = new Point(12, 12);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(171, 25);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Thêm nhân viên";
            // 
            // pnlMain
            // 
            pnlMain.AutoScroll = true;
            pnlMain.Controls.Add(groupBox1);
            pnlMain.Controls.Add(groupBox4);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 48);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(800, 402);
            pnlMain.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbMat_Khau);
            groupBox1.Controls.Add(tbTenDN);
            groupBox1.Controls.Add(tbTen_NV);
            groupBox1.Controls.Add(dtNgayVaoLam);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbGioiTinh);
            groupBox1.Controls.Add(cbLoaiNV);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbSDT);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtNgaySinh);
            groupBox1.Controls.Add(tbDiaChi);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tbCCCD);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbMaNV);
            groupBox1.Controls.Add(label10);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox1.ForeColor = Color.Teal;
            groupBox1.Location = new Point(24, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(580, 358);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // tbMat_Khau
            // 
            tbMat_Khau.BorderStyle = BorderStyle.FixedSingle;
            tbMat_Khau.Location = new Point(16, 213);
            tbMat_Khau.Name = "tbMat_Khau";
            tbMat_Khau.Size = new Size(261, 27);
            tbMat_Khau.TabIndex = 37;
            // 
            // tbTenDN
            // 
            tbTenDN.BorderStyle = BorderStyle.FixedSingle;
            tbTenDN.Location = new Point(16, 161);
            tbTenDN.Name = "tbTenDN";
            tbTenDN.Size = new Size(261, 27);
            tbTenDN.TabIndex = 36;
            // 
            // tbTen_NV
            // 
            tbTen_NV.BorderStyle = BorderStyle.FixedSingle;
            tbTen_NV.Location = new Point(16, 108);
            tbTen_NV.Name = "tbTen_NV";
            tbTen_NV.Size = new Size(261, 27);
            tbTen_NV.TabIndex = 35;
            // 
            // dtNgayVaoLam
            // 
            dtNgayVaoLam.CustomFormat = "dd/MM/yyyy";
            dtNgayVaoLam.Format = DateTimePickerFormat.Custom;
            dtNgayVaoLam.Location = new Point(296, 267);
            dtNgayVaoLam.Name = "dtNgayVaoLam";
            dtNgayVaoLam.Size = new Size(268, 27);
            dtNgayVaoLam.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 244);
            label2.Name = "label2";
            label2.Size = new Size(107, 19);
            label2.TabIndex = 33;
            label2.Text = "Ngày vào làm";
            // 
            // cbGioiTinh
            // 
            cbGioiTinh.FormattingEnabled = true;
            cbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbGioiTinh.Location = new Point(16, 319);
            cbGioiTinh.Name = "cbGioiTinh";
            cbGioiTinh.Size = new Size(261, 27);
            cbGioiTinh.TabIndex = 32;
            // 
            // cbLoaiNV
            // 
            cbLoaiNV.FormattingEnabled = true;
            cbLoaiNV.Location = new Point(16, 267);
            cbLoaiNV.Name = "cbLoaiNV";
            cbLoaiNV.Size = new Size(261, 27);
            cbLoaiNV.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(296, 191);
            label6.Name = "label6";
            label6.Size = new Size(105, 19);
            label6.TabIndex = 14;
            label6.Text = "Số điện thoại";
            // 
            // tbSDT
            // 
            tbSDT.BorderStyle = BorderStyle.FixedSingle;
            tbSDT.Font = new Font("Times New Roman", 10.2F);
            tbSDT.Location = new Point(296, 214);
            tbSDT.Name = "tbSDT";
            tbSDT.Size = new Size(268, 27);
            tbSDT.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 297);
            label12.Name = "label12";
            label12.Size = new Size(78, 19);
            label12.TabIndex = 30;
            label12.Text = "Giới tính";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(16, 244);
            label13.Name = "label13";
            label13.Size = new Size(117, 19);
            label13.TabIndex = 29;
            label13.Text = "Loại nhân viên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 191);
            label5.Name = "label5";
            label5.Size = new Size(78, 19);
            label5.TabIndex = 27;
            label5.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 138);
            label1.Name = "label1";
            label1.Size = new Size(114, 19);
            label1.TabIndex = 25;
            label1.Text = "Tên đăng nhập";
            // 
            // dtNgaySinh
            // 
            dtNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtNgaySinh.Format = DateTimePickerFormat.Custom;
            dtNgaySinh.Location = new Point(296, 54);
            dtNgaySinh.Name = "dtNgaySinh";
            dtNgaySinh.Size = new Size(268, 27);
            dtNgaySinh.TabIndex = 24;
            // 
            // tbDiaChi
            // 
            tbDiaChi.BorderStyle = BorderStyle.FixedSingle;
            tbDiaChi.Font = new Font("Times New Roman", 10.2F);
            tbDiaChi.Location = new Point(296, 161);
            tbDiaChi.Name = "tbDiaChi";
            tbDiaChi.Size = new Size(268, 27);
            tbDiaChi.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(296, 138);
            label9.Name = "label9";
            label9.Size = new Size(62, 19);
            label9.TabIndex = 18;
            label9.Text = "Địa chỉ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(296, 31);
            label7.Name = "label7";
            label7.Size = new Size(81, 19);
            label7.TabIndex = 12;
            label7.Text = "Ngày sinh";
            // 
            // tbCCCD
            // 
            tbCCCD.BorderStyle = BorderStyle.FixedSingle;
            tbCCCD.Font = new Font("Times New Roman", 10.2F);
            tbCCCD.Location = new Point(296, 105);
            tbCCCD.Name = "tbCCCD";
            tbCCCD.Size = new Size(268, 27);
            tbCCCD.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(296, 84);
            label4.Name = "label4";
            label4.Size = new Size(114, 19);
            label4.TabIndex = 8;
            label4.Text = "CCCD/CMND";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 83);
            label3.Name = "label3";
            label3.Size = new Size(110, 19);
            label3.TabIndex = 6;
            label3.Text = "Tên nhân viên";
            // 
            // tbMaNV
            // 
            tbMaNV.BorderStyle = BorderStyle.FixedSingle;
            tbMaNV.Font = new Font("Times New Roman", 10.2F);
            tbMaNV.Location = new Point(16, 54);
            tbMaNV.Name = "tbMaNV";
            tbMaNV.Size = new Size(261, 27);
            tbMaNV.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 31);
            label10.Name = "label10";
            label10.Size = new Size(107, 19);
            label10.TabIndex = 4;
            label10.Text = "Mã nhân viên";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lbExit);
            groupBox4.Controls.Add(btnExit);
            groupBox4.Controls.Add(btnThem);
            groupBox4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.Teal;
            groupBox4.Location = new Point(621, 19);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(167, 155);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chức năng";
            // 
            // lbExit
            // 
            lbExit.AutoSize = true;
            lbExit.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbExit.ForeColor = Color.Red;
            lbExit.Location = new Point(609, -203);
            lbExit.Name = "lbExit";
            lbExit.Size = new Size(27, 25);
            lbExit.TabIndex = 1;
            lbExit.Text = "X";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Teal;
            btnExit.BackgroundColor = Color.Teal;
            btnExit.BorderColor = Color.Teal;
            btnExit.BorderRadius = 20;
            btnExit.BorderSize = 1;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(15, 90);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(135, 35);
            btnExit.TabIndex = 11;
            btnExit.Text = "Đóng";
            btnExit.TextColor = Color.White;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Teal;
            btnThem.BackgroundColor = Color.Teal;
            btnThem.BorderColor = Color.Teal;
            btnThem.BorderRadius = 20;
            btnThem.BorderSize = 1;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(15, 37);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(135, 35);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm nhân viên";
            btnThem.TextColor = Color.White;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // AddStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMain);
            Controls.Add(pnlTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddStaff";
            Text = "AddStaff";
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            pnlMain.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitle;
        private Label lbTitle;
        private Panel pnlMain;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox1;
        private Label label1;
        private DateTimePicker dtNgaySinh;
        private ComboBox cbGioi_Tinh;
        private ComboBox cbLoai_KH;
        private TextBox tbQuoc_Tich;
        private Label label11;
        private TextBox tbDiaChi;
        private Label label9;
        private TextBox tbSDT;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox tbCCCD;
        private Label label4;
        private TextBox tbTen_KH;
        private Label label3;
        private TextBox tbMaNV;
        private Label label10;
        private GroupBox groupBox4;
        private Label lbExit;
        private Assets.CusButton btnExit;
        private Assets.CusButton btnThem;
        private DateTimePicker dtNgayVaoLam;
        private Label label2;
        private ComboBox cbGioiTinh;
        private ComboBox cbLoaiNV;
        private Label label12;
        private Label label13;
        private TextBox tbMat_Khau;
        private TextBox tbTenDN;
        private TextBox tbTen_NV;
    }
}