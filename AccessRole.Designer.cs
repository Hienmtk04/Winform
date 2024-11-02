namespace HotelManage
{
    partial class AccessRole
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
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnExit = new Assets.CusButton();
            btnXoa = new Assets.CusButton();
            btnThem = new Assets.CusButton();
            btnUpdate = new Assets.CusButton();
            cbLoaiNV = new ComboBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            lst1 = new ListBox();
            groupBox3 = new GroupBox();
            lst2 = new ListBox();
            btnLTRAll = new Button();
            btnLTR = new Button();
            btnRTLAll = new Button();
            btnRTL = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 56);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(168, 25);
            label1.TabIndex = 0;
            label1.Text = "Quyền truy cập";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(cbLoaiNV);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 147);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Loại nhân viên";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Teal;
            btnExit.BackgroundColor = Color.Teal;
            btnExit.BorderColor = Color.PaleVioletRed;
            btnExit.BorderRadius = 20;
            btnExit.BorderSize = 0;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(541, 88);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(178, 43);
            btnExit.TabIndex = 5;
            btnExit.Text = "Đóng";
            btnExit.TextColor = Color.White;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Teal;
            btnXoa.BackgroundColor = Color.Teal;
            btnXoa.BorderColor = Color.PaleVioletRed;
            btnXoa.BorderRadius = 20;
            btnXoa.BorderSize = 0;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(291, 88);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(178, 43);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.TextColor = Color.White;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
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
            btnThem.Location = new Point(541, 29);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(178, 43);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm mới";
            btnThem.TextColor = Color.White;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Teal;
            btnUpdate.BackgroundColor = Color.Teal;
            btnUpdate.BorderColor = Color.PaleVioletRed;
            btnUpdate.BorderRadius = 20;
            btnUpdate.BorderSize = 0;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(291, 29);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(178, 43);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Sửa tên";
            btnUpdate.TextColor = Color.White;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cbLoaiNV
            // 
            cbLoaiNV.FormattingEnabled = true;
            cbLoaiNV.Location = new Point(20, 75);
            cbLoaiNV.Name = "cbLoaiNV";
            cbLoaiNV.Size = new Size(214, 28);
            cbLoaiNV.TabIndex = 1;
            cbLoaiNV.SelectedIndexChanged += cbLoaiNV_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 40);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên loại nhân viên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lst1);
            groupBox2.Location = new Point(12, 225);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(342, 447);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Quyền hiện tại";
            // 
            // lst1
            // 
            lst1.FormattingEnabled = true;
            lst1.ImeMode = ImeMode.NoControl;
            lst1.Location = new Point(6, 26);
            lst1.Name = "lst1";
            lst1.Size = new Size(330, 344);
            lst1.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lst2);
            groupBox3.Location = new Point(446, 225);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(342, 447);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Các quyền còn lại";
            // 
            // lst2
            // 
            lst2.FormattingEnabled = true;
            lst2.ImeMode = ImeMode.NoControl;
            lst2.Location = new Point(6, 26);
            lst2.Name = "lst2";
            lst2.Size = new Size(330, 344);
            lst2.TabIndex = 2;
            // 
            // btnLTRAll
            // 
            btnLTRAll.Location = new Point(369, 291);
            btnLTRAll.Name = "btnLTRAll";
            btnLTRAll.Size = new Size(59, 41);
            btnLTRAll.TabIndex = 4;
            btnLTRAll.Text = ">>";
            btnLTRAll.UseVisualStyleBackColor = true;
            btnLTRAll.Click += btnLTRAll_Click;
            // 
            // btnLTR
            // 
            btnLTR.Location = new Point(369, 338);
            btnLTR.Name = "btnLTR";
            btnLTR.Size = new Size(59, 41);
            btnLTR.TabIndex = 5;
            btnLTR.Text = ">";
            btnLTR.UseVisualStyleBackColor = true;
            btnLTR.Click += btnLTR_Click;
            // 
            // btnRTLAll
            // 
            btnRTLAll.Location = new Point(369, 517);
            btnRTLAll.Name = "btnRTLAll";
            btnRTLAll.Size = new Size(59, 43);
            btnRTLAll.TabIndex = 6;
            btnRTLAll.Text = "<<";
            btnRTLAll.UseVisualStyleBackColor = true;
            btnRTLAll.Click += btnRTLAll_Click;
            // 
            // btnRTL
            // 
            btnRTL.Location = new Point(369, 468);
            btnRTL.Name = "btnRTL";
            btnRTL.Size = new Size(59, 43);
            btnRTL.TabIndex = 7;
            btnRTL.Text = "<";
            btnRTL.UseVisualStyleBackColor = true;
            btnRTL.Click += btnRTL_Click;
            // 
            // AccessRole
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 684);
            Controls.Add(btnRTL);
            Controls.Add(btnLTR);
            Controls.Add(btnRTLAll);
            Controls.Add(btnLTRAll);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AccessRole";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AccessRole";
            Load += AccessRole_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Assets.CusButton btnExit;
        private Assets.CusButton btnXoa;
        private Assets.CusButton btnThem;
        private Assets.CusButton btnUpdate;
        private ComboBox cbLoaiNV;
        private Label label2;
        private GroupBox groupBox2;
        private ListBox lst1;
        private GroupBox groupBox3;
        private ListBox lst2;
        private Button btnLTRAll;
        private Button btnLTR;
        private Button btnRTLAll;
        private Button btnRTL;
    }
}