namespace HotelManage
{
    partial class AddService
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
            groupBox4 = new GroupBox();
            lbExit = new Label();
            btnClose = new Assets.CusButton();
            btnAddService = new Assets.CusButton();
            groupBox1 = new GroupBox();
            tbGia_DV = new TextBox();
            label4 = new Label();
            cbLoai_DV = new ComboBox();
            label3 = new Label();
            tbTen_DV = new TextBox();
            label2 = new Label();
            tbMa_DV = new TextBox();
            label1 = new Label();
            pnlTitle.SuspendLayout();
            pnlMain.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.Controls.Add(lbTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(601, 48);
            pnlTitle.TabIndex = 0;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.Teal;
            lbTitle.Location = new Point(12, 12);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(147, 25);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Thêm dịch vụ";
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(groupBox4);
            pnlMain.Controls.Add(groupBox1);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 48);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(601, 287);
            pnlMain.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lbExit);
            groupBox4.Controls.Add(btnClose);
            groupBox4.Controls.Add(btnAddService);
            groupBox4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.Teal;
            groupBox4.Location = new Point(22, 178);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(558, 97);
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
            lbExit.Click += lbExit_Click;
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
            btnClose.Location = new Point(298, 46);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(221, 35);
            btnClose.TabIndex = 11;
            btnClose.Text = "Đóng";
            btnClose.TextColor = Color.White;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnAddService
            // 
            btnAddService.BackColor = Color.Teal;
            btnAddService.BackgroundColor = Color.Teal;
            btnAddService.BorderColor = Color.Teal;
            btnAddService.BorderRadius = 20;
            btnAddService.BorderSize = 1;
            btnAddService.FlatAppearance.BorderSize = 0;
            btnAddService.FlatStyle = FlatStyle.Flat;
            btnAddService.ForeColor = Color.White;
            btnAddService.Location = new Point(32, 46);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(221, 35);
            btnAddService.TabIndex = 10;
            btnAddService.Text = "Thêm dịch vụ";
            btnAddService.TextColor = Color.White;
            btnAddService.UseVisualStyleBackColor = false;
            btnAddService.Click += btnAddService_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbGia_DV);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cbLoai_DV);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbTen_DV);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbMa_DV);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Teal;
            groupBox1.Location = new Point(22, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(558, 154);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin dịch vụ";
            // 
            // tbGia_DV
            // 
            tbGia_DV.BorderStyle = BorderStyle.FixedSingle;
            tbGia_DV.Location = new Point(289, 110);
            tbGia_DV.Name = "tbGia_DV";
            tbGia_DV.Size = new Size(255, 27);
            tbGia_DV.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(289, 88);
            label4.Name = "label4";
            label4.Size = new Size(37, 19);
            label4.TabIndex = 6;
            label4.Text = "Giá";
            // 
            // cbLoai_DV
            // 
            cbLoai_DV.FormattingEnabled = true;
            cbLoai_DV.Items.AddRange(new object[] { "Ăn uống", "Giải trí", "Tiện ích", "Sức khỏe" });
            cbLoai_DV.Location = new Point(15, 110);
            cbLoai_DV.Name = "cbLoai_DV";
            cbLoai_DV.Size = new Size(249, 27);
            cbLoai_DV.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 88);
            label3.Name = "label3";
            label3.Size = new Size(100, 19);
            label3.TabIndex = 4;
            label3.Text = "Loại dịch vụ";
            // 
            // tbTen_DV
            // 
            tbTen_DV.BorderStyle = BorderStyle.FixedSingle;
            tbTen_DV.Location = new Point(289, 49);
            tbTen_DV.Name = "tbTen_DV";
            tbTen_DV.Size = new Size(255, 27);
            tbTen_DV.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(289, 27);
            label2.Name = "label2";
            label2.Size = new Size(93, 19);
            label2.TabIndex = 2;
            label2.Text = "Tên dịch vụ";
            // 
            // tbMa_DV
            // 
            tbMa_DV.BorderStyle = BorderStyle.FixedSingle;
            tbMa_DV.Location = new Point(15, 49);
            tbMa_DV.Name = "tbMa_DV";
            tbMa_DV.Size = new Size(249, 27);
            tbMa_DV.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 27);
            label1.Name = "label1";
            label1.Size = new Size(90, 19);
            label1.TabIndex = 0;
            label1.Text = "Mã dịch vụ";
            // 
            // AddService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 335);
            Controls.Add(pnlMain);
            Controls.Add(pnlTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddService";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddService";
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            pnlMain.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitle;
        private Label lbTitle;
        private Panel pnlMain;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cbLoai_DV;
        private Label label3;
        private TextBox tbTen_DV;
        private Label label2;
        private TextBox tbMa_DV;
        private GroupBox groupBox4;
        private Assets.CusButton btnClose;
        private Assets.CusButton btnAddService;
        private Label lbExit;
        private TextBox tbGia_DV;
        private Label label4;
    }
}