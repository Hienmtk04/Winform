using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HotelManage.Bill;

namespace HotelManage
{
    public partial class UseServicePayment : UserControl
    {
        private string connectionString = "Data Source=HIENMTK-PC\\SQLEXPRESS;Initial Catalog=Winform_HotelManage;Integrated Security=true;TrustServerCertificate=True";
        private int selectedRowId = -1;
        private string bookingPrefix = "HD";


        string tenDichVu = "";
        decimal donGia = 0;
        int soLuong = 0;
        decimal thanhTien = 0;
        decimal TongThanhTien = 0;


        string MaKH = "";
        string TenPhong = "";
        string MaNhanPhong = "";
        string MaPhong = "";
        decimal DonGia = 0;
        DateTime NgayNhan = DateTime.Now;
        DateTime NgayTra = DateTime.Now;
        decimal TienPhong = 0;
        decimal PhuThu = 0;
        decimal ThanhTien = 0;



        public UseServicePayment()
        {
            InitializeComponent();
            TypeService();
            LoadRoom();
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
                    string query = "SELECT IDENT_CURRENT('HOADON') + 1";
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

                    cbLoaiDV.DataSource = dataTable;
                    cbLoaiDV.DisplayMember = "Ten_Dich_Vu";
                    cbLoaiDV.ValueMember = "ID";
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void ServiceName()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM DICHVU WHERE Loai_DV = @Loai_DV", connection);

                    command.Parameters.Add(new SqlParameter("@Loai_DV", cbLoaiDV.SelectedValue));

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    cbDichVu.DataSource = dataTable;
                    cbDichVu.DisplayMember = "Ten_DV";
                    cbDichVu.ValueMember = "Ma_DV";
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Service()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM DICHVU WHERE Ma_DV = @Ma_DV", connection);

                    command.Parameters.Add(new SqlParameter("@Ma_DV", cbDichVu.SelectedValue));

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        tbGia.Text = dataTable.Rows[0]["Gia_DV"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error: " + ex.Message);
                }
            }
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

                    dtgPhuThu.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private Panel selectedRoomPanel = null; // To keep track of the selected room

        private void LoadRoom()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM NHANPHONG np JOIN LOAIPHONG lp ON np.Loai_Phong = lp.ID JOIN PHONG p ON np.Ma_Phong = p.Ma_Phong";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    panelRoom.Controls.Clear();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        Label lbTenPhong = new Label
                        {
                            Text = row["Ten_Phong"].ToString(),
                            AutoSize = true,
                            Font = new Font("Arial", 10, FontStyle.Bold),
                            ForeColor = Color.Black
                        };

                        // Create a picture box for the room image
                        PictureBox picRoom = new PictureBox
                        {
                            Image = Image.FromFile(@"D:\winform\DoAn\HotelManage\HotelManage\Assets\notepad.png"),
                            SizeMode = PictureBoxSizeMode.Zoom,
                            Margin = new Padding(5),
                            Size = new Size(50, 50)
                        };

                        // Create a panel to hold each room's components
                        Panel roomPanel = new Panel
                        {
                            Size = new Size(100, 100),
                            Margin = new Padding(5),
                            Tag = row["Ma_Phong"]
                        };

                        string MaPhong = roomPanel.Tag.ToString();

                        int loaiPhong = Convert.ToInt32(row["Loai_Phong"]);
                        if (loaiPhong == 1)
                        {
                            roomPanel.BackColor = Color.Bisque;
                        }
                        else if (loaiPhong == 2)
                        {
                            roomPanel.BackColor = Color.BurlyWood;
                        }
                        else
                        {
                            roomPanel.BackColor = Color.DarkOrange;
                        }

                        roomPanel.Controls.Add(lbTenPhong);
                        roomPanel.Controls.Add(picRoom);

                        lbTenPhong.Location = new Point(10, 10);
                        picRoom.Location = new Point(10, lbTenPhong.Bottom + 5);

                        // Add click event for room selection
                        roomPanel.Click += (s, e) => RoomPanel_Click(roomPanel, MaPhong);

