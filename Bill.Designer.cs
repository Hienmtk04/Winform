namespace HotelManage
{
    partial class Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            panel1 = new Panel();
            tbTitle = new TextBox();
            panel2 = new Panel();
            btnDong = new Assets.CusButton();
            btnIn = new Assets.CusButton();
            lbThanhTien = new Label();
            lbTienDV = new Label();
            label29 = new Label();
            label31 = new Label();
            lbGiamGia = new Label();
            lbPhuThu = new Label();
            label21 = new Label();
            label23 = new Label();
            lbTongTien = new Label();
            lbTienPhong = new Label();
            label11 = new Label();
            panel7 = new Panel();
            label15 = new Label();
            dtgDV = new DataGridView();
            TenDV = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            panel6 = new Panel();
            panel4 = new Panel();
            lbSoNguoi = new Label();
            label22 = new Label();
            lbSoDem = new Label();
            label24 = new Label();
            lbNgayDen = new Label();
            label26 = new Label();
            lbDonGia = new Label();
            label28 = new Label();
            lbLoaiPhong = new Label();
            label30 = new Label();
            lbTenPhong = new Label();
            label32 = new Label();
            lbQuocTich = new Label();
            label20 = new Label();
            lbDiaChi = new Label();
            label18 = new Label();
            lbLoaiKH = new Label();
            label16 = new Label();
            lbSDT = new Label();
            label14 = new Label();
            lbCCCD = new Label();
            label12 = new Label();
            lbTenKH = new Label();
            label9 = new Label();
            panel5 = new Panel();
            lbNgayLap = new Label();
            label10 = new Label();
            lbNV = new Label();
            label8 = new Label();
            lbMaHoaDon = new Label();
            label6 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDV).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(tbTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1018, 58);
            panel1.TabIndex = 0;
            // 
            // tbTitle
            // 
            tbTitle.BorderStyle = BorderStyle.None;
            tbTitle.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbTitle.ForeColor = Color.Teal;
            tbTitle.Location = new Point(12, 12);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(234, 32);
            tbTitle.TabIndex = 0;
            tbTitle.Text = "In Hóa Đơn";
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = SystemColors.Window;
            panel2.Controls.Add(btnDong);
            panel2.Controls.Add(btnIn);
            panel2.Controls.Add(lbThanhTien);
            panel2.Controls.Add(lbTienDV);
            panel2.Controls.Add(label29);
            panel2.Controls.Add(label31);
            panel2.Controls.Add(lbGiamGia);
            panel2.Controls.Add(lbPhuThu);
            panel2.Controls.Add(label21);
            panel2.Controls.Add(label23);
            panel2.Controls.Add(lbTongTien);
            panel2.Controls.Add(lbTienPhong);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(dtgDV);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(1018, 1009);
            panel2.TabIndex = 1;
            // 
            // btnDong
            // 
            btnDong.BackColor = Color.Teal;
            btnDong.BackgroundColor = Color.Teal;
            btnDong.BorderColor = Color.PaleVioletRed;
            btnDong.BorderRadius = 20;
            btnDong.BorderSize = 0;
            btnDong.FlatAppearance.BorderSize = 0;
            btnDong.FlatStyle = FlatStyle.Flat;
            btnDong.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDong.ForeColor = Color.White;
            btnDong.Location = new Point(539, 911);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(188, 50);
            btnDong.TabIndex = 50;
            btnDong.Text = "Đóng";
            btnDong.TextColor = Color.White;
            btnDong.UseVisualStyleBackColor = false;
            btnDong.Click += btnDong_Click;
            // 
            // btnIn
            // 
            btnIn.BackColor = Color.Teal;
            btnIn.BackgroundColor = Color.Teal;
            btnIn.BorderColor = Color.PaleVioletRed;
            btnIn.BorderRadius = 20;
            btnIn.BorderSize = 0;
            btnIn.FlatAppearance.BorderSize = 0;
            btnIn.FlatStyle = FlatStyle.Flat;
            btnIn.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIn.ForeColor = Color.White;
            btnIn.Location = new Point(236, 911);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(188, 50);
            btnIn.TabIndex = 49;
            btnIn.Text = "In hóa đơn";
            btnIn.TextColor = Color.White;
            btnIn.UseVisualStyleBackColor = false;
            btnIn.Click += btnIn_Click;
            // 
            // lbThanhTien
            // 
            lbThanhTien.AutoSize = true;
            lbThanhTien.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lbThanhTien.Location = new Point(821, 885);
            lbThanhTien.Name = "lbThanhTien";
            lbThanhTien.Size = new Size(64, 20);
            lbThanhTien.TabIndex = 46;
            lbThanhTien.Text = "label25";
            // 
            // lbTienDV
            // 
            lbTienDV.AutoSize = true;
            lbTienDV.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lbTienDV.Location = new Point(821, 853);
            lbTienDV.Name = "lbTienDV";
            lbTienDV.Size = new Size(64, 20);
            lbTienDV.TabIndex = 48;
            lbTienDV.Text = "label27";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            label29.Location = new Point(686, 885);
            label29.Name = "label29";
            label29.Size = new Size(98, 20);
            label29.TabIndex = 45;
            label29.Text = "Thành tiền:";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            label31.Location = new Point(686, 853);
            label31.Name = "label31";
            label31.Size = new Size(110, 20);
            label31.TabIndex = 47;
            label31.Text = "Tiền dịch vụ:";
            // 
            // lbGiamGia
            // 
            lbGiamGia.AutoSize = true;
            lbGiamGia.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lbGiamGia.Location = new Point(481, 885);
            lbGiamGia.Name = "lbGiamGia";
            lbGiamGia.Size = new Size(64, 20);
            lbGiamGia.TabIndex = 42;
            lbGiamGia.Text = "label17";
            // 
            // lbPhuThu
            // 
            lbPhuThu.AutoSize = true;
            lbPhuThu.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lbPhuThu.Location = new Point(481, 853);
            lbPhuThu.Name = "lbPhuThu";
            lbPhuThu.Size = new Size(64, 20);
            lbPhuThu.TabIndex = 44;
            lbPhuThu.Text = "label19";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            label21.Location = new Point(378, 885);
            label21.Name = "label21";
            label21.Size = new Size(85, 20);
            label21.TabIndex = 41;
            label21.Text = "Giảm giá:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            label23.Location = new Point(378, 853);
            label23.Name = "label23";
            label23.Size = new Size(81, 20);
            label23.TabIndex = 43;
            label23.Text = "Phụ thu: ";
            // 
            // lbTongTien
            // 
            lbTongTien.AutoSize = true;
            lbTongTien.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lbTongTien.Location = new Point(177, 885);
            lbTongTien.Name = "lbTongTien";
            lbTongTien.Size = new Size(55, 20);
            lbTongTien.TabIndex = 38;
            lbTongTien.Text = "label7";
            // 
            // lbTienPhong
            // 
            lbTienPhong.AutoSize = true;
            lbTienPhong.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lbTienPhong.Location = new Point(177, 853);
            lbTienPhong.Name = "lbTienPhong";
            lbTienPhong.Size = new Size(64, 20);
            lbTienPhong.TabIndex = 40;
            lbTienPhong.Text = "label13";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            label11.Location = new Point(65, 885);
            label11.Name = "label11";
            label11.Size = new Size(88, 20);
            label11.TabIndex = 37;
            label11.Text = "Tổng tiền:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(0, 64, 64);
            panel7.Location = new Point(22, 833);
            panel7.Name = "panel7";
            panel7.Size = new Size(972, 10);
            panel7.TabIndex = 14;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            label15.Location = new Point(65, 853);
            label15.Name = "label15";
            label15.Size = new Size(106, 20);
            label15.TabIndex = 39;
            label15.Text = "Tiền phòng: ";
            // 
            // dtgDV
            // 
            dtgDV.BackgroundColor = SystemColors.GradientInactiveCaption;
            dtgDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDV.Columns.AddRange(new DataGridViewColumn[] { TenDV, DonGia, SoLuong, ThanhTien });
            dtgDV.Location = new Point(65, 564);
            dtgDV.Name = "dtgDV";
            dtgDV.RowHeadersWidth = 51;
            dtgDV.Size = new Size(884, 263);
            dtgDV.TabIndex = 14;
            // 
            // TenDV
            // 
            TenDV.HeaderText = "Tên dịch vụ";
            TenDV.MinimumWidth = 6;
            TenDV.Name = "TenDV";
            TenDV.Width = 400;
            // 
            // DonGia
            // 
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            DonGia.Width = 150;
            // 
            // SoLuong
            // 
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            SoLuong.Width = 130;
            // 
            // ThanhTien
            // 
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            ThanhTien.Width = 150;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 64, 64);
            panel6.Location = new Point(22, 548);
            panel6.Name = "panel6";
            panel6.Size = new Size(972, 10);
            panel6.TabIndex = 13;
            // 
            // panel4
            // 
            panel4.Controls.Add(lbSoNguoi);
            panel4.Controls.Add(label22);
            panel4.Controls.Add(lbSoDem);
            panel4.Controls.Add(label24);
            panel4.Controls.Add(lbNgayDen);
            panel4.Controls.Add(label26);
            panel4.Controls.Add(lbDonGia);
            panel4.Controls.Add(label28);
            panel4.Controls.Add(lbLoaiPhong);
            panel4.Controls.Add(label30);
            panel4.Controls.Add(lbTenPhong);
            panel4.Controls.Add(label32);
            panel4.Controls.Add(lbQuocTich);
            panel4.Controls.Add(label20);
            panel4.Controls.Add(lbDiaChi);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(lbLoaiKH);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(lbSDT);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(lbCCCD);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(lbTenKH);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(lbNgayLap);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(lbNV);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(lbMaHoaDon);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(3, 226);
            panel4.Name = "panel4";
            panel4.Size = new Size(1011, 316);
            panel4.TabIndex = 1;
            // 
            // lbSoNguoi
            // 
            lbSoNguoi.AutoSize = true;
            lbSoNguoi.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lbSoNguoi.Location = new Point(660, 277);
            lbSoNguoi.Name = "lbSoNguoi";
            lbSoNguoi.Size = new Size(55, 20);
            lbSoNguoi.TabIndex = 36;
            lbSoNguoi.Text = "label7";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            label22.Location = new Point(533, 277);
            label22.Name = "label22";
            label22.Size = new Size(89, 20);
            label22.TabIndex = 35;
            label22.Text = "Số người: ";
            // 
            // lbSoDem
            // 
            lbSoDem.AutoSize = true;
            lbSoDem.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lbSoDem.Location = new Point(660, 245);
            lbSoDem.Name = "lbSoDem";
            lbSoDem.Size = new Size(55, 20);
            lbSoDem.TabIndex = 34;
            lbSoDem.Text = "label7";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            label24.Location = new Point(533, 245);
            label24.Name = "label24";
            label24.Size = new Size(77, 20);
            label24.TabIndex = 33;
            label24.Text = "Số đêm: ";
            // 
            // lbNgayDen
            // 
            lbNgayDen.AutoSize = true;
            lbNgayDen.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lbNgayDen.Location = new Point(660, 212);
            lbNgayDen.Name = "lbNgayDen";
            lbNgayDen.Size = new Size(55, 20);
            lbNgayDen.TabIndex = 32;
            lbNgayDen.Text = "label7";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            label26.Location = new Point(533, 212);
            label26.Name = "label26";
            label26.Size = new Size(92, 20);
            label26.TabIndex = 31;
            label26.Text = "Ngày đến: ";
            // 
            // lbDonGia
            // 
            lbDonGia.AutoSize = true;
            lbDonGia.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lbDonGia.Location = new Point(660, 179);
            lbDonGia.Name = "lbDonGia";
            lbDonGia.Size = new Size(55, 20);
            lbDonGia.TabIndex = 30;
            lbDonGia.Text = "label7";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            label28.Location = new Point(533, 179);
            label28.Name = "label28";
            label28.Size = new Size(80, 20);
            label28.TabIndex = 29;
            label28.Text = "Đơn giá: ";
            // 
            // lbLoaiPhong
            // 
            lbLoaiPhong.AutoSize = true;
            lbLoaiPhong.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lbLoaiPhong.Location = new Point(660, 146);
            lbLoaiPhong.Name = "lbLoaiPhong";
            lbLoaiPhong.Size = new Size(55, 20);
            lbLoaiPhong.TabIndex = 28;
            lbLoaiPhong.Text = "label7";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            label30.Location = new Point(533, 146);
            label30.Name = "label30";
            label30.Size = new Size(108, 20);
            label30.TabIndex = 27;
            label30.Text = "Loại phòng: ";
            // 
            // lbTenPhong
            // 
            lbTenPhong.AutoSize = true;
            lbTenPhong.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lbTenPhong.Location = new Point(660, 110);
            lbTenPhong.Name = "lbTenPhong";
            lbTenPhong.Size = new Size(64, 20);
            lbTenPhong.TabIndex = 26;
            lbTenPhong.Text = "label31";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            label32.Location = new Point(533, 110);
            label32.Name = "label32";
            label32.Size = new Size(96, 20);
            label32.TabIndex = 25;
            label32.Text = "Tên phòng:";
            // 
            // lbQuocTich
            // 
            lbQuocTich.AutoSize = true;
            lbQuocTich.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lbQuocTich.Location = new Point(222, 277);
            lbQuocTich.Name = "lbQuocTich";
            lbQuocTich.Size = new Size(55, 20);
            lbQuocTich.TabIndex = 24;
            lbQuocTich.Text = "label7";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            label20.Location = new Point(62, 277);
            label20.Name = "label20";
            label20.Size = new Size(95, 20);
            label20.TabIndex = 23;
            label20.Text = "Quốc tịch: ";
            // 
            // lbDiaChi
            // 
            lbDiaChi.AutoSize = true;
            lbDiaChi.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lbDiaChi.Location = new Point(222, 245);
            lbDiaChi.Name = "lbDiaChi";
            lbDiaChi.Size = new Size(55, 20);
            lbDiaChi.TabIndex = 22;
            lbDiaChi.Text = "label7";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            label18.Location = new Point(62, 245);
            label18.Name = "label18";
            label18.Size = new Size(74, 20);
            label18.TabIndex = 21;
            label18.Text = "Địa chỉ: ";
            // 
            // lbLoaiKH
            // 
            lbLoaiKH.AutoSize = true;
            lbLoaiKH.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lbLoaiKH.Location = new Point(222, 212);
            lbLoaiKH.Name = "lbLoaiKH";
            lbLoaiKH.Size = new Size(55, 20);
            lbLoaiKH.TabIndex = 20;
            lbLoaiKH.Text = "label7";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            label16.Location = new Point(62, 212);
            label16.Name = "label16";
            label16.Size = new Size(150, 20);
            label16.TabIndex = 19;
            label16.Text = "Loại khách hàng: ";
            // 
            // lbSDT
            // 
            lbSDT.AutoSize = true;
            lbSDT.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lbSDT.Location = new Point(222, 179);
            lbSDT.Name = "lbSDT";
            lbSDT.Size = new Size(55, 20);
            lbSDT.TabIndex = 18;
            lbSDT.Text = "label7";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            label14.Location = new Point(62, 179);
            label14.Name = "label14";
            label14.Size = new Size(122, 20);
            label14.TabIndex = 17;
            label14.Text = "Số điện thoại: ";
            // 
            // lbCCCD
            // 
            lbCCCD.AutoSize = true;
            lbCCCD.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lbCCCD.Location = new Point(222, 146);
            lbCCCD.Name = "lbCCCD";
            lbCCCD.Size = new Size(55, 20);
            lbCCCD.TabIndex = 16;
            lbCCCD.Text = "label7";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            label12.Location = new Point(62, 146);
            label12.Name = "label12";
            label12.Size = new Size(132, 20);
            label12.TabIndex = 15;
            label12.Text = "CCCD/CMND: ";
            // 
            // lbTenKH
            // 
            lbTenKH.AutoSize = true;
            lbTenKH.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lbTenKH.Location = new Point(222, 110);
            lbTenKH.Name = "lbTenKH";
            lbTenKH.Size = new Size(55, 20);
            lbTenKH.TabIndex = 14;
            lbTenKH.Text = "label7";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            label9.Location = new Point(62, 110);
            label9.Name = "label9";
            label9.Size = new Size(143, 20);
            label9.TabIndex = 13;
            label9.Text = "Tên khách hàng: ";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 64, 64);
            panel5.Location = new Point(19, 83);
            panel5.Name = "panel5";
            panel5.Size = new Size(972, 10);
            panel5.TabIndex = 12;
            // 
            // lbNgayLap
            // 
            lbNgayLap.AutoSize = true;
            lbNgayLap.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lbNgayLap.Location = new Point(777, 57);
            lbNgayLap.Name = "lbNgayLap";
            lbNgayLap.Size = new Size(55, 20);
            lbNgayLap.TabIndex = 11;
            lbNgayLap.Text = "label7";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            label10.Location = new Point(683, 57);
            label10.Name = "label10";
            label10.Size = new Size(88, 20);
            label10.TabIndex = 10;
            label10.Text = "Ngày lập: ";
            // 
            // lbNV
            // 
            lbNV.AutoSize = true;
            lbNV.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lbNV.Location = new Point(449, 57);
            lbNV.Name = "lbNV";
            lbNV.Size = new Size(55, 20);
            lbNV.TabIndex = 9;
            lbNV.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            label8.Location = new Point(329, 57);
            label8.Name = "label8";
            label8.Size = new Size(127, 20);
            label8.TabIndex = 8;
            label8.Text = "Nhân viên lập: ";
            // 
            // lbMaHoaDon
            // 
            lbMaHoaDon.AutoSize = true;
            lbMaHoaDon.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lbMaHoaDon.Location = new Point(172, 57);
            lbMaHoaDon.Name = "lbMaHoaDon";
            lbMaHoaDon.Size = new Size(55, 20);
            lbMaHoaDon.TabIndex = 7;
            lbMaHoaDon.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            label6.Location = new Point(62, 57);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 6;
            label6.Text = "Mã hóa đơn: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(314, 12);
            label5.Name = "label5";
            label5.Size = new Size(369, 35);
            label5.TabIndex = 5;
            label5.Text = "Hóa đơn thanh toán dịch vụ";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Window;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1014, 223);
            panel3.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(358, 161);
            label4.Name = "label4";
            label4.Size = new Size(267, 46);
            label4.TabIndex = 4;
            label4.Text = "Website: https://meiihotel.com\r\n\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(358, 124);
            label3.Name = "label3";
            label3.Size = new Size(230, 23);
            label3.TabIndex = 3;
            label3.Text = "Số điện thoại: 0367048004\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(358, 86);
            label2.Name = "label2";
            label2.Size = new Size(515, 23);
            label2.TabIndex = 2;
            label2.Text = "Địa chỉ: Meii Hotel, Phú Mỹ Hưng, Quận 7, Tp Hồ Chí Minh\r\n";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(358, 32);
            label1.Name = "label1";
            label1.Size = new Size(329, 35);
            label1.TabIndex = 1;
            label1.Text = "Hệ thống khách sạn Meii";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(280, 223);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(277, 217);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Bill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1018, 1067);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bill";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDV).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox tbTitle;
        private Panel panel2;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel4;
        private Label lbNgayLap;
        private Label label10;
        private Label lbNV;
        private Label label8;
        private Label lbMaHoaDon;
        private Label label6;
        private Label label5;
        private Label lbSoNguoi;
        private Label label22;
        private Label lbSoDem;
        private Label label24;
        private Label lbNgayDen;
        private Label label26;
        private Label lbDonGia;
        private Label label28;
        private Label lbLoaiPhong;
        private Label label30;
        private Label lbTenPhong;
        private Label label32;
        private Label lbQuocTich;
        private Label label20;
        private Label lbDiaChi;
        private Label label18;
        private Label lbLoaiKH;
        private Label label16;
        private Label lbSDT;
        private Label label14;
        private Label lbCCCD;
        private Label label12;
        private Label lbTenKH;
        private Label label9;
        private Panel panel5;
        private Panel panel6;
        private Label lbThanhTien;
        private Label lbTienDV;
        private Label label29;
        private Label label31;
        private Label lbGiamGia;
        private Label lbPhuThu;
        private Label label21;
        private Label label23;
        private Label lbTongTien;
        private Label lbTienPhong;
        private Label label11;
        private Panel panel7;
        private Label label15;
        private DataGridView dtgDV;
        private Assets.CusButton btnDong;
        private Assets.CusButton btnIn;
        private DataGridViewTextBoxColumn TenDV;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn ThanhTien;
    }
}