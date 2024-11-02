using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManage
{
    public partial class ManagerStaff : UserControl
    {
        private string connectionString = "Data Source=HIENMTK-PC\\SQLEXPRESS;Initial Catalog=Winform_HotelManage;Integrated Security=true;TrustServerCertificate=True";
        private int selectedRowId = -1;
        private SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        public ManagerStaff()
        {
            InitializeComponent();
            LoadData();
            TypeStaff();
            saveFileDialog1.Filter = "Excel Files|*.xlsx";
            saveFileDialog1.Title = "Save an Excel File";
        }

        private void TypeStaff()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT ID, Ten_Truy_Cap FROM QUYENTRUYCAP", connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    cbLoai_NV.DataSource = dataTable;
                    cbLoai_NV.DisplayMember = "Ten_Truy_Cap";
                    cbLoai_NV.ValueMember = "ID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM NHANVIEN nv JOIN QUYENTRUYCAP qtc ON nv.LoaiNV = qtc.ID", connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    dtgStaff.DataSource = dataTable;
                    dtgStaff.AutoGenerateColumns = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                connection.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM NHANVIEN nv JOIN QUYENTRUYCAP qtc ON nv.LoaiNV = qtc.ID" +
                        " WHERE TENNV LIKE '%@tb_TimKiem%' OR So_cccd = @tb_TimKiem OR So_dien_thoai =  @tb_TimKiem", connection);
                    command.Parameters.Add(new SqlParameter("@tb_TimKiem", tbSearch.Text));

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {

                        tbMaNV.Text = dataTable.Rows[0]["MaNV"].ToString();
                        tbTen_NV.Text = dataTable.Rows[0]["TenNV"].ToString();
                        tbCCCD.Text = dataTable.Rows[0]["So_cccd"].ToString();
                        cbGioi_tinh.Text = dataTable.Rows[0]["Gioi_tinh"].ToString();
                        dtNgay_Sinh.Text = dataTable.Rows[0]["Ngay_sinh"].ToString();
                        tbSDT.Text = dataTable.Rows[0]["So_dien_thoai"].ToString();
                        tbDiaChi.Text = dataTable.Rows[0]["Dia_chi"].ToString();
                        tbTen_DN.Text = dataTable.Rows[0]["Ten_dang_nhap"].ToString();
                        cbLoai_NV.Text = dataTable.Rows[0]["Ten_Truy_Cap"].ToString();
                        dtNgay_lam.Text = dataTable.Rows[0]["Ngay_vao_lam"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm kiếm nhân viên nào với từ khóa bạn tìm kiếm.");
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddStaff add = new AddStaff();
            add.StaffAdded += LoadData;
            add.ShowDialog();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE NHANVIEN SET Ten_dang_nhap = @Ten_dang_nhap, TenNV =  @TenNV, Ngay_sinh = @Ngay_sinh," +
                        " Gioi_tinh = @Gioi_tinh,  LoaiNV = @LoaiNV, So_cccd = @So_cccd, So_dien_thoai = @SoDT, Dia_chi = @Dia_chi , Ngay_vao_lam = @NgayVaoLam WHERE  MaNV = @MaNV ", connection);

                    command.Parameters.Add(new SqlParameter("@MaNV", tbMaNV.Text));
                    command.Parameters.Add(new SqlParameter("@Ten_dang_nhap", tbTen_DN.Text));
                    command.Parameters.Add(new SqlParameter("@TenNV", tbTen_NV.Text));
                    command.Parameters.Add(new SqlParameter("@Ngay_sinh", DateTime.ParseExact(dtNgay_Sinh.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)));
                    command.Parameters.Add(new SqlParameter("@Gioi_tinh", cbGioi_tinh.Text));
                    command.Parameters.Add(new SqlParameter("@LoaiNV", cbLoai_NV.SelectedValue));
                    command.Parameters.Add(new SqlParameter("@So_cccd", tbCCCD.Text));
                    command.Parameters.Add(new SqlParameter("@SoDT", tbSDT.Text));
                    command.Parameters.Add(new SqlParameter("@Dia_chi", tbDiaChi.Text));
                    command.Parameters.Add(new SqlParameter("@NgayVaoLam", DateTime.ParseExact(dtNgay_lam.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)));

                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Cập nhật nhân viên thành công! ");

                    LoadData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dtgStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgStaff.Rows[e.RowIndex];

                tbMaNV.Text = selectedRow.Cells["MaNV"].Value.ToString();
                tbTen_NV.Text = selectedRow.Cells["TenNV"].Value.ToString();
                tbCCCD.Text = selectedRow.Cells["So_cccd"].Value.ToString();
                cbGioi_tinh.Text = selectedRow.Cells["Gioi_tinh"].Value.ToString();
                dtNgay_Sinh.Text = selectedRow.Cells["Ngay_sinh"].Value.ToString();
                tbSDT.Text = selectedRow.Cells["So_dien_thoai"].Value.ToString();
                tbDiaChi.Text = selectedRow.Cells["Dia_chi"].Value.ToString();
                tbTen_DN.Text = selectedRow.Cells["Ten_dang_nhap"].Value.ToString();
                cbLoai_NV.Text = selectedRow.Cells["Ten_Truy_Cap"].Value.ToString();
                dtNgay_lam.Text = selectedRow.Cells["Ngay_vao_lam"].Value.ToString();
            }
        }

        private void btnDLMK_Click(object sender, EventArgs e)
        {
            if (selectedRowId != -1)
            {
                string username = tbTen_DN.Text;
                SetPassAgain resetPasswordForm = new SetPassAgain(selectedRowId, username);
                resetPasswordForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để đặt lại mật khẩu.");
            }
        }
        private void btnAccessRole_Click(object sender, EventArgs e)
        {
            string typeStaff = tbTen_DN.Text;
            AccessRole accessrole = new AccessRole();
            accessrole.ShowDialog();
        }

        private void dtgStaff_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgStaff.SelectedRows.Count > 0)
            {
                selectedRowId = Convert.ToInt32(dtgStaff.SelectedRows[0].Cells["MaNV"].Value);
            }
            else
            {
                selectedRowId = -1;
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                ToExcel(dtgStaff, saveFileDialog1.FileName);
            }
        }
        private void ToExcel(DataGridView dataGridView1, string fileName)
        {
            // Create COM objects
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
            worksheet.Name = "Quản lý nhân viên";

            // Export header in DataGridView
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }

            // Export content in DataGridView
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    // Check for null value before converting to string
                    var cellValue = dataGridView1.Rows[i].Cells[j].Value;
                    worksheet.Cells[i + 2, j + 1] = cellValue != null ? cellValue.ToString() : string.Empty;
                }
            }

            // Save workbook
            workbook.SaveAs(fileName);
            workbook.Close();
            excel.Quit();

            MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
        }
    }
}
