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
    public partial class SetPassAgain : Form
    {

        private int staffId;
        private string username;
        private string connectionString = "Data Source=HIENMTK-PC\\SQLEXPRESS;Initial Catalog=Winform_HotelManage;Integrated Security=true;TrustServerCertificate=True";
        public SetPassAgain(int selectedStaffId, string selectedUsername)
        {
            InitializeComponent();
            staffId = selectedStaffId;
            username = selectedUsername;
            tbTenDN.Text = username;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateOldPassword(staffId, tbMatKhauCu.Text))
            {
                if (tbMatKhauMoi.Text != null)
                {
                    UpdatePassword(staffId, tbMatKhauMoi.Text);
                    MessageBox.Show("Đặt lại mật khẩu thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu mới.");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng.");
            }
        }

        private bool ValidateOldPassword(int staffId, string oldPassword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT Mat_khau FROM NHANVIEN WHERE MaNV = @MaNV", connection);
                    command.Parameters.Add(new SqlParameter("@MaNV", staffId));

                    string storedHash = (string)command.ExecuteScalar();

                    // Validate the provided password against the stored hash
                    return BCrypt.Net.BCrypt.Verify(oldPassword, storedHash);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                    return false;
                }
            }
        }

        private void UpdatePassword(int staffId, string newPassword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Hash the new password before storing it
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);

                    SqlCommand command = new SqlCommand("UPDATE NHANVIEN SET Mat_khau = @Password WHERE MaNV = @MaNV", connection);
                    command.Parameters.Add(new SqlParameter("@MaNV", staffId));
                    command.Parameters.Add(new SqlParameter("@Password", hashedPassword));

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
