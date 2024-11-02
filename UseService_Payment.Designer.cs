namespace HotelManage
{
    partial class UseServicePayment
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
            groupBox6 = new GroupBox();
            dtgHoadonDV = new DataGridView();
            stt = new DataGridViewTextBoxColumn();
            NameService = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            TotalService = new DataGridViewTextBoxColumn();
            groupBox5 = new GroupBox();
            dtgPhuThu = new DataGridView();
            groupBox4 = new GroupBox();
            dtgHoaDon = new DataGridView();
            NameRoom = new DataGridViewTextBoxColumn();
            PriceService = new DataGridViewTextBoxColumn();
            DateCheckin = new DataGridViewTextBoxColumn();
            DateCheckout = new DataGridViewTextBoxColumn();
            PriceRoom = new DataGridViewTextBoxColumn();
            OtherPrice = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            btnThanhToan = new Assets.CusButton();
            nbGiamGia = new NumericUpDown();
            tbTongTien = new TextBox();
            label12 = new Label();
            label13 = new Label();
            groupBox2 = new GroupBox();
            btnThemDV = new Assets.CusButton();
            nbSoLuong = new NumericUpDown();
            tbGia = new TextBox();
            label10 = new Label();
            label11 = new Label();
            cbDichVu = new ComboBox();
            label9 = new Label();
            cbLoaiDV = new ComboBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            panelRoom = new FlowLayoutPanel();
            panel6 = new Panel();
            picRoom = new PictureBox();
            label7 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            pnlTitle.SuspendLayout();
            pnlMain.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgHoadonDV).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgPhuThu).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgHoaDon).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbGiamGia).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbSoLuong).BeginInit();
            groupBox1.SuspendLayout();
            panelRoom.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRoom).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BorderStyle = BorderStyle.Fixed3D;
            pnlTitle.Controls.Add(label1);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1201, 64);
            pnlTitle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(17, 23);
            label1.Name = "label1";
            label1.Size = new Size(319, 25);
            label1.TabIndex = 1;
            label1.Text = "Sử dụng dịch vụ và thanh toán";
            // 
            // pnlMain
            // 
            pnlMain.AutoScroll = true;
            pnlMain.Controls.Add(groupBox6);
            pnlMain.Controls.Add(groupBox5);
            pnlMain.Controls.Add(groupBox4);
            pnlMain.Controls.Add(groupBox3);
            pnlMain.Controls.Add(groupBox2);
            pnlMain.Controls.Add(groupBox1);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 64);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1201, 632);
            pnlMain.TabIndex = 1;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dtgHoadonDV);
            groupBox6.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox6.ForeColor = Color.Teal;
            groupBox6.Location = new Point(293, 389);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(884, 453);
            groupBox6.TabIndex = 14;
            groupBox6.TabStop = false;
            groupBox6.Text = "Hóa đơn dịch vụ";
            // 
            // dtgHoadonDV
            // 
            dtgHoadonDV.BackgroundColor = SystemColors.GradientInactiveCaption;
            dtgHoadonDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgHoadonDV.Columns.AddRange(new DataGridViewColumn[] { stt, NameService, Price, Quantity, TotalService });
            dtgHoadonDV.Location = new Point(12, 26);
            dtgHoadonDV.Name = "dtgHoadonDV";
            dtgHoadonDV.RowHeadersWidth = 51;
            dtgHoadonDV.Size = new Size(861, 413);
            dtgHoadonDV.TabIndex = 0;
            // 
            // stt
            // 
            stt.HeaderText = "STT";
            stt.MinimumWidth = 6;
            stt.Name = "stt";
            stt.Width = 80;
            // 
            // NameService
            // 
            NameService.HeaderText = "Tên dịch vụ";
            NameService.MinimumWidth = 6;
            NameService.Name = "NameService";
            NameService.Width = 350;
            // 
            // Price
            // 
            Price.HeaderText = "Đơn giá";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 140;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Số lượng";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 130;
            // 
            // TotalService
            // 
            TotalService.HeaderText = "Thành tiền";
            TotalService.MinimumWidth = 6;
            TotalService.Name = "TotalService";
            TotalService.Width = 140;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dtgPhuThu);
            groupBox5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox5.ForeColor = Color.Teal;
            groupBox5.Location = new Point(293, 848);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(884, 279);
            groupBox5.TabIndex = 13;
            groupBox5.TabStop = false;
            groupBox5.Text = "Chính sách phụ thu";
            // 
            // dtgPhuThu
            // 
            dtgPhuThu.BackgroundColor = SystemColors.GradientInactiveCaption;
            dtgPhuThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPhuThu.Location = new Point(12, 26);
            dtgPhuThu.Name = "dtgPhuThu";
            dtgPhuThu.RowHeadersWidth = 51;
            dtgPhuThu.Size = new Size(861, 231);
            dtgPhuThu.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dtgHoaDon);
            groupBox4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox4.ForeColor = Color.Teal;
            groupBox4.Location = new Point(293, 210);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(884, 163);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hóa đơn tiền phòng";
            // 
            // dtgHoaDon
            // 
            dtgHoaDon.BackgroundColor = SystemColors.GradientInactiveCaption;
            dtgHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgHoaDon.Columns.AddRange(new DataGridViewColumn[] { NameRoom, PriceService, DateCheckin, DateCheckout, PriceRoom, OtherPrice, Total });
            dtgHoaDon.Location = new Point(8, 26);
            dtgHoaDon.Name = "dtgHoaDon";
            dtgHoaDon.RowHeadersWidth = 51;
            dtgHoaDon.Size = new Size(870, 131);
            dtgHoaDon.TabIndex = 0;
            // 
            // NameRoom
            // 
            NameRoom.HeaderText = "Tên phòng";
            NameRoom.MinimumWidth = 6;
            NameRoom.Name = "NameRoom";
            NameRoom.Width = 125;
            // 
            // PriceService
            // 
            PriceService.HeaderText = "Đơn giá";
            PriceService.MinimumWidth = 6;
            PriceService.Name = "PriceService";
            PriceService.Width = 125;
            // 
            // DateCheckin
            // 
            DateCheckin.HeaderText = "Ngày nhận";
            DateCheckin.MinimumWidth = 6;
            DateCheckin.Name = "DateCheckin";
            DateCheckin.Width = 110;
            // 
            // DateCheckout
            // 
            DateCheckout.HeaderText = "Ngày trả";
            DateCheckout.MinimumWidth = 6;
            DateCheckout.Name = "DateCheckout";
            DateCheckout.Width = 110;
            // 
            // PriceRoom
            // 
            PriceRoom.HeaderText = "Tiền phòng";
            PriceRoom.MinimumWidth = 6;
            PriceRoom.Name = "PriceRoom";
            PriceRoom.Width = 125;
            // 
            // OtherPrice
            // 
            OtherPrice.HeaderText = "Phụ thu";
            OtherPrice.MinimumWidth = 6;
            OtherPrice.Name = "OtherPrice";
            OtherPrice.Width = 125;
            // 
            // Total
            // 
            Total.HeaderText = "Thành tiền";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.Width = 125;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnThanhToan);
            groupBox3.Controls.Add(nbGiamGia);
            groupBox3.Controls.Add(tbTongTien);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label13);
            groupBox3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.Teal;
            groupBox3.Location = new Point(19, 523);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(268, 215);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.Teal;
            btnThanhToan.BackgroundColor = Color.Teal;
            btnThanhToan.BorderColor = Color.PaleVioletRed;
            btnThanhToan.BorderRadius = 20;
            btnThanhToan.BorderSize = 0;
            btnThanhToan.FlatAppearance.BorderSize = 0;
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(42, 156);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(188, 39);
            btnThanhToan.TabIndex = 15;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.TextColor = Color.White;
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // nbGiamGia
            // 
            nbGiamGia.Location = new Point(15, 110);
            nbGiamGia.Name = "nbGiamGia";
            nbGiamGia.Size = new Size(243, 27);
            nbGiamGia.TabIndex = 14;
            nbGiamGia.TextAlign = HorizontalAlignment.Center;
            // 
            // tbTongTien
            // 
            tbTongTien.BorderStyle = BorderStyle.FixedSingle;
            tbTongTien.Location = new Point(15, 57);
            tbTongTien.Name = "tbTongTien";
            tbTongTien.Size = new Size(243, 27);
            tbTongTien.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 87);
            label12.Name = "label12";
            label12.Size = new Size(78, 19);
            label12.TabIndex = 12;
            label12.Text = "Giảm giá";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 33);
            label13.Name = "label13";
            label13.Size = new Size(79, 19);
            label13.TabIndex = 11;
            label13.Text = "Tổng tiền";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnThemDV);
            groupBox2.Controls.Add(nbSoLuong);
            groupBox2.Controls.Add(tbGia);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(cbDichVu);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(cbLoaiDV);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Teal;
            groupBox2.Location = new Point(19, 209);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(268, 308);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách dịch vụ";
            // 
            // btnThemDV
            // 
            btnThemDV.BackColor = Color.Teal;
            btnThemDV.BackgroundColor = Color.Teal;
            btnThemDV.BorderColor = Color.PaleVioletRed;
            btnThemDV.BorderRadius = 20;
            btnThemDV.BorderSize = 0;
            btnThemDV.FlatAppearance.BorderSize = 0;
            btnThemDV.FlatStyle = FlatStyle.Flat;
            btnThemDV.ForeColor = Color.White;
            btnThemDV.Location = new Point(44, 256);
            btnThemDV.Name = "btnThemDV";
            btnThemDV.Size = new Size(176, 39);
            btnThemDV.TabIndex = 10;
            btnThemDV.Text = "Thêm dịch vụ";
            btnThemDV.TextColor = Color.White;
            btnThemDV.UseVisualStyleBackColor = false;
            btnThemDV.Click += btnThemDV_Click;
            // 
            // nbSoLuong
            // 
            nbSoLuong.Location = new Point(15, 216);
            nbSoLuong.Name = "nbSoLuong";
            nbSoLuong.Size = new Size(243, 27);
            nbSoLuong.TabIndex = 9;
            nbSoLuong.TextAlign = HorizontalAlignment.Center;
            // 
            // tbGia
            // 
            tbGia.BorderStyle = BorderStyle.FixedSingle;
            tbGia.Location = new Point(15, 163);
            tbGia.Name = "tbGia";
            tbGia.Size = new Size(243, 27);
            tbGia.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 193);
            label10.Name = "label10";
            label10.Size = new Size(74, 19);
            label10.TabIndex = 6;
            label10.Text = "Số lượng";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 139);
            label11.Name = "label11";
            label11.Size = new Size(37, 19);
            label11.TabIndex = 4;
            label11.Text = "Giá";
            // 
            // cbDichVu
            // 
            cbDichVu.FormattingEnabled = true;
            cbDichVu.Location = new Point(15, 108);
            cbDichVu.Name = "cbDichVu";
            cbDichVu.Size = new Size(243, 27);
            cbDichVu.TabIndex = 3;
            cbDichVu.SelectedIndexChanged += cbDichVu_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 85);
            label9.Name = "label9";
            label9.Size = new Size(65, 19);
            label9.TabIndex = 2;
            label9.Text = "Dịch vụ";
            // 
            // cbLoaiDV
            // 
            cbLoaiDV.FormattingEnabled = true;
            cbLoaiDV.Location = new Point(15, 54);
            cbLoaiDV.Name = "cbLoaiDV";
            cbLoaiDV.Size = new Size(243, 27);
            cbLoaiDV.TabIndex = 1;
            cbLoaiDV.SelectedIndexChanged += cbLoaiDV_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 31);
            label8.Name = "label8";
            label8.Size = new Size(100, 19);
            label8.TabIndex = 0;
            label8.Text = "Loại dịch vụ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panelRoom);
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Teal;
            groupBox1.Location = new Point(21, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1156, 176);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách phòng";
            // 
            // panelRoom
            // 
            panelRoom.AutoScroll = true;
            panelRoom.Controls.Add(panel6);
            panelRoom.Dock = DockStyle.Right;
            panelRoom.Location = new Point(284, 23);
            panelRoom.Name = "panelRoom";
            panelRoom.Size = new Size(869, 150);
            panelRoom.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Bisque;
            panel6.Controls.Add(picRoom);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(111, 91);
            panel6.TabIndex = 5;
            // 
            // picRoom
            // 
            picRoom.Location = new Point(36, 13);
            picRoom.Name = "picRoom";
            picRoom.Size = new Size(40, 36);
            picRoom.SizeMode = PictureBoxSizeMode.StretchImage;
            picRoom.TabIndex = 2;
            picRoom.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(13, 52);
            label7.Name = "label7";
            label7.Size = new Size(87, 19);
            label7.TabIndex = 1;
            label7.Text = "Phòng 103";
            // 
            // panel4
            // 
            panel4.BackColor = Color.PowderBlue;
            panel4.Controls.Add(label5);
            panel4.Location = new Point(144, 26);
            panel4.Name = "panel4";
            panel4.Size = new Size(91, 32);
            panel4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(2, 6);
            label5.Name = "label5";
            label5.Size = new Size(86, 19);
            label5.TabIndex = 1;
            label5.Text = "Đang chọn";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkOrange;
            panel3.Controls.Add(label4);
            panel3.ForeColor = Color.Teal;
            panel3.Location = new Point(30, 129);
            panel3.Name = "panel3";
            panel3.Size = new Size(91, 32);
            panel3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(2, 6);
            label4.Name = "label4";
            label4.Size = new Size(88, 19);
            label4.TabIndex = 1;
            label4.Text = "Phòng VIP";
            // 
            // panel2
            // 
            panel2.BackColor = Color.BurlyWood;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(29, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(91, 32);
            panel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(2, 6);
            label3.Name = "label3";
            label3.Size = new Size(84, 19);
            label3.TabIndex = 1;
            label3.Text = "Phòng đôi";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(30, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(91, 32);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(2, 6);
            label2.Name = "label2";
            label2.Size = new Size(87, 19);
            label2.TabIndex = 1;
            label2.Text = "Phòng đơn";
            // 
            // UseServicePayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlMain);
            Controls.Add(pnlTitle);
            Name = "UseServicePayment";
            Size = new Size(1201, 696);
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            pnlMain.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgHoadonDV).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgPhuThu).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgHoaDon).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nbGiamGia).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nbSoLuong).EndInit();
            groupBox1.ResumeLayout(false);
            panelRoom.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picRoom).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitle;
        private Label label1;
        private Panel pnlMain;
        private GroupBox groupBox1;
        private Panel panel1;
        private Panel panel3;
        private Label label4;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Panel room;
        private PictureBox pictureBox1;
        private Label lbTenPhong;
        private Panel panel4;
        private Label label5;
        private GroupBox groupBox2;
        private NumericUpDown nbSoLuong;
        private TextBox tbGia;
        private Label label10;
        private Label label11;
        private ComboBox cbDichVu;
        private Label label9;
        private ComboBox cbLoaiDV;
        private Label label8;
        private Panel panel6;
        private PictureBox pictureBox2;
        private Label label7;
        private GroupBox groupBox3;
        private Assets.CusButton btnThanhToan;
        private NumericUpDown nbGiamGia;
        private TextBox tbTongTien;
        private Label label12;
        private Label label13;
        private Assets.CusButton btnThemDV;
        private GroupBox groupBox4;
        private DataGridView dtgHoaDon;
        private GroupBox groupBox5;
        private DataGridView dtgPhuThu;
        private DataGridViewTextBoxColumn NameRoom;
        private DataGridViewTextBoxColumn PriceService;
        private DataGridViewTextBoxColumn DateCheckin;
        private DataGridViewTextBoxColumn DateCheckout;
        private DataGridViewTextBoxColumn PriceRoom;
        private DataGridViewTextBoxColumn OtherPrice;
        private DataGridViewTextBoxColumn Total;
        private GroupBox groupBox6;
        private DataGridView dtgHoadonDV;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn NameService;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn TotalService;
        private FlowLayoutPanel panelRoom;
        private PictureBox picRoom;
    }
}
