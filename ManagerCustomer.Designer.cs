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
            cusButton2 = new Assets.CusButton();
            dtgListRoom = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            CCCD = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Nation = new DataGridViewTextBoxColumn();
            groupBox4 = new GroupBox();
            btnClose = new Assets.CusButton();
            btnAdd = new Assets.CusButton();
            btnUpdate = new Assets.CusButton();
            groupBox1 = new GroupBox();
            textBox10 = new TextBox();
            label11 = new Label();
            textBox9 = new TextBox();
            label9 = new Label();
            textBox8 = new TextBox();
            label2 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label10 = new Label();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            btnSearch = new Assets.CusButton();
            label5 = new Label();
            pnlTitle.SuspendLayout();
            pnlMain.SuspendLayout();
            lstRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListRoom).BeginInit();
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
            lstRoom.Controls.Add(cusButton2);
            lstRoom.Controls.Add(dtgListRoom);
            lstRoom.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstRoom.ForeColor = Color.Teal;
            lstRoom.Location = new Point(59, 354);
            lstRoom.Name = "lstRoom";
            lstRoom.Size = new Size(1064, 524);
            lstRoom.TabIndex = 21;
            lstRoom.TabStop = false;
            lstRoom.Text = "Danh sách phòng";
            // 
            // cusButton2
            // 
            cusButton2.BackColor = Color.Teal;
            cusButton2.BackgroundColor = Color.Teal;
            cusButton2.BorderColor = Color.Teal;
            cusButton2.BorderRadius = 20;
            cusButton2.BorderSize = 1;
            cusButton2.FlatAppearance.BorderSize = 0;
            cusButton2.FlatStyle = FlatStyle.Flat;
            cusButton2.ForeColor = Color.White;
            cusButton2.Location = new Point(944, 26);
            cusButton2.Name = "cusButton2";
            cusButton2.Size = new Size(104, 32);
            cusButton2.TabIndex = 12;
            cusButton2.Text = "Xuất";
            cusButton2.TextColor = Color.White;
            cusButton2.UseVisualStyleBackColor = false;
            // 
            // dtgListRoom
            // 
            dtgListRoom.BackgroundColor = SystemColors.GradientInactiveCaption;
            dtgListRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListRoom.Columns.AddRange(new DataGridViewColumn[] { ID, CustomerName, CCCD, type, phone, Address, Nation });
            dtgListRoom.Location = new Point(11, 69);
            dtgListRoom.Name = "dtgListRoom";
            dtgListRoom.RowHeadersWidth = 51;
            dtgListRoom.Size = new Size(1043, 449);
            dtgListRoom.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "Mã";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // CustomerName
            // 
            CustomerName.HeaderText = "Tên khách hàng";
            CustomerName.MinimumWidth = 6;
            CustomerName.Name = "CustomerName";
            CustomerName.Width = 200;
            // 
            // CCCD
            // 
            CCCD.HeaderText = "Số CCCD/CMND";
            CCCD.MinimumWidth = 6;
            CCCD.Name = "CCCD";
            CCCD.Width = 150;
            // 
            // type
            // 
            type.HeaderText = "Loại";
            type.MinimumWidth = 6;
            type.Name = "type";
            type.Width = 110;
            // 
            // phone
            // 
            phone.HeaderText = "SĐT";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            phone.Width = 130;
            // 
            // Address
            // 
            Address.HeaderText = "Địa chỉ";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.Width = 150;
            // 
            // Nation
            // 
            Nation.HeaderText = "Quốc tịch";
            Nation.MinimumWidth = 6;
            Nation.Name = "Nation";
            Nation.Width = 130;
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
            btnClose.Location = new Point(19, 93);
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
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox10);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(textBox9);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
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
            // textBox10
            // 
            textBox10.BorderStyle = BorderStyle.FixedSingle;
            textBox10.Font = new Font("Times New Roman", 10.2F);
            textBox10.Location = new Point(296, 214);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(261, 27);
            textBox10.TabIndex = 21;
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
            // textBox9
            // 
            textBox9.BorderStyle = BorderStyle.FixedSingle;
            textBox9.Font = new Font("Times New Roman", 10.2F);
            textBox9.Location = new Point(296, 161);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(268, 27);
            textBox9.TabIndex = 19;
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
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.FixedSingle;
            textBox8.Font = new Font("Times New Roman", 10.2F);
            textBox8.Location = new Point(16, 213);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(261, 27);
            textBox8.TabIndex = 17;
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
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Times New Roman", 10.2F);
            textBox5.Location = new Point(296, 107);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(268, 27);
            textBox5.TabIndex = 15;
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
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Font = new Font("Times New Roman", 10.2F);
            textBox6.Location = new Point(296, 54);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(268, 27);
            textBox6.TabIndex = 13;
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
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Font = new Font("Times New Roman", 10.2F);
            textBox7.Location = new Point(16, 266);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(268, 27);
            textBox7.TabIndex = 11;
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
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Times New Roman", 10.2F);
            textBox4.Location = new Point(16, 159);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(261, 27);
            textBox4.TabIndex = 9;
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
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Times New Roman", 10.2F);
            textBox3.Location = new Point(16, 106);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(261, 27);
            textBox3.TabIndex = 7;
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
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Times New Roman", 10.2F);
            textBox1.Location = new Point(16, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 27);
            textBox1.TabIndex = 5;
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
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(comboBox1);
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
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(10, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(217, 27);
            textBox2.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mã khách hàng", "Tên khách hàng", "Số CCCD/CMND", "Số điện thoại" });
            comboBox1.Location = new Point(132, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(205, 27);
            comboBox1.TabIndex = 8;
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
            ((System.ComponentModel.ISupportInitialize)dtgListRoom).EndInit();
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
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Assets.CusButton btnSearch;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox textBox9;
        private Label label9;
        private TextBox textBox8;
        private Label label2;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox1;
        private Label label10;
        private GroupBox groupBox4;
        private Assets.CusButton btnAdd;
        private Assets.CusButton btnUpdate;
        private TextBox textBox10;
        private Label label11;
        private GroupBox lstRoom;
        private Assets.CusButton cusButton2;
        private DataGridView dtgListRoom;
        private Assets.CusButton btnClose;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn CCCD;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Nation;
    }
}
