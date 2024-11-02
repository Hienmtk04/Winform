namespace HotelManage
{
    partial class AddRoom
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
            groupBox4 = new GroupBox();
            lbExit = new Label();
            btnExit = new Assets.CusButton();
            btnThem = new Assets.CusButton();
            groupBox1 = new GroupBox();
            tbSoNguoi = new TextBox();
            label6 = new Label();
            cbLoaiPhong = new ComboBox();
            label4 = new Label();
            tbTenPhong = new TextBox();
            label5 = new Label();
            cbTrangThai = new ComboBox();
            label3 = new Label();
            tbGiaPhong = new TextBox();
            label2 = new Label();
            tbMaPhong = new TextBox();
            label1 = new Label();
            pnlTitle.SuspendLayout();
            pnlMain.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.Controls.Add(lbTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(697, 48);
            pnlTitle.TabIndex = 1;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.Teal;
            lbTitle.Location = new Point(12, 12);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(138, 25);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Thêm phòng";
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(groupBox4);
            pnlMain.Controls.Add(groupBox1);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 48);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(697, 402);
            pnlMain.TabIndex = 2;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lbExit);
            groupBox4.Controls.Add(btnExit);
            groupBox4.Controls.Add(btnThem);
            groupBox4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.Teal;
            groupBox4.Location = new Point(68, 283);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(558, 97);
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
            btnExit.Location = new Point(298, 46);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(221, 35);
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
            btnThem.Location = new Point(32, 46);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(221, 35);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm phòng";
            btnThem.TextColor = Color.White;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbSoNguoi);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbLoaiPhong);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbTenPhong);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbTrangThai);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbGiaPhong);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbMaPhong);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Teal;
            groupBox1.Location = new Point(39, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(616, 259);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin dịch vụ";
            // 
            // tbSoNguoi
            // 
            tbSoNguoi.BorderStyle = BorderStyle.FixedSingle;
            tbSoNguoi.Location = new Point(338, 170);
            tbSoNguoi.Name = "tbSoNguoi";
            tbSoNguoi.Size = new Size(255, 27);
            tbSoNguoi.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(338, 148);
            label6.Name = "label6";
            label6.Size = new Size(120, 19);
            label6.TabIndex = 10;
            label6.Text = "Số người tối đa";
            // 
            // cbLoaiPhong
            // 
            cbLoaiPhong.FormattingEnabled = true;
            cbLoaiPhong.Items.AddRange(new object[] { "Ăn uống", "Giải trí", "Tiện ích", "Sức khỏe" });
            cbLoaiPhong.Location = new Point(338, 110);
            cbLoaiPhong.Name = "cbLoaiPhong";
            cbLoaiPhong.Size = new Size(255, 27);
            cbLoaiPhong.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(338, 88);
            label4.Name = "label4";
            label4.Size = new Size(92, 19);
            label4.TabIndex = 8;
            label4.Text = "Loại phòng";
            // 
            // tbTenPhong
            // 
            tbTenPhong.BorderStyle = BorderStyle.FixedSingle;
            tbTenPhong.Location = new Point(338, 49);
            tbTenPhong.Name = "tbTenPhong";
            tbTenPhong.Size = new Size(255, 27);
            tbTenPhong.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(338, 27);
            label5.Name = "label5";
            label5.Size = new Size(85, 19);
            label5.TabIndex = 6;
            label5.Text = "Tên phòng";
            // 
            // cbTrangThai
            // 
            cbTrangThai.FormattingEnabled = true;
            cbTrangThai.Items.AddRange(new object[] { "Ăn uống", "Giải trí", "Tiện ích", "Sức khỏe" });
            cbTrangThai.Location = new Point(22, 110);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(255, 27);
            cbTrangThai.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 88);
            label3.Name = "label3";
            label3.Size = new Size(85, 19);
            label3.TabIndex = 4;
            label3.Text = "Trạng thái";
            // 
            // tbGiaPhong
            // 
            tbGiaPhong.BorderStyle = BorderStyle.FixedSingle;
            tbGiaPhong.Location = new Point(22, 170);
            tbGiaPhong.Name = "tbGiaPhong";
            tbGiaPhong.Size = new Size(255, 27);
            tbGiaPhong.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 148);
            label2.Name = "label2";
            label2.Size = new Size(86, 19);
            label2.TabIndex = 2;
            label2.Text = "Giá phòng";
            // 
            // tbMaPhong
            // 
            tbMaPhong.BorderStyle = BorderStyle.FixedSingle;
            tbMaPhong.Location = new Point(22, 49);
            tbMaPhong.Name = "tbMaPhong";
            tbMaPhong.Size = new Size(255, 27);
            tbMaPhong.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 27);
            label1.Name = "label1";
            label1.Size = new Size(82, 19);
            label1.TabIndex = 0;
            label1.Text = "Mã phòng";
            // 
            // AddRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 450);
            Controls.Add(pnlMain);
            Controls.Add(pnlTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddRoom";
            Text = "AddRoom";
            Load += AddRoom_Load;
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            pnlMain.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private ComboBox cbTrangThai;
        private Label label3;
        private TextBox tbGiaPhong;
        private Label label2;
        private TextBox tbMaPhong;
        private Label label1;
        private ComboBox cbLoaiPhong;
        private Label label4;
        private TextBox tbTenPhong;
        private Label label5;
        private TextBox tbSoNguoi;
        private Label label6;
    }
}