using Microsoft.Data.SqlClient;

namespace HotelManage
{
    public partial class Login : Form
    {

        private string connectionString = "Data Source=HIENMTK-PC\\SQLEXPRESS;Initial Catalog=Winform_HotelManage;Integrated Security=true;TrustServerCertificate=True";

        public Login()
        {
            InitializeComponent();
        }

        private void Login1(object sender, EventArgs e)
        {
            tbUsername.Left = (this.ClientSize.Width - tbUsername.Width) / 2;


        }

        private void Exit_Click_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            tbPass.PasswordChar = cbShowPass.Checked ? '\0' : '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPass.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT Mat_Khau FROM NHANVIEN WHERE Ten_dang_nhap = @Ten_dang_nhap", connection);
                command.Parameters.AddWithValue("@Ten_dang_nhap", username);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string hashedPassword = reader.GetString(0);

                    bool passwordMatch = BCrypt.Net.BCrypt.Verify(password, hashedPassword);

                    if (passwordMatch)
                    {
                        MessageBox.Show("Đăng nhập thành công!");
                        Session.Username = username;
                        MainPage frm = new MainPage(username);
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sai mật khẩu.");
                    }
                }
                else
                {
                    MessageBox.Show("Nhân viên không tồn tại.");
                }

                reader.Close();
                connection.Close();
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            tbPass.PasswordChar = '*';
        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register rgt = new Register();
            rgt.Show();
        }
    }
}
