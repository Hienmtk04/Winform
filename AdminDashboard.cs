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
    public partial class AdminDashboard : UserControl
    {

        private string connectionString = "Data Source=HIENMTK-PC\\SQLEXPRESS;Initial Catalog=Winform_HotelManage;Integrated Security=true;TrustServerCertificate=True";
        private int selectedRowId = -1;
        public AdminDashboard()
        {
            InitializeComponent();
            LoadRoom();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand allcommand = new SqlCommand("SELECT * FROM PHONG", connection);

                    SqlDataAdapter adapter1 = new SqlDataAdapter(allcommand);
                    DataTable dataTable1 = new DataTable();

                    adapter1.Fill(dataTable1);

                    int all = dataTable1.Rows.Count;
                    btnTatCa.Text = "Tất cả ( " + all + " )";

                    SqlCommand command = new SqlCommand("SELECT * FROM PHONG WHERE Trang_Thai = 'Còn phòng' ", connection);

                    SqlDataAdapter adapter2 = new SqlDataAdapter(command);
                    DataTable dataTable2 = new DataTable();

                    adapter2.Fill(dataTable2);

                    int trong = dataTable2.Rows.Count;
                    btnTrong.Text = "Trống ( " + trong + " )";

                    SqlCommand commandNP = new SqlCommand("SELECT * FROM NHANPHONG ", connection);

                    SqlDataAdapter adapter3 = new SqlDataAdapter(commandNP);
                    DataTable dataTable3 = new DataTable();

                    adapter3.Fill(dataTable3);

                    int NP = dataTable3.Rows.Count;
                    btnNP.Text = "Nhận phòng ( " + NP + " )";

                    SqlCommand commandDP = new SqlCommand("SELECT * FROM DATPHONG ", connection);

                    SqlDataAdapter adapterDP = new SqlDataAdapter(commandDP);
                    DataTable dataTableDP = new DataTable();

                    adapterDP.Fill(dataTableDP);

                    int DP = dataTableDP.Rows.Count;
                    btnDP.Text = "Đặt phòng ( " + DP + " )";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void LoadRoom()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT p.Ma_Phong, p.Trang_Thai, lp.Ten_LoaiPhong, " +
                                   "np.Ten_Khach_Hang, np.Ngay_Nhan, np.Ngay_Tra " +
                                   "FROM PHONG p " +
                                   "JOIN LOAIPHONG lp ON p.Loai_Phong = lp.ID " +
                                   "LEFT JOIN NHANPHONG np ON p.Ma_Phong = np.Ma_Phong;";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    panelRooms.Controls.Clear();

                    int panelsPerRow = 6; // Number of panels per row
                    int panelWidth = 160; // Width of each room panel
                    int panelHeight = 120; // Height of each room panel
                    int spacing = 15; // Spacing between panels

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        DataRow row = dataTable.Rows[i];
                        string roomStatus = row["Trang_Thai"].ToString();
                        bool isOccupied = roomStatus == "Có khách";

                        // Set background color based on room status
                        Color panelColor = isOccupied ? Color.Gold : Color.LightSeaGreen;

                        Panel roomPanel = new Panel
                        {
                            Size = new Size(panelWidth, panelHeight),
                            Margin = new Padding(spacing),
                            BackColor = panelColor,
                            Tag = row["Ma_Phong"]
                        };

                        // Room Type Label
                        Label lbRoomType = new Label
                        {
                            Text = row["Ten_LoaiPhong"] != DBNull.Value ? row["Ten_LoaiPhong"].ToString() : "Unknown",
                            AutoSize = true,
                            Font = new Font("Arial", 8, FontStyle.Regular)
                        };

                        roomPanel.Controls.Add(lbRoomType);
                        lbRoomType.Location = new Point((roomPanel.Width - lbRoomType.Width) / 2, 5); // Centered horizontally

                        // Room Number Label
                        Label lbRoomNumber = new Label
                        {
                            Text = row["Ma_Phong"].ToString(),
                            AutoSize = true,
                            Font = new Font("Arial", 12, FontStyle.Bold),
                            Location = new Point(50, 25) // Positioned below the room type
                        };

                        PictureBox picIcon = new PictureBox
                        {
                            Image = isOccupied ? Image.FromFile(@"D:\winform\DoAn\HotelManage\HotelManage\Assets\lock.gif") : Image.FromFile(@"D:\winform\DoAn\HotelManage\HotelManage\Assets\key.gif"),
                            SizeMode = PictureBoxSizeMode.Zoom,
                            Size = new Size(30, 30),
                            Location = new Point(60, 45)
                        };

                        roomPanel.Controls.Add(lbRoomNumber);
                        roomPanel.Controls.Add(picIcon);

                        if (isOccupied)
                        {
                            Label lbCustomerName = new Label
                            {
                                Text = row["Ten_Khach_Hang"] != DBNull.Value ? row["Ten_Khach_Hang"].ToString() : "N/A",
                                AutoSize = true,
                                Font = new Font("Arial", 8, FontStyle.Regular),
                                Location = new Point(35, 75) // Adjusted position for customer name
                            };

                            Label lbDates = new Label
                            {
                                Text = (row["Ngay_Nhan"] != DBNull.Value && row["Ngay_Tra"] != DBNull.Value)
                                    ? $"{Convert.ToDateTime(row["Ngay_Nhan"]).ToString("dd/MM")} - {Convert.ToDateTime(row["Ngay_Tra"]).ToString("dd/MM/yyyy")}"
                                    : "N/A",
                                AutoSize = true,
                                Font = new Font("Arial", 8, FontStyle.Regular),
                                Location = new Point(10, 90) // Adjusted position for dates
                            };

                            roomPanel.Controls.Add(lbCustomerName);
                            roomPanel.Controls.Add(lbDates);
                        }
                        else
                        {
                            Label lbStatus = new Label
                            {
                                Text = "Trống",
                                AutoSize = true,
                                Font = new Font("Arial", 10, FontStyle.Bold),
                                Location = new Point(45, 75) // Positioned for empty room status
                            };

                            roomPanel.Controls.Add(lbStatus);
                        }

                        // Calculate the position for each panel
                        int xPosition = (i % panelsPerRow) * (panelWidth + spacing);
                        int yPosition = (i / panelsPerRow) * (panelHeight + spacing);

                        roomPanel.Location = new Point(xPosition, yPosition);
                        panelRooms.Controls.Add(roomPanel);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
