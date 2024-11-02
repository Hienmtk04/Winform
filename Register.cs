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

    public partial class Register : Form
    {
        private string connectionString = "Data Source=HIENMTK-PC\\SQLEXPRESS;Initial Catalog=Winform_HotelManage;Integrated Security=true;TrustServerCertificate=True";

        public Register()
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


        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Check for duplicate username
                    SqlCommand checkUsernameCommand = new SqlCommand("SELECT COUNT(*) FROM NHANVIEN WHERE Ten_dang_nhap = @Ten_dang_nhap", connection);
                    checkUsernameCommand.Parameters.Add(new SqlParameter("@Ten_dang_nhap", tbTenDN.Text));
                    int usernameExists = (int)checkUsernameCommand.ExecuteScalar();

                    if (usernameExists > 0)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên đăng nhập khác.");
                        return;
                    }

                    // Check for duplicate ID card number
                    SqlCommand checkCCCDCommand = new SqlCommand("SELECT COUNT(*) FROM NHANVIEN WHERE So_cccd = @So_cccd", connection);
                    checkCCCDCommand.Parameters.Add(new SqlParameter("@So_cccd", tbCCCD.Text));
                    int cccdExists = (int)checkCCCDCommand.ExecuteScalar();

                    if (cccdExists > 0)
                    {
                        MessageBox.Show("Số CCCD đã tồn tại. Vui lòng nhập số CCCD khác.");
                        return;
                    }

                    // Proceed with registration if no duplicates are found
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

                    MessageBox.Show("Đăng ký thành công! ");

                    StaffAdded?.Invoke();

                    Login login = new Login();
                    login.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbTenDN_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {
            tbMat_Khau.PasswordChar = '*';
        }
    }
}
