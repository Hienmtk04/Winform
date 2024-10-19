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
            btnShowDetail = new Assets.CusButton();
            dataGridView1 = new DataGridView();
            IDRoom = new DataGridViewTextBoxColumn();
            NameCus = new DataGridViewTextBoxColumn();
            IDCustomer = new DataGridViewTextBoxColumn();
            TypeRoom = new DataGridViewTextBoxColumn();
            DateBook = new DataGridViewTextBoxColumn();
            DateCheckOut = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            cusButton5 = new Assets.CusButton();
            cusButton4 = new Assets.CusButton();
            cusButton3 = new Assets.CusButton();
            cusButton2 = new Assets.CusButton();
            groupBox1 = new GroupBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox6 = new TextBox();
            label9 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox8 = new TextBox();
            label11 = new Label();
            textBox7 = new TextBox();
            label10 = new Label();
            ListRoom = new GroupBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            grSearch = new GroupBox();
            cusButton1 = new Assets.CusButton();
            tbIDRoom = new TextBox();
            lbID = new Label();
            pnlTittle.SuspendLayout();
            pnlMain.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            groupBox5.Controls.Add(btnShowDetail);
            groupBox5.Controls.Add(dataGridView1);
            groupBox5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = Color.Teal;
            groupBox5.Location = new Point(60, 544);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1059, 389);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Danh sách đặt phòng trong ngày";
            // 
            // btnShowDetail
            // 
            btnShowDetail.BackColor = Color.Teal;
            btnShowDetail.BackgroundColor = Color.Teal;
            btnShowDetail.BorderColor = Color.Teal;
            btnShowDetail.BorderRadius = 20;
            btnShowDetail.BorderSize = 1;
            btnShowDetail.FlatAppearance.BorderSize = 0;
            btnShowDetail.FlatStyle = FlatStyle.Flat;
            btnShowDetail.ForeColor = Color.White;
            btnShowDetail.Location = new Point(759, 336);
            btnShowDetail.Name = "btnShowDetail";
            btnShowDetail.Size = new Size(228, 35);
            btnShowDetail.TabIndex = 11;
            btnShowDetail.Text = "Xem chi tiết";
            btnShowDetail.TextColor = Color.White;
            btnShowDetail.UseVisualStyleBackColor = false;
            btnShowDetail.Click += btnShowDetail_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDRoom, NameCus, IDCustomer, TypeRoom, DateBook, DateCheckOut });
            dataGridView1.Location = new Point(30, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(996, 259);
            dataGridView1.TabIndex = 0;
            // 
            // IDRoom
            // 
            IDRoom.HeaderText = "Mã đặt phòng  ";
            IDRoom.MinimumWidth = 6;
            IDRoom.Name = "IDRoom";
            IDRoom.Width = 150;
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
            IDCustomer.Width = 200;
            // 
            // TypeRoom
            // 
            TypeRoom.HeaderText = "Loại phòng";
            TypeRoom.MinimumWidth = 6;
            TypeRoom.Name = "TypeRoom";
            TypeRoom.Width = 130;
            // 
            // DateBook
            // 
            DateBook.HeaderText = "Ngày nhận";
            DateBook.MinimumWidth = 6;
            DateBook.Name = "DateBook";
            DateBook.Width = 130;
            // 
            // DateCheckOut
            // 
            DateCheckOut.HeaderText = "Ngày trả";
            DateCheckOut.MinimumWidth = 6;
            DateCheckOut.Name = "DateCheckOut";
            DateCheckOut.Width = 130;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cusButton5);
            groupBox2.Controls.Add(cusButton4);
            groupBox2.Controls.Add(cusButton3);
            groupBox2.Controls.Add(cusButton2);
            groupBox2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox2.ForeColor = Color.Teal;
            groupBox2.Location = new Point(860, 32);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(259, 298);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // cusButton5
            // 
            cusButton5.BackColor = Color.Teal;
            cusButton5.BackgroundColor = Color.Teal;
            cusButton5.BorderColor = Color.PaleVioletRed;
            cusButton5.BorderRadius = 20;
            cusButton5.BorderSize = 0;
            cusButton5.FlatAppearance.BorderSize = 0;
            cusButton5.FlatStyle = FlatStyle.Flat;
            cusButton5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cusButton5.ForeColor = Color.White;
            cusButton5.Location = new Point(28, 221);
            cusButton5.Name = "cusButton5";
            cusButton5.Size = new Size(203, 41);
            cusButton5.TabIndex = 6;
            cusButton5.Text = "Đóng";
            cusButton5.TextColor = Color.White;
            cusButton5.UseVisualStyleBackColor = false;
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
            cusButton4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cusButton4.ForeColor = Color.White;
            cusButton4.Location = new Point(28, 160);
            cusButton4.Name = "cusButton4";
            cusButton4.Size = new Size(203, 41);
            cusButton4.TabIndex = 5;
            cusButton4.Text = "Hủy";
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
            cusButton3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cusButton3.ForeColor = Color.White;
            cusButton3.Location = new Point(28, 97);
            cusButton3.Name = "cusButton3";
            cusButton3.Size = new Size(203, 41);
            cusButton3.TabIndex = 4;
            cusButton3.Text = "Nhận phòng";
            cusButton3.TextColor = Color.White;
            cusButton3.UseVisualStyleBackColor = false;
            cusButton3.Click += cusButton3_Click;
            // 
            // cusButton2
            // 
            cusButton2.BackColor = Color.Teal;
            cusButton2.BackgroundColor = Color.Teal;
            cusButton2.BorderColor = Color.PaleVioletRed;
            cusButton2.BorderRadius = 20;
            cusButton2.BorderSize = 0;
            cusButton2.FlatAppearance.BorderSize = 0;
            cusButton2.FlatStyle = FlatStyle.Flat;
            cusButton2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cusButton2.ForeColor = Color.White;
            cusButton2.Location = new Point(28, 36);
            cusButton2.Name = "cusButton2";
            cusButton2.Size = new Size(203, 41);
            cusButton2.TabIndex = 3;
            cusButton2.Text = "Thêm khách hàng";
            cusButton2.TextColor = Color.White;
            cusButton2.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(label10);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox1.ForeColor = Color.Teal;
            groupBox1.Location = new Point(60, 224);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(775, 298);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhận phòng";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarMonthBackground = SystemColors.Control;
            dateTimePicker2.CalendarTitleBackColor = Color.Teal;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Font = new Font("Times New Roman", 10.2F);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(414, 119);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(290, 27);
            dateTimePicker2.TabIndex = 23;
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
            dateTimePicker1.Location = new Point(414, 59);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(290, 27);
            dateTimePicker1.TabIndex = 22;
            dateTimePicker1.Value = new DateTime(2024, 10, 15, 22, 53, 41, 0);
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
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Times New Roman", 10.2F);
            textBox1.Location = new Point(59, 241);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 27);
            textBox1.TabIndex = 19;
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
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Font = new Font("Times New Roman", 10.2F);
            textBox6.Location = new Point(412, 238);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(292, 27);
            textBox6.TabIndex = 17;
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
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Times New Roman", 10.2F);
            textBox5.Location = new Point(412, 177);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(292, 27);
            textBox5.TabIndex = 15;
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
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Times New Roman", 10.2F);
            textBox4.Location = new Point(59, 180);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(294, 27);
            textBox4.TabIndex = 13;
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
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.FixedSingle;
            textBox8.Font = new Font("Times New Roman", 10.2F);
            textBox8.Location = new Point(59, 122);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(294, 27);
            textBox8.TabIndex = 11;
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
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Font = new Font("Times New Roman", 10.2F);
            textBox7.Location = new Point(59, 63);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(294, 27);
            textBox7.TabIndex = 9;
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
            ListRoom.Controls.Add(comboBox2);
            ListRoom.Controls.Add(comboBox1);
            ListRoom.Controls.Add(label2);
            ListRoom.Controls.Add(label1);
            ListRoom.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            ListRoom.ForeColor = Color.Teal;
            ListRoom.Location = new Point(399, 32);
            ListRoom.Name = "ListRoom";
            ListRoom.Size = new Size(436, 168);
            ListRoom.TabIndex = 1;
            ListRoom.TabStop = false;
            ListRoom.Text = "Danh sách phòng trống";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(37, 125);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(361, 27);
            comboBox2.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Phòng đơn", "Phòng đôi", "Phòng VIP" });
            comboBox1.Location = new Point(37, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(361, 27);
            comboBox1.TabIndex = 7;
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
            grSearch.Controls.Add(tbIDRoom);
            grSearch.Controls.Add(lbID);
            grSearch.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            grSearch.ForeColor = Color.Teal;
            grSearch.Location = new Point(60, 32);
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
            cusButton1.Location = new Point(21, 102);
            cusButton1.Name = "cusButton1";
            cusButton1.Size = new Size(127, 42);
            cusButton1.TabIndex = 2;
            cusButton1.Text = "Tìm kiếm";
            cusButton1.TextColor = Color.White;
            cusButton1.UseVisualStyleBackColor = false;
            // 
            // tbIDRoom
            // 
            tbIDRoom.BorderStyle = BorderStyle.FixedSingle;
            tbIDRoom.Location = new Point(21, 58);
            tbIDRoom.Name = "tbIDRoom";
            tbIDRoom.Size = new Size(252, 27);
            tbIDRoom.TabIndex = 1;
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
            Controls.Add(pnlMain);
            Controls.Add(pnlTittle);
            Name = "AdminRecieve";
            Size = new Size(1180, 733);
            pnlTittle.ResumeLayout(false);
            pnlTittle.PerformLayout();
            pnlMain.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox tbIDRoom;
        private GroupBox ListRoom;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox8;
        private Label label11;
        private TextBox textBox7;
        private Label label10;
        private TextBox textBox6;
        private Label label9;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox1;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label5;
        private GroupBox groupBox2;
        private Assets.CusButton cusButton5;
        private Assets.CusButton cusButton4;
        private Assets.CusButton cusButton3;
        private Assets.CusButton cusButton2;
        private GroupBox groupBox5;
        private Assets.CusButton btnShowDetail;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IDRoom;
        private DataGridViewTextBoxColumn NameCus;
        private DataGridViewTextBoxColumn IDCustomer;
        private DataGridViewTextBoxColumn TypeRoom;
        private DataGridViewTextBoxColumn DateBook;
        private DataGridViewTextBoxColumn DateCheckOut;
    }
}
