namespace HotelManage
{
    partial class AdminRecieve
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
            lbTittle = new Label();
            pnlMain = new Panel();
            groupBox5 = new GroupBox();
            dtgNhanPhong = new DataGridView();
            groupBox2 = new GroupBox();
            btnHuy = new Assets.CusButton();
            btnNhan = new Assets.CusButton();
            btnThem = new Assets.CusButton();
            groupBox1 = new GroupBox();
            dtNgayTra = new DateTimePicker();
            dtNgayNhan = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            tbTenLoaiPhong = new TextBox();
            label3 = new Label();
            tbGia = new TextBox();
            label9 = new Label();
            tbSoNguoi = new TextBox();
            label8 = new Label();
            tbTenPhong = new TextBox();
            label7 = new Label();
            tbCCCD = new TextBox();
            label11 = new Label();
            tbTenKH = new TextBox();
            label10 = new Label();
            ListRoom = new GroupBox();
            cbTenPhong = new ComboBox();
            cbLoaiPhong = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            grSearch = new GroupBox();
            cusButton1 = new Assets.CusButton();
            tbMaDatPhong = new TextBox();
            lbID = new Label();
            pnlTittle.SuspendLayout();
            pnlMain.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgNhanPhong).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ListRoom.SuspendLayout();
            grSearch.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTittle
            // 
            pnlTittle.BorderStyle = BorderStyle.Fixed3D;
            pnlTittle.Controls.Add(lbTittle);
            pnlTittle.Dock = DockStyle.Top;
            pnlTittle.Location = new Point(0, 0);
            pnlTittle.Name = "pnlTittle";
            pnlTittle.Size = new Size(1180, 56);
            pnlTittle.TabIndex = 0;
            // 
            // lbTittle
            // 
            lbTittle.AutoSize = true;
            lbTittle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTittle.ForeColor = Color.Teal;
            lbTittle.Location = new Point(21, 16);
            lbTittle.Name = "lbTittle";
            lbTittle.Size = new Size(136, 25);
            lbTittle.TabIndex = 0;
            lbTittle.Text = "Nhận phòng";
            // 
            // pnlMain
            // 
            pnlMain.AutoScroll = true;
            pnlMain.Controls.Add(groupBox5);
            pnlMain.Controls.Add(groupBox2);
            pnlMain.Controls.Add(groupBox1);
            pnlMain.Controls.Add(ListRoom);
            pnlMain.Controls.Add(grSearch);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 56);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1180, 677);
            pnlMain.TabIndex = 1;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dtgNhanPhong);
            groupBox5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = Color.Teal;
            groupBox5.Location = new Point(60, 492);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1059, 389);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Danh sách nhận phòng trong ngày";
            // 
            // dtgNhanPhong
            // 
            dtgNhanPhong.BackgroundColor = SystemColors.GradientInactiveCaption;
            dtgNhanPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgNhanPhong.Location = new Point(31, 26);
            dtgNhanPhong.Name = "dtgNhanPhong";
            dtgNhanPhong.RowHeadersWidth = 51;
            dtgNhanPhong.Size = new Size(996, 321);
            dtgNhanPhong.TabIndex = 0;
            dtgNhanPhong.CellClick += dtgNhanPhong_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnHuy);
            groupBox2.Controls.Add(btnNhan);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox2.ForeColor = Color.Teal;
            groupBox2.Location = new Point(860, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(259, 226);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Teal;
            btnHuy.BackgroundColor = Color.Teal;
            btnHuy.BorderColor = Color.PaleVioletRed;
            btnHuy.BorderRadius = 20;
            btnHuy.BorderSize = 0;
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(28, 160);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(203, 41);
            btnHuy.TabIndex = 5;
            btnHuy.Text = "Hủy";
            btnHuy.TextColor = Color.White;
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnNhan
            // 
            btnNhan.BackColor = Color.Teal;
            btnNhan.BackgroundColor = Color.Teal;
            btnNhan.BorderColor = Color.PaleVioletRed;
            btnNhan.BorderRadius = 20;
            btnNhan.BorderSize = 0;
            btnNhan.FlatAppearance.BorderSize = 0;
            btnNhan.FlatStyle = FlatStyle.Flat;
            btnNhan.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNhan.ForeColor = Color.White;
            btnNhan.Location = new Point(28, 97);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(203, 41);
            btnNhan.TabIndex = 4;
            btnNhan.Text = "Nhận phòng";
            btnNhan.TextColor = Color.White;
            btnNhan.UseVisualStyleBackColor = false;
            btnNhan.Click += cusButton3_Click;
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
            btnThem.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(28, 36);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(203, 41);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm khách hàng";
            btnThem.TextColor = Color.White;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtNgayTra);
            groupBox1.Controls.Add(dtNgayNhan);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbTenLoaiPhong);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbGia);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(tbSoNguoi);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(tbTenPhong);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tbCCCD);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(tbTenKH);
            groupBox1.Controls.Add(label10);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox1.ForeColor = Color.Teal;
            groupBox1.Location = new Point(60, 197);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(775, 289);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhận phòng";
            // 
            // dtNgayTra
            // 
            dtNgayTra.CalendarMonthBackground = SystemColors.Control;
            dtNgayTra.CalendarTitleBackColor = Color.Teal;
            dtNgayTra.CustomFormat = "dd/MM/yyyy";
            dtNgayTra.Font = new Font("Times New Roman", 10.2F);
            dtNgayTra.Format = DateTimePickerFormat.Custom;
            dtNgayTra.Location = new Point(414, 119);
            dtNgayTra.Name = "dtNgayTra";
            dtNgayTra.Size = new Size(290, 27);
            dtNgayTra.TabIndex = 23;
            dtNgayTra.Value = new DateTime(2024, 10, 31, 23, 51, 0, 0);
            // 
            // dtNgayNhan
            // 
            dtNgayNhan.CalendarForeColor = Color.Teal;
            dtNgayNhan.CalendarMonthBackground = SystemColors.Control;
            dtNgayNhan.CalendarTitleBackColor = Color.Teal;
            dtNgayNhan.CalendarTitleForeColor = Color.AliceBlue;
            dtNgayNhan.CustomFormat = "dd/MM/yyyy";
            dtNgayNhan.Font = new Font("Times New Roman", 10.2F);
            dtNgayNhan.Format = DateTimePickerFormat.Custom;
            dtNgayNhan.Location = new Point(414, 59);
            dtNgayNhan.Name = "dtNgayNhan";
            dtNgayNhan.Size = new Size(290, 27);
            dtNgayNhan.TabIndex = 22;
            dtNgayNhan.Value = new DateTime(2024, 10, 31, 23, 51, 7, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(414, 96);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 21;
            label4.Text = "Ngày trả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(414, 37);
            label5.Name = "label5";
            label5.Size = new Size(85, 19);
            label5.TabIndex = 20;
            label5.Text = "Ngày nhận";
            // 
            // tbTenLoaiPhong
            // 
            tbTenLoaiPhong.BorderStyle = BorderStyle.FixedSingle;
            tbTenLoaiPhong.Font = new Font("Times New Roman", 10.2F);
            tbTenLoaiPhong.Location = new Point(59, 241);
            tbTenLoaiPhong.Name = "tbTenLoaiPhong";
            tbTenLoaiPhong.Size = new Size(294, 27);
            tbTenLoaiPhong.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 218);
            label3.Name = "label3";
            label3.Size = new Size(118, 19);
            label3.TabIndex = 18;
            label3.Text = "Tên loại phòng";
            // 
            // tbGia
            // 
            tbGia.BorderStyle = BorderStyle.FixedSingle;
            tbGia.Font = new Font("Times New Roman", 10.2F);
            tbGia.Location = new Point(412, 238);
            tbGia.Name = "tbGia";
            tbGia.Size = new Size(292, 27);
            tbGia.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(412, 215);
            label9.Name = "label9";
            label9.Size = new Size(37, 19);
            label9.TabIndex = 16;
            label9.Text = "Giá";
            // 
            // tbSoNguoi
            // 
            tbSoNguoi.BorderStyle = BorderStyle.FixedSingle;
            tbSoNguoi.Font = new Font("Times New Roman", 10.2F);
            tbSoNguoi.Location = new Point(412, 177);
            tbSoNguoi.Name = "tbSoNguoi";
            tbSoNguoi.Size = new Size(292, 27);
            tbSoNguoi.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(412, 154);
            label8.Name = "label8";
            label8.Size = new Size(120, 19);
            label8.TabIndex = 14;
            label8.Text = "Số người tối đa";
            // 
            // tbTenPhong
            // 
            tbTenPhong.BorderStyle = BorderStyle.FixedSingle;
            tbTenPhong.Font = new Font("Times New Roman", 10.2F);
            tbTenPhong.Location = new Point(59, 180);
            tbTenPhong.Name = "tbTenPhong";
            tbTenPhong.Size = new Size(294, 27);
            tbTenPhong.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(59, 157);
            label7.Name = "label7";
            label7.Size = new Size(85, 19);
            label7.TabIndex = 12;
            label7.Text = "Tên phòng";
            // 
            // tbCCCD
            // 
            tbCCCD.BorderStyle = BorderStyle.FixedSingle;
            tbCCCD.Font = new Font("Times New Roman", 10.2F);
            tbCCCD.Location = new Point(59, 122);
            tbCCCD.Name = "tbCCCD";
            tbCCCD.Size = new Size(294, 27);
            tbCCCD.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(59, 99);
            label11.Name = "label11";
            label11.Size = new Size(149, 19);
            label11.TabIndex = 10;
            label11.Text = "Thẻ CCCD/CMND ";
            // 
            // tbTenKH
            // 
            tbTenKH.BorderStyle = BorderStyle.FixedSingle;
            tbTenKH.Font = new Font("Times New Roman", 10.2F);
            tbTenKH.Location = new Point(59, 63);
            tbTenKH.Name = "tbTenKH";
            tbTenKH.Size = new Size(294, 27);
            tbTenKH.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(59, 40);
            label10.Name = "label10";
            label10.Size = new Size(58, 19);
            label10.TabIndex = 8;
            label10.Text = "Họ tên";
            // 
            // ListRoom
            // 
            ListRoom.Controls.Add(cbTenPhong);
            ListRoom.Controls.Add(cbLoaiPhong);
            ListRoom.Controls.Add(label2);
            ListRoom.Controls.Add(label1);
            ListRoom.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            ListRoom.ForeColor = Color.Teal;
            ListRoom.Location = new Point(399, 23);
            ListRoom.Name = "ListRoom";
            ListRoom.Size = new Size(436, 168);
            ListRoom.TabIndex = 1;
            ListRoom.TabStop = false;
            ListRoom.Text = "Danh sách phòng trống";
            // 
            // cbTenPhong
            // 
            cbTenPhong.FormattingEnabled = true;
            cbTenPhong.Location = new Point(37, 125);
            cbTenPhong.Name = "cbTenPhong";
            cbTenPhong.Size = new Size(361, 27);
            cbTenPhong.TabIndex = 8;
            cbTenPhong.SelectedIndexChanged += cbTenPhong_SelectedIndexChanged;
            // 
            // cbLoaiPhong
            // 
            cbLoaiPhong.FormattingEnabled = true;
            cbLoaiPhong.Location = new Point(37, 57);
            cbLoaiPhong.Name = "cbLoaiPhong";
            cbLoaiPhong.Size = new Size(361, 27);
            cbLoaiPhong.TabIndex = 7;
            cbLoaiPhong.SelectedIndexChanged += cbLoaiPhong_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 102);
            label2.Name = "label2";
            label2.Size = new Size(56, 19);
            label2.TabIndex = 5;
            label2.Text = "Phòng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 35);
            label1.Name = "label1";
            label1.Size = new Size(92, 19);
            label1.TabIndex = 3;
            label1.Text = "Loại phòng";
            // 
            // grSearch
            // 
            grSearch.Controls.Add(cusButton1);
            grSearch.Controls.Add(tbMaDatPhong);
            grSearch.Controls.Add(lbID);
            grSearch.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            grSearch.ForeColor = Color.Teal;
            grSearch.Location = new Point(60, 23);
            grSearch.Name = "grSearch";
            grSearch.Size = new Size(315, 168);
            grSearch.TabIndex = 0;
            grSearch.TabStop = false;
            grSearch.Text = "Tìm kiếm";
            // 
            // cusButton1
            // 
            cusButton1.BackColor = Color.Teal;
            cusButton1.BackgroundColor = Color.Teal;
            cusButton1.BorderColor = Color.PaleVioletRed;
            cusButton1.BorderRadius = 20;
            cusButton1.BorderSize = 0;
            cusButton1.FlatAppearance.BorderSize = 0;
            cusButton1.FlatStyle = FlatStyle.Flat;
            cusButton1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cusButton1.ForeColor = Color.White;
            cusButton1.Location = new Point(81, 97);
            cusButton1.Name = "cusButton1";
            cusButton1.Size = new Size(127, 42);
            cusButton1.TabIndex = 2;
            cusButton1.Text = "Tìm kiếm";
            cusButton1.TextColor = Color.White;
            cusButton1.UseVisualStyleBackColor = false;
            cusButton1.Click += cusButton1_Click;
            // 
            // tbMaDatPhong
            // 
            tbMaDatPhong.BorderStyle = BorderStyle.FixedSingle;
            tbMaDatPhong.Location = new Point(21, 58);
            tbMaDatPhong.Name = "tbMaDatPhong";
            tbMaDatPhong.Size = new Size(252, 27);
            tbMaDatPhong.TabIndex = 1;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(21, 35);
            lbID.Name = "lbID";
            lbID.Size = new Size(109, 19);
            lbID.TabIndex = 0;
            lbID.Text = "Mã đặt phòng";
            // 
            // AdminRecieve
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(pnlMain);
            Controls.Add(pnlTittle);
            Name = "AdminRecieve";
            Size = new Size(1180, 733);
            pnlTittle.ResumeLayout(false);
            pnlTittle.PerformLayout();
            pnlMain.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgNhanPhong).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ListRoom.ResumeLayout(false);
            ListRoom.PerformLayout();
            grSearch.ResumeLayout(false);
            grSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTittle;
        private Label lbTittle;
        private Panel pnlMain;
        private GroupBox grSearch;
        private Label lbID;
        private Assets.CusButton cusButton1;
        private TextBox tbMaDatPhong;
        private GroupBox ListRoom;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cbTenPhong;
        private ComboBox cbLoaiPhong;
        private TextBox tbCCCD;
        private Label label11;
        private TextBox tbTenKH;
        private Label label10;
        private TextBox tbGia;
        private Label label9;
        private TextBox tbSoNguoi;
        private Label label8;
        private TextBox tbTenPhong;
        private Label label7;
        private TextBox tbTenLoaiPhong;
        private Label label3;
        private DateTimePicker dtNgayTra;
        private DateTimePicker dtNgayNhan;
        private Label label4;
        private Label label5;
        private GroupBox groupBox2;
        private Assets.CusButton btnHuy;
        private Assets.CusButton btnNhan;
        private Assets.CusButton btnThem;
        private GroupBox groupBox5;
        private Assets.CusButton btnXemChiTiet;
        private DataGridView dtgNhanPhong;
    }
}
