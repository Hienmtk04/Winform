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
    public partial class AddService : Form
    {


        private string connectionString = "Data Source=HIENMTK-PC\\SQLEXPRESS;Initial Catalog=Winform_HotelManage;Integrated Security=true;TrustServerCertificate=True";

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

                    cbLoai_DV.DataSource = dataTable;
                    cbLoai_DV.DisplayMember = "Ten_Dich_Vu";
                    cbLoai_DV.ValueMember = "ID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        public AddService()
        {
            InitializeComponent();
            TypeService();
        }
        public event Action ServiceAdded;
        private void lbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO DICHVU VALUES(@Ma_DV, @Ten_DV, @Gia_DV , @Loai_DV)", connection);

                    command.Parameters.Add(new SqlParameter("@Ma_DV", tbMa_DV.Text));
                    command.Parameters.Add(new SqlParameter("@Ten_DV", tbTen_DV.Text));
                    command.Parameters.Add(new SqlParameter("@Loai_DV", cbLoai_DV.SelectedValue));
                    command.Parameters.Add(new SqlParameter("@Gia_DV", tbGia_DV.Text));

                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Thêm dịch vụ thành công! ");

                    ServiceAdded?.Invoke();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
