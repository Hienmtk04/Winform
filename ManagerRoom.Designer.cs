namespace HotelManage
{
    partial class ManagerRoom
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
            pnlMain = new Panel();
            lstRoom = new GroupBox();
            btnExport = new Assets.CusButton();
            dtgListRoom = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NameRoom = new DataGridViewTextBoxColumn();
            TypeRoom = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            QtyPeople = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
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
            cusButton3 = new Assets.CusButton();
            cusButton2 = new Assets.CusButton();
            groupBox2 = new GroupBox();
            cusButton1 = new Assets.CusButton();
            textBox2 = new TextBox();
            label5 = new Label();
            pnlTittle.SuspendLayout();
            pnlMain.SuspendLayout();
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
            pnlTittle.TabIndex = 0;
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
            // pnlMain
            // 
            pnlMain.AutoScroll = true;
            pnlMain.Controls.Add(lstRoom);
            pnlMain.Controls.Add(groupBox1);
            pnlMain.Controls.Add(groupBox4);
            pnlMain.Controls.Add(groupBox2);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 56);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1201, 690);
            pnlMain.TabIndex = 1;
            // 
            // lstRoom
            // 
            lstRoom.Controls.Add(btnExport);
            lstRoom.Controls.Add(dtgListRoom);
            lstRoom.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstRoom.ForeColor = Color.Teal;
            lstRoom.Location = new Point(49, 288);
            lstRoom.Name = "lstRoom";
            lstRoom.Size = new Size(1070, 524);
            lstRoom.TabIndex = 13;
            lstRoom.TabStop = false;
            lstRoom.Text = "Danh sách phòng";
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
            btnExport.Location = new Point(938, 34);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(98, 35);
            btnExport.TabIndex = 12;
            btnExport.Text = "Xuất";
            btnExport.TextColor = Color.White;
            btnExport.UseVisualStyleBackColor = false;
            // 
            // dtgListRoom
            // 
            dtgListRoom.BackgroundColor = SystemColors.GradientInactiveCaption;
            dtgListRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListRoom.Columns.AddRange(new DataGridViewColumn[] { ID, NameRoom, TypeRoom, Price, QtyPeople, status });
            dtgListRoom.Location = new Point(32, 77);
            dtgListRoom.Name = "dtgListRoom";
            dtgListRoom.RowHeadersWidth = 51;
            dtgListRoom.Size = new Size(1018, 370);
            dtgListRoom.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "Mã";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // NameRoom
            // 
            NameRoom.HeaderText = "Tên phòng";
            NameRoom.MinimumWidth = 6;
            NameRoom.Name = "NameRoom";
            NameRoom.Width = 160;
            // 
            // TypeRoom
            // 
            TypeRoom.HeaderText = "Loại phòng";
            TypeRoom.MinimumWidth = 6;
            TypeRoom.Name = "TypeRoom";
            TypeRoom.Width = 180;
            // 
            // Price
            // 
            Price.HeaderText = "Giá";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 180;
            // 
            // QtyPeople
            // 
            QtyPeople.HeaderText = "Số người tối đa";
            QtyPeople.MinimumWidth = 6;
            QtyPeople.Name = "QtyPeople";
            QtyPeople.Width = 150;
            // 
            // status
            // 
            status.HeaderText = "Trạng thái";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.Width = 180;
            // 
            // groupBox1
            // 
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
            groupBox1.Location = new Point(551, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(568, 254);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phòng";
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Times New Roman", 10.2F);
            textBox5.Location = new Point(296, 186);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(238, 27);
            textBox5.TabIndex = 15;
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
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Font = new Font("Times New Roman", 10.2F);
            textBox6.Location = new Point(296, 124);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(238, 27);
            textBox6.TabIndex = 13;
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
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Font = new Font("Times New Roman", 10.2F);
            textBox7.Location = new Point(296, 64);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(238, 27);
            textBox7.TabIndex = 11;
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
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Times New Roman", 10.2F);
            textBox4.Location = new Point(16, 186);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(243, 27);
            textBox4.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 163);
            label4.Name = "label4";
            label4.Size = new Size(85, 19);
            label4.TabIndex = 8;
            label4.Text = "Trạng thái";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Times New Roman", 10.2F);
            textBox3.Location = new Point(16, 124);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(243, 27);
            textBox3.TabIndex = 7;
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
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Times New Roman", 10.2F);
            textBox1.Location = new Point(16, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 27);
            textBox1.TabIndex = 5;
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
            groupBox4.Controls.Add(cusButton4);
            groupBox4.Controls.Add(cusButton5);
            groupBox4.Controls.Add(cusButton3);
            groupBox4.Controls.Add(cusButton2);
            groupBox4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.Teal;
            groupBox4.Location = new Point(49, 116);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(475, 153);
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
            cusButton4.Location = new Point(228, 99);
            cusButton4.Name = "cusButton4";
            cusButton4.Size = new Size(189, 35);
            cusButton4.TabIndex = 11;
            cusButton4.Text = "Đặt phòng";
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
            cusButton5.Location = new Point(16, 99);
            cusButton5.Name = "cusButton5";
            cusButton5.Size = new Size(189, 35);
            cusButton5.TabIndex = 10;
            cusButton5.Text = "Đặt phòng";
            cusButton5.TextColor = Color.White;
            cusButton5.UseVisualStyleBackColor = false;
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
            cusButton3.Location = new Point(228, 48);
            cusButton3.Name = "cusButton3";
            cusButton3.Size = new Size(189, 35);
            cusButton3.TabIndex = 9;
            cusButton3.Text = "Đặt phòng";
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
            cusButton2.Location = new Point(16, 48);
            cusButton2.Name = "cusButton2";
            cusButton2.Size = new Size(189, 35);
            cusButton2.TabIndex = 8;
            cusButton2.Text = "Đặt phòng";
            cusButton2.TextColor = Color.White;
            cusButton2.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cusButton1);
            groupBox2.Controls.Add(textBox2);
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
            cusButton1.Location = new Point(302, 48);
            cusButton1.Name = "cusButton1";
            cusButton1.Size = new Size(133, 35);
            cusButton1.TabIndex = 7;
            cusButton1.Text = "Tìm kiếm";
            cusButton1.TextColor = Color.White;
            cusButton1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Times New Roman", 10.2F);
            textBox2.Location = new Point(16, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(231, 27);
            textBox2.TabIndex = 5;
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
            // ManagerRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlMain);
            Controls.Add(pnlTittle);
            Name = "ManagerRoom";
            Size = new Size(1201, 746);
            pnlTittle.ResumeLayout(false);
            pnlTittle.PerformLayout();
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

        private Panel pnlTittle;
        private Label label1;
        private Panel pnlMain;
        private GroupBox lstRoom;
        private Assets.CusButton btnExport;
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
        private Assets.CusButton cusButton3;
        private Assets.CusButton cusButton2;
        private GroupBox groupBox2;
        private Assets.CusButton cusButton1;
        private TextBox textBox2;
        private Label label5;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NameRoom;
        private DataGridViewTextBoxColumn TypeRoom;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn QtyPeople;
        private DataGridViewTextBoxColumn status;
    }
}
