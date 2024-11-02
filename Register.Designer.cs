namespace HotelManage
{
    partial class Register
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
            label8 = new Label();
            label11 = new Label();
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
            btnRegister = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.InactiveCaptionText;
            label8.Location = new Point(265, 9);
            label8.Name = "label8";
            label8.Size = new Size(121, 25);
            label8.TabIndex = 16;
            label8.Text = "ĐĂNG KÝ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.InactiveCaptionText;
            label11.Location = new Point(177, 49);
            label11.Name = "label11";
            label11.Size = new Size(342, 25);
            label11.TabIndex = 15;
            label11.Text = "Hệ thống quản lý khách sạn Meii";
            // 
            // tbMat_Khau
            // 
            tbMat_Khau.BorderStyle = BorderStyle.FixedSingle;
            tbMat_Khau.Location = new Point(67, 297);
            tbMat_Khau.Name = "tbMat_Khau";
            tbMat_Khau.Size = new Size(261, 27);
            tbMat_Khau.TabIndex = 59;
            // 
            // tbTenDN
            // 
            tbTenDN.BorderStyle = BorderStyle.FixedSingle;
            tbTenDN.Location = new Point(67, 245);
            tbTenDN.Name = "tbTenDN";
            tbTenDN.Size = new Size(261, 27);
            tbTenDN.TabIndex = 58;
            tbTenDN.TextChanged += tbTenDN_TextChanged;
            // 
            // tbTen_NV
            // 
            tbTen_NV.BorderStyle = BorderStyle.FixedSingle;
            tbTen_NV.Location = new Point(67, 192);
            tbTen_NV.Name = "tbTen_NV";
            tbTen_NV.Size = new Size(261, 27);
            tbTen_NV.TabIndex = 57;
            // 
            // dtNgayVaoLam
            // 
            dtNgayVaoLam.CustomFormat = "dd/MM/yyyy";
            dtNgayVaoLam.Format = DateTimePickerFormat.Custom;
            dtNgayVaoLam.Location = new Point(355, 351);
            dtNgayVaoLam.Name = "dtNgayVaoLam";
            dtNgayVaoLam.Size = new Size(268, 27);
            dtNgayVaoLam.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(355, 328);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 55;
            label2.Text = "Ngày vào làm";
            // 
            // cbGioiTinh
            // 
            cbGioiTinh.FormattingEnabled = true;
            cbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbGioiTinh.Location = new Point(67, 403);
            cbGioiTinh.Name = "cbGioiTinh";
            cbGioiTinh.Size = new Size(261, 28);
            cbGioiTinh.TabIndex = 54;
            // 
            // cbLoaiNV
            // 
            cbLoaiNV.FormattingEnabled = true;
            cbLoaiNV.Location = new Point(67, 351);
            cbLoaiNV.Name = "cbLoaiNV";
            cbLoaiNV.Size = new Size(261, 28);
            cbLoaiNV.TabIndex = 53;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(355, 275);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 44;
            label6.Text = "Số điện thoại";
            // 
            // tbSDT
            // 
            tbSDT.BorderStyle = BorderStyle.FixedSingle;
            tbSDT.Font = new Font("Times New Roman", 10.2F);
            tbSDT.Location = new Point(355, 298);
            tbSDT.Name = "tbSDT";
            tbSDT.Size = new Size(268, 27);
            tbSDT.TabIndex = 45;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(67, 381);
            label12.Name = "label12";
            label12.Size = new Size(65, 20);
            label12.TabIndex = 52;
            label12.Text = "Giới tính";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(67, 328);
            label13.Name = "label13";
            label13.Size = new Size(104, 20);
            label13.TabIndex = 51;
            label13.Text = "Loại nhân viên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 275);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 50;
            label5.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 222);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 49;
            label1.Text = "Tên đăng nhập";
            // 
            // dtNgaySinh
            // 
            dtNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtNgaySinh.Format = DateTimePickerFormat.Custom;
            dtNgaySinh.Location = new Point(355, 138);
            dtNgaySinh.Name = "dtNgaySinh";
            dtNgaySinh.Size = new Size(268, 27);
            dtNgaySinh.TabIndex = 48;
            // 
            // tbDiaChi
            // 
            tbDiaChi.BorderStyle = BorderStyle.FixedSingle;
            tbDiaChi.Font = new Font("Times New Roman", 10.2F);
            tbDiaChi.Location = new Point(355, 245);
            tbDiaChi.Name = "tbDiaChi";
            tbDiaChi.Size = new Size(268, 27);
            tbDiaChi.TabIndex = 47;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(355, 222);
            label9.Name = "label9";
            label9.Size = new Size(55, 20);
            label9.TabIndex = 46;
            label9.Text = "Địa chỉ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(355, 115);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 43;
            label7.Text = "Ngày sinh";
            // 
            // tbCCCD
            // 
            tbCCCD.BorderStyle = BorderStyle.FixedSingle;
            tbCCCD.Font = new Font("Times New Roman", 10.2F);
            tbCCCD.Location = new Point(355, 189);
            tbCCCD.Name = "tbCCCD";
            tbCCCD.Size = new Size(268, 27);
            tbCCCD.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(355, 168);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 41;
            label4.Text = "CCCD/CMND";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 167);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 40;
            label3.Text = "Tên nhân viên";
            // 
            // tbMaNV
            // 
            tbMaNV.BorderStyle = BorderStyle.FixedSingle;
            tbMaNV.Font = new Font("Times New Roman", 10.2F);
            tbMaNV.Location = new Point(67, 138);
            tbMaNV.Name = "tbMaNV";
            tbMaNV.Size = new Size(261, 27);
            tbMaNV.TabIndex = 39;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(67, 115);
            label10.Name = "label10";
            label10.Size = new Size(97, 20);
            label10.TabIndex = 38;
            label10.Text = "Mã nhân viên";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DarkSlateGray;
            btnRegister.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = SystemColors.Control;
            btnRegister.Location = new Point(126, 462);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(163, 56);
            btnRegister.TabIndex = 60;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkSlateGray;
            btnCancel.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.Control;
            btnCancel.Location = new Point(356, 462);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(163, 56);
            btnCancel.TabIndex = 61;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(689, 546);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(tbMat_Khau);
            Controls.Add(tbTenDN);
            Controls.Add(tbTen_NV);
            Controls.Add(dtNgayVaoLam);
            Controls.Add(label2);
            Controls.Add(cbGioiTinh);
            Controls.Add(cbLoaiNV);
            Controls.Add(label6);
            Controls.Add(tbSDT);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(dtNgaySinh);
            Controls.Add(tbDiaChi);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(tbCCCD);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbMaNV);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label11);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label8;
        private Label label11;
        private TextBox tbMat_Khau;
        private TextBox tbTenDN;
        private TextBox tbTen_NV;
        private DateTimePicker dtNgayVaoLam;
        private Label label2;
        private ComboBox cbGioiTinh;
        private ComboBox cbLoaiNV;
        private Label label6;
        private TextBox tbSDT;
        private Label label12;
        private Label label13;
        private Label label5;
        private Label label1;
        private DateTimePicker dtNgaySinh;
        private TextBox tbDiaChi;
        private Label label9;
        private Label label7;
        private TextBox tbCCCD;
        private Label label4;
        private Label label3;
        private TextBox tbMaNV;
        private Label label10;
        private Button btnRegister;
        private Button btnCancel;
    }
}