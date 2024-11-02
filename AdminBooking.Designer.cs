namespace HotelManage
{
    partial class AdminBooking
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
            pnlTittle = new Panel();
            lbTitle = new Label();
            pnlInfoBooking = new Panel();
            groupBox5 = new GroupBox();
            cusButton5 = new Assets.CusButton();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            btnDong = new Assets.CusButton();
            btnThemKH = new Assets.CusButton();
            btnDatPhong = new Assets.CusButton();
            cbRecieve = new CheckBox();
            groupBox1 = new GroupBox();
            cbLoaiKH = new ComboBox();
            dtNgay_Sinh = new DateTimePicker();
            cbGioiTinh = new ComboBox();
            tbQuocTich = new TextBox();
            label17 = new Label();
            label16 = new Label();
            tbDiaChi = new TextBox();
            label15 = new Label();
            label14 = new Label();
            tbSDT = new TextBox();
            label13 = new Label();
            label12 = new Label();
            tbCCCD = new TextBox();
            label11 = new Label();
            tbTenKH = new TextBox();
            label10 = new Label();
            groupBox3 = new GroupBox();
            tbGia = new TextBox();
            label9 = new Label();
            tbSoNguoi = new TextBox();
            label8 = new Label();
            tbTebLoaiPhong = new TextBox();
            label7 = new Label();
            tbMaLoaiPhong = new TextBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            btnSearch = new Assets.CusButton();
            tbSearch = new TextBox();
            label5 = new Label();
            grInfoBooking = new GroupBox();
            dtNgayTra = new DateTimePicker();
            dtNgayNhan = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            tbSoDem = new TextBox();
            label2 = new Label();
            cbLoaiPhong = new ComboBox();
            label1 = new Label();
            IDRoom = new DataGridViewTextBoxColumn();
            NameCus = new DataGridViewTextBoxColumn();
            IDCustomer = new DataGridViewTextBoxColumn();
            DateBook = new DataGridViewTextBoxColumn();
            DateCheckOut = new DataGridViewTextBoxColumn();
            pnlTittle.SuspendLayout();
            pnlInfoBooking.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            grInfoBooking.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTittle
            // 
            pnlTittle.AutoScroll = true;
            pnlTittle.BackColor = SystemColors.Control;
            pnlTittle.BorderStyle = BorderStyle.Fixed3D;
            pnlTittle.Controls.Add(lbTitle);
            pnlTittle.Dock = DockStyle.Top;
            pnlTittle.Location = new Point(0, 0);
            pnlTittle.Name = "pnlTittle";
            pnlTittle.Size = new Size(1180, 50);
            pnlTittle.TabIndex = 0;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.Teal;
            lbTitle.Location = new Point(16, 14);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(118, 25);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Đặt phòng";
            // 
            // pnlInfoBooking
            // 
            pnlInfoBooking.AutoScroll = true;
            pnlInfoBooking.Controls.Add(groupBox5);
            pnlInfoBooking.Controls.Add(groupBox4);
            pnlInfoBooking.Controls.Add(groupBox1);
            pnlInfoBooking.Controls.Add(groupBox3);
            pnlInfoBooking.Controls.Add(groupBox2);
            pnlInfoBooking.Controls.Add(grInfoBooking);
            pnlInfoBooking.Dock = DockStyle.Fill;
            pnlInfoBooking.Location = new Point(0, 50);
            pnlInfoBooking.Name = "pnlInfoBooking";
            pnlInfoBooking.Size = new Size(1180, 683);
            pnlInfoBooking.TabIndex = 1;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(cusButton5);
            groupBox5.Controls.Add(dataGridView1);
            groupBox5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = Color.Teal;
            groupBox5.Location = new Point(76, 650);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1000, 389);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Danh sách đặt phòng trong ngày";
            // 
            // cusButton5
            // 
            cusButton5.BackColor = Color.Teal;
            cusButton5.BackgroundColor = Color.Teal;
            cusButton5.BorderColor = Color.Teal;
            cusButton5.BorderRadius = 20;
            cusButton5.BorderSize = 1;
            cusButton5.FlatAppearance.BorderSize = 0;
            cusButton5.FlatStyle = FlatStyle.Flat;
            cusButton5.ForeColor = Color.White;
            cusButton5.Location = new Point(660, 329);
            cusButton5.Name = "cusButton5";
            cusButton5.Size = new Size(228, 35);
            cusButton5.TabIndex = 11;
            cusButton5.Text = "Xem chi tiết";
            cusButton5.TextColor = Color.White;
            cusButton5.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(969, 259);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnDong);
            groupBox4.Controls.Add(btnThemKH);
            groupBox4.Controls.Add(btnDatPhong);
            groupBox4.Controls.Add(cbRecieve);
            groupBox4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.Teal;
            groupBox4.Location = new Point(714, 325);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(362, 303);
            groupBox4.TabIndex = 3;
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
            btnDong.Location = new Point(40, 221);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(277, 35);
            btnDong.TabIndex = 10;
            btnDong.Text = "Đóng";
            btnDong.TextColor = Color.White;
            btnDong.UseVisualStyleBackColor = false;
            btnDong.Click += btnDong_Click;
            // 
            // btnThemKH
            // 
            btnThemKH.BackColor = Color.Teal;
            btnThemKH.BackgroundColor = Color.Teal;
            btnThemKH.BorderColor = Color.Teal;
            btnThemKH.BorderRadius = 20;
            btnThemKH.BorderSize = 1;
            btnThemKH.FlatAppearance.BorderSize = 0;
            btnThemKH.FlatStyle = FlatStyle.Flat;
            btnThemKH.ForeColor = Color.White;
            btnThemKH.Location = new Point(42, 159);
            btnThemKH.Name = "btnThemKH";
            btnThemKH.Size = new Size(275, 35);
            btnThemKH.TabIndex = 9;
            btnThemKH.Text = "Thêm khách hàng";
            btnThemKH.TextColor = Color.White;
            btnThemKH.UseVisualStyleBackColor = false;
            btnThemKH.Click += btnThemKH_Click;
            // 
            // btnDatPhong
            // 
            btnDatPhong.BackColor = Color.Teal;
            btnDatPhong.BackgroundColor = Color.Teal;
            btnDatPhong.BorderColor = Color.Teal;
            btnDatPhong.BorderRadius = 20;
            btnDatPhong.BorderSize = 1;
            btnDatPhong.FlatAppearance.BorderSize = 0;
            btnDatPhong.FlatStyle = FlatStyle.Flat;
            btnDatPhong.ForeColor = Color.White;
            btnDatPhong.Location = new Point(42, 96);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new Size(275, 35);
            btnDatPhong.TabIndex = 8;
            btnDatPhong.Text = "Đặt phòng";
            btnDatPhong.TextColor = Color.White;
            btnDatPhong.UseVisualStyleBackColor = false;
            btnDatPhong.Click += btnDatPhong_Click;
            // 
            // cbRecieve
            // 
            cbRecieve.AutoSize = true;
            cbRecieve.Location = new Point(64, 48);
            cbRecieve.Name = "cbRecieve";
            cbRecieve.Size = new Size(204, 23);
            cbRecieve.TabIndex = 0;
            cbRecieve.Text = "Chuyển đến nhận phòng";
            cbRecieve.UseVisualStyleBackColor = true;
            cbRecieve.CheckedChanged += cbRecieve_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbLoaiKH);
            groupBox1.Controls.Add(dtNgay_Sinh);
            groupBox1.Controls.Add(cbGioiTinh);
            groupBox1.Controls.Add(tbQuocTich);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(tbDiaChi);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(tbSDT);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(tbCCCD);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(tbTenKH);
            groupBox1.Controls.Add(label10);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Teal;
            groupBox1.Location = new Point(76, 325);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(607, 312);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // cbLoaiKH
            // 
            cbLoaiKH.FormattingEnabled = true;
            cbLoaiKH.Items.AddRange(new object[] { "Địa phương", "Du lịch" });
            cbLoaiKH.Location = new Point(16, 197);
            cbLoaiKH.Name = "cbLoaiKH";
            cbLoaiKH.Size = new Size(257, 27);
            cbLoaiKH.TabIndex = 21;
            // 
            // dtNgay_Sinh
            // 
            dtNgay_Sinh.CalendarForeColor = Color.Teal;
            dtNgay_Sinh.CalendarMonthBackground = SystemColors.Control;
            dtNgay_Sinh.CalendarTitleBackColor = Color.Teal;
            dtNgay_Sinh.CalendarTitleForeColor = Color.AliceBlue;
            dtNgay_Sinh.CustomFormat = "dd/MM/yyyy";
            dtNgay_Sinh.Font = new Font("Times New Roman", 10.2F);
            dtNgay_Sinh.Format = DateTimePickerFormat.Custom;
            dtNgay_Sinh.Location = new Point(311, 70);
            dtNgay_Sinh.Name = "dtNgay_Sinh";
            dtNgay_Sinh.Size = new Size(259, 27);
            dtNgay_Sinh.TabIndex = 8;
            dtNgay_Sinh.Value = new DateTime(2024, 10, 15, 22, 53, 41, 0);
            // 
            // cbGioiTinh
            // 
            cbGioiTinh.FormattingEnabled = true;
            cbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbGioiTinh.Location = new Point(311, 197);
            cbGioiTinh.Name = "cbGioiTinh";
            cbGioiTinh.Size = new Size(259, 27);
            cbGioiTinh.TabIndex = 20;
            // 
            // tbQuocTich
            // 
            tbQuocTich.BorderStyle = BorderStyle.FixedSingle;
            tbQuocTich.Font = new Font("Times New Roman", 10.2F);
            tbQuocTich.Location = new Point(313, 263);
            tbQuocTich.Name = "tbQuocTich";
            tbQuocTich.Size = new Size(257, 27);
            tbQuocTich.TabIndex = 19;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(313, 240);
            label17.Name = "label17";
            label17.Size = new Size(81, 19);
            label17.TabIndex = 18;
            label17.Text = "Quốc tịch";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(311, 174);
            label16.Name = "label16";
            label16.Size = new Size(78, 19);
            label16.TabIndex = 16;
            label16.Text = "Giới tính";
            // 
            // tbDiaChi
            // 
            tbDiaChi.BorderStyle = BorderStyle.FixedSingle;
            tbDiaChi.Font = new Font("Times New Roman", 10.2F);
            tbDiaChi.Location = new Point(311, 134);
            tbDiaChi.Name = "tbDiaChi";
            tbDiaChi.Size = new Size(259, 27);
            tbDiaChi.TabIndex = 15;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(311, 111);
            label15.Name = "label15";
            label15.Size = new Size(62, 19);
            label15.TabIndex = 14;
            label15.Text = "Địa chỉ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(311, 47);
            label14.Name = "label14";
            label14.Size = new Size(81, 19);
            label14.TabIndex = 12;
            label14.Text = "Ngày sinh";
            // 
            // tbSDT
            // 
            tbSDT.BorderStyle = BorderStyle.FixedSingle;
            tbSDT.Font = new Font("Times New Roman", 10.2F);
            tbSDT.Location = new Point(16, 263);
            tbSDT.Name = "tbSDT";
            tbSDT.Size = new Size(257, 27);
            tbSDT.TabIndex = 11;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(16, 240);
            label13.Name = "label13";
            label13.Size = new Size(105, 19);
            label13.TabIndex = 10;
            label13.Text = "Số điện thoại";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 174);
            label12.Name = "label12";
            label12.Size = new Size(72, 19);
            label12.TabIndex = 8;
            label12.Text = "Loại KH";
            // 
            // tbCCCD
            // 
            tbCCCD.BorderStyle = BorderStyle.FixedSingle;
            tbCCCD.Font = new Font("Times New Roman", 10.2F);
            tbCCCD.Location = new Point(16, 134);
            tbCCCD.Name = "tbCCCD";
            tbCCCD.Size = new Size(257, 27);
            tbCCCD.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 111);
            label11.Name = "label11";
            label11.Size = new Size(149, 19);
            label11.TabIndex = 6;
            label11.Text = "Thẻ CCCD/CMND ";
            // 
            // tbTenKH
            // 
            tbTenKH.BorderStyle = BorderStyle.FixedSingle;
            tbTenKH.Font = new Font("Times New Roman", 10.2F);
            tbTenKH.Location = new Point(16, 70);
            tbTenKH.Name = "tbTenKH";
            tbTenKH.Size = new Size(257, 27);
            tbTenKH.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 47);
            label10.Name = "label10";
            label10.Size = new Size(58, 19);
            label10.TabIndex = 4;
            label10.Text = "Họ tên";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tbGia);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(tbSoNguoi);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(tbTebLoaiPhong);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(tbMaLoaiPhong);
            groupBox3.Controls.Add(label6);
            groupBox3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox3.ForeColor = Color.Teal;
            groupBox3.Location = new Point(714, 23);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(362, 296);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin loại phòng";
            // 
            // tbGia
            // 
            tbGia.BorderStyle = BorderStyle.FixedSingle;
            tbGia.Font = new Font("Times New Roman", 10.2F);
            tbGia.Location = new Point(20, 246);
            tbGia.Name = "tbGia";
            tbGia.Size = new Size(316, 27);
            tbGia.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 223);
            label9.Name = "label9";
            label9.Size = new Size(37, 19);
            label9.TabIndex = 10;
            label9.Text = "Giá";
            // 
            // tbSoNguoi
            // 
            tbSoNguoi.BorderStyle = BorderStyle.FixedSingle;
            tbSoNguoi.Font = new Font("Times New Roman", 10.2F);
            tbSoNguoi.Location = new Point(20, 184);
            tbSoNguoi.Name = "tbSoNguoi";
            tbSoNguoi.Size = new Size(316, 27);
            tbSoNguoi.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 161);
            label8.Name = "label8";
            label8.Size = new Size(120, 19);
            label8.TabIndex = 8;
            label8.Text = "Số người tối đa";
            // 
            // tbTebLoaiPhong
            // 
            tbTebLoaiPhong.BorderStyle = BorderStyle.FixedSingle;
            tbTebLoaiPhong.Font = new Font("Times New Roman", 10.2F);
            tbTebLoaiPhong.Location = new Point(20, 122);
            tbTebLoaiPhong.Name = "tbTebLoaiPhong";
            tbTebLoaiPhong.Size = new Size(316, 27);
            tbTebLoaiPhong.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 99);
            label7.Name = "label7";
            label7.Size = new Size(118, 19);
            label7.TabIndex = 6;
            label7.Text = "Tên loại phòng";
            // 
            // tbMaLoaiPhong
            // 
            tbMaLoaiPhong.BorderStyle = BorderStyle.FixedSingle;
            tbMaLoaiPhong.Font = new Font("Times New Roman", 10.2F);
            tbMaLoaiPhong.Location = new Point(20, 56);
            tbMaLoaiPhong.Name = "tbMaLoaiPhong";
            tbMaLoaiPhong.Size = new Size(316, 27);
            tbMaLoaiPhong.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 33);
            label6.Name = "label6";
            label6.Size = new Size(115, 19);
            label6.TabIndex = 4;
            label6.Text = "Mã loại phòng";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(tbSearch);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox2.ForeColor = Color.Teal;
            groupBox2.Location = new Point(76, 206);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(607, 107);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm khách hàng";
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
            btnSearch.Location = new Point(414, 51);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(172, 35);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.BorderStyle = BorderStyle.FixedSingle;
            tbSearch.Font = new Font("Times New Roman", 10.2F);
            tbSearch.Location = new Point(16, 57);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(330, 27);
            tbSearch.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 34);
            label5.Name = "label5";
            label5.Size = new Size(151, 19);
            label5.TabIndex = 4;
            label5.Text = "Thẻ CCCD/CMND:";
            // 
            // grInfoBooking
            // 
            grInfoBooking.Controls.Add(dtNgayTra);
            grInfoBooking.Controls.Add(dtNgayNhan);
            grInfoBooking.Controls.Add(label4);
            grInfoBooking.Controls.Add(label3);
            grInfoBooking.Controls.Add(tbSoDem);
            grInfoBooking.Controls.Add(label2);
            grInfoBooking.Controls.Add(cbLoaiPhong);
            grInfoBooking.Controls.Add(label1);
            grInfoBooking.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            grInfoBooking.ForeColor = Color.Teal;
            grInfoBooking.Location = new Point(76, 23);
            grInfoBooking.Name = "grInfoBooking";
            grInfoBooking.Size = new Size(607, 171);
            grInfoBooking.TabIndex = 0;
            grInfoBooking.TabStop = false;
            grInfoBooking.Text = "Thông tin đặt phòng";
            // 
            // dtNgayTra
            // 
            dtNgayTra.CalendarMonthBackground = SystemColors.Control;
            dtNgayTra.CalendarTitleBackColor = Color.Teal;
            dtNgayTra.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            dtNgayTra.Font = new Font("Times New Roman", 10.2F);
            dtNgayTra.Format = DateTimePickerFormat.Custom;
            dtNgayTra.Location = new Point(307, 122);
            dtNgayTra.Name = "dtNgayTra";
            dtNgayTra.Size = new Size(263, 27);
            dtNgayTra.TabIndex = 7;
            dtNgayTra.Value = new DateTime(2024, 10, 15, 22, 53, 41, 0);
            dtNgayTra.ValueChanged += dtNgayTra_ValueChanged;
            // 
            // dtNgayNhan
            // 
            dtNgayNhan.CalendarForeColor = Color.Teal;
            dtNgayNhan.CalendarMonthBackground = SystemColors.Control;
            dtNgayNhan.CalendarTitleBackColor = Color.Teal;
            dtNgayNhan.CalendarTitleForeColor = Color.AliceBlue;
            dtNgayNhan.CustomFormat = "dd/MM/yyyy hh:mm:ss ";
            dtNgayNhan.Font = new Font("Times New Roman", 10.2F);
            dtNgayNhan.Format = DateTimePickerFormat.Custom;
            dtNgayNhan.Location = new Point(307, 56);
            dtNgayNhan.Name = "dtNgayNhan";
            dtNgayNhan.Size = new Size(263, 27);
            dtNgayNhan.TabIndex = 6;
            dtNgayNhan.Value = new DateTime(2024, 10, 15, 22, 53, 41, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(307, 99);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 5;
            label4.Text = "Ngày trả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(307, 32);
            label3.Name = "label3";
            label3.Size = new Size(85, 19);
            label3.TabIndex = 4;
            label3.Text = "Ngày nhận";
            // 
            // tbSoDem
            // 
            tbSoDem.BorderStyle = BorderStyle.FixedSingle;
            tbSoDem.Font = new Font("Times New Roman", 10.2F);
            tbSoDem.Location = new Point(16, 122);
            tbSoDem.Name = "tbSoDem";
            tbSoDem.Size = new Size(257, 27);
            tbSoDem.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 99);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 2;
            label2.Text = "Số đêm";
            // 
            // cbLoaiPhong
            // 
            cbLoaiPhong.Font = new Font("Times New Roman", 10.2F);
            cbLoaiPhong.FormattingEnabled = true;
            cbLoaiPhong.Location = new Point(16, 56);
            cbLoaiPhong.Name = "cbLoaiPhong";
            cbLoaiPhong.Size = new Size(257, 27);
            cbLoaiPhong.TabIndex = 1;
            cbLoaiPhong.SelectedIndexChanged += cbLoaiPhong_SelectedIndexChanged;
            cbLoaiPhong.SelectedValueChanged += cbLoaiPhong_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 33);
            label1.Name = "label1";
            label1.Size = new Size(92, 19);
            label1.TabIndex = 0;
            label1.Text = "Loại phòng";
            // 
            // IDRoom
            // 
            IDRoom.HeaderText = "Mã đặt phòng  ";
            IDRoom.MinimumWidth = 6;
            IDRoom.Name = "IDRoom";
            IDRoom.Width = 125;
            // 
            // NameCus
            // 
            NameCus.HeaderText = "Họ và Tên";
            NameCus.MinimumWidth = 6;
            NameCus.Name = "NameCus";
            NameCus.Width = 200;
            // 
            // IDCustomer
            // 
            IDCustomer.HeaderText = "CCCD/CMND";
            IDCustomer.MinimumWidth = 6;
            IDCustomer.Name = "IDCustomer";
            IDCustomer.Width = 180;
            // 
            // DateBook
            // 
            DateBook.HeaderText = "Ngày nhận";
            DateBook.MinimumWidth = 6;
            DateBook.Name = "DateBook";
            DateBook.Width = 150;
            // 
            // DateCheckOut
            // 
            DateCheckOut.HeaderText = "Ngày trả";
            DateCheckOut.MinimumWidth = 6;
            DateCheckOut.Name = "DateCheckOut";
            DateCheckOut.Width = 150;
            // 
            // AdminBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlInfoBooking);
            Controls.Add(pnlTittle);
            Name = "AdminBooking";
            Size = new Size(1180, 733);
            pnlTittle.ResumeLayout(false);
            pnlTittle.PerformLayout();
            pnlInfoBooking.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            grInfoBooking.ResumeLayout(false);
            grInfoBooking.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTittle;
        private Label lbTitle;
        private Panel pnlInfoBooking;
        private GroupBox groupBox2;
        private GroupBox grInfoBooking;
        private GroupBox groupBox3;
        private Label label1;
        private ComboBox cbLoaiPhong;
        private TextBox tbSoDem;
        private Label label2;
        private DateTimePicker dtNgayTra;
        private DateTimePicker dtNgayNhan;
        private Label label4;
        private Label label3;
        private TextBox tbSearch;
        private Label label5;
        private TextBox tbGia;
        private Label label9;
        private TextBox tbSoNguoi;
        private Label label8;
        private TextBox tbTebLoaiPhong;
        private Label label7;
        private TextBox tbMaLoaiPhong;
        private Label label6;
        private Assets.CusButton btnSearch;
        private GroupBox groupBox1;
        private TextBox tbTenKH;
        private Label label10;
        private TextBox tbQuocTich;
        private Label label17;
        private Label label16;
        private TextBox tbDiaChi;
        private Label label15;
        private Label label14;
        private TextBox tbSDT;
        private Label label13;
        private Label label12;
        private TextBox tbCCCD;
        private Label label11;
        private GroupBox groupBox4;
        private Assets.CusButton btnDong;
        private Assets.CusButton btnThemKH;
        private Assets.CusButton btnDatPhong;
        private CheckBox cbRecieve;
        private GroupBox groupBox5;
        private DataGridView dataGridView1;
        private ComboBox cbLoaiKH;
        private DateTimePicker dtNgay_Sinh;
        private ComboBox cbGioiTinh;
        private Assets.CusButton cusButton5;
        private DataGridViewTextBoxColumn IDRoom;
        private DataGridViewTextBoxColumn NameCus;
        private DataGridViewTextBoxColumn IDCustomer;
        private DataGridViewTextBoxColumn DateBook;
        private DataGridViewTextBoxColumn DateCheckOut;
    }
}
