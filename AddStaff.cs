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
using System.Security.Cryptography;


namespace HotelManage
{
    public partial class AddStaff : Form
    {

        private string connectionString = "Data Source=HIENMTK-PC\\SQLEXPRESS;Initial Catalog=Winform_HotelManage;Integrated Security=true;TrustServerCertificate=True";

        public AddStaff()
        {
            InitializeComponent();
            TypeStaff();
        }

        public event Action StaffAdded;

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

                    cbLoaiNV.DataSource = dataTable;
                    cbLoaiNV.DisplayMember = "Ten_Truy_Cap";
                    cbLoaiNV.ValueMember = "ID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO NHANVIEN VALUES(@MaNV, @Ten_dang_nhap, @Mat_khau," +
                        " @TenNV, @Ngay_sinh, @Gioi_tinh, @LoaiNV, @So_cccd, @SoDT, @Dia_chi, @NgayVaoLam)", connection);

                    command.Parameters.Add(new SqlParameter("@MaNV", tbMaNV.Text));
                    command.Parameters.Add(new SqlParameter("@Ten_dang_nhap", tbTenDN.Text));

                    string password = tbMat_Khau.Text;

                    string salt = BCrypt.Net.BCrypt.GenerateSalt();

                    string hash = BCrypt.Net.BCrypt.HashPassword(password, salt);

                    command.Parameters.Add(new SqlParameter("@Mat_khau", hash));

                    command.Parameters.Add(new SqlParameter("@TenNV", tbTen_NV.Text));
                    command.Parameters.Add(new SqlParameter("@Ngay_sinh", DateTime.ParseExact(dtNgaySinh.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)));
                    command.Parameters.Add(new SqlParameter("@Gioi_tinh", cbGioiTinh.Text));
                    command.Parameters.Add(new SqlParameter("@LoaiNV", cbLoaiNV.SelectedValue));
                    command.Parameters.Add(new SqlParameter("@So_cccd", tbCCCD.Text));
                    command.Parameters.Add(new SqlParameter("@SoDT", tbSDT.Text));
                    command.Parameters.Add(new SqlParameter("@Dia_chi", tbDiaChi.Text));
                    command.Parameters.Add(new SqlParameter("@NgayVaoLam", DateTime.ParseExact(dtNgayVaoLam.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)));

                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Thêm nhân viên thành công! ");

                    StaffAdded?.Invoke();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
