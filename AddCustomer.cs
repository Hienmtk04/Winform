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
    public partial class AddCustomer : Form
    {

        private string connectionString = "Data Source=HIENMTK-PC\\SQLEXPRESS;Initial Catalog=Winform_HotelManage;Integrated Security=true;TrustServerCertificate=True";

        public AddCustomer()
        {
            InitializeComponent();
        }
        public event Action CustomerAdded;

        private void AddCustomer_Load(object sender, EventArgs e)
        {
       
        }

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
                    SqlCommand command = new SqlCommand("INSERT INTO KHACHHANG VALUES(@MAKH, @TenKH, @SoCCCD, @Loai, @Ngay_sinh, @Gioi_tinh, @SoDT, @Dia_chi, @Quoc_tich)", connection);

                    command.Parameters.Add(new SqlParameter("@MAKH", tbMaKH.Text));
                    command.Parameters.Add(new SqlParameter("@TenKH", tbTen_KH.Text));
                    command.Parameters.Add(new SqlParameter("@SoCCCD", tbCCCD.Text));
                    command.Parameters.Add(new SqlParameter("@Loai", cbLoai_KH.Text));
                    command.Parameters.Add(new SqlParameter("@Ngay_sinh", DateTime.ParseExact(dtNgay_Sinh.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)));
                    command.Parameters.Add(new SqlParameter("@Gioi_tinh", cbGioi_Tinh.Text));
                    command.Parameters.Add(new SqlParameter("@SoDT", tbSDT.Text));
                    command.Parameters.Add(new SqlParameter("@Dia_chi", tbDia_Chi.Text));
                    command.Parameters.Add(new SqlParameter("@Quoc_tich", tbQuoc_Tich.Text));

                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Thêm khách hàng thành công! ");

                    CustomerAdded?.Invoke();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
