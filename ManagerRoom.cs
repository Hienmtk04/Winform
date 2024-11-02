using OfficeOpenXml.Style;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using Microsoft.Data.SqlClient;
using System.Xml.Linq;
using static HotelManage.AddRoom;
using ExcelApp = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace HotelManage
{
    public partial class ManagerRoom : UserControl
    {
        private string connectionString = "Data Source=HIENMTK-PC\\SQLEXPRESS;Initial Catalog=Winform_HotelManage;Integrated Security=true;TrustServerCertificate=True";
        private int selectedRowId = -1;
        List<Status> lstStatus;
        List<TypeRoom> lstType;

        public ManagerRoom()
        {
            InitializeComponent();
            lstType = new List<TypeRoom>()
            {
                new TypeRoom(){Name = "Phòng đơn (SINGLE)"},
                new TypeRoom(){Name = "Phòng đôi (COUPLE)"},
                new TypeRoom(){Name = "Phòng VIP (VIP)"},
            };

            cbLoaiPhong.DataSource = lstType;
            cbLoaiPhong.DisplayMember = "Name";


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
        public class TypeRoom
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
                    SqlCommand command = new SqlCommand("SELECT * FROM PHONG", connection);

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
        private void ManagerRoom_Load(object sender, EventArgs e)
        {
            LoadData();
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
                    command.Parameters.Add(new SqlParameter("@Loai_Phong", cbLoaiPhong.Text));
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM PHONG WHERE Ma_Phong = @Ma_Phong", connection);

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
                        cbLoaiPhong.Text = dataTable.Rows[0]["Loai_Phong"].ToString();
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

        private void dtgListRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgListRoom.Rows[e.RowIndex];

                tbIDRoom.Text = selectedRow.Cells["Ma_Phong"].Value.ToString();
                tbNameRoom.Text = selectedRow.Cells["Ten_Phong"].Value.ToString();
                cbLoaiPhong.Text = selectedRow.Cells["Loai_Phong"].Value.ToString();
                tbPrice.Text = selectedRow.Cells["Gia_Phong"].Value.ToString();
                cbTrangThai.Text = selectedRow.Cells["Trang_Thai"].Value.ToString();
                tbPeople.Text = selectedRow.Cells["So_Nguoi"].Value.ToString();
            }
        }
    }
}
