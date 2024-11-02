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
    public partial class AdminBooking : UserControl
    {

        private string connectionString = "Data Source=HIENMTK-PC\\SQLEXPRESS;Initial Catalog=Winform_HotelManage;Integrated Security=true;TrustServerCertificate=True";
        private int selectedRowId = -1;
        private string bookingPrefix = "DP";

        public AdminBooking()
        {
            InitializeComponent();
            dtNgayNhan.ValueChanged += DatePicker_ValueChanged;
            dtNgayTra.ValueChanged += DatePicker_ValueChanged;
            LoadBookingData();
            TypeRoom();
            cbLoaiPhong.SelectedIndexChanged += cbLoaiPhong_SelectedIndexChanged;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void LoadBookingData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM DATPHONG dp JOIN LOAIPHONG lp ON dp.Loai_Phong = lp.ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Lỗi: " + ex.Message);
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
                    string query = "SELECT IDENT_CURRENT('DATPHONG') + 1";
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
                    //MessageBox.Show("Lỗi: " + ex.Message);
                }
            }

            // Generate booking code using the prefix NP and the new ID
            return $"NP{newBookingId}";
        }



        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            Time(); // Gọi hàm tính số đêm khi chọn ngày
        }



        private void cbRecieve_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRecieve.Checked)
            {
                MainPage mainForm = this.FindForm() as MainPage;
                if (mainForm != null)
                {
                    // Collect booking details
                    string bookingCode = tbMaLoaiPhong.Text;
                    string customerName = tbTenKH.Text;
                    string idNumber = tbCCCD.Text;
                    string roomType = cbLoaiPhong.Text;
                    DateTime checkInDate = dtNgayNhan.Value;
                    DateTime checkOutDate = dtNgayTra.Value;

                    mainForm.ShowAdminRecieve(bookingCode, customerName, idNumber, roomType, checkInDate, checkOutDate);
                }
            }
        }

        private void Time()
        {
            DateTime checkInTime = dtNgayNhan.Value;
            DateTime checkOutTime = dtNgayTra.Value;

            int numberOfDays = 0;

            if (checkOutTime >= checkInTime && checkOutTime < checkInTime.AddDays(1))
            {
                numberOfDays = 1;
            }
            else if (checkOutTime >= checkInTime.AddDays(1))
            {
                numberOfDays = (int)(checkOutTime - checkInTime).TotalDays;
            }

            tbSoDem.Text = numberOfDays.ToString();
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
                    //MessageBox.Show("Lỗi: " + ex.Message);
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
                    SqlCommand command = new SqlCommand("SELECT * FROM KHACHHANG WHERE SoCCCD = @CCCD", connection);

                    command.Parameters.Add(new SqlParameter("@CCCD", tbSearch.Text));

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        // Display the data in corresponding textboxes
                        tbTenKH.Text = dataTable.Rows[0]["TenKH"].ToString();
                        tbCCCD.Text = dataTable.Rows[0]["SoCCCD"].ToString();
                        cbLoaiKH.Text = dataTable.Rows[0]["Loai"].ToString();
                        tbSDT.Text = dataTable.Rows[0]["So_dien_thoai"].ToString();
                        dtNgay_Sinh.Text = dataTable.Rows[0]["Ngay_sinh"].ToString();
                        tbDiaChi.Text = dataTable.Rows[0]["Dia_chi"].ToString();
                        cbGioiTinh.Text = dataTable.Rows[0]["Gioi_tinh"].ToString();
                        tbQuocTich.Text = dataTable.Rows[0]["Quoc_tich"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng này.");
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Lỗi: " + ex.Message);
                }
                connection.Close();
            }
        }

        private void dtNgayTra_ValueChanged(object sender, EventArgs e)
        {
            Time();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            AddCustomer add = new AddCustomer();
            add.ShowDialog();

        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn đặt phòng không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                string newBookingCode = GenerateBookingCode();

                // Lưu mã và thông tin vào cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO DATPHONG (Ma_Dat_Phong, Ten_Khach_Hang, So_CCCD, Loai_Phong, Ngay_Nhan, Ngay_Tra) " +
                            "VALUES (@Ma_Dat_Phong, @Ten_Khach_Hang, @So_CCCD, @Loai_Phong, @Ngay_Nhan, @Ngay_Tra)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Ma_Dat_Phong", newBookingCode);
                            command.Parameters.AddWithValue("@Ten_Khach_Hang", tbTenKH.Text);
                            command.Parameters.AddWithValue("@So_CCCD", tbCCCD.Text);
                            command.Parameters.AddWithValue("@Loai_Phong", cbLoaiPhong.SelectedValue);
                            command.Parameters.AddWithValue("@Ngay_Nhan", dtNgayNhan.Value);
                            command.Parameters.AddWithValue("@Ngay_Tra", dtNgayTra.Value);

                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show($"Đặt phòng thành công! Mã đặt phòng: {newBookingCode}");
                        LoadBookingData();
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn đã hủy thao tác đặt phòng.");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {

        }

        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load();
        }

        private void Load()
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("SELECT * FROM PHONG p JOIN LOAIPHONG lp ON p.Loai_Phong = lp.ID WHERE lp.ID = @ID", connection);
                        command.Parameters.Add(new SqlParameter("@ID", cbLoaiPhong.SelectedValue));

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            // Display the data in corresponding textboxes
                            tbMaLoaiPhong.Text = dataTable.Rows[0]["Loai_Phong"].ToString();
                            tbTebLoaiPhong.Text = dataTable.Rows[0]["Ten_Loaiphong"].ToString();
                            tbSoNguoi.Text = dataTable.Rows[0]["So_Nguoi"].ToString();
                            tbGia.Text = dataTable.Rows[0]["Gia_Phong"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Không có loại phòng này." + cbLoaiPhong.SelectedValue);
                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
        }

        private void cbLoaiPhong_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                string bookingCode = row.Cells["Ma_Dat_Phong"].Value.ToString();
                string customerName = row.Cells["Ten_Khach_Hang"].Value.ToString();
                string idNumber = row.Cells["So_CCCD"].Value.ToString();
                string roomType = row.Cells["Ten_LoaiPhong"].Value.ToString();
                DateTime checkInDate = Convert.ToDateTime(row.Cells["Ngay_Nhan"].Value);
                DateTime checkOutDate = Convert.ToDateTime(row.Cells["Ngay_Tra"].Value);

                // Show AdminRecieve and pass booking details
                MainPage mainForm = this.FindForm() as MainPage;
                if (mainForm != null)
                {
                    mainForm.ShowAdminRecieve(bookingCode, customerName, idNumber, roomType, checkInDate, checkOutDate);
                    mainForm.Refresh();
                }
            }
        }
    }
}
