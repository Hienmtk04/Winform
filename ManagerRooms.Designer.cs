namespace HotelManage
{
    partial class ManagerRooms
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
            label1 = new Label();
            pnlManagerRoom = new Panel();
            lstRoom = new GroupBox();
            dtgListRoom = new DataGridView();
            groupBox1 = new GroupBox();
            cbLoaiPhong = new ComboBox();
            cbTrangThai = new ComboBox();
            tbPeople = new TextBox();
            label9 = new Label();
            label6 = new Label();
            tbPrice = new TextBox();
            label7 = new Label();
            label8 = new Label();
            tbNameRoom = new TextBox();
            label3 = new Label();
            tbIDRoom = new TextBox();
            label2 = new Label();
            groupBox4 = new GroupBox();
            btnExit = new Assets.CusButton();
            btnUpdate = new Assets.CusButton();
            btnAdd = new Assets.CusButton();
            groupBox2 = new GroupBox();
            btnSearch = new Assets.CusButton();
            tbWordSearch = new TextBox();
            label5 = new Label();
            btnExport = new Assets.CusButton();
            pnlTittle.SuspendLayout();
            pnlManagerRoom.SuspendLayout();
            lstRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListRoom).BeginInit();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTittle
            // 
            pnlTittle.BorderStyle = BorderStyle.Fixed3D;
            pnlTittle.Controls.Add(label1);
            pnlTittle.Dock = DockStyle.Top;
            pnlTittle.Location = new Point(0, 0);
            pnlTittle.Name = "pnlTittle";
            pnlTittle.Size = new Size(1201, 56);
            pnlTittle.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 1;
            label1.Text = "Quản lý phòng";
            // 
            // pnlManagerRoom
            // 
            pnlManagerRoom.AutoScroll = true;
            pnlManagerRoom.Controls.Add(lstRoom);
            pnlManagerRoom.Controls.Add(groupBox1);
            pnlManagerRoom.Controls.Add(groupBox4);
            pnlManagerRoom.Controls.Add(groupBox2);
            pnlManagerRoom.Dock = DockStyle.Fill;
            pnlManagerRoom.Location = new Point(0, 56);
            pnlManagerRoom.Name = "pnlManagerRoom";
            pnlManagerRoom.Size = new Size(1201, 690);
            pnlManagerRoom.TabIndex = 2;
            // 
            // lstRoom
            // 
            lstRoom.Controls.Add(btnExport);
            lstRoom.Controls.Add(dtgListRoom);
            lstRoom.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstRoom.ForeColor = Color.Teal;
            lstRoom.Location = new Point(49, 293);
            lstRoom.Name = "lstRoom";
            lstRoom.Size = new Size(1070, 524);
            lstRoom.TabIndex = 13;
            lstRoom.TabStop = false;
            lstRoom.Text = "Danh sách phòng";
            // 
            // dtgListRoom
            // 
            dtgListRoom.BackgroundColor = SystemColors.GradientInactiveCaption;
            dtgListRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListRoom.Location = new Point(50, 75);
            dtgListRoom.Name = "dtgListRoom";
            dtgListRoom.RowHeadersWidth = 51;
            dtgListRoom.Size = new Size(963, 449);
            dtgListRoom.TabIndex = 13;
            dtgListRoom.CellClick += dtgListRoom_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbLoaiPhong);
            groupBox1.Controls.Add(cbTrangThai);
            groupBox1.Controls.Add(tbPeople);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbPrice);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(tbNameRoom);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbIDRoom);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox1.ForeColor = Color.Teal;
            groupBox1.Location = new Point(551, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(568, 254);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phòng";
            // 
            // cbLoaiPhong
            // 
            cbLoaiPhong.FormattingEnabled = true;
            cbLoaiPhong.Location = new Point(296, 64);
            cbLoaiPhong.Name = "cbLoaiPhong";
            cbLoaiPhong.Size = new Size(238, 27);
            cbLoaiPhong.TabIndex = 16;
            // 
            // cbTrangThai
            // 
            cbTrangThai.FormattingEnabled = true;
            cbTrangThai.Location = new Point(16, 185);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(243, 27);
            cbTrangThai.TabIndex = 9;
            // 
            // tbPeople
            // 
            tbPeople.BorderStyle = BorderStyle.FixedSingle;
            tbPeople.Font = new Font("Times New Roman", 10.2F);
            tbPeople.Location = new Point(296, 186);
            tbPeople.Name = "tbPeople";
            tbPeople.Size = new Size(238, 27);
            tbPeople.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 163);
            label9.Name = "label9";
            label9.Size = new Size(85, 19);
            label9.TabIndex = 8;
            label9.Text = "Trạng thái";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(296, 163);
            label6.Name = "label6";
            label6.Size = new Size(120, 19);
            label6.TabIndex = 14;
            label6.Text = "Số người tối đa";
            // 
            // tbPrice
            // 
            tbPrice.BorderStyle = BorderStyle.FixedSingle;
            tbPrice.Font = new Font("Times New Roman", 10.2F);
            tbPrice.Location = new Point(296, 124);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(238, 27);
            tbPrice.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(296, 101);
            label7.Name = "label7";
            label7.Size = new Size(86, 19);
            label7.TabIndex = 12;
            label7.Text = "Giá phòng";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(296, 42);
            label8.Name = "label8";
            label8.Size = new Size(92, 19);
            label8.TabIndex = 10;
            label8.Text = "Loại phòng";
            // 
            // tbNameRoom
            // 
            tbNameRoom.BorderStyle = BorderStyle.FixedSingle;
            tbNameRoom.Font = new Font("Times New Roman", 10.2F);
            tbNameRoom.Location = new Point(16, 124);
            tbNameRoom.Name = "tbNameRoom";
            tbNameRoom.Size = new Size(243, 27);
            tbNameRoom.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 101);
            label3.Name = "label3";
            label3.Size = new Size(85, 19);
            label3.TabIndex = 6;
            label3.Text = "Tên phòng";
            // 
            // tbIDRoom
            // 
            tbIDRoom.BorderStyle = BorderStyle.FixedSingle;
            tbIDRoom.Font = new Font("Times New Roman", 10.2F);
            tbIDRoom.Location = new Point(16, 65);
            tbIDRoom.Name = "tbIDRoom";
            tbIDRoom.Size = new Size(243, 27);
            tbIDRoom.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 42);
            label2.Name = "label2";
            label2.Size = new Size(82, 19);
            label2.TabIndex = 4;
            label2.Text = "Mã phòng";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnExit);
            groupBox4.Controls.Add(btnUpdate);
            groupBox4.Controls.Add(btnAdd);
            groupBox4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.Teal;
            groupBox4.Location = new Point(49, 116);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(475, 153);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chức năng";
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
            btnExit.Location = new Point(146, 94);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(168, 35);
            btnExit.TabIndex = 16;
            btnExit.Text = "Đóng";
            btnExit.TextColor = Color.White;
            btnExit.UseVisualStyleBackColor = false;
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
            btnUpdate.Location = new Point(258, 37);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(168, 35);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.TextColor = Color.White;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
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
            btnAdd.Location = new Point(35, 37);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(168, 35);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Thêm";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(tbWordSearch);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox2.ForeColor = Color.Teal;
            groupBox2.Location = new Point(49, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(475, 95);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm ";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Teal;
            btnSearch.BackgroundColor = Color.Teal;
            btnSearch.BorderColor = Color.Teal;
            btnSearch.BorderRadius = 20;
            btnSearch.BorderSize = 1;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(299, 48);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(127, 35);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbWordSearch
            // 
            tbWordSearch.BorderStyle = BorderStyle.FixedSingle;
            tbWordSearch.Font = new Font("Times New Roman", 10.2F);
            tbWordSearch.Location = new Point(16, 54);
            tbWordSearch.Name = "tbWordSearch";
            tbWordSearch.Size = new Size(231, 27);
            tbWordSearch.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 31);
            label5.Name = "label5";
            label5.Size = new Size(85, 19);
            label5.TabIndex = 4;
            label5.Text = "Tên phòng";
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
            btnExport.Location = new Point(909, 26);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(104, 32);
            btnExport.TabIndex = 14;
            btnExport.Text = "Xuất";
            btnExport.TextColor = Color.White;
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // ManagerRooms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlManagerRoom);
            Controls.Add(pnlTittle);
            Name = "ManagerRooms";
            Size = new Size(1201, 746);
            Load += ManagerRooms_Load;
            pnlTittle.ResumeLayout(false);
            pnlTittle.PerformLayout();
            pnlManagerRoom.ResumeLayout(false);
            lstRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgListRoom).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTittle;
        private Label label1;
        private Panel pnlManagerRoom;
        private GroupBox lstRoom;
        private DataGridView dtgListRoom;
        private GroupBox groupBox1;
        private ComboBox cbLoaiPhong;
        private ComboBox cbTrangThai;
        private TextBox tbPeople;
        private Label label9;
        private Label label6;
        private TextBox tbPrice;
        private Label label7;
        private Label label8;
        private TextBox tbNameRoom;
        private Label label3;
        private TextBox tbIDRoom;
        private Label label2;
        private GroupBox groupBox4;
        private GroupBox groupBox2;
        private TextBox tbWordSearch;
        private Label label5;
        private Assets.CusButton btnExit;
        private Assets.CusButton btnUpdate;
        private Assets.CusButton btnAdd;
        private Assets.CusButton btnSearch;
        private Assets.CusButton btnExport;
    }
}
