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
            IDRoom = new DataGridViewTextBoxColumn();
            NameCus = new DataGridViewTextBoxColumn();
            IDCustomer = new DataGridViewTextBoxColumn();
            TypeRoom = new DataGridViewTextBoxColumn();
            DateBook = new DataGridViewTextBoxColumn();
            DateCheckOut = new DataGridViewTextBoxColumn();
            groupBox4 = new GroupBox();
            cusButton4 = new Assets.CusButton();
            cusButton3 = new Assets.CusButton();
            cusButton2 = new Assets.CusButton();
            cbRecieve = new CheckBox();
            groupBox1 = new GroupBox();
            comboBox3 = new ComboBox();
            dateTimePicker3 = new DateTimePicker();
            comboBox2 = new ComboBox();
            textBox14 = new TextBox();
            label17 = new Label();
            label16 = new Label();
            textBox12 = new TextBox();
            label15 = new Label();
            label14 = new Label();
            textBox10 = new TextBox();
            label13 = new Label();
            label12 = new Label();
            textBox8 = new TextBox();
            label11 = new Label();
            textBox7 = new TextBox();
            label10 = new Label();
            groupBox3 = new GroupBox();
            textBox6 = new TextBox();
            label9 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            cusButton1 = new Assets.CusButton();
            textBox2 = new TextBox();
            label5 = new Label();
            grInfoBooking = new GroupBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDRoom, NameCus, IDCustomer, TypeRoom, DateBook, DateCheckOut });
            dataGridView1.Location = new Point(16, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(969, 259);
            dataGridView1.TabIndex = 0;
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
            // TypeRoom
            // 
            TypeRoom.HeaderText = "Loại phòng";
            TypeRoom.MinimumWidth = 6;
            TypeRoom.Name = "TypeRoom";
            TypeRoom.Width = 125;
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
            // groupBox4
            // 
            groupBox4.Controls.Add(cusButton4);
            groupBox4.Controls.Add(cusButton3);
            groupBox4.Controls.Add(cusButton2);
            groupBox4.Controls.Add(cbRecieve);
            groupBox4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.Teal;
            groupBox4.Location = new Point(714, 337);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(362, 291);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chức năng";
            // 
            // cusButton4
            // 
            cusButton4.BackColor = Color.Teal;
            cusButton4.BackgroundColor = Color.Teal;
            cusButton4.BorderColor = Color.Teal;
            cusButton4.BorderRadius = 20;
            cusButton4.BorderSize = 1;
            cusButton4.FlatAppearance.BorderSize = 0;
            cusButton4.FlatStyle = FlatStyle.Flat;
            cusButton4.ForeColor = Color.White;
            cusButton4.Location = new Point(40, 221);
            cusButton4.Name = "cusButton4";
            cusButton4.Size = new Size(277, 35);
            cusButton4.TabIndex = 10;
            cusButton4.Text = "Đóng";
            cusButton4.TextColor = Color.White;
            cusButton4.UseVisualStyleBackColor = false;
            // 
            // cusButton3
            // 
            cusButton3.BackColor = Color.Teal;
            cusButton3.BackgroundColor = Color.Teal;
            cusButton3.BorderColor = Color.Teal;
            cusButton3.BorderRadius = 20;
            cusButton3.BorderSize = 1;
            cusButton3.FlatAppearance.BorderSize = 0;
            cusButton3.FlatStyle = FlatStyle.Flat;
            cusButton3.ForeColor = Color.White;
            cusButton3.Location = new Point(42, 159);
            cusButton3.Name = "cusButton3";
            cusButton3.Size = new Size(275, 35);
            cusButton3.TabIndex = 9;
            cusButton3.Text = "Hủy";
            cusButton3.TextColor = Color.White;
            cusButton3.UseVisualStyleBackColor = false;
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
            cusButton2.Location = new Point(42, 96);
            cusButton2.Name = "cusButton2";
            cusButton2.Size = new Size(275, 35);
            cusButton2.TabIndex = 8;
            cusButton2.Text = "Đặt phòng";
            cusButton2.TextColor = Color.White;
            cusButton2.UseVisualStyleBackColor = false;
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
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(dateTimePicker3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(textBox14);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(textBox12);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(textBox10);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(textBox7);
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
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Địa phương", "Du lịch" });
            comboBox3.Location = new Point(16, 197);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(257, 27);
            comboBox3.TabIndex = 21;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.CalendarForeColor = Color.Teal;
            dateTimePicker3.CalendarMonthBackground = SystemColors.Control;
            dateTimePicker3.CalendarTitleBackColor = Color.Teal;
            dateTimePicker3.CalendarTitleForeColor = Color.AliceBlue;
            dateTimePicker3.CustomFormat = "dd/MM/yyyy";
            dateTimePicker3.Font = new Font("Times New Roman", 10.2F);
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.Location = new Point(311, 70);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(259, 27);
            dateTimePicker3.TabIndex = 8;
            dateTimePicker3.Value = new DateTime(2024, 10, 15, 22, 53, 41, 0);
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Nam", "Nữ" });
            comboBox2.Location = new Point(311, 197);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(259, 27);
            comboBox2.TabIndex = 20;
            // 
            // textBox14
            // 
            textBox14.BorderStyle = BorderStyle.FixedSingle;
            textBox14.Font = new Font("Times New Roman", 10.2F);
            textBox14.Location = new Point(313, 263);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(257, 27);
            textBox14.TabIndex = 19;
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
            // textBox12
            // 
            textBox12.BorderStyle = BorderStyle.FixedSingle;
            textBox12.Font = new Font("Times New Roman", 10.2F);
            textBox12.Location = new Point(311, 134);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(259, 27);
            textBox12.TabIndex = 15;
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
            // textBox10
            // 
            textBox10.BorderStyle = BorderStyle.FixedSingle;
            textBox10.Font = new Font("Times New Roman", 10.2F);
            textBox10.Location = new Point(16, 263);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(257, 27);
            textBox10.TabIndex = 11;
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
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.FixedSingle;
            textBox8.Font = new Font("Times New Roman", 10.2F);
            textBox8.Location = new Point(16, 134);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(257, 27);
            textBox8.TabIndex = 7;
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
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Font = new Font("Times New Roman", 10.2F);
            textBox7.Location = new Point(16, 70);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(257, 27);
            textBox7.TabIndex = 5;
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
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(textBox3);
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
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Font = new Font("Times New Roman", 10.2F);
            textBox6.Location = new Point(20, 246);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(316, 27);
            textBox6.TabIndex = 11;
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
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Times New Roman", 10.2F);
            textBox5.Location = new Point(20, 184);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(316, 27);
            textBox5.TabIndex = 9;
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
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Times New Roman", 10.2F);
            textBox4.Location = new Point(20, 122);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(316, 27);
            textBox4.TabIndex = 7;
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
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Times New Roman", 10.2F);
            textBox3.Location = new Point(20, 56);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(316, 27);
            textBox3.TabIndex = 5;
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
            groupBox2.Controls.Add(cusButton1);
            groupBox2.Controls.Add(textBox2);
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
            cusButton1.Location = new Point(414, 51);
            cusButton1.Name = "cusButton1";
            cusButton1.Size = new Size(172, 35);
            cusButton1.TabIndex = 7;
            cusButton1.Text = "Tìm kiếm";
            cusButton1.TextColor = Color.White;
            cusButton1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Times New Roman", 10.2F);
            textBox2.Location = new Point(16, 57);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(330, 27);
            textBox2.TabIndex = 5;
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
            grInfoBooking.Controls.Add(dateTimePicker2);
            grInfoBooking.Controls.Add(dateTimePicker1);
            grInfoBooking.Controls.Add(label4);
            grInfoBooking.Controls.Add(label3);
            grInfoBooking.Controls.Add(textBox1);
            grInfoBooking.Controls.Add(label2);
            grInfoBooking.Controls.Add(comboBox1);
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
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarMonthBackground = SystemColors.Control;
            dateTimePicker2.CalendarTitleBackColor = Color.Teal;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Font = new Font("Times New Roman", 10.2F);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(307, 122);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(263, 27);
            dateTimePicker2.TabIndex = 7;
            dateTimePicker2.Value = new DateTime(2024, 10, 15, 22, 53, 41, 0);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.Teal;
            dateTimePicker1.CalendarMonthBackground = SystemColors.Control;
            dateTimePicker1.CalendarTitleBackColor = Color.Teal;
            dateTimePicker1.CalendarTitleForeColor = Color.AliceBlue;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Font = new Font("Times New Roman", 10.2F);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(307, 57);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(263, 27);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.Value = new DateTime(2024, 10, 15, 22, 53, 41, 0);
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
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Times New Roman", 10.2F);
            textBox1.Location = new Point(16, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 27);
            textBox1.TabIndex = 3;
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
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 10.2F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Phòng đơn (SIMP)", "Phòng đôi (COUP)", "Phòng VIP (VIP)" });
            comboBox1.Location = new Point(16, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(257, 27);
            comboBox1.TabIndex = 1;
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
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox6;
        private Label label9;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox3;
        private Label label6;
        private Assets.CusButton cusButton1;
        private GroupBox groupBox1;
        private TextBox textBox7;
        private Label label10;
        private TextBox textBox14;
        private Label label17;
        private Label label16;
        private TextBox textBox12;
        private Label label15;
        private Label label14;
        private TextBox textBox10;
        private Label label13;
        private Label label12;
        private TextBox textBox8;
        private Label label11;
        private GroupBox groupBox4;
        private Assets.CusButton cusButton4;
        private Assets.CusButton cusButton3;
        private Assets.CusButton cusButton2;
        private CheckBox cbRecieve;
        private GroupBox groupBox5;
        private DataGridView dataGridView1;
        private ComboBox comboBox3;
        private DateTimePicker dateTimePicker3;
        private ComboBox comboBox2;
        private Assets.CusButton cusButton5;
        private DataGridViewTextBoxColumn IDRoom;
        private DataGridViewTextBoxColumn NameCus;
        private DataGridViewTextBoxColumn IDCustomer;
        private DataGridViewTextBoxColumn TypeRoom;
        private DataGridViewTextBoxColumn DateBook;
        private DataGridViewTextBoxColumn DateCheckOut;
    }
}
