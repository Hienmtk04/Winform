namespace HotelManage
{
    partial class AddCustomer
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
            pnlTitle.TabIndex = 2;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.Teal;
            lbTitle.Location = new Point(12, 12);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(192, 25);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Thêm khách hàng";
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(groupBox1);
            pnlMain.Controls.Add(groupBox4);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 48);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(800, 399);
            pnlMain.TabIndex = 3;
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
            groupBox1.Location = new Point(24, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(580, 309);
            groupBox1.TabIndex = 14;
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
            cbGioi_Tinh.Items.AddRange(new object[] { "Nam", "Nữ" });
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
            // groupBox4
            // 
            groupBox4.Controls.Add(lbExit);
            groupBox4.Controls.Add(btnExit);
            groupBox4.Controls.Add(btnThem);
            groupBox4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.Teal;
            groupBox4.Location = new Point(621, 28);
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
            btnThem.Text = "Thêm khách hàng";
            btnThem.TextColor = Color.White;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 447);
            Controls.Add(pnlMain);
            Controls.Add(pnlTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCustomer";
            Load += AddCustomer_Load;
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
        private GroupBox groupBox4;
        private Label lbExit;
        private Assets.CusButton btnExit;
        private Assets.CusButton btnThem;
        private GroupBox groupBox1;
        private DateTimePicker dtNgay_Sinh;
        private ComboBox cbGioi_Tinh;
        private ComboBox cbLoai_KH;
        private TextBox tbQuoc_Tich;
        private Label label11;
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
    }
}