                        // Add room panel to main panelRoom
                        panelRoom.Controls.Add(roomPanel);
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Event handler for selecting a room panel
        private void RoomPanel_Click(Panel roomPanel, string MaPhong)
        {
            roomPanel.BackColor = Color.LightBlue;
            selectedRoomPanel = roomPanel;
            LoadRoomDetails(MaPhong);
            LoadCustomer();

            if (!string.IsNullOrEmpty(TenPhong) && DonGia > 0)
            {
                try
                {

                    dtgHoaDon.Rows.Add(
                        TenPhong,
                        DonGia.ToString("N0") + " đ",
                        NgayNhan.ToString("dd/MM/yyyy"),
                        NgayTra.ToString("dd/MM/yyyy"),
                        TienPhong.ToString("N0") + " đ",
                        PhuThu.ToString("N0") + " đ",
                        ThanhTien.ToString("N0") + " đ"
                    );
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Room details could not be loaded. Please select a different room.");
            }
        }


        private void btnThemDV_Click(object sender, EventArgs e)
        {
            try
            {
                tenDichVu = cbDichVu.Text;
                donGia = decimal.Parse(tbGia.Text);
                soLuong = int.Parse(nbSoLuong.Text);
                thanhTien = donGia * soLuong;

                TongThanhTien += thanhTien;


                int stt = dtgHoadonDV.Rows.Count + 1;

                dtgHoadonDV.Rows.Add(stt, tenDichVu, donGia.ToString("N0") + " đ", soLuong, thanhTien.ToString("N0") + " đ");

                tbTongTien.Text = (ThanhTien + TongThanhTien).ToString("N0") + " đ";
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cbLoaiDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiceName();
        }

        private void cbDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Service();
        }

        private void LoadRoomDetails(string roomId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM PHONG p JOIN NHANPHONG np ON p.Ma_Phong = np.Ma_Phong WHERE p.Ma_Phong = @Ma_Phong", connection);
                    command.Parameters.Add(new SqlParameter("@Ma_Phong", roomId));

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        MaNhanPhong = dataTable.Rows[0]["Ma_Nhan_Phong"].ToString();
                        MaPhong = dataTable.Rows[0]["Ma_Phong"].ToString();
                        TenPhong = dataTable.Rows[0]["Ten_Phong"].ToString();
                        DonGia = Convert.ToDecimal(dataTable.Rows[0]["Gia_Phong"]);
                        NgayNhan = Convert.ToDateTime(dataTable.Rows[0]["Ngay_Nhan"]);
                        NgayTra = Convert.ToDateTime(dataTable.Rows[0]["Ngay_Tra"]);
                        int numberOfNights = (NgayTra - NgayNhan).Days;
                        TienPhong = numberOfNights * DonGia;
                        PhuThu = 0;
                        ThanhTien = TienPhong + PhuThu;
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LoadCustomer()
        {
            MessageBox.Show("MaPhong hiện tại là: " + MaPhong); // Kiểm tra giá trị của MaPhong

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM NHANPHONG np JOIN KHACHHANG kh ON np.So_CCCD = kh.SoCCCD WHERE np.Ma_Phong = @Ma_Phong", connection);
                    command.Parameters.Add(new SqlParameter("@Ma_Phong", MaPhong));

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        MaKH = dataTable.Rows[0]["MaKH"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu cho MaPhong: " + MaPhong);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }


        private void btnThanhToan_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thanh toán cho phòng " + TenPhong + " không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                string newBookingCode = GenerateBookingCode();
                List<Service> selectedServices = new List<Service>();

                foreach (DataGridViewRow row in dtgHoadonDV.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        object serviceNameValue = row.Cells[1].Value;
                        object servicePriceValue = row.Cells[2].Value;
                        object quantityValue = row.Cells[3].Value;
                        object totalPriceValue = row.Cells[4].Value;

                        string serviceName = serviceNameValue != null ? serviceNameValue.ToString() : string.Empty;

                        decimal servicePrice = servicePriceValue != null
                            ? decimal.Parse(servicePriceValue.ToString().Replace(" đ", "").Replace(",", ""))
                            : 0;

                        int quantity = quantityValue != null
                            ? int.Parse(quantityValue.ToString())
                            : 0;

                        decimal totalPrice = totalPriceValue != null
                            ? decimal.Parse(totalPriceValue.ToString().Replace(" đ", "").Replace(",", ""))
                            : 0;

                        selectedServices.Add(new Service(serviceName, servicePrice, quantity, totalPrice));
                    }

                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Start a transaction
                        using (SqlTransaction transaction = connection.BeginTransaction())
                        {
                            // Insert the booking data into HOADON
                            string insertQuery = "INSERT INTO HOADON VALUES(@Ma_Hoa_Don, @Ma_Phong, @Ma_Nhan_Phong, @Ma_KH, @Nhan_Vien_Tao, @Ngay_Tao, " +
                                                 "@Tien_Phong, @Tien_DV, @Don_Gia, @Giam_Gia, @Thanh_Tien)";

                            decimal discountPercentage = decimal.Parse(nbGiamGia.Text);
                            decimal totalAmount = ThanhTien + TongThanhTien; // Calculate the total before discount
                            decimal finalAmount = totalAmount * (1 - discountPercentage / 100); // Apply the discount

                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection, transaction))
                            {
                                insertCommand.Parameters.AddWithValue("@Ma_Hoa_Don", newBookingCode);
                                insertCommand.Parameters.AddWithValue("@Ma_Phong", MaPhong);
                                insertCommand.Parameters.AddWithValue("@Ma_Nhan_Phong", MaNhanPhong);
                                insertCommand.Parameters.AddWithValue("@Ma_KH", MaKH);
                                insertCommand.Parameters.AddWithValue("@Nhan_Vien_Tao", Session.Username);
                                insertCommand.Parameters.AddWithValue("@Ngay_Tao", DateTime.Now);
                                insertCommand.Parameters.AddWithValue("@Tien_Phong", ThanhTien);
                                insertCommand.Parameters.AddWithValue("@Tien_DV", TongThanhTien);
                                insertCommand.Parameters.AddWithValue("@Don_Gia", totalAmount);
                                insertCommand.Parameters.AddWithValue("@Giam_Gia", discountPercentage);
                                insertCommand.Parameters.AddWithValue("@Thanh_Tien", finalAmount);

                                insertCommand.ExecuteNonQuery();
                            }

                            // Commit the transaction
                            transaction.Commit();
                        }

                        MessageBox.Show("Thanh toán thành công!");
                      
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
                Bill formBill = new Bill(newBookingCode, tenDichVu, donGia, soLuong, thanhTien, TongThanhTien, MaKH, TenPhong, MaNhanPhong, MaPhong, DonGia, NgayNhan, NgayTra, TienPhong, PhuThu, ThanhTien, selectedServices);
                formBill.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn đã hủy thao tác thanh toán.");
            }
        }
    }
}
