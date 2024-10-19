namespace HotelManage
{
    partial class ManagerService
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
            groupBox4 = new GroupBox();
            cusButton3 = new Assets.CusButton();
            cusButton5 = new Assets.CusButton();
            cusButton2 = new Assets.CusButton();
            cusButton1 = new Assets.CusButton();
            groupBox3 = new GroupBox();
            btnSearch = new Assets.CusButton();
            lbSearch = new Label();
            textBox4 = new TextBox();
            groupBox5 = new GroupBox();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            tbIDRoom = new TextBox();
            lbID = new Label();
            pnlTitle.SuspendLayout();
            pnlMain.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.Controls.Add(lbTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1201, 58);
            pnlTitle.TabIndex = 0;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.Teal;
            lbTitle.Location = new Point(18, 16);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(169, 25);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "Quản lý dịch vụ";
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(groupBox4);
            pnlMain.Controls.Add(groupBox3);
            pnlMain.Controls.Add(groupBox5);
            pnlMain.Controls.Add(groupBox1);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 58);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1201, 638);
            pnlMain.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cusButton3);
            groupBox4.Controls.Add(cusButton5);
            groupBox4.Controls.Add(cusButton2);
            groupBox4.Controls.Add(cusButton1);
            groupBox4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.Teal;
            groupBox4.Location = new Point(39, 464);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(357, 158);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chức năng";
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
            cusButton3.Location = new Point(193, 97);
            cusButton3.Name = "cusButton3";
            cusButton3.Size = new Size(135, 35);
            cusButton3.TabIndex = 6;
            cusButton3.Text = "Đóng";
            cusButton3.TextColor = Color.White;
            cusButton3.UseVisualStyleBackColor = false;
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
            cusButton5.ForeColor = Color.White;
            cusButton5.Location = new Point(21, 97);
            cusButton5.Name = "cusButton5";
            cusButton5.Size = new Size(138, 35);
            cusButton5.TabIndex = 5;
            cusButton5.Text = "Sửa loại DV";
            cusButton5.TextColor = Color.White;
            cusButton5.UseVisualStyleBackColor = false;
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
            cusButton2.ForeColor = Color.White;
            cusButton2.Location = new Point(193, 44);
            cusButton2.Name = "cusButton2";
            cusButton2.Size = new Size(135, 35);
            cusButton2.TabIndex = 4;
            cusButton2.Text = "Cập nhật";
            cusButton2.TextColor = Color.White;
            cusButton2.UseVisualStyleBackColor = false;
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
            cusButton1.Location = new Point(21, 44);
            cusButton1.Name = "cusButton1";
            cusButton1.Size = new Size(138, 35);
            cusButton1.TabIndex = 3;
            cusButton1.Text = "Thêm";
            cusButton1.TextColor = Color.White;
            cusButton1.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnSearch);
            groupBox3.Controls.Add(lbSearch);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.Teal;
            groupBox3.Location = new Point(39, 20);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(357, 161);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm";
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
            btnSearch.Location = new Point(85, 104);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(177, 39);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(10, 34);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(93, 19);
            lbSearch.TabIndex = 1;
            lbSearch.Text = "Tên dịch vụ";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(6, 61);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(322, 27);
            textBox4.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridView1);
            groupBox5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = Color.Teal;
            groupBox5.Location = new Point(452, 20);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(712, 608);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "Danh sách dịch vụ";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Name, Price, Type });
            dataGridView1.Location = new Point(16, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(679, 576);
            dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "Mã";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // Name
            // 
            Name.HeaderText = "Tên";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.Width = 220;
            // 
            // Price
            // 
            Price.HeaderText = "Giá";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 140;
            // 
            // Type
            // 
            Type.HeaderText = "Loại dịch vụ";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.Width = 140;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbIDRoom);
            groupBox1.Controls.Add(lbID);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Teal;
            groupBox1.Location = new Point(39, 187);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 265);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin dịch vụ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ăn uống", "Giải trí", "Sức khỏe" });
            comboBox1.Location = new Point(21, 167);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(297, 27);
            comboBox1.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(21, 220);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(297, 27);
            textBox3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 197);
            label4.Name = "label4";
            label4.Size = new Size(37, 19);
            label4.TabIndex = 8;
            label4.Text = "Giá";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(21, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(297, 27);
            textBox2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 88);
            label3.Name = "label3";
            label3.Size = new Size(93, 19);
            label3.TabIndex = 6;
            label3.Text = "Tên dịch vụ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 144);
            label2.Name = "label2";
            label2.Size = new Size(100, 19);
            label2.TabIndex = 4;
            label2.Text = "Loại dịch vụ";
            // 
            // tbIDRoom
            // 
            tbIDRoom.BorderStyle = BorderStyle.FixedSingle;
            tbIDRoom.Location = new Point(21, 55);
            tbIDRoom.Name = "tbIDRoom";
            tbIDRoom.Size = new Size(297, 27);
            tbIDRoom.TabIndex = 3;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(21, 32);
            lbID.Name = "lbID";
            lbID.Size = new Size(90, 19);
            lbID.TabIndex = 2;
            lbID.Text = "Mã dịch vụ";
            // 
            // ManagerService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlMain);
            Controls.Add(pnlTitle);
            Size = new Size(1201, 696);
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            pnlMain.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitle;
        private Panel pnlMain;
        private GroupBox groupBox5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Type;
        private GroupBox groupBox1;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private TextBox tbIDRoom;
        private Label lbID;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Assets.CusButton btnSearch;
        private Label lbSearch;
        private TextBox textBox4;
        private Assets.CusButton cusButton3;
        private Assets.CusButton cusButton5;
        private Assets.CusButton cusButton2;
        private Assets.CusButton cusButton1;
        private Label lbTitle;
        private ComboBox comboBox1;
    }
}
