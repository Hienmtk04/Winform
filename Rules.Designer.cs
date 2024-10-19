namespace HotelManage
{
    partial class Rules
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
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            cusButton1 = new Assets.CusButton();
            textBox2 = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            groupBox3 = new GroupBox();
            cusButton3 = new Assets.CusButton();
            lstRoom = new GroupBox();
            btnExport = new Assets.CusButton();
            dtgListRoom = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            value = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            UpdatedAt = new DataGridViewTextBoxColumn();
            pnlTitle.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            lstRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListRoom).BeginInit();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BorderStyle = BorderStyle.Fixed3D;
            pnlTitle.Controls.Add(lbTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1201, 61);
            pnlTitle.TabIndex = 0;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.Teal;
            lbTitle.Location = new Point(13, 18);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(104, 25);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Quy định";
            // 
            // panel1
            // 
            panel1.Controls.Add(lstRoom);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(1201, 672);
            panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cusButton1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox2.ForeColor = Color.Teal;
            groupBox2.Location = new Point(32, 16);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(236, 154);
            groupBox2.TabIndex = 11;
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
            cusButton1.Location = new Point(16, 102);
            cusButton1.Name = "cusButton1";
            cusButton1.Size = new Size(204, 35);
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
            textBox2.Size = new Size(204, 27);
            textBox2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 31);
            label5.Name = "label5";
            label5.Size = new Size(36, 19);
            label5.TabIndex = 4;
            label5.Text = "Tên";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox1.ForeColor = Color.Teal;
            groupBox1.Location = new Point(32, 185);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(236, 203);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin quy định";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Times New Roman", 10.2F);
            textBox1.Location = new Point(16, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 27);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 31);
            label1.Name = "label1";
            label1.Size = new Size(36, 19);
            label1.TabIndex = 4;
            label1.Text = "Tên";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Times New Roman", 10.2F);
            textBox3.Location = new Point(16, 107);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(204, 27);
            textBox3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 84);
            label2.Name = "label2";
            label2.Size = new Size(61, 19);
            label2.TabIndex = 6;
            label2.Text = "Giá trị";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Times New Roman", 10.2F);
            textBox4.Location = new Point(16, 160);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(204, 27);
            textBox4.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 137);
            label3.Name = "label3";
            label3.Size = new Size(66, 19);
            label3.TabIndex = 8;
            label3.Text = "Miêu tả";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cusButton3);
            groupBox3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox3.ForeColor = Color.Teal;
            groupBox3.Location = new Point(32, 406);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(236, 106);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
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
            cusButton3.Location = new Point(16, 43);
            cusButton3.Name = "cusButton3";
            cusButton3.Size = new Size(204, 35);
            cusButton3.TabIndex = 8;
            cusButton3.Text = "Cập nhật";
            cusButton3.TextColor = Color.White;
            cusButton3.UseVisualStyleBackColor = false;
            // 
            // lstRoom
            // 
            lstRoom.Controls.Add(btnExport);
            lstRoom.Controls.Add(dtgListRoom);
            lstRoom.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstRoom.ForeColor = Color.Teal;
            lstRoom.Location = new Point(289, 16);
            lstRoom.Name = "lstRoom";
            lstRoom.Size = new Size(885, 623);
            lstRoom.TabIndex = 14;
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
            btnExport.Location = new Point(776, 23);
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
            dtgListRoom.Columns.AddRange(new DataGridViewColumn[] { name, value, Description, UpdatedAt });
            dtgListRoom.Location = new Point(13, 67);
            dtgListRoom.Name = "dtgListRoom";
            dtgListRoom.RowHeadersWidth = 51;
            dtgListRoom.Size = new Size(861, 532);
            dtgListRoom.TabIndex = 0;
            // 
            // name
            // 
            name.HeaderText = "Tên";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.Width = 180;
            // 
            // value
            // 
            value.HeaderText = "Giá trị";
            value.MinimumWidth = 6;
            value.Name = "value";
            value.Width = 125;
            // 
            // Description
            // 
            Description.HeaderText = "Miêu tả";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.Width = 350;
            // 
            // UpdatedAt
            // 
            UpdatedAt.HeaderText = "Ngày cập nhật";
            UpdatedAt.MinimumWidth = 6;
            UpdatedAt.Name = "UpdatedAt";
            UpdatedAt.Width = 150;
            // 
            // Rules
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(pnlTitle);
            Name = "Rules";
            Size = new Size(1201, 733);
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            lstRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgListRoom).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitle;
        private Label lbTitle;
        private Panel panel1;
        private GroupBox groupBox1;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Assets.CusButton cusButton1;
        private TextBox textBox2;
        private Label label5;
        private GroupBox groupBox3;
        private Assets.CusButton cusButton3;
        private GroupBox lstRoom;
        private Assets.CusButton btnExport;
        private DataGridView dtgListRoom;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn value;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn UpdatedAt;
    }
}
