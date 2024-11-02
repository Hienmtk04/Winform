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
    public partial class ManagerBill : UserControl
    {


        private string connectionString = "Data Source=HIENMTK-PC\\SQLEXPRESS;Initial Catalog=Winform_HotelManage;Integrated Security=true;TrustServerCertificate=True";
        private int selectedRowId = -1;
        private string select = "";
        private SaveFileDialog saveFileDialog1 = new SaveFileDialog();

        public ManagerBill()
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
                    SqlCommand command = new SqlCommand(
                            "SELECT hd.Ma_Hoa_Don, p.Ten_Phong, kh.TenKH, hd.Ngay_Tao, hd.Don_Gia, hd.Giam_Gia, hd.Thanh_Tien " +
                            "FROM HOADON hd JOIN KHACHHANG kh ON hd.MA_KH = kh.MAKH " +
                            "JOIN PHONG p ON hd.Ma_Phong = p.Ma_Phong", connection);


                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    dtgHoaDon.DataSource = dataTable;
                    dtgHoaDon.AutoGenerateColumns = true;
                    cbMaHoaDon.DisplayMember = "Ma_Hoa_Don";
                    cbMaHoaDon.ValueMember = "Ma_Hoa_Don";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                connection.Close();
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                ToExcel(dtgHoaDon, saveFileDialog1.FileName);
            }
        }
        private void ToExcel(DataGridView dataGridView1, string fileName)
        {
            // Create COM objects
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
            worksheet.Name = "Quản lý hóa đơn";

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


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    if (cbTimKiemTheo.Text == "Mã hóa đơn")
                    {
                        select = "SELECT * FROM HOADON WHERE Ma_Hoa_Don = @tb_TimKiem";
                    }
                    else if (cbTimKiemTheo.Text == "Tên khách hàng")
                    {
                        select = "SELECT * FROM  HOADON hd JOIN KHACHHANG kh ON hd.MA_KH = kh.MAKH WHERE TenKH LIKE @tb_TimKiem ";
                    }
                    else if (cbTimKiemTheo.Text == "Số CMND/CCCD")
                    {
                        select = "SELECT * FROM  HOADON hd JOIN KHACHHANG kh ON hd.MA_KH = kh.MAKH WHERE SoCCCD = @tb_TimKiem";
                    }
                    else
                    {
                        select = "SELECT * FROM  HOADON hd JOIN KHACHHANG kh ON hd.MA_KH = kh.MAKH WHERE So_dien_thoai = @tb_TimKiem";
                    }

                    connection.Open();
                    SqlCommand command = new SqlCommand(select, connection);

                    // Handle partial search for "Tên khách hàng" with LIKE
                    if (cbTimKiemTheo.Text == "Tên khách hàng")
                    {
                        command.Parameters.Add(new SqlParameter("@tb_TimKiem", $"%{tbSearch.Text}%"));
                    }
                    else
                    {
                        command.Parameters.Add(new SqlParameter("@tb_TimKiem", tbSearch.Text));
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        // Display the data in corresponding textboxes
                        cbMaHoaDon.Text = dataTable.Rows[0]["Ma_Hoa_Don"].ToString();
                        tbTenPhong.Text = dataTable.Rows[0]["Ten_Phong"].ToString();
                        tbNhanVien.Text = dataTable.Rows[0]["So_CCCD"].ToString();
                        tbNgayTao.Text = dataTable.Rows[0]["Ngay_Tao"].ToString();
                        tbDonGia.Text = dataTable.Rows[0]["Don_Gia"].ToString();
                        tbGiamGia.Text = dataTable.Rows[0]["Giam_Gia"].ToString();
                        tbThanhTien.Text = dataTable.Rows[0]["Thanh_Tien"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("Không có hóa đơn nào với từ khóa bạn tìm kiếm.");
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {

        }
    }
}
