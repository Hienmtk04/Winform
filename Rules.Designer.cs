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
            lstRoom = new GroupBox();
            btnExport = new Assets.CusButton();
            dtgQuyDinh = new DataGridView();
            groupBox3 = new GroupBox();
            btnCapNhat = new Assets.CusButton();
            btnThem = new Assets.CusButton();
            groupBox1 = new GroupBox();
            cbTen = new ComboBox();
            tbMieuTa = new TextBox();
            label3 = new Label();
            tbGiaTri = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnSearch = new Assets.CusButton();
            tbSearch = new TextBox();
            label5 = new Label();
            pnlTitle.SuspendLayout();
            panel1.SuspendLayout();
            lstRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgQuyDinh).BeginInit();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
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
            // lstRoom
            // 
            lstRoom.Controls.Add(btnExport);
            lstRoom.Controls.Add(dtgQuyDinh);
            lstRoom.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstRoom.ForeColor = Color.Teal;
            lstRoom.Location = new Point(289, 16);
            lstRoom.Name = "lstRoom";
            lstRoom.Size = new Size(885, 623);
            lstRoom.TabIndex = 14;
            lstRoom.TabStop = false;
            lstRoom.Text = "Danh sách quy định";
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
            // dtgQuyDinh
            // 
            dtgQuyDinh.BackgroundColor = SystemColors.GradientInactiveCaption;
            dtgQuyDinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgQuyDinh.Location = new Point(13, 67);
            dtgQuyDinh.Name = "dtgQuyDinh";
            dtgQuyDinh.RowHeadersWidth = 51;
            dtgQuyDinh.Size = new Size(861, 532);
            dtgQuyDinh.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnCapNhat);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox3.ForeColor = Color.Teal;
            groupBox3.Location = new Point(32, 406);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(236, 156);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.Teal;
            btnCapNhat.BackgroundColor = Color.Teal;
            btnCapNhat.BorderColor = Color.PaleVioletRed;
            btnCapNhat.BorderRadius = 20;
            btnCapNhat.BorderSize = 0;
            btnCapNhat.FlatAppearance.BorderSize = 0;
            btnCapNhat.FlatStyle = FlatStyle.Flat;
            btnCapNhat.ForeColor = Color.White;
            btnCapNhat.Location = new Point(16, 95);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(204, 35);
            btnCapNhat.TabIndex = 9;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.TextColor = Color.White;
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Teal;
            btnThem.BackgroundColor = Color.Teal;
            btnThem.BorderColor = Color.PaleVioletRed;
            btnThem.BorderRadius = 20;
            btnThem.BorderSize = 0;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(16, 43);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(204, 35);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm quy định";
            btnThem.TextColor = Color.White;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbTen);
            groupBox1.Controls.Add(tbMieuTa);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbGiaTri);
            groupBox1.Controls.Add(label2);
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
            // cbTen
            // 
            cbTen.FormattingEnabled = true;
            cbTen.Location = new Point(16, 54);
            cbTen.Name = "cbTen";
            cbTen.Size = new Size(204, 27);
            cbTen.TabIndex = 10;
            // 
            // tbMieuTa
            // 
            tbMieuTa.BorderStyle = BorderStyle.FixedSingle;
            tbMieuTa.Font = new Font("Times New Roman", 10.2F);
            tbMieuTa.Location = new Point(16, 160);
            tbMieuTa.Name = "tbMieuTa";
            tbMieuTa.Size = new Size(204, 27);
            tbMieuTa.TabIndex = 9;
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
            // tbGiaTri
            // 
            tbGiaTri.BorderStyle = BorderStyle.FixedSingle;
            tbGiaTri.Font = new Font("Times New Roman", 10.2F);
            tbGiaTri.Location = new Point(16, 107);
            tbGiaTri.Name = "tbGiaTri";
            tbGiaTri.Size = new Size(204, 27);
            tbGiaTri.TabIndex = 7;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 31);
            label1.Name = "label1";
            label1.Size = new Size(36, 19);
            label1.TabIndex = 4;
            label1.Text = "Tên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(tbSearch);
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
            btnSearch.Location = new Point(16, 102);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(204, 35);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.BorderStyle = BorderStyle.FixedSingle;
            tbSearch.Font = new Font("Times New Roman", 10.2F);
            tbSearch.Location = new Point(16, 54);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(204, 27);
            tbSearch.TabIndex = 5;
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
            lstRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgQuyDinh).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitle;
        private Label lbTitle;
        private Panel panel1;
        private GroupBox groupBox1;
        private TextBox tbMieuTa;
        private Label label3;
        private TextBox tbGiaTri;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Assets.CusButton btnSearch;
        private TextBox tbSearch;
        private Label label5;
        private GroupBox groupBox3;
        private Assets.CusButton btnThem;
        private GroupBox lstRoom;
        private Assets.CusButton btnExport;
        private DataGridView dtgQuyDinh;
        private Assets.CusButton btnCapNhat;
        private ComboBox cbTen;
    }
}
