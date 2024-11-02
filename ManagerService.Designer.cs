namespace HotelManage
{
    partial class managerService
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
            btnClose = new Assets.CusButton();
            btnUpdate = new Assets.CusButton();
            btnAdd = new Assets.CusButton();
            groupBox3 = new GroupBox();
            btnSearch = new Assets.CusButton();
            lbSearch = new Label();
            tbSearch = new TextBox();
            groupBox5 = new GroupBox();
            dtgService = new DataGridView();
            groupBox1 = new GroupBox();
            cbTypeService = new ComboBox();
            tbPrice = new TextBox();
            label4 = new Label();
            tbNameService = new TextBox();
            label3 = new Label();
            label2 = new Label();
            tbIDService = new TextBox();
            lbID = new Label();
            btnExport = new Assets.CusButton();
            pnlTitle.SuspendLayout();
            pnlMain.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgService).BeginInit();
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
            groupBox4.Controls.Add(btnClose);
            groupBox4.Controls.Add(btnUpdate);
            groupBox4.Controls.Add(btnAdd);
            groupBox4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.Teal;
            groupBox4.Location = new Point(39, 464);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(357, 158);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chức năng";
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
            btnClose.Location = new Point(109, 102);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(127, 35);
            btnClose.TabIndex = 13;
            btnClose.Text = "Đóng";
            btnClose.TextColor = Color.White;
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Teal;
            btnUpdate.BackgroundColor = Color.Teal;
            btnUpdate.BorderColor = Color.Teal;
            btnUpdate.BorderRadius = 20;
            btnUpdate.BorderSize = 1;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(201, 44);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(127, 35);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.TextColor = Color.White;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Teal;
            btnAdd.BackgroundColor = Color.Teal;
            btnAdd.BorderColor = Color.Teal;
            btnAdd.BorderRadius = 20;
            btnAdd.BorderSize = 1;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(19, 44);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(127, 35);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Thêm";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnSearch);
            groupBox3.Controls.Add(lbSearch);
            groupBox3.Controls.Add(tbSearch);
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
            btnSearch.BorderColor = Color.Teal;
            btnSearch.BorderRadius = 20;
            btnSearch.BorderSize = 1;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(109, 105);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(127, 35);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click_1;
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
            // tbSearch
            // 
            tbSearch.BorderStyle = BorderStyle.FixedSingle;
            tbSearch.Location = new Point(19, 60);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(322, 27);
            tbSearch.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnExport);
            groupBox5.Controls.Add(dtgService);
            groupBox5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = Color.Teal;
            groupBox5.Location = new Point(452, 20);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(712, 608);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "Danh sách dịch vụ";
            // 
            // dtgService
            // 
            dtgService.BackgroundColor = SystemColors.GradientInactiveCaption;
            dtgService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgService.Location = new Point(16, 82);
            dtgService.Name = "dtgService";
            dtgService.RowHeadersWidth = 51;
            dtgService.Size = new Size(679, 520);
            dtgService.TabIndex = 0;
            dtgService.CellClick += dtgService_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbTypeService);
            groupBox1.Controls.Add(tbPrice);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbNameService);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbIDService);
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
            // cbTypeService
            // 
            cbTypeService.FormattingEnabled = true;
            cbTypeService.Location = new Point(21, 167);
            cbTypeService.Name = "cbTypeService";
            cbTypeService.Size = new Size(297, 27);
            cbTypeService.TabIndex = 10;
            // 
            // tbPrice
            // 
            tbPrice.BorderStyle = BorderStyle.FixedSingle;
            tbPrice.Location = new Point(21, 220);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(297, 27);
            tbPrice.TabIndex = 9;
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
            // tbNameService
            // 
            tbNameService.BorderStyle = BorderStyle.FixedSingle;
            tbNameService.Location = new Point(21, 111);
            tbNameService.Name = "tbNameService";
            tbNameService.Size = new Size(297, 27);
            tbNameService.TabIndex = 7;
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
            // tbIDService
            // 
            tbIDService.BorderStyle = BorderStyle.FixedSingle;
            tbIDService.Location = new Point(21, 55);
            tbIDService.Name = "tbIDService";
            tbIDService.Size = new Size(297, 27);
            tbIDService.TabIndex = 3;
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
            btnExport.Location = new Point(591, 34);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(104, 32);
            btnExport.TabIndex = 13;
            btnExport.Text = "Xuất";
            btnExport.TextColor = Color.White;
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // managerService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlMain);
            Controls.Add(pnlTitle);
            Name = "managerService";
            Size = new Size(1201, 696);
            Load += ManagerService_Load;
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            pnlMain.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgService).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitle;
        private Panel pnlMain;
        private GroupBox groupBox5;
        private DataGridView dtgService;
        private GroupBox groupBox1;
        private TextBox tbPrice;
        private Label label4;
        private TextBox tbNameService;
        private Label label3;
        private Label label2;
        private TextBox tbIDService;
        private Label lbID;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Assets.CusButton btnSearch;
        private Label lbSearch;
        private TextBox tbSearch;
        private Assets.CusButton btnAdd;
        private Assets.CusButton btnAddService;
        private Label lbTitle;
        private ComboBox cbTypeService;
        private Assets.CusButton btnClose;
        private Assets.CusButton btnUpdate;
        private Assets.CusButton btnExport;
    }
}
