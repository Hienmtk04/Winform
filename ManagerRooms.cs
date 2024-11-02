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
    public partial class ManagerRooms : UserControl
    {

        private string connectionString = "Data Source=HIENMTK-PC\\SQLEXPRESS;Initial Catalog=Winform_HotelManage;Integrated Security=true;TrustServerCertificate=True";
        private int selectedRowId = -1;
        List<Status> lstStatus;
        private SaveFileDialog saveFileDialog1 = new SaveFileDialog();


        public ManagerRooms()
        {
            InitializeComponent();
            TypeRoom();
            saveFileDialog1.Filter = "Excel Files|*.xlsx";
            saveFileDialog1.Title = "Save an Excel File";


            lstStatus = new List<Status>()
            {
                new Status(){Name = "Còn phòng"},
                new Status(){Name = "Có khách"},
            };
            cbTrangThai.DataSource = lstStatus;
            cbTrangThai.DisplayMember = "Name";
        }

        public class Status
        {
            public string Name { get; set; }
        }
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT p.Ma_Phong, p.Ten_Phong, lp.Ten_LoaiPhong, p.Gia_Phong, p.Trang_Thai, p.So_Nguoi " +
                "FROM PHONG p " +
                "JOIN LOAIPHONG lp ON p.Loai_Phong = lp.ID", connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable); // Thực hiện điền dữ liệu vào DataTable

                    dtgListRoom.DataSource = dataTable; // Gán DataTable cho DataGridView
                    dtgListRoom.AutoGenerateColumns = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                connection.Close();
            }
        }

        private void TypeRoom()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT ID, Ten_LoaiPhong FROM LOAIPHONG", connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    cbLoaiPhong.DataSource = dataTable;
                    cbLoaiPhong.DisplayMember = "Ten_LoaiPhong";
                    cbLoaiPhong.ValueMember = "ID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM PHONG p JOIN LOAIPHONG lp ON p.Loai_Phong = lp.ID WHERE Ma_Phong = @Ma_Phong", connection);

                    command.Parameters.Add(new SqlParameter("@Ma_Phong", tbWordSearch.Text));

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    LoadData();

                    if (dataTable.Rows.Count > 0)
                    {
                        // Display the data in corresponding textboxes
                        tbIDRoom.Text = dataTable.Rows[0]["Ma_Phong"].ToString();
                        tbNameRoom.Text = dataTable.Rows[0]["Ten_Phong"].ToString();
                        cbLoaiPhong.Text = dataTable.Rows[0]["Ten_LoaiPhong"].ToString();
                        tbPrice.Text = dataTable.Rows[0]["Gia_Phong"].ToString();
                        cbTrangThai.Text = dataTable.Rows[0]["Trang_Thai"].ToString();
                        tbPeople.Text = dataTable.Rows[0]["So_Nguoi"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No room found with the specified ID.");
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                connection.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRoom add = new AddRoom();
            add.RoomAdded += LoadData;
            add.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE PHONG SET Ten_Phong = @Ten_Phong, Loai_Phong =  @Loai_Phong, Gia_Phong = @Gia_Phong, Trang_Thai = @Trang_Thai, So_Nguoi = @So_Nguoi WHERE  Ma_Phong = @Ma_Phong ", connection);

                    command.Parameters.Add(new SqlParameter("@Ma_Phong", tbIDRoom.Text));
                    command.Parameters.Add(new SqlParameter("@Ten_Phong", tbNameRoom.Text));
                    command.Parameters.Add(new SqlParameter("@Loai_Phong", cbLoaiPhong.SelectedValue));
                    command.Parameters.Add(new SqlParameter("@Gia_Phong", tbPrice.Text));
                    command.Parameters.Add(new SqlParameter("@Trang_Thai", cbTrangThai.Text));
                    command.Parameters.Add(new SqlParameter("@So_Nguoi", tbPeople.Text));

                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Cập nhật phòng thành công! ");

                    LoadData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void ManagerRooms_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgListRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgListRoom.Rows[e.RowIndex];

                tbIDRoom.Text = selectedRow.Cells["Ma_Phong"].Value.ToString();
                tbNameRoom.Text = selectedRow.Cells["Ten_Phong"].Value.ToString();
                cbLoaiPhong.Text = selectedRow.Cells["Ten_LoaiPhong"].Value.ToString();
                tbPrice.Text = selectedRow.Cells["Gia_Phong"].Value.ToString();
                cbTrangThai.Text = selectedRow.Cells["Trang_Thai"].Value.ToString();
                tbPeople.Text = selectedRow.Cells["So_Nguoi"].Value.ToString();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                ToExcel(dtgListRoom, saveFileDialog1.FileName);
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


    }
}
