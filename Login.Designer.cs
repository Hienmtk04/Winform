namespace HotelManage
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            txtUsername = new Label();
            txtPass = new Label();
            tbUsername = new TextBox();
            btnLogin = new Button();
            tbPass = new TextBox();
            cbShowPass = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            Exit_Click = new Label();
            label5 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox3 = new PictureBox();
            linkDangKy = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.InactiveCaptionText;
            label1.Location = new Point(484, 190);
            label1.Name = "label1";
            label1.Size = new Size(342, 25);
            label1.TabIndex = 0;
            label1.Text = "Hệ thống quản lý khách sạn Meii";
            // 
            // txtUsername
            // 
            txtUsername.AutoSize = true;
            txtUsername.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(455, 243);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(123, 19);
            txtUsername.TabIndex = 2;
            txtUsername.Text = "Tên người dùng";
            // 
            // txtPass
            // 
            txtPass.AutoSize = true;
            txtPass.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(455, 305);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(78, 19);
            txtPass.TabIndex = 3;
            txtPass.Text = "Mật khẩu";
            // 
            // tbUsername
            // 
            tbUsername.BackColor = SystemColors.HighlightText;
            tbUsername.BorderStyle = BorderStyle.FixedSingle;
            tbUsername.Location = new Point(455, 265);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(386, 27);
            tbUsername.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkSlateGray;
            btnLogin.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(540, 431);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(220, 56);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // tbPass
            // 
            tbPass.BackColor = SystemColors.HighlightText;
            tbPass.BorderStyle = BorderStyle.FixedSingle;
            tbPass.Location = new Point(455, 327);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(386, 27);
            tbPass.TabIndex = 7;
            tbPass.TextChanged += tbPass_TextChanged;
            // 
            // cbShowPass
            // 
            cbShowPass.AutoSize = true;
            cbShowPass.Location = new Point(455, 373);
            cbShowPass.Name = "cbShowPass";
            cbShowPass.Size = new Size(148, 24);
            cbShowPass.TabIndex = 9;
            cbShowPass.Text = "Hiển thị mật khẩu";
            cbShowPass.UseVisualStyleBackColor = true;
            cbShowPass.CheckedChanged += cbShowPass_CheckedChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.CalendarMonthBackground = SystemColors.HighlightText;
            dateTimePicker1.CustomFormat = "ddd, dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(73, 399);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(255, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(397, 527);
            panel1.TabIndex = 12;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(22, 123);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(353, 253);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // Exit_Click
            // 
            Exit_Click.AutoSize = true;
            Exit_Click.BackColor = Color.Red;
            Exit_Click.BorderStyle = BorderStyle.FixedSingle;
            Exit_Click.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit_Click.Location = new Point(865, 18);
            Exit_Click.Name = "Exit_Click";
            Exit_Click.Size = new Size(20, 19);
            Exit_Click.TabIndex = 13;
            Exit_Click.Text = "X";
            Exit_Click.Click += Exit_Click_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.InactiveCaptionText;
            label5.Location = new Point(572, 150);
            label5.Name = "label5";
            label5.Size = new Size(152, 25);
            label5.TabIndex = 14;
            label5.Text = "ĐĂNG NHẬP";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(604, 53);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(81, 80);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // linkDangKy
            // 
            linkDangKy.AutoSize = true;
            linkDangKy.LinkColor = Color.DarkCyan;
            linkDangKy.Location = new Point(778, 373);
            linkDangKy.Name = "linkDangKy";
            linkDangKy.Size = new Size(63, 20);
            linkDangKy.TabIndex = 16;
            linkDangKy.TabStop = true;
            linkDangKy.Text = "Đăng ký";
            linkDangKy.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.PowderBlue;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(895, 527);
            Controls.Add(linkDangKy);
            Controls.Add(pictureBox3);
            Controls.Add(label5);
            Controls.Add(Exit_Click);
            Controls.Add(panel1);
            Controls.Add(cbShowPass);
            Controls.Add(tbPass);
            Controls.Add(btnLogin);
            Controls.Add(tbUsername);
            Controls.Add(txtPass);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResizeEnd += Login1;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label txtUsername;
        private Label txtPass;
        private TextBox tbUsername;
        private Button btnLogin;
        private TextBox tbPass;
        private CheckBox cbShowPass;
        private DateTimePicker dateTimePicker1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label Exit_Click;
        private Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox3;
        private LinkLabel linkDangKy;
    }
}
