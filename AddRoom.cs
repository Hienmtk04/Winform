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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManage
{
    public partial class AddRoom : Form
    {

        private string connectionString = "Data Source=HIENMTK-PC\\SQLEXPRESS;Initial Catalog=Winform_HotelManage;Integrated Security=true;TrustServerCertificate=True";
        List<Status> lstStatus;


        public AddRoom()
        {
            InitializeComponent();
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
        public event Action RoomAdded;
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO PHONG VALUES(@Ma_Phong, @Ten_Phong, @Loai_Phong, @Gia_Phong, @Trang_Thai, @So_Nguoi)", connection);

                    command.Parameters.Add(new SqlParameter("@Ma_Phong", tbMaPhong.Text));
                    command.Parameters.Add(new SqlParameter("@Ten_Phong", tbTenPhong.Text));
                    command.Parameters.Add(new SqlParameter("@Loai_Phong", cbLoaiPhong.SelectedValue));
                    command.Parameters.Add(new SqlParameter("@Gia_Phong", tbGiaPhong.Text));
                    command.Parameters.Add(new SqlParameter("@Trang_Thai", cbTrangThai.Text));
                    command.Parameters.Add(new SqlParameter("@So_Nguoi", tbSoNguoi.Text));

                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Thêm phòng thành công! ");

                     RoomAdded?.Invoke();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
            TypeRoom();

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
    
    }
}
