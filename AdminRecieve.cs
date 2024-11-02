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
    public partial class AdminRecieve : UserControl
    {


        private string connectionString = "Data Source=HIENMTK-PC\\SQLEXPRESS;Initial Catalog=Winform_HotelManage;Integrated Security=true;TrustServerCertificate=True";
        private int selectedRowId = -1;
        private string bookingPrefix = "NP";
        public AdminRecieve()
        {
            InitializeComponent();
            TypeRoom();
            LoadReceivegData();
        }

        private void TypeRoom()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM LOAIPHONG"; // Adjust if you want to filter by a specific ID

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // No need to add the parameter if you're not filtering by it
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);

                        cbLoaiPhong.DataSource = dataTable;
                        cbLoaiPhong.DisplayMember = "Ten_LoaiPhong";
                        cbLoaiPhong.ValueMember = "ID";
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void LoadTypeRoom()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM PHONG WHERE Loai_Phong = @Loai_Phong AND Trang_Thai = 'Còn phòng'", connection);
                    command.Parameters.Add(new SqlParameter("@Loai_Phong", cbLoaiPhong.SelectedValue));

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    cbTenPhong.DataSource = dataTable;
                    cbTenPhong.DisplayMember = "Ten_Phong";
                    cbTenPhong.ValueMember = "Ma_Phong";
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void LoadReceivegData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM NHANPHONG np JOIN LOAIPHONG lp ON np.Loai_Phong = lp.ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dtgNhanPhong.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private string GenerateBookingCode()
        {
            int newBookingId = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Fetch the latest ID from the DATPHONG table.
                    string query = "SELECT IDENT_CURRENT('NHANPHONG') + 1";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            newBookingId = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }

            // Generate booking code using the prefix NP and the new ID
            return $"NP{newBookingId}";
        }


        private void cusButton3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn nhận phòng không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                string newBookingCode = GenerateBookingCode();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Start a transaction
                        using (SqlTransaction transaction = connection.BeginTransaction())
                        {
                            // Insert the booking data into NHANPHONG
                            string insertQuery = "INSERT INTO NHANPHONG (Ma_Nhan_Phong, Ten_Khach_Hang, So_CCCD, Loai_Phong, Ngay_Nhan, Ngay_Tra, Ma_Phong) " +
                                "VALUES (@Ma_Nhan_Phong, @Ten_Khach_Hang, @So_CCCD, @Loai_Phong, @Ngay_Nhan, @Ngay_Tra, @Ma_Phong)";

                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection, transaction))
                            {
                                insertCommand.Parameters.AddWithValue("@Ma_Nhan_Phong", newBookingCode);
                                insertCommand.Parameters.AddWithValue("@Ten_Khach_Hang", tbTenKH.Text);
                                insertCommand.Parameters.AddWithValue("@So_CCCD", tbCCCD.Text);
                                insertCommand.Parameters.AddWithValue("@Loai_Phong", cbLoaiPhong.SelectedValue);
                                insertCommand.Parameters.AddWithValue("@Ngay_Nhan", dtNgayNhan.Value);
                                insertCommand.Parameters.AddWithValue("@Ngay_Tra", dtNgayTra.Value);
                                insertCommand.Parameters.AddWithValue("@Ma_Phong", cbTenPhong.SelectedValue);

                                insertCommand.ExecuteNonQuery();
                            }

                            // Update the room status in PHONG to indicate it is occupied
                            string updateQuery = "UPDATE PHONG SET Trang_Thai = 'Có khách' WHERE Ma_Phong = @Ma_Phong";

                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection, transaction))
                            {
                                updateCommand.Parameters.AddWithValue("@Ma_Phong", cbTenPhong.SelectedValue);
                                updateCommand.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }

                        MessageBox.Show($"Nhận phòng thành công! Mã nhận phòng: {newBookingCode}");
                        LoadReceivegData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn đã hủy thao tác nhận phòng.");
            }
        }

        private void btnShowDetail_Click(object sender, EventArgs e)
        {
            ShowDetail showDetail = new ShowDetail();
            showDetail.ShowDialog();
        }

        private void cusButton1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM DATPHONG dp JOIN LOAIPHONG lp ON dp.Loai_Phong = lp.ID WHERE Ma_Dat_Phong = @MaDP", connection);

                    command.Parameters.Add(new SqlParameter("@MaDP", tbMaDatPhong.Text));

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        // Display the data in corresponding textboxes
                        tbTenKH.Text = dataTable.Rows[0]["Ten_Khach_Hang"].ToString();
                        tbCCCD.Text = dataTable.Rows[0]["So_CCCD"].ToString();
                        tbTenLoaiPhong.Text = dataTable.Rows[0]["Ten_LoaiPhong"].ToString();
                        //tbTenPhong.Text = dataTable.Rows[0]["So_dien_thoai"].ToString();
                        dtNgayNhan.Text = dataTable.Rows[0]["Ngay_Nhan"].ToString();
                        dtNgayTra.Text = dataTable.Rows[0]["Ngay_Tra"].ToString();
                        //tbSoNguoi.Text = dataTable.Rows[0]["Gioi_tinh"].ToString();
                        //tbGia.Text = dataTable.Rows[0]["Quoc_tich"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng này.");
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

        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTypeRoom();
        }

        private void cbTenPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTenPhong.SelectedItem != null)
            {
                DataRowView selectedRow = cbTenPhong.SelectedItem as DataRowView;
                if (selectedRow != null)
                {
                    tbTenPhong.Text = selectedRow["Ten_Phong"].ToString();
                    tbGia.Text = selectedRow["Gia_Phong"].ToString();
                    tbSoNguoi.Text = selectedRow["So_Nguoi"].ToString();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddCustomer add = new AddCustomer();
            add.ShowDialog();
        }

        public void SetBookingDetails(string bookingCode, string customerName, string idNumber, string roomType, DateTime checkInDate, DateTime checkOutDate)
        {
            tbMaDatPhong.Text = bookingCode;
            tbTenKH.Text = customerName;
            tbCCCD.Text = idNumber;
            tbTenLoaiPhong.Text = roomType;
            dtNgayNhan.Value = checkInDate;
            dtNgayTra.Value = checkOutDate;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void dtgNhanPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
