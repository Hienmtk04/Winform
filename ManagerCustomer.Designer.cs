namespace HotelManage
{
    partial class ManagerCustomer
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
            label1 = new Label();
            pnlMain = new Panel();
            lstRoom = new GroupBox();
            btnExport = new Assets.CusButton();
            dtgKhach_Hang = new DataGridView();
            groupBox4 = new GroupBox();
            btnClose = new Assets.CusButton();
            btnAdd = new Assets.CusButton();
            btnUpdate = new Assets.CusButton();
            groupBox1 = new GroupBox();
            dtNgay_Sinh = new DateTimePicker();
            cbGioi_Tinh = new ComboBox();
            cbLoai_KH = new ComboBox();
            tbQuoc_Tich = new TextBox();
            label11 = new Label();
            tbDia_Chi = new TextBox();
            label9 = new Label();
            label2 = new Label();
            tbSDT = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tbCCCD = new TextBox();
            label4 = new Label();
            tbTen_KH = new TextBox();
            label3 = new Label();
            tbMaKH = new TextBox();
            label10 = new Label();
            groupBox2 = new GroupBox();
            tbTim_kiem = new TextBox();
            cbTim_theo = new ComboBox();
            btnSearch = new Assets.CusButton();
            label5 = new Label();
            Ma = new DataGridViewTextBoxColumn();
            Ten = new DataGridViewTextBoxColumn();
            SoCCCD = new DataGridViewTextBoxColumn();
            Loai = new DataGridViewTextBoxColumn();
            SDT = new DataGridViewTextBoxColumn();
            Diachi = new DataGridViewTextBoxColumn();
            QuocTich = new DataGridViewTextBoxColumn();
            pnlTitle.SuspendLayout();
            pnlMain.SuspendLayout();
            lstRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgKhach_Hang).BeginInit();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BorderStyle = BorderStyle.Fixed3D;
            pnlTitle.Controls.Add(label1);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1180, 57);
            pnlTitle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(15, 20);
            label1.Name = "label1";
            label1.Size = new Size(214, 25);
            label1.TabIndex = 0;
            label1.Text = "Quản lý khách hàng";
            // 
            // pnlMain
            // 
            pnlMain.AutoScroll = true;
            pnlMain.Controls.Add(lstRoom);
            pnlMain.Controls.Add(groupBox4);
            pnlMain.Controls.Add(groupBox1);
            pnlMain.Controls.Add(groupBox2);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 57);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1180, 676);
            pnlMain.TabIndex = 1;
            // 
            // lstRoom
            // 
            lstRoom.Controls.Add(btnExport);
            lstRoom.Controls.Add(dtgKhach_Hang);
            lstRoom.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstRoom.ForeColor = Color.Teal;
            lstRoom.Location = new Point(59, 354);
            lstRoom.Name = "lstRoom";
            lstRoom.Size = new Size(1064, 524);
            lstRoom.TabIndex = 21;
            lstRoom.TabStop = false;
            lstRoom.Text = "Danh sách khách hàng";
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
            btnExport.Click += btnExport_Click;
            // 
            // dtgKhach_Hang
            // 
            dtgKhach_Hang.BackgroundColor = SystemColors.GradientInactiveCaption;
            dtgKhach_Hang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgKhach_Hang.Columns.AddRange(new DataGridViewColumn[] { Ma, Ten, SoCCCD, Loai, SDT, Diachi, QuocTich });
            dtgKhach_Hang.Location = new Point(11, 69);
            dtgKhach_Hang.Name = "dtgKhach_Hang";
            dtgKhach_Hang.RowHeadersWidth = 51;
            dtgKhach_Hang.Size = new Size(1043, 449);
            dtgKhach_Hang.TabIndex = 0;
            dtgKhach_Hang.CellClick += dtgKhach_Hang_CellClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnClose);
            groupBox4.Controls.Add(btnAdd);
            groupBox4.Controls.Add(btnUpdate);
            groupBox4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.Teal;
            groupBox4.Location = new Point(59, 177);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(453, 156);
            groupBox4.TabIndex = 20;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chức năng";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Teal;
            btnClose.BackgroundColor = Color.Teal;
            btnClose.BorderColor = Color.Teal;
            btnClose.BorderRadius = 20;
            btnClose.BorderSize = 1;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(132, 90);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(189, 35);
            btnClose.TabIndex = 12;
            btnClose.Text = "Đóng";
            btnClose.TextColor = Color.White;
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Teal;
            btnAdd.BackgroundColor = Color.Teal;
            btnAdd.BorderColor = Color.Teal;
            btnAdd.BorderRadius = 20;
            btnAdd.BorderSize = 1;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(234, 42);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(189, 35);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Thêm";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Teal;
            btnUpdate.BackgroundColor = Color.Teal;
            btnUpdate.BorderColor = Color.Teal;
            btnUpdate.BorderRadius = 20;
            btnUpdate.BorderSize = 1;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(22, 42);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(189, 35);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.TextColor = Color.White;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtNgay_Sinh);
            groupBox1.Controls.Add(cbGioi_Tinh);
            groupBox1.Controls.Add(cbLoai_KH);
            groupBox1.Controls.Add(tbQuoc_Tich);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(tbDia_Chi);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbSDT);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(tbCCCD);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbTen_KH);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbMaKH);
            groupBox1.Controls.Add(label10);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox1.ForeColor = Color.Teal;
            groupBox1.Location = new Point(543, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(580, 309);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // dtNgay_Sinh
            // 
            dtNgay_Sinh.CustomFormat = "dd/MM/yyyy";
            dtNgay_Sinh.Format = DateTimePickerFormat.Custom;
            dtNgay_Sinh.Location = new Point(296, 54);
            dtNgay_Sinh.Name = "dtNgay_Sinh";
            dtNgay_Sinh.Size = new Size(268, 27);
            dtNgay_Sinh.TabIndex = 24;
            // 
            // cbGioi_Tinh
            // 
            cbGioi_Tinh.FormattingEnabled = true;
            cbGioi_Tinh.Items.AddRange(new object[] { "Địa phương", "Du lịch" });
            cbGioi_Tinh.Location = new Point(16, 265);
            cbGioi_Tinh.Name = "cbGioi_Tinh";
            cbGioi_Tinh.Size = new Size(261, 27);
            cbGioi_Tinh.TabIndex = 23;
            // 
            // cbLoai_KH
            // 
            cbLoai_KH.FormattingEnabled = true;
            cbLoai_KH.Items.AddRange(new object[] { "Địa phương", "Du lịch" });
            cbLoai_KH.Location = new Point(16, 213);
            cbLoai_KH.Name = "cbLoai_KH";
            cbLoai_KH.Size = new Size(261, 27);
            cbLoai_KH.TabIndex = 22;
            // 
            // tbQuoc_Tich
            // 
            tbQuoc_Tich.BorderStyle = BorderStyle.FixedSingle;
            tbQuoc_Tich.Font = new Font("Times New Roman", 10.2F);
            tbQuoc_Tich.Location = new Point(296, 214);
            tbQuoc_Tich.Name = "tbQuoc_Tich";
            tbQuoc_Tich.Size = new Size(268, 27);
            tbQuoc_Tich.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(296, 191);
            label11.Name = "label11";
            label11.Size = new Size(81, 19);
            label11.TabIndex = 20;
            label11.Text = "Quốc tịch";
            // 
            // tbDia_Chi
            // 
            tbDia_Chi.BorderStyle = BorderStyle.FixedSingle;
            tbDia_Chi.Font = new Font("Times New Roman", 10.2F);
            tbDia_Chi.Location = new Point(296, 161);
            tbDia_Chi.Name = "tbDia_Chi";
            tbDia_Chi.Size = new Size(268, 27);
            tbDia_Chi.TabIndex = 19;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 243);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 16;
            label2.Text = "Giới tính";
            // 
            // tbSDT
            // 
            tbSDT.BorderStyle = BorderStyle.FixedSingle;
            tbSDT.Font = new Font("Times New Roman", 10.2F);
            tbSDT.Location = new Point(296, 107);
            tbSDT.Name = "tbSDT";
            tbSDT.Size = new Size(268, 27);
            tbSDT.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(296, 84);
            label6.Name = "label6";
            label6.Size = new Size(105, 19);
            label6.TabIndex = 14;
            label6.Text = "Số điện thoại";
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 190);
            label8.Name = "label8";
            label8.Size = new Size(129, 19);
            label8.TabIndex = 10;
            label8.Text = "Loại khách hàng";
            // 
            // tbCCCD
            // 
            tbCCCD.BorderStyle = BorderStyle.FixedSingle;
            tbCCCD.Font = new Font("Times New Roman", 10.2F);
            tbCCCD.Location = new Point(16, 159);
            tbCCCD.Name = "tbCCCD";
            tbCCCD.Size = new Size(261, 27);
            tbCCCD.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 136);
            label4.Name = "label4";
            label4.Size = new Size(114, 19);
            label4.TabIndex = 8;
            label4.Text = "CCCD/CMND";
            // 
            // tbTen_KH
            // 
            tbTen_KH.BorderStyle = BorderStyle.FixedSingle;
            tbTen_KH.Font = new Font("Times New Roman", 10.2F);
            tbTen_KH.Location = new Point(16, 106);
            tbTen_KH.Name = "tbTen_KH";
            tbTen_KH.Size = new Size(261, 27);
            tbTen_KH.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 83);
            label3.Name = "label3";
            label3.Size = new Size(82, 19);
            label3.TabIndex = 6;
            label3.Text = "Họ và Tên";
            // 
            // tbMaKH
            // 
            tbMaKH.BorderStyle = BorderStyle.FixedSingle;
            tbMaKH.Font = new Font("Times New Roman", 10.2F);
            tbMaKH.Location = new Point(16, 54);
            tbMaKH.Name = "tbMaKH";
            tbMaKH.Size = new Size(261, 27);
            tbMaKH.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 31);
            label10.Name = "label10";
            label10.Size = new Size(119, 19);
            label10.TabIndex = 4;
            label10.Text = "Mã khách hàng";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbTim_kiem);
            groupBox2.Controls.Add(cbTim_theo);
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox2.ForeColor = Color.Teal;
            groupBox2.Location = new Point(59, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(453, 135);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // tbTim_kiem
            // 
            tbTim_kiem.BorderStyle = BorderStyle.FixedSingle;
            tbTim_kiem.Location = new Point(10, 81);
            tbTim_kiem.Name = "tbTim_kiem";
            tbTim_kiem.Size = new Size(217, 27);
            tbTim_kiem.TabIndex = 9;
            // 
            // cbTim_theo
            // 
            cbTim_theo.FormattingEnabled = true;
            cbTim_theo.Items.AddRange(new object[] { "Mã khách hàng", "Tên khách hàng", "Số CCCD/CMND", "Số điện thoại" });
            cbTim_theo.Location = new Point(132, 31);
            cbTim_theo.Name = "cbTim_theo";
            cbTim_theo.Size = new Size(205, 27);
            cbTim_theo.TabIndex = 8;
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
            btnSearch.Location = new Point(290, 76);
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
            label5.Size = new Size(116, 19);
            label5.TabIndex = 4;
            label5.Text = "Tìm kiếm theo";
            // 
            // Ma
            // 
            Ma.HeaderText = "Mã";
            Ma.MinimumWidth = 6;
            Ma.Name = "Ma";
            Ma.Width = 125;
            // 
            // Ten
            // 
            Ten.HeaderText = "Tên";
            Ten.MinimumWidth = 6;
            Ten.Name = "Ten";
            Ten.Width = 160;
            // 
            // SoCCCD
            // 
            SoCCCD.HeaderText = "Số CCCD/CMND";
            SoCCCD.MinimumWidth = 6;
            SoCCCD.Name = "SoCCCD";
            SoCCCD.Width = 140;
            // 
            // Loai
            // 
            Loai.HeaderText = "Loại";
            Loai.MinimumWidth = 6;
            Loai.Name = "Loai";
            Loai.Width = 130;
            // 
            // SDT
            // 
            SDT.HeaderText = "Số điện thoại";
            SDT.MinimumWidth = 6;
            SDT.Name = "SDT";
            SDT.Width = 140;
            // 
            // Diachi
            // 
            Diachi.HeaderText = "Địa chỉ";
            Diachi.MinimumWidth = 6;
            Diachi.Name = "Diachi";
            Diachi.Width = 150;
            // 
            // QuocTich
            // 
            QuocTich.HeaderText = "Quốc tịch";
            QuocTich.MinimumWidth = 6;
            QuocTich.Name = "QuocTich";
            QuocTich.Width = 140;
            // 
            // ManagerCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlMain);
            Controls.Add(pnlTitle);
            Name = "ManagerCustomer";
            Size = new Size(1180, 733);
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            pnlMain.ResumeLayout(false);
            lstRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgKhach_Hang).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitle;
        private Label label1;
        private Panel pnlMain;
        private GroupBox groupBox2;
        private TextBox tbTim_kiem;
        private ComboBox cbTim_theo;
        private Assets.CusButton btnSearch;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox tbDia_Chi;
        private Label label9;
        private Label label2;
        private TextBox tbSDT;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox tbCCCD;
        private Label label4;
        private TextBox tbTen_KH;
        private Label label3;
        private TextBox tbMaKH;
        private Label label10;
        private GroupBox groupBox4;
        private Assets.CusButton btnAdd;
        private Assets.CusButton btnUpdate;
        private TextBox tbQuoc_Tich;
        private Label label11;
        private GroupBox lstRoom;
        private Assets.CusButton btnExport;
        private DataGridView dtgKhach_Hang;
        private Assets.CusButton btnClose;
        private ComboBox cbGioi_Tinh;
        private ComboBox cbLoai_KH;
        private DateTimePicker dtNgay_Sinh;
        private DataGridViewTextBoxColumn Ma;
        private DataGridViewTextBoxColumn Ten;
        private DataGridViewTextBoxColumn SoCCCD;
        private DataGridViewTextBoxColumn Loai;
        private DataGridViewTextBoxColumn SDT;
        private DataGridViewTextBoxColumn Diachi;
        private DataGridViewTextBoxColumn QuocTich;
    }
}
