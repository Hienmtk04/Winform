namespace HotelManage
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            panel1 = new Panel();
            panel3 = new Panel();
            btnTatCa = new Button();
            panel8 = new Panel();
            btnDP = new Button();
            panel5 = new Panel();
            btnNP = new Button();
            panel4 = new Panel();
            btnTrong = new Button();
            panel2 = new Panel();
            panelRooms = new Panel();
            panel9 = new Panel();
            button10 = new Button();
            button7 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(71, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(1001, 92);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnTatCa);
            panel3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            panel3.ForeColor = SystemColors.Control;
            panel3.Location = new Point(340, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(147, 50);
            panel3.TabIndex = 0;
            // 
            // btnTatCa
            // 
            btnTatCa.BackColor = Color.Teal;
            btnTatCa.ForeColor = SystemColors.Control;
            btnTatCa.Image = (Image)resources.GetObject("btnTatCa.Image");
            btnTatCa.ImageAlign = ContentAlignment.MiddleLeft;
            btnTatCa.Location = new Point(0, 3);
            btnTatCa.Name = "btnTatCa";
            btnTatCa.Size = new Size(145, 44);
            btnTatCa.TabIndex = 0;
            btnTatCa.Text = "Tất cả (100)";
            btnTatCa.TextAlign = ContentAlignment.MiddleRight;
            btnTatCa.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnDP);
            panel8.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            panel8.ForeColor = SystemColors.Control;
            panel8.Location = new Point(810, 19);
            panel8.Name = "panel8";
            panel8.Size = new Size(167, 50);
            panel8.TabIndex = 3;
            // 
            // btnDP
            // 
            btnDP.BackColor = Color.Teal;
            btnDP.Image = (Image)resources.GetObject("btnDP.Image");
            btnDP.ImageAlign = ContentAlignment.MiddleLeft;
            btnDP.Location = new Point(3, 3);
            btnDP.Name = "btnDP";
            btnDP.Size = new Size(160, 44);
            btnDP.TabIndex = 0;
            btnDP.Text = "Đã đặt (2)";
            btnDP.TextAlign = ContentAlignment.MiddleRight;
            btnDP.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnNP);
            panel5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            panel5.ForeColor = SystemColors.Control;
            panel5.Location = new Point(637, 19);
            panel5.Name = "panel5";
            panel5.Size = new Size(167, 50);
            panel5.TabIndex = 2;
            // 
            // btnNP
            // 
            btnNP.BackColor = Color.Teal;
            btnNP.Image = (Image)resources.GetObject("btnNP.Image");
            btnNP.ImageAlign = ContentAlignment.MiddleLeft;
            btnNP.Location = new Point(3, 3);
            btnNP.Name = "btnNP";
            btnNP.Size = new Size(161, 44);
            btnNP.TabIndex = 0;
            btnNP.Text = "Đã nhận (8)";
            btnNP.TextAlign = ContentAlignment.MiddleRight;
            btnNP.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnTrong);
            panel4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            panel4.ForeColor = SystemColors.Control;
            panel4.Location = new Point(493, 19);
            panel4.Name = "panel4";
            panel4.Size = new Size(138, 50);
            panel4.TabIndex = 1;
            // 
            // btnTrong
            // 
            btnTrong.BackColor = Color.Teal;
            btnTrong.Image = (Image)resources.GetObject("btnTrong.Image");
            btnTrong.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrong.Location = new Point(3, 3);
            btnTrong.Name = "btnTrong";
            btnTrong.Size = new Size(134, 44);
            btnTrong.TabIndex = 0;
            btnTrong.Text = "Trống (90)";
            btnTrong.TextAlign = ContentAlignment.MiddleRight;
            btnTrong.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(panelRooms);
            panel2.Controls.Add(panel9);
            panel2.Location = new Point(71, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(1001, 562);
            panel2.TabIndex = 1;
            // 
            // panelRooms
            // 
            panelRooms.BorderStyle = BorderStyle.FixedSingle;
            panelRooms.Dock = DockStyle.Fill;
            panelRooms.Location = new Point(0, 49);
            panelRooms.Name = "panelRooms";
            panelRooms.Size = new Size(1001, 513);
            panelRooms.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Teal;
            panel9.Controls.Add(button10);
            panel9.Controls.Add(button7);
            panel9.Controls.Add(label1);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(1001, 49);
            panel9.TabIndex = 0;
            // 
            // button10
            // 
            button10.BackColor = Color.Gold;
            button10.Location = new Point(884, 11);
            button10.Name = "button10";
            button10.Size = new Size(94, 29);
            button10.TabIndex = 4;
            button10.Text = "Khách ở";
            button10.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.LightSeaGreen;
            button7.Location = new Point(783, 11);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 1;
            button7.Text = "P.Trống";
            button7.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(16, 13);
            label1.Name = "label1";
            label1.Size = new Size(151, 23);
            label1.TabIndex = 0;
            label1.Text = "Danh sách phòng";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Control;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminDashboard";
            Size = new Size(1159, 733);
            Load += AdminDashboard_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private Button btnNP;
        private Panel panel4;
        private Button btnTrong;
        private Panel panel8;
        private Button btnDP;
        private Panel panel9;
        private Label label1;
        private Panel panelRooms;
        private Button button7;
        private Button button10;
        private Panel panel3;
        private Button btnTatCa;
    }
}
