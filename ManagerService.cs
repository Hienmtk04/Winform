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
    public partial class managerService : UserControl
    {
        private string connectionString = "Data Source=HIENMTK-PC\\SQLEXPRESS;Initial Catalog=Winform_HotelManage;Integrated Security=true;TrustServerCertificate=True";
        private int selectedRowId = -1;
        private SaveFileDialog saveFileDialog1 = new SaveFileDialog();

        private void TypeService()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT ID, Ten_Dich_Vu FROM LOAIDICHVU", connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    cbTypeService.DataSource = dataTable;
                    cbTypeService.DisplayMember = "Ten_Dich_Vu";
                    cbTypeService.ValueMember = "ID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public managerService()
        {
            InitializeComponent();
            TypeService();
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
                    SqlCommand command = new SqlCommand("SELECT dv.Ma_DV, dv.Ten_DV, ldv.Ten_Dich_Vu, dv.Gia_DV FROM DICHVU dv JOIN LOAIDICHVU ldv ON dv.Loai_DV = ldv.ID  ", connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable); // Thực hiện điền dữ liệu vào DataTable

                    dtgService.DataSource = dataTable; // Gán DataTable cho DataGridView
                    dtgService.AutoGenerateColumns = true;

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
                    SqlCommand command = new SqlCommand("SELECT * FROM DICHVU WHERE Ten_DV LIKE @Ten_DV", connection);

                    command.Parameters.Add(new SqlParameter("@Ten_DV", tbSearch.Text));

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    LoadData();

                    if (dataTable.Rows.Count > 0)
                    {
                        // Display the data in corresponding textboxes
                        tbIDService.Text = dataTable.Rows[0]["Ma_DV"].ToString();
                        tbNameService.Text = dataTable.Rows[0]["Ten_DV"].ToString();
                        cbTypeService.Text = dataTable.Rows[0]["Loai_DV"].ToString();
                        tbPrice.Text = dataTable.Rows[0]["Gia_DV"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không có dịch vụ nào với tên bạn tìm kiếm.");
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                connection.Close();
            }
        }

        private void ManagerService_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddService add = new AddService();
            add.ServiceAdded += LoadData;
            add.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE DICHVU SET Ten_DV = @Ten_DV, Loai_DV =  @Loai_DV, Gia_DV = @Gia_DV WHERE  Ma_DV = @Ma_DV ", connection);

                    command.Parameters.Add(new SqlParameter("@Ma_DV", tbIDService.Text));
                    command.Parameters.Add(new SqlParameter("@Ten_DV", tbNameService.Text));
                    command.Parameters.Add(new SqlParameter("@Loai_DV", cbTypeService.SelectedValue));
                    command.Parameters.Add(new SqlParameter("@Gia_DV", tbPrice.Text));


                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Cập nhật dịch vụ thành công! ");

                    LoadData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dtgService_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgService.Rows[e.RowIndex];

                tbIDService.Text = selectedRow.Cells["Ma_DV"].Value.ToString();
                tbNameService.Text = selectedRow.Cells["Ten_DV"].Value.ToString();
                cbTypeService.Text = selectedRow.Cells["Ten_Dich_Vu"].Value.ToString();
                tbPrice.Text = selectedRow.Cells["Gia_DV"].Value.ToString();
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                ToExcel(dtgService, saveFileDialog1.FileName);
            }
        }
        private void ToExcel(DataGridView dataGridView1, string fileName)
        {
            // Create COM objects
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
            worksheet.Name = "Quản lý dịch vụ";

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
