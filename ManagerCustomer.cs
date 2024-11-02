using Microsoft.Data.SqlClient;
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
    public partial class ManagerCustomer : UserControl
    {

        private string connectionString = "Data Source=HIENMTK-PC\\SQLEXPRESS;Initial Catalog=Winform_HotelManage;Integrated Security=true;TrustServerCertificate=True";
        private int selectedRowId = -1;
        private string select = "";
        private SaveFileDialog saveFileDialog1 = new SaveFileDialog();

        public ManagerCustomer()
        {
            InitializeComponent();
            LoadData();

            saveFileDialog1.Filter = "Excel Files|*.xlsx";
            saveFileDialog1.Title = "Save an Excel File";

        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM KHACHHANG", connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable); // Thực hiện điền dữ liệu vào DataTable

                    dtgKhach_Hang.Rows.Clear();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        dtgKhach_Hang.Rows.Add(
                            row["MaKH"].ToString(),
                            row["TenKH"].ToString(),
                            row["SoCCCD"].ToString(),
                            row["Loai"].ToString(),
                            row["So_dien_thoai"].ToString(),
                            row["Dia_chi"].ToString(),
                            row["Quoc_tich"].ToString()
                        );
                    }


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
                    // Set the query based on the selected search criterion
                    if (cbTim_theo.Text == "Mã khách hàng")
                    {
                        select = "SELECT * FROM KHACHHANG WHERE MaKH = @tb_TimKiem";
                    }
                    else if (cbTim_theo.Text == "Tên khách hàng")
                    {
                        select = "SELECT * FROM KHACHHANG WHERE TenKH LIKE @tb_TimKiem ";
                    }
                    else if (cbTim_theo.Text == "Số CMND/CCCD")
                    {
                        select = "SELECT * FROM KHACHHANG WHERE SoCCCD = @tb_TimKiem";
                    }
                    else
                    {
                        select = "SELECT * FROM KHACHHANG WHERE So_dien_thoai = @tb_TimKiem";
                    }

                    connection.Open();
                    SqlCommand command = new SqlCommand(select, connection);

                    // Handle partial search for "Tên khách hàng" with LIKE
                    if (cbTim_theo.Text == "Tên khách hàng")
                    {
                        command.Parameters.Add(new SqlParameter("@tb_TimKiem", $"%{tbTim_kiem.Text}%"));
                    }
                    else
                    {
                        command.Parameters.Add(new SqlParameter("@tb_TimKiem", tbTim_kiem.Text));
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        // Display the data in corresponding textboxes
                        tbMaKH.Text = dataTable.Rows[0]["MaKH"].ToString();
                        tbTen_KH.Text = dataTable.Rows[0]["TenKH"].ToString();
                        tbCCCD.Text = dataTable.Rows[0]["SoCCCD"].ToString();
                        cbLoai_KH.Text = dataTable.Rows[0]["Loai"].ToString();
                        cbGioi_Tinh.Text = dataTable.Rows[0]["Gioi_tinh"].ToString();
                        dtNgay_Sinh.Text = dataTable.Rows[0]["Ngay_sinh"].ToString();
                        tbSDT.Text = dataTable.Rows[0]["So_dien_thoai"].ToString();
                        tbDia_Chi.Text = dataTable.Rows[0]["Dia_chi"].ToString();
                        tbQuoc_Tich.Text = dataTable.Rows[0]["Quoc_tich"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không có khách hàng nào với từ khóa bạn tìm kiếm.");
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCustomer add = new AddCustomer();
            add.CustomerAdded += LoadData;
            add.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE KHACHHANG SET TenKH = @TenKH, SoCCCD =  @SoCCCD, Loai = @Loai, Ngay_sinh = @Ngay_sinh," +
                        " Gioi_tinh = @Gioi_tinh, So_dien_thoai = @SoDT, Dia_chi = @Dia_chi, Quoc_tich = @Quoc_tich WHERE  MaKH = @MaKH ", connection);

                    command.Parameters.Add(new SqlParameter("@MAKH", tbMaKH.Text));
                    command.Parameters.Add(new SqlParameter("@TenKH", tbTen_KH.Text));
                    command.Parameters.Add(new SqlParameter("@SoCCCD", tbCCCD.Text));
                    command.Parameters.Add(new SqlParameter("@Loai", cbLoai_KH.Text));
                    command.Parameters.Add(new SqlParameter("@Ngay_sinh", DateTime.ParseExact(dtNgay_Sinh.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)));
                    command.Parameters.Add(new SqlParameter("@Gioi_tinh", cbGioi_Tinh.Text));
                    command.Parameters.Add(new SqlParameter("@SoDT", tbSDT.Text));
                    command.Parameters.Add(new SqlParameter("@Dia_chi", tbDia_Chi.Text));
                    command.Parameters.Add(new SqlParameter("@Quoc_tich", tbQuoc_Tich.Text));


                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Cập nhật khách hàng thành công! ");

                    LoadData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dtgKhach_Hang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgKhach_Hang.Rows[e.RowIndex];

                tbMaKH.Text = selectedRow.Cells["MaKH"].Value.ToString();
                tbTen_KH.Text = selectedRow.Cells["TenKH"].Value.ToString();
                tbCCCD.Text = selectedRow.Cells["SoCCCD"].Value.ToString();
                cbLoai_KH.Text = selectedRow.Cells["Loai"].Value.ToString();
                cbGioi_Tinh.Text = selectedRow.Cells["Gioi_tinh"].Value.ToString();
                dtNgay_Sinh.Text = selectedRow.Cells["Ngay_sinh"].Value.ToString();
                tbSDT.Text = selectedRow.Cells["So_dien_thoai"].Value.ToString();
                tbDia_Chi.Text = selectedRow.Cells["Dia_chi"].Value.ToString();
                tbQuoc_Tich.Text = selectedRow.Cells["Quoc_tich"].Value.ToString();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                ToExcel(dtgKhach_Hang, saveFileDialog1.FileName);
            }
        }
        private void ToExcel(DataGridView dataGridView1, string fileName)
        {
            // Create COM objects
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
            worksheet.Name = "Quản lý khách hàng";

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
