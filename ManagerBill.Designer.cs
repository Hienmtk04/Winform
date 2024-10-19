namespace HotelManage
{
    partial class ManagerBill
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
            pnlMain = new Panel();
            lstRoom = new GroupBox();
            cusButton2 = new Assets.CusButton();
            dtgListRoom = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NameRoom = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            DateCreate = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Discount = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            textBox9 = new TextBox();
            label9 = new Label();
            textBox8 = new TextBox();
            label1 = new Label();
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
            label2 = new Label();
            groupBox4 = new GroupBox();
            cusButton4 = new Assets.CusButton();
            cusButton5 = new Assets.CusButton();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            cusButton1 = new Assets.CusButton();
            label5 = new Label();
            pnlTitle.SuspendLayout();
            pnlMain.SuspendLayout();
            lstRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListRoom).BeginInit();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BorderStyle = BorderStyle.Fixed3D;
            pnlTitle.Controls.Add(lbTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1180, 51);
            pnlTitle.TabIndex = 0;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.Teal;
            lbTitle.Location = new Point(13, 16);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(179, 25);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Quản lý hóa đơn";
            // 
            // pnlMain
            // 
            pnlMain.AutoScroll = true;
            pnlMain.Controls.Add(lstRoom);
            pnlMain.Controls.Add(groupBox1);
            pnlMain.Controls.Add(groupBox4);
            pnlMain.Controls.Add(groupBox2);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 51);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1180, 682);
            pnlMain.TabIndex = 1;
            // 
            // lstRoom
            // 
            lstRoom.Controls.Add(cusButton2);
            lstRoom.Controls.Add(dtgListRoom);
            lstRoom.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstRoom.ForeColor = Color.Teal;
            lstRoom.Location = new Point(51, 295);
            lstRoom.Name = "lstRoom";
            lstRoom.Size = new Size(1082, 524);
            lstRoom.TabIndex = 13;
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
            dtgListRoom.Columns.AddRange(new DataGridViewColumn[] { ID, NameRoom, CustomerName, DateCreate, status, Price, Discount, Total });
            dtgListRoom.Location = new Point(19, 64);
            dtgListRoom.Name = "dtgListRoom";
            dtgListRoom.RowHeadersWidth = 51;
            dtgListRoom.Size = new Size(1043, 370);
            dtgListRoom.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "Mã hóa đơn";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // NameRoom
            // 
            NameRoom.HeaderText = "Tên phòng";
            NameRoom.MinimumWidth = 6;
            NameRoom.Name = "NameRoom";
            NameRoom.Width = 120;
            // 
            // CustomerName
            // 
            CustomerName.HeaderText = "Tên khách hàng";
            CustomerName.MinimumWidth = 6;
            CustomerName.Name = "CustomerName";
            CustomerName.Width = 200;
            // 
            // DateCreate
            // 
            DateCreate.HeaderText = "Ngày tạo";
            DateCreate.MinimumWidth = 6;
            DateCreate.Name = "DateCreate";
            DateCreate.Width = 120;
            // 
            // status
            // 
            status.HeaderText = "Trạng thái";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.Width = 110;
            // 
            // Price
            // 
            Price.HeaderText = "Đơn giá";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 130;
            // 
            // Discount
            // 
            Discount.HeaderText = "Giảm giá";
            Discount.MinimumWidth = 6;
            Discount.Name = "Discount";
            Discount.Width = 80;
            // 
            // Total
            // 
            Total.HeaderText = "Thành tiền";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.Width = 130;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox9);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(label1);
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
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox1.ForeColor = Color.Teal;
            groupBox1.Location = new Point(536, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(592, 250);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // textBox9
            // 
            textBox9.BorderStyle = BorderStyle.FixedSingle;
            textBox9.Font = new Font("Times New Roman", 10.2F);
            textBox9.Location = new Point(295, 213);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(268, 27);
            textBox9.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(295, 190);
            label9.Name = "label9";
            label9.Size = new Size(87, 19);
            label9.TabIndex = 18;
            label9.Text = "Thành tiền";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(295, 31);
            label1.Name = "label1";
            label1.Size = new Size(85, 19);
            label1.TabIndex = 16;
            label1.Text = "Trạng thái";
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Times New Roman", 10.2F);
            textBox5.Location = new Point(295, 159);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(268, 27);
            textBox5.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(295, 136);
            label6.Name = "label6";
            label6.Size = new Size(78, 19);
            label6.TabIndex = 14;
            label6.Text = "Giảm giá";
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Font = new Font("Times New Roman", 10.2F);
            textBox6.Location = new Point(295, 106);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(268, 27);
            textBox6.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(295, 83);
            label7.Name = "label7";
            label7.Size = new Size(66, 19);
            label7.TabIndex = 12;
            label7.Text = "Đơn giá";
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Font = new Font("Times New Roman", 10.2F);
            textBox7.Location = new Point(295, 54);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(268, 27);
            textBox7.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 190);
            label8.Name = "label8";
            label8.Size = new Size(73, 19);
            label8.TabIndex = 10;
            label8.Text = "Ngày tạo";
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
            label4.Size = new Size(109, 19);
            label4.TabIndex = 8;
            label4.Text = "Nhân viên tạo";
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
            label3.Size = new Size(85, 19);
            label3.TabIndex = 6;
            label3.Text = "Tên phòng";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 31);
            label2.Name = "label2";
            label2.Size = new Size(94, 19);
            label2.TabIndex = 4;
            label2.Text = "Mã hóa đơn";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cusButton4);
            groupBox4.Controls.Add(cusButton5);
            groupBox4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.Teal;
            groupBox4.Location = new Point(53, 175);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(453, 97);
            groupBox4.TabIndex = 11;
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
            cusButton4.Location = new Point(234, 36);
            cusButton4.Name = "cusButton4";
            cusButton4.Size = new Size(189, 35);
            cusButton4.TabIndex = 11;
            cusButton4.Text = "Đóng";
            cusButton4.TextColor = Color.White;
            cusButton4.UseVisualStyleBackColor = false;
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
            cusButton5.Location = new Point(22, 36);
            cusButton5.Name = "cusButton5";
            cusButton5.Size = new Size(189, 35);
            cusButton5.TabIndex = 10;
            cusButton5.Text = "Chi tiết hóa đơn";
            cusButton5.TextColor = Color.White;
            cusButton5.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(cusButton1);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox2.ForeColor = Color.Teal;
            groupBox2.Location = new Point(53, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(453, 135);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(10, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(259, 27);
            textBox2.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mã hóa đơn", "Tên khách hàng", "Số CCCD/CMND", "Số điện thoại" });
            comboBox1.Location = new Point(132, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(291, 27);
            comboBox1.TabIndex = 8;
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
            cusButton1.Location = new Point(290, 76);
            cusButton1.Name = "cusButton1";
            cusButton1.Size = new Size(133, 35);
            cusButton1.TabIndex = 7;
            cusButton1.Text = "Tìm kiếm";
            cusButton1.TextColor = Color.White;
            cusButton1.UseVisualStyleBackColor = false;
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
            // ManagerBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlMain);
            Controls.Add(pnlTitle);
            Name = "ManagerBill";
            Size = new Size(1180, 733);
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            pnlMain.ResumeLayout(false);
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

        private Panel pnlTitle;
        private Label lbTitle;
        private Panel pnlMain;
        private GroupBox lstRoom;
        private DataGridView dtgListRoom;
        private GroupBox groupBox1;
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
        private Label label2;
        private GroupBox groupBox4;
        private Assets.CusButton cusButton4;
        private Assets.CusButton cusButton5;
        private GroupBox groupBox2;
        private Assets.CusButton cusButton1;
        private Label label5;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private TextBox textBox9;
        private Label label9;
        private TextBox textBox8;
        private Label label1;
        private Assets.CusButton cusButton2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NameRoom;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn DateCreate;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Discount;
        private DataGridViewTextBoxColumn Total;
    }
}
