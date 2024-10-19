namespace HotelManage
{
    public partial class Login : Form
    {
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
            if (tbUsername.Text == "" || tbPass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (tbUsername.Text == "hienmtk@gmail.com" && tbPass.Text == "123456789")
            {
                MainPage mainPage = new MainPage();
                mainPage.Show();
            }
            else
            {
                MessageBox.Show("Tên người dùng hoặc mật khẩu không đúng. Vui lòng thử lại!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            tbPass.PasswordChar = '*';
        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
