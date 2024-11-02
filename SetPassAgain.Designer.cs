namespace HotelManage
{
    partial class SetPassAgain
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
            pnlTitle = new Panel();
            lbTitle = new Label();
            pnlMain = new Panel();
            btnClose = new Assets.CusButton();
            btnSubmit = new Assets.CusButton();
            groupBox1 = new GroupBox();
            tbMatKhauMoi = new TextBox();
            label2 = new Label();
            tbMatKhauCu = new TextBox();
            label1 = new Label();
            tbTenDN = new TextBox();
            label10 = new Label();
            groupBox4 = new GroupBox();
            lbExit = new Label();
            btnExit = new Assets.CusButton();
            btnThem = new Assets.CusButton();
            pnlTitle.SuspendLayout();
            pnlMain.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.Controls.Add(lbTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(379, 48);
            pnlTitle.TabIndex = 4;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.Teal;
            lbTitle.Location = new Point(12, 12);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(171, 25);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Thêm nhân viên";
            // 
            // pnlMain
            // 
            pnlMain.AutoScroll = true;
            pnlMain.Controls.Add(btnClose);
            pnlMain.Controls.Add(btnSubmit);
            pnlMain.Controls.Add(groupBox1);
            pnlMain.Controls.Add(groupBox4);
            pnlMain.Location = new Point(0, 48);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(352, 326);
            pnlMain.TabIndex = 5;
            pnlMain.Paint += pnlMain_Paint;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Teal;
            btnClose.BackgroundColor = Color.Teal;
            btnClose.BorderColor = Color.Teal;
            btnClose.BorderRadius = 20;
            btnClose.BorderSize = 1;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(189, 249);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(135, 35);
            btnClose.TabIndex = 16;
            btnClose.Text = "Đóng";
            btnClose.TextColor = Color.White;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Teal;
            btnSubmit.BackgroundColor = Color.Teal;
            btnSubmit.BorderColor = Color.Teal;
            btnSubmit.BorderRadius = 20;
            btnSubmit.BorderSize = 1;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(24, 249);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(135, 35);
            btnSubmit.TabIndex = 15;
            btnSubmit.Text = "Thay đổi";
            btnSubmit.TextColor = Color.White;
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbMatKhauMoi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbMatKhauCu);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbTenDN);
            groupBox1.Controls.Add(label10);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            groupBox1.ForeColor = Color.Teal;
            groupBox1.Location = new Point(24, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 224);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mật khẩu";
            // 
            // tbMatKhauMoi
            // 
            tbMatKhauMoi.BorderStyle = BorderStyle.FixedSingle;
            tbMatKhauMoi.Font = new Font("Times New Roman", 10.2F);
            tbMatKhauMoi.Location = new Point(16, 173);
            tbMatKhauMoi.Name = "tbMatKhauMoi";
            tbMatKhauMoi.Size = new Size(261, 27);
            tbMatKhauMoi.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 150);
            label2.Name = "label2";
            label2.Size = new Size(111, 19);
            label2.TabIndex = 8;
            label2.Text = "Mật khẩu mới";
            // 
            // tbMatKhauCu
            // 
            tbMatKhauCu.BorderStyle = BorderStyle.FixedSingle;
            tbMatKhauCu.Font = new Font("Times New Roman", 10.2F);
            tbMatKhauCu.Location = new Point(16, 113);
            tbMatKhauCu.Name = "tbMatKhauCu";
            tbMatKhauCu.Size = new Size(261, 27);
            tbMatKhauCu.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 90);
            label1.Name = "label1";
            label1.Size = new Size(99, 19);
            label1.TabIndex = 6;
            label1.Text = "Mật khẩu cũ";
            // 
            // tbTenDN
            // 
            tbTenDN.BorderStyle = BorderStyle.FixedSingle;
            tbTenDN.Font = new Font("Times New Roman", 10.2F);
            tbTenDN.Location = new Point(16, 54);
            tbTenDN.Name = "tbTenDN";
            tbTenDN.Size = new Size(261, 27);
            tbTenDN.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 31);
            label10.Name = "label10";
            label10.Size = new Size(114, 19);
            label10.TabIndex = 4;
            label10.Text = "Tên đăng nhập";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lbExit);
            groupBox4.Controls.Add(btnExit);
            groupBox4.Controls.Add(btnThem);
            groupBox4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.Teal;
            groupBox4.Location = new Point(621, 19);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(167, 155);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chức năng";
            // 
            // lbExit
            // 
            lbExit.AutoSize = true;
            lbExit.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbExit.ForeColor = Color.Red;
            lbExit.Location = new Point(609, -203);
            lbExit.Name = "lbExit";
            lbExit.Size = new Size(27, 25);
            lbExit.TabIndex = 1;
            lbExit.Text = "X";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Teal;
            btnExit.BackgroundColor = Color.Teal;
            btnExit.BorderColor = Color.Teal;
            btnExit.BorderRadius = 20;
            btnExit.BorderSize = 1;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(15, 90);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(135, 35);
            btnExit.TabIndex = 11;
            btnExit.Text = "Đóng";
            btnExit.TextColor = Color.White;
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Teal;
            btnThem.BackgroundColor = Color.Teal;
            btnThem.BorderColor = Color.Teal;
            btnThem.BorderRadius = 20;
            btnThem.BorderSize = 1;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(15, 37);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(135, 35);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm nhân viên";
            btnThem.TextColor = Color.White;
            btnThem.UseVisualStyleBackColor = false;
            // 
            // SetPassAgain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 374);
            Controls.Add(pnlMain);
            Controls.Add(pnlTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SetPassAgain";
            Text = "SetPassAgain";
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            pnlMain.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitle;
        private Label lbTitle;
        private Panel pnlMain;
        private GroupBox groupBox1;
        private TextBox tbMatKhauMoi;
        private Label label2;
        private TextBox tbMatKhauCu;
        private Label label1;
        private TextBox tbTenDN;
        private Label label10;
        private GroupBox groupBox4;
        private Label lbExit;
        private Assets.CusButton btnExit;
        private Assets.CusButton btnThem;
        private Assets.CusButton btnClose;
        private Assets.CusButton btnSubmit;
    }
}