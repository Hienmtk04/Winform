namespace HotelManage
{
    partial class MainPage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            panel2 = new Panel();
            btnUse_Payment = new Button();
            pictureBox4 = new PictureBox();
            btnRules = new Button();
            btnMonitor = new Button();
            btnServiceMng = new Button();
            btnBooking = new Button();
            btnRecieve = new Button();
            btnStaffMng = new Button();
            btnBillMng = new Button();
            btnCustomerMng = new Button();
            btnRoomMng = new Button();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            btnDashboard = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            txtTime = new Label();
            pictureBox3 = new PictureBox();
            btnExit = new Button();
            btnReport = new Button();
            btnLogout = new Button();
            panel3 = new Panel();
            adminDashboard1 = new AdminDashboard();
            timer1 = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(btnUse_Payment);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(btnRules);
            panel2.Controls.Add(btnMonitor);
            panel2.Controls.Add(btnServiceMng);
            panel2.Controls.Add(btnBooking);
            panel2.Controls.Add(btnRecieve);
            panel2.Controls.Add(btnStaffMng);
            panel2.Controls.Add(btnBillMng);
            panel2.Controls.Add(btnCustomerMng);
            panel2.Controls.Add(btnRoomMng);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnDashboard);
            panel2.Location = new Point(0, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(343, 752);
            panel2.TabIndex = 1;
            // 
            // btnUse_Payment
            // 
            btnUse_Payment.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnUse_Payment.Image = (Image)resources.GetObject("btnUse_Payment.Image");
            btnUse_Payment.ImageAlign = ContentAlignment.MiddleLeft;
            btnUse_Payment.Location = new Point(22, 528);
            btnUse_Payment.Name = "btnUse_Payment";
            btnUse_Payment.Size = new Size(300, 48);
            btnUse_Payment.TabIndex = 16;
            btnUse_Payment.Text = "SD dịch vụ và thanh toán";
            btnUse_Payment.UseVisualStyleBackColor = true;
            btnUse_Payment.Click += btnUse_Payment_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(290, 10);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // btnRules
            // 
            btnRules.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnRules.Image = (Image)resources.GetObject("btnRules.Image");
            btnRules.ImageAlign = ContentAlignment.MiddleLeft;
            btnRules.Location = new Point(22, 635);
            btnRules.Name = "btnRules";
            btnRules.Size = new Size(300, 48);
            btnRules.TabIndex = 13;
            btnRules.Text = "Quy định";
            btnRules.UseVisualStyleBackColor = true;
            btnRules.Click += btnRules_Click;
            // 
            // btnMonitor
            // 
            btnMonitor.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnMonitor.Image = (Image)resources.GetObject("btnMonitor.Image");
            btnMonitor.ImageAlign = ContentAlignment.MiddleLeft;
            btnMonitor.Location = new Point(22, 581);
            btnMonitor.Name = "btnMonitor";
            btnMonitor.Size = new Size(300, 48);
            btnMonitor.TabIndex = 11;
            btnMonitor.Text = "Thống kê doanh thu";
            btnMonitor.UseVisualStyleBackColor = true;
            btnMonitor.Click += btnMonitor_Click;
            // 
            // btnServiceMng
            // 
            btnServiceMng.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnServiceMng.Image = (Image)resources.GetObject("btnServiceMng.Image");
            btnServiceMng.ImageAlign = ContentAlignment.MiddleLeft;
            btnServiceMng.Location = new Point(22, 474);
            btnServiceMng.Name = "btnServiceMng";
            btnServiceMng.Size = new Size(300, 48);
            btnServiceMng.TabIndex = 10;
            btnServiceMng.Text = "Quản lý dịch vụ";
            btnServiceMng.UseVisualStyleBackColor = true;
            btnServiceMng.Click += btnServiceMng_Click;
            // 
            // btnBooking
            // 
            btnBooking.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnBooking.Image = (Image)resources.GetObject("btnBooking.Image");
            btnBooking.ImageAlign = ContentAlignment.MiddleLeft;
            btnBooking.Location = new Point(22, 204);
            btnBooking.Name = "btnBooking";
            btnBooking.Size = new Size(300, 49);
            btnBooking.TabIndex = 9;
            btnBooking.Text = "Đặt phòng";
            btnBooking.UseVisualStyleBackColor = true;
            btnBooking.Click += btnBooking_Click;
            // 
            // btnRecieve
            // 
            btnRecieve.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnRecieve.Image = (Image)resources.GetObject("btnRecieve.Image");
            btnRecieve.ImageAlign = ContentAlignment.MiddleLeft;
            btnRecieve.Location = new Point(22, 150);
            btnRecieve.Name = "btnRecieve";
            btnRecieve.Size = new Size(300, 49);
            btnRecieve.TabIndex = 8;
            btnRecieve.Text = "Nhận phòng";
            btnRecieve.UseVisualStyleBackColor = true;
            btnRecieve.Click += btnRecieve_Click;
            // 
            // btnStaffMng
            // 
            btnStaffMng.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnStaffMng.Image = (Image)resources.GetObject("btnStaffMng.Image");
            btnStaffMng.ImageAlign = ContentAlignment.MiddleLeft;
            btnStaffMng.Location = new Point(22, 420);
            btnStaffMng.Name = "btnStaffMng";
            btnStaffMng.Size = new Size(300, 48);
            btnStaffMng.TabIndex = 7;
            btnStaffMng.Text = "Quản lý nhân viên";
            btnStaffMng.UseVisualStyleBackColor = true;
            btnStaffMng.Click += btnStaffMng_Click;
            // 
            // btnBillMng
            // 
            btnBillMng.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnBillMng.Image = (Image)resources.GetObject("btnBillMng.Image");
            btnBillMng.ImageAlign = ContentAlignment.MiddleLeft;
            btnBillMng.Location = new Point(22, 366);
            btnBillMng.Name = "btnBillMng";
            btnBillMng.Size = new Size(300, 48);
            btnBillMng.TabIndex = 6;
            btnBillMng.Text = "Quản lý hóa đơn";
            btnBillMng.UseVisualStyleBackColor = true;
            btnBillMng.Click += btnBillMng_Click;
            // 
            // btnCustomerMng
            // 
            btnCustomerMng.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnCustomerMng.Image = (Image)resources.GetObject("btnCustomerMng.Image");
            btnCustomerMng.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomerMng.Location = new Point(22, 312);
            btnCustomerMng.Name = "btnCustomerMng";
            btnCustomerMng.Size = new Size(300, 48);
            btnCustomerMng.TabIndex = 5;
            btnCustomerMng.Text = "Quản lý khách hàng";
            btnCustomerMng.UseVisualStyleBackColor = true;
            btnCustomerMng.Click += btnCustomerMng_Click;
            // 
            // btnRoomMng
            // 
            btnRoomMng.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnRoomMng.Image = (Image)resources.GetObject("btnRoomMng.Image");
            btnRoomMng.ImageAlign = ContentAlignment.MiddleLeft;
            btnRoomMng.Location = new Point(22, 259);
            btnRoomMng.Name = "btnRoomMng";
            btnRoomMng.Size = new Size(300, 47);
            btnRoomMng.TabIndex = 4;
            btnRoomMng.Text = "Quản lý phòng";
            btnRoomMng.UseVisualStyleBackColor = true;
            btnRoomMng.Click += btnRoomMng_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(22, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(88, 49);
            label2.Name = "label2";
            label2.Size = new Size(145, 23);
            label2.TabIndex = 2;
            label2.Text = "Xin chào, Admin";
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(22, 95);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(300, 49);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 27);
            label1.Name = "label1";
            label1.Size = new Size(283, 23);
            label1.TabIndex = 2;
            label1.Text = "Hệ thống quản lý khách sạn Meii";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PowderBlue;
            panel1.Controls.Add(txtTime);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnReport);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1542, 76);
            panel1.TabIndex = 0;
            // 
            // txtTime
            // 
            txtTime.AutoSize = true;
            txtTime.BackColor = Color.White;
            txtTime.BorderStyle = BorderStyle.FixedSingle;
            txtTime.Location = new Point(806, 30);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(2, 22);
            txtTime.TabIndex = 11;
            txtTime.Click += txtTime_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(362, 18);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(1416, 21);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(102, 37);
            btnExit.TabIndex = 9;
            btnExit.Text = "Thoát";
            btnExit.TextAlign = ContentAlignment.MiddleRight;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnReport
            // 
            btnReport.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReport.Image = (Image)resources.GetObject("btnReport.Image");
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(1072, 21);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(194, 37);
            btnReport.TabIndex = 8;
            btnReport.Text = "Báo cáo thống kê";
            btnReport.TextAlign = ContentAlignment.MiddleRight;
            btnReport.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(1272, 21);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(138, 37);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Đăng xuất";
            btnLogout.TextAlign = ContentAlignment.MiddleRight;
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(adminDashboard1);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(341, 76);
            panel3.Name = "panel3";
            panel3.Size = new Size(1201, 733);
            panel3.TabIndex = 2;
            // 
            // adminDashboard1
            // 
            adminDashboard1.AutoScroll = true;
            adminDashboard1.BackColor = SystemColors.Control;
            adminDashboard1.Location = new Point(0, -4);
            adminDashboard1.Name = "adminDashboard1";
            adminDashboard1.Size = new Size(1201, 906);
            adminDashboard1.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1542, 809);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Meii - Niềm tin và hạnh phúc";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button btnDashboard;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnBillMng;
        private Button btnCustomerMng;
        private Button btnRoomMng;
        private Button btnLogout;
        private Button btnExit;
        private Button btnReport;
        private Button btnStaffMng;
        private Button btnRecieve;
        private Button btnBooking;
        private Button btnRules;
        private Button btnMonitor;
        private Button btnServiceMng;
        private Panel panel3;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label txtTime;
        private Button btnUse_Payment;
        private AdminDashboard adminDashboard1;
    }
}