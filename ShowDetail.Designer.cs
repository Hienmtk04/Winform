namespace HotelManage
{
    partial class ShowDetail
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
            Exit = new Label();
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            tbIDRoom = new TextBox();
            lbID = new Label();
            groupBox2 = new GroupBox();
            btnClose = new Assets.CusButton();
            cusButton4 = new Assets.CusButton();
            groupBox5 = new GroupBox();
            cusButton2 = new Assets.CusButton();
            cusButton1 = new Assets.CusButton();
            cusButton6 = new Assets.CusButton();
            dataGridView1 = new DataGridView();
            NameCus = new DataGridViewTextBoxColumn();
            IDCustomer = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Nation = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit.ForeColor = Color.Red;
            Exit.Location = new Point(1027, 9);
            Exit.Name = "Exit";
            Exit.Size = new Size(27, 25);
            Exit.TabIndex = 0;
            Exit.Text = "X";
            Exit.Click += Exit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Exit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1062, 60);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(10, 18);
            label1.Name = "label1";
            label1.Size = new Size(211, 25);
            label1.TabIndex = 0;
            label1.Text = "Chi tiết nhận phòng";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbIDRoom);
            groupBox1.Controls.Add(lbID);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Teal;
            groupBox1.Location = new Point(12, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(270, 282);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhận phòng";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(21, 220);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(228, 27);
            textBox3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 197);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 8;
            label4.Text = "Ngày trả";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(21, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 27);
            textBox2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 88);
            label3.Name = "label3";
            label3.Size = new Size(85, 19);
            label3.TabIndex = 6;
            label3.Text = "Tên phòng";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(21, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 27);
            textBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 144);
            label2.Name = "label2";
            label2.Size = new Size(85, 19);
            label2.TabIndex = 4;
            label2.Text = "Ngày nhận";
            // 
            // tbIDRoom
            // 
            tbIDRoom.BorderStyle = BorderStyle.FixedSingle;
            tbIDRoom.Location = new Point(21, 55);
            tbIDRoom.Name = "tbIDRoom";
            tbIDRoom.Size = new Size(228, 27);
            tbIDRoom.TabIndex = 3;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(21, 32);
            lbID.Name = "lbID";
            lbID.Size = new Size(121, 19);
            lbID.TabIndex = 2;
            lbID.Text = "Mã nhận phòng";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClose);
            groupBox2.Controls.Add(cusButton4);
            groupBox2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox2.ForeColor = Color.Teal;
            groupBox2.Location = new Point(12, 381);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(270, 164);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Teal;
            btnClose.BackgroundColor = Color.Teal;
            btnClose.BorderColor = Color.PaleVioletRed;
            btnClose.BorderRadius = 20;
            btnClose.BorderSize = 0;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(28, 101);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(203, 41);
            btnClose.TabIndex = 6;
            btnClose.Text = "Đóng";
            btnClose.TextColor = Color.White;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
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
            cusButton4.Location = new Point(28, 40);
            cusButton4.Name = "cusButton4";
            cusButton4.Size = new Size(203, 41);
            cusButton4.TabIndex = 5;
            cusButton4.Text = "Đổi phòng";
            cusButton4.TextColor = Color.White;
            cusButton4.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(cusButton2);
            groupBox5.Controls.Add(cusButton1);
            groupBox5.Controls.Add(cusButton6);
            groupBox5.Controls.Add(dataGridView1);
            groupBox5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = Color.Teal;
            groupBox5.Location = new Point(288, 80);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(762, 465);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "Danh sách khách hàng";
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
            cusButton2.Location = new Point(295, 402);
            cusButton2.Name = "cusButton2";
            cusButton2.Size = new Size(173, 35);
            cusButton2.TabIndex = 13;
            cusButton2.Text = "Xóa khách hàng";
            cusButton2.TextColor = Color.White;
            cusButton2.UseVisualStyleBackColor = false;
            // 
            // cusButton1
            // 
            cusButton1.BackColor = Color.Teal;
            cusButton1.BackgroundColor = Color.Teal;
            cusButton1.BorderColor = Color.Teal;
            cusButton1.BorderRadius = 20;
            cusButton1.BorderSize = 1;
            cusButton1.FlatAppearance.BorderSize = 0;
            cusButton1.FlatStyle = FlatStyle.Flat;
            cusButton1.ForeColor = Color.White;
            cusButton1.Location = new Point(519, 402);
            cusButton1.Name = "cusButton1";
            cusButton1.Size = new Size(173, 35);
            cusButton1.TabIndex = 12;
            cusButton1.Text = "Cập nhật khách hàng";
            cusButton1.TextColor = Color.White;
            cusButton1.UseVisualStyleBackColor = false;
            // 
            // cusButton6
            // 
            cusButton6.BackColor = Color.Teal;
            cusButton6.BackgroundColor = Color.Teal;
            cusButton6.BorderColor = Color.Teal;
            cusButton6.BorderRadius = 20;
            cusButton6.BorderSize = 1;
            cusButton6.FlatAppearance.BorderSize = 0;
            cusButton6.FlatStyle = FlatStyle.Flat;
            cusButton6.ForeColor = Color.White;
            cusButton6.Location = new Point(71, 402);
            cusButton6.Name = "cusButton6";
            cusButton6.Size = new Size(173, 35);
            cusButton6.TabIndex = 11;
            cusButton6.Text = "Thêm khách hàng";
            cusButton6.TextColor = Color.White;
            cusButton6.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameCus, IDCustomer, Address, Phone, Nation });
            dataGridView1.Location = new Point(6, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(741, 334);
            dataGridView1.TabIndex = 0;
            // 
            // NameCus
            // 
            NameCus.HeaderText = "Họ và Tên";
            NameCus.MinimumWidth = 6;
            NameCus.Name = "NameCus";
            NameCus.Width = 160;
            // 
            // IDCustomer
            // 
            IDCustomer.HeaderText = "CCCD/CMND";
            IDCustomer.MinimumWidth = 6;
            IDCustomer.Name = "IDCustomer";
            IDCustomer.Width = 140;
            // 
            // Address
            // 
            Address.HeaderText = "Địa chỉ";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.Width = 140;
            // 
            // Phone
            // 
            Phone.HeaderText = "Số điện thoại";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.Width = 140;
            // 
            // Nation
            // 
            Nation.HeaderText = "Quốc tịch";
            Nation.MinimumWidth = 6;
            Nation.Name = "Nation";
            Nation.Width = 110;
            // 
            // ShowDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 568);
            Controls.Add(groupBox5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ShowDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShowDetail";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label Exit;
        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private TextBox tbIDRoom;
        private Label lbID;
        private GroupBox groupBox2;
        private Assets.CusButton btnClose;
        private Assets.CusButton cusButton4;
        private GroupBox groupBox5;
        private Assets.CusButton cusButton6;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NameCus;
        private DataGridViewTextBoxColumn IDCustomer;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Nation;
        private Assets.CusButton cusButton2;
        private Assets.CusButton cusButton1;
    }
}