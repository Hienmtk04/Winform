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
    public partial class Rules : UserControl
    {
        private string connectionString = "Data Source=HIENMTK-PC\\SQLEXPRESS;Initial Catalog=Winform_HotelManage;Integrated Security=true;TrustServerCertificate=True";

        public Rules()
        {
            InitializeComponent();
            Rule();
        }

        private void Rule()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM QUYDINH", connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    dtgQuyDinh.DataSource = dataTable;
                    cbTen.DataSource = dataTable;
                    cbTen.DisplayMember = "Ten";
                    cbTen.ValueMember = "ID";
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
                    SqlCommand command = new SqlCommand("INSERT INTO QUYDINH VALUES(@Ten, @GiaTri, @MieuTa)", connection);

                    command.Parameters.Add(new SqlParameter("@Ten", cbTen.Text));
                    command.Parameters.Add(new SqlParameter("@GiaTri", tbGiaTri.Text));
                    command.Parameters.Add(new SqlParameter("@MieuTa", tbMieuTa.Text));

                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Thêm quy định thành công! ");

                    Rule();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE QUYDINH SET GiaTri =  @GiaTri, MieuTa = @MieuTa, NgayCapNhat = @NgayCapNhat WHERE  ID = @ID ", connection);

                    command.Parameters.Add(new SqlParameter("@ID", cbTen.SelectedValue));
                    command.Parameters.Add(new SqlParameter("@GiaTri", tbGiaTri.Text));
                    command.Parameters.Add(new SqlParameter("@MieuTa", tbMieuTa.Text));
                    command.Parameters.Add(new SqlParameter("@NgayCapNhat", DateTime.Now));


                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Cập nhật dịch vụ thành công! ");

                    Rule();

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
                    SqlCommand command = new SqlCommand("SELECT * FROM QUYDINH WHERE Ten LIKE @Ten", connection);

                    command.Parameters.Add(new SqlParameter("@Ten", tbSearch.Text));

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    Rule();

                    if (dataTable.Rows.Count > 0)
                    {
                        cbTen.Text = dataTable.Rows[0]["Ten"].ToString();
                        tbGiaTri.Text = dataTable.Rows[0]["GiaTri"].ToString();
                        tbMieuTa.Text = dataTable.Rows[0]["MieuTa"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không cóquy định nào với tên bạn tìm kiếm.");
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                connection.Close();
            }
        }
    }
}
