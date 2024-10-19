namespace HotelManage
{
    partial class UseServicePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UseServicePayment));
            pnlTitle = new Panel();
            label1 = new Label();
            pnlMain = new Panel();
            groupBox6 = new GroupBox();
            dataGridView3 = new DataGridView();
            stt = new DataGridViewTextBoxColumn();
            NameService = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            TotalService = new DataGridViewTextBoxColumn();
            groupBox5 = new GroupBox();
            dataGridView2 = new DataGridView();
            Index = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            heso = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            NameRoom = new DataGridViewTextBoxColumn();
            PriceService = new DataGridViewTextBoxColumn();
            DateCheckin = new DataGridViewTextBoxColumn();
            DateCheckout = new DataGridViewTextBoxColumn();
            PriceRoom = new DataGridViewTextBoxColumn();
            OtherPrice = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            btnPayment = new Assets.CusButton();
            numericUpDown2 = new NumericUpDown();
            textBox2 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            groupBox2 = new GroupBox();
            btnAddService = new Assets.CusButton();
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            comboBox2 = new ComboBox();
            label9 = new Label();
            comboBox1 = new ComboBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            panel6 = new Panel();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            pnlTitle.SuspendLayout();
            pnlMain.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BorderStyle = BorderStyle.Fixed3D;
            pnlTitle.Controls.Add(label1);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1201, 64);
            pnlTitle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(17, 23);
            label1.Name = "label1";
            label1.Size = new Size(319, 25);
            label1.TabIndex = 1;
            label1.Text = "Sử dụng dịch vụ và thanh toán";
            // 
            // pnlMain
            // 
            pnlMain.AutoScroll = true;
            pnlMain.Controls.Add(groupBox6);
            pnlMain.Controls.Add(groupBox5);
            pnlMain.Controls.Add(groupBox4);
            pnlMain.Controls.Add(groupBox3);
            pnlMain.Controls.Add(groupBox2);
            pnlMain.Controls.Add(groupBox1);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 64);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1201, 632);
            pnlMain.TabIndex = 1;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dataGridView3);
            groupBox6.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox6.ForeColor = Color.Teal;
            groupBox6.Location = new Point(293, 635);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(884, 471);
            groupBox6.TabIndex = 14;
            groupBox6.TabStop = false;
            groupBox6.Text = "Hóa đơn dịch vụ";
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { stt, NameService, Price, Quantity, TotalService });
            dataGridView3.Location = new Point(12, 26);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(861, 413);
            dataGridView3.TabIndex = 0;
            // 
            // stt
            // 
            stt.HeaderText = "STT";
            stt.MinimumWidth = 6;
            stt.Name = "stt";
            stt.Width = 80;
            // 
            // NameService
            // 
            NameService.HeaderText = "Tên dịch vụ";
            NameService.MinimumWidth = 6;
            NameService.Name = "NameService";
            NameService.Width = 350;
            // 
            // Price
            // 
            Price.HeaderText = "Đơn giá";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 140;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Số lượng";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 130;
            // 
            // TotalService
            // 
            TotalService.HeaderText = "Thành tiền";
            TotalService.MinimumWidth = 6;
            TotalService.Name = "TotalService";
            TotalService.Width = 140;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridView2);
            groupBox5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox5.ForeColor = Color.Teal;
            groupBox5.Location = new Point(293, 350);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(884, 279);
            groupBox5.TabIndex = 13;
            groupBox5.TabStop = false;
            groupBox5.Text = "Chính sách phụ thu";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Index, Name, heso, description });
            dataGridView2.Location = new Point(12, 26);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(861, 231);
            dataGridView2.TabIndex = 0;
            // 
            // Index
            // 
            Index.HeaderText = "STT";
            Index.MinimumWidth = 6;
            Index.Name = "Index";
            Index.Width = 80;
            // 
            // Name
            // 
            Name.HeaderText = "Tên quy định";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.Width = 150;
            // 
            // heso
            // 
            heso.HeaderText = "Hệ số";
            heso.MinimumWidth = 6;
            heso.Name = "heso";
            heso.Width = 110;
            // 
            // description
            // 
            description.HeaderText = "Mô tả";
            description.MinimumWidth = 6;
            description.Name = "description";
            description.Width = 470;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox4.ForeColor = Color.Teal;
            groupBox4.Location = new Point(293, 210);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(884, 134);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hóa đơn tiền phòng";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameRoom, PriceService, DateCheckin, DateCheckout, PriceRoom, OtherPrice, Total });
            dataGridView1.Location = new Point(8, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(870, 99);
            dataGridView1.TabIndex = 0;
            // 
            // NameRoom
            // 
            NameRoom.HeaderText = "Tên phòng";
            NameRoom.MinimumWidth = 6;
            NameRoom.Name = "NameRoom";
            NameRoom.Width = 125;
            // 
            // PriceService
            // 
            PriceService.HeaderText = "Đơn giá";
            PriceService.MinimumWidth = 6;
            PriceService.Name = "PriceService";
            PriceService.Width = 125;
            // 
            // DateCheckin
            // 
            DateCheckin.HeaderText = "Ngày nhận";
            DateCheckin.MinimumWidth = 6;
            DateCheckin.Name = "DateCheckin";
            DateCheckin.Width = 110;
            // 
            // DateCheckout
            // 
            DateCheckout.HeaderText = "Ngày trả";
            DateCheckout.MinimumWidth = 6;
            DateCheckout.Name = "DateCheckout";
            DateCheckout.Width = 110;
            // 
            // PriceRoom
            // 
            PriceRoom.HeaderText = "Tiền phòng";
            PriceRoom.MinimumWidth = 6;
            PriceRoom.Name = "PriceRoom";
            PriceRoom.Width = 125;
            // 
            // OtherPrice
            // 
            OtherPrice.HeaderText = "Phụ thu";
            OtherPrice.MinimumWidth = 6;
            OtherPrice.Name = "OtherPrice";
            OtherPrice.Width = 125;
            // 
            // Total
            // 
            Total.HeaderText = "Thành tiền";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.Width = 125;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnPayment);
            groupBox3.Controls.Add(numericUpDown2);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label13);
            groupBox3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.Teal;
            groupBox3.Location = new Point(19, 523);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(268, 215);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // btnPayment
            // 
            btnPayment.BackColor = Color.Teal;
            btnPayment.BackgroundColor = Color.Teal;
            btnPayment.BorderColor = Color.PaleVioletRed;
            btnPayment.BorderRadius = 20;
            btnPayment.BorderSize = 0;
            btnPayment.FlatAppearance.BorderSize = 0;
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.ForeColor = Color.White;
            btnPayment.Location = new Point(42, 156);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(188, 39);
            btnPayment.TabIndex = 15;
            btnPayment.Text = "Thanh toán";
            btnPayment.TextColor = Color.White;
            btnPayment.UseVisualStyleBackColor = false;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(15, 110);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(243, 27);
            numericUpDown2.TabIndex = 14;
            numericUpDown2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(15, 57);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 27);
            textBox2.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 87);
            label12.Name = "label12";
            label12.Size = new Size(78, 19);
            label12.TabIndex = 12;
            label12.Text = "Giảm giá";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 33);
            label13.Name = "label13";
            label13.Size = new Size(79, 19);
            label13.TabIndex = 11;
            label13.Text = "Tổng tiền";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAddService);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Teal;
            groupBox2.Location = new Point(19, 209);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(268, 308);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách dịch vụ";
            // 
            // btnAddService
            // 
            btnAddService.BackColor = Color.Teal;
            btnAddService.BackgroundColor = Color.Teal;
            btnAddService.BorderColor = Color.PaleVioletRed;
            btnAddService.BorderRadius = 20;
            btnAddService.BorderSize = 0;
            btnAddService.FlatAppearance.BorderSize = 0;
            btnAddService.FlatStyle = FlatStyle.Flat;
            btnAddService.ForeColor = Color.White;
            btnAddService.Location = new Point(44, 256);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(176, 39);
            btnAddService.TabIndex = 10;
            btnAddService.Text = "Thêm dịch vụ";
            btnAddService.TextColor = Color.White;
            btnAddService.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(15, 216);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(243, 27);
            numericUpDown1.TabIndex = 9;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(15, 163);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 27);
            textBox1.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 193);
            label10.Name = "label10";
            label10.Size = new Size(74, 19);
            label10.TabIndex = 6;
            label10.Text = "Số lượng";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 139);
            label11.Name = "label11";
            label11.Size = new Size(37, 19);
            label11.TabIndex = 4;
            label11.Text = "Giá";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(15, 108);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(243, 27);
            comboBox2.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 85);
            label9.Name = "label9";
            label9.Size = new Size(65, 19);
            label9.TabIndex = 2;
            label9.Text = "Dịch vụ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(15, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(243, 27);
            comboBox1.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 31);
            label8.Name = "label8";
            label8.Size = new Size(100, 19);
            label8.TabIndex = 0;
            label8.Text = "Loại dịch vụ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel6);
            groupBox1.Controls.Add(panel5);
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Teal;
            groupBox1.Location = new Point(21, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1156, 176);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách phòng";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Bisque;
            panel6.Controls.Add(pictureBox2);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(443, 26);
            panel6.Name = "panel6";
            panel6.Size = new Size(111, 91);
            panel6.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(36, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(13, 52);
            label7.Name = "label7";
            label7.Size = new Size(87, 19);
            label7.TabIndex = 1;
            label7.Text = "Phòng 103";
            // 
            // panel5
            // 
            panel5.BackColor = Color.PowderBlue;
            panel5.Controls.Add(pictureBox1);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(313, 26);
            panel5.Name = "panel5";
            panel5.Size = new Size(111, 91);
            panel5.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(13, 52);
            label6.Name = "label6";
            label6.Size = new Size(87, 19);
            label6.TabIndex = 1;
            label6.Text = "Phòng 102";
            // 
            // panel4
            // 
            panel4.BackColor = Color.PowderBlue;
            panel4.Controls.Add(label5);
            panel4.Location = new Point(144, 26);
            panel4.Name = "panel4";
            panel4.Size = new Size(91, 32);
            panel4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(2, 6);
            label5.Name = "label5";
            label5.Size = new Size(86, 19);
            label5.TabIndex = 1;
            label5.Text = "Đang chọn";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkOrange;
            panel3.Controls.Add(label4);
            panel3.ForeColor = Color.Teal;
            panel3.Location = new Point(30, 129);
            panel3.Name = "panel3";
            panel3.Size = new Size(91, 32);
            panel3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(2, 6);
            label4.Name = "label4";
            label4.Size = new Size(88, 19);
            label4.TabIndex = 1;
            label4.Text = "Phòng VIP";
            // 
            // panel2
            // 
            panel2.BackColor = Color.BurlyWood;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(29, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(91, 32);
            panel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(2, 6);
            label3.Name = "label3";
            label3.Size = new Size(84, 19);
            label3.TabIndex = 1;
            label3.Text = "Phòng đôi";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(30, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(91, 32);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(2, 6);
            label2.Name = "label2";
            label2.Size = new Size(87, 19);
            label2.TabIndex = 1;
            label2.Text = "Phòng đơn";
            // 
            // UseServicePayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlMain);
            Controls.Add(pnlTitle);
             Size = new Size(1201, 696);
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            pnlMain.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitle;
        private Label label1;
        private Panel pnlMain;
        private GroupBox groupBox1;
        private Panel panel1;
        private Panel panel3;
        private Label label4;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Panel panel5;
        private PictureBox pictureBox1;
        private Label label6;
        private Panel panel4;
        private Label label5;
        private GroupBox groupBox2;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private Label label10;
        private Label label11;
        private ComboBox comboBox2;
        private Label label9;
        private ComboBox comboBox1;
        private Label label8;
        private Panel panel6;
        private PictureBox pictureBox2;
        private Label label7;
        private GroupBox groupBox3;
        private Assets.CusButton btnPayment;
        private NumericUpDown numericUpDown2;
        private TextBox textBox2;
        private Label label12;
        private Label label13;
        private Assets.CusButton btnAddService;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private GroupBox groupBox5;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn NameRoom;
        private DataGridViewTextBoxColumn PriceService;
        private DataGridViewTextBoxColumn DateCheckin;
        private DataGridViewTextBoxColumn DateCheckout;
        private DataGridViewTextBoxColumn PriceRoom;
        private DataGridViewTextBoxColumn OtherPrice;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Index;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn heso;
        private DataGridViewTextBoxColumn description;
        private GroupBox groupBox6;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn NameService;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn TotalService;
    }
}
