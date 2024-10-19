namespace HotelManage
{
    partial class ManagerStaff
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
            lbTitle = new Label();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            btnSearch = new Assets.CusButton();
            label5 = new Label();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            textBox5 = new TextBox();
            label9 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            textBox4 = new TextBox();
            dateTimePicker3 = new DateTimePicker();
            label8 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            lstRoom = new GroupBox();
            cusButton2 = new Assets.CusButton();
            dtgListRoom = new DataGridView();
            AdminName = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            CCCD = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            groupBox4 = new GroupBox();
            btnAccessRole = new Assets.CusButton();
            cusButton4 = new Assets.CusButton();
            cusButton3 = new Assets.CusButton();
            cusButton1 = new Assets.CusButton();
            pnlTitle.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            lstRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListRoom).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.Controls.Add(lbTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1173, 62);
            pnlTitle.TabIndex = 0;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.Teal;
            lbTitle.Location = new Point(24, 22);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(193, 25);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Quản lý nhân viên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox2.ForeColor = Color.Teal;
            groupBox2.Location = new Point(24, 77);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(241, 160);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(12, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(217, 27);
            textBox2.TabIndex = 9;
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
            btnSearch.Location = new Point(43, 102);
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
            label5.Size = new Size(210, 19);
            label5.TabIndex = 4;
            label5.Text = "Tài khoản/ Tên/ CCCD/SĐT";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox1.ForeColor = Color.Teal;
            groupBox1.Location = new Point(24, 243);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(241, 216);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tài khoản nhân viên";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(10, 166);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(217, 27);
            dateTimePicker1.TabIndex = 15;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Quản lý", "Lễ tân", "Vệ sinh" });
            comboBox1.Location = new Point(10, 109);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(217, 27);
            comboBox1.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 144);
            label3.Name = "label3";
            label3.Size = new Size(107, 19);
            label3.TabIndex = 12;
            label3.Text = "Ngày vào làm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(117, 19);
            label2.TabIndex = 10;
            label2.Text = "Loại nhân viên";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(10, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 27);
            textBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 31);
            label1.Name = "label1";
            label1.Size = new Size(114, 19);
            label1.TabIndex = 4;
            label1.Text = "Tên đăng nhập";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(dateTimePicker3);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(label7);
            groupBox3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox3.ForeColor = Color.Teal;
            groupBox3.Location = new Point(271, 87);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(902, 150);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin nhân viên";
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(641, 110);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(250, 27);
            textBox5.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(641, 87);
            label9.Name = "label9";
            label9.Size = new Size(62, 19);
            label9.TabIndex = 21;
            label9.Text = "Địa chỉ";
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(641, 53);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(250, 27);
            textBox6.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(641, 31);
            label10.Name = "label10";
            label10.Size = new Size(105, 19);
            label10.TabIndex = 19;
            label10.Text = "Số điện thoại";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(12, 108);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(248, 27);
            textBox4.TabIndex = 18;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.CustomFormat = "dd/MM/yyyy";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.Location = new Point(322, 110);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(250, 27);
            dateTimePicker3.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(322, 88);
            label8.Name = "label8";
            label8.Size = new Size(81, 19);
            label8.TabIndex = 16;
            label8.Text = "Ngày sinh";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Nam", "Nữ" });
            comboBox2.Location = new Point(322, 53);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(250, 27);
            comboBox2.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(322, 31);
            label4.Name = "label4";
            label4.Size = new Size(78, 19);
            label4.TabIndex = 12;
            label4.Text = "Giới tính";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 87);
            label6.Name = "label6";
            label6.Size = new Size(114, 19);
            label6.TabIndex = 10;
            label6.Text = "CCCD/CMND";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(10, 53);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 27);
            textBox3.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 31);
            label7.Name = "label7";
            label7.Size = new Size(40, 19);
            label7.TabIndex = 4;
            label7.Text = "Tên ";
            // 
            // lstRoom
            // 
            lstRoom.Controls.Add(cusButton2);
            lstRoom.Controls.Add(dtgListRoom);
            lstRoom.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstRoom.ForeColor = Color.Teal;
            lstRoom.Location = new Point(271, 243);
            lstRoom.Name = "lstRoom";
            lstRoom.Size = new Size(902, 524);
            lstRoom.TabIndex = 22;
            lstRoom.TabStop = false;
            lstRoom.Text = "Danh sách nhân viên";
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
            cusButton2.Location = new Point(775, 21);
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
            dtgListRoom.Columns.AddRange(new DataGridViewColumn[] { AdminName, Name, type, CCCD, phone, Address });
            dtgListRoom.Location = new Point(11, 64);
            dtgListRoom.Name = "dtgListRoom";
            dtgListRoom.RowHeadersWidth = 51;
            dtgListRoom.Size = new Size(868, 449);
            dtgListRoom.TabIndex = 0;
            // 
            // AdminName
            // 
            AdminName.HeaderText = "Tên đăng nhập";
            AdminName.MinimumWidth = 6;
            AdminName.Name = "AdminName";
            AdminName.Width = 150;
            // 
            // Name
            // 
            Name.HeaderText = "Tên";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.Width = 125;
            // 
            // type
            // 
            type.HeaderText = "Loại";
            type.MinimumWidth = 6;
            type.Name = "type";
            type.Width = 110;
            // 
            // CCCD
            // 
            CCCD.HeaderText = "Số CCCD/CMND";
            CCCD.MinimumWidth = 6;
            CCCD.Name = "CCCD";
            CCCD.Width = 150;
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
            // groupBox4
            // 
            groupBox4.Controls.Add(btnAccessRole);
            groupBox4.Controls.Add(cusButton4);
            groupBox4.Controls.Add(cusButton3);
            groupBox4.Controls.Add(cusButton1);
            groupBox4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox4.ForeColor = Color.Teal;
            groupBox4.Location = new Point(24, 475);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(241, 281);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chức năng";
            // 
            // btnAccessRole
            // 
            btnAccessRole.BackColor = Color.Teal;
            btnAccessRole.BackgroundColor = Color.Teal;
            btnAccessRole.BorderColor = Color.PaleVioletRed;
            btnAccessRole.BorderRadius = 20;
            btnAccessRole.BorderSize = 0;
            btnAccessRole.FlatAppearance.BorderSize = 0;
            btnAccessRole.FlatStyle = FlatStyle.Flat;
            btnAccessRole.ForeColor = Color.White;
            btnAccessRole.Location = new Point(26, 218);
            btnAccessRole.Name = "btnAccessRole";
            btnAccessRole.Size = new Size(186, 35);
            btnAccessRole.TabIndex = 11;
            btnAccessRole.Text = "Quyền truy cập";
            btnAccessRole.TextColor = Color.White;
            btnAccessRole.UseVisualStyleBackColor = false;
            btnAccessRole.Click += btnAccessRole_Click;
            // 
            // cusButton4
            // 
            cusButton4.BackColor = Color.Teal;
            cusButton4.BackgroundColor = Color.Teal;
            cusButton4.BorderColor = Color.PaleVioletRed;
            cusButton4.BorderRadius = 20;
            cusButton4.BorderSize = 0;
            cusButton4.FlatAppearance.BorderSize = 0;
            cusButton4.FlatStyle = FlatStyle.Flat;
            cusButton4.ForeColor = Color.White;
            cusButton4.Location = new Point(27, 158);
            cusButton4.Name = "cusButton4";
            cusButton4.Size = new Size(186, 35);
            cusButton4.TabIndex = 10;
            cusButton4.Text = "Đặt lại mật khẩu ";
            cusButton4.TextColor = Color.White;
            cusButton4.UseVisualStyleBackColor = false;
            // 
            // cusButton3
            // 
            cusButton3.BackColor = Color.Teal;
            cusButton3.BackgroundColor = Color.Teal;
            cusButton3.BorderColor = Color.PaleVioletRed;
            cusButton3.BorderRadius = 20;
            cusButton3.BorderSize = 0;
            cusButton3.FlatAppearance.BorderSize = 0;
            cusButton3.FlatStyle = FlatStyle.Flat;
            cusButton3.ForeColor = Color.White;
            cusButton3.Location = new Point(27, 96);
            cusButton3.Name = "cusButton3";
            cusButton3.Size = new Size(186, 35);
            cusButton3.TabIndex = 9;
            cusButton3.Text = "Cập nhật nhân viên";
            cusButton3.TextColor = Color.White;
            cusButton3.UseVisualStyleBackColor = false;
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
            cusButton1.ForeColor = Color.White;
            cusButton1.Location = new Point(27, 36);
            cusButton1.Name = "cusButton1";
            cusButton1.Size = new Size(186, 35);
            cusButton1.TabIndex = 8;
            cusButton1.Text = "Thêm nhân viên";
            cusButton1.TextColor = Color.White;
            cusButton1.UseVisualStyleBackColor = false;
            // 
            // ManagerStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(groupBox4);
            Controls.Add(lstRoom);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(pnlTitle);
            Size = new Size(1138, 691);
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            lstRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgListRoom).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitle;
        private Label lbTitle;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private Assets.CusButton btnSearch;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private GroupBox groupBox3;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker3;
        private Label label8;
        private ComboBox comboBox2;
        private Label label4;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox5;
        private Label label9;
        private TextBox textBox6;
        private Label label10;
        private GroupBox lstRoom;
        private Assets.CusButton cusButton2;
        private DataGridView dtgListRoom;
        private DataGridViewTextBoxColumn AdminName;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn CCCD;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn Address;
        private GroupBox groupBox4;
        private Assets.CusButton btnAccessRole;
        private Assets.CusButton cusButton4;
        private Assets.CusButton cusButton3;
        private Assets.CusButton cusButton1;
    }
}
