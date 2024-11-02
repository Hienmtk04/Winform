using Microsoft.Data.SqlClient;
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

namespace HotelManage
{
    public partial class Bill : Form
    {

        private string connectionString = "Data Source=HIENMTK-PC\\SQLEXPRESS;Initial Catalog=Winform_HotelManage;Integrated Security=true;TrustServerCertificate=True";
        private List<Service> services;
        public Bill(string maHoaDon, string tenDichVu, decimal donGia, int soLuong, decimal thanhTien, decimal tongThanhTien,
    string maKH, string tenPhong, string maNhanPhong, string maPhong, decimal donGiaPhong,
    DateTime ngayNhan, DateTime ngayTra, decimal tienPhong, decimal phuThu, decimal thanhTienCuoi, List<Service> selectedServices)
        {
            InitializeComponent();

            lbMaHoaDon.Text = maHoaDon.ToString();
            lbNV.Text = Session.Username.ToString();
            lbPhuThu.Text = phuThu.ToString();
            Data();

            // Initialize DataGridView columns
            InitializeDataGridView();

            services = selectedServices;
            LoadServices();
        }

        private void LoadServices()
        {
            foreach (var service in services)
            {
                dtgDV.Rows.Add(service.Name, service.Price.ToString("N0") + " đ", service.Quantity, service.Total.ToString("N0") + " đ");
            }
        }

        private void InitializeDataGridView()
        {
            // Clear existing columns if needed
            dtgDV.Columns.Clear();

            // Define columns
            dtgDV.Columns.Add("ServiceName", "Service Name"); // Column for service name
            dtgDV.Columns.Add("ServicePrice", "Service Price"); // Column for service price
            dtgDV.Columns.Add("Quantity", "Quantity"); // Column for quantity
            dtgDV.Columns.Add("TotalPrice", "Total Price"); // Column for total price
        }

        public class Service
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public decimal Total { get; set; }

            public Service(string name, decimal price, int quantity, decimal total)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
                Total = total;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Data()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM HOADON hd" +
                        " JOIN KHACHHANG kh ON hd.Ma_KH = kh.MaKH " +
                        "JOIN PHONG p ON hd.Ma_Phong = p.Ma_Phong" +
                        " JOIN LOAIPHONG lp ON p.Loai_Phong = lp.ID" +
                        " JOIN NHANPHONG np ON hd.Ma_Nhan_Phong = np.Ma_Nhan_Phong " +
                        " WHERE Ma_Hoa_Don = @Ma_Hoa_Don", connection);

                    command.Parameters.Add(new SqlParameter("@Ma_Hoa_Don", lbMaHoaDon.Text));

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        lbNgayLap.Text = dataTable.Rows[0]["Ngay_Tao"].ToString();
                        lbTenKH.Text = dataTable.Rows[0]["Ten_Khach_Hang"].ToString();
                        lbCCCD.Text = dataTable.Rows[0]["So_cccd"].ToString();
                        lbSDT.Text = dataTable.Rows[0]["So_dien_thoai"].ToString();
                        lbLoaiKH.Text = dataTable.Rows[0]["Loai"].ToString();
                        lbDiaChi.Text = dataTable.Rows[0]["Dia_chi"].ToString();
                        lbQuocTich.Text = dataTable.Rows[0]["Quoc_tich"].ToString();

                        lbTenPhong.Text = dataTable.Rows[0]["Ten_Phong"].ToString();
                        lbLoaiPhong.Text = dataTable.Rows[0]["Ten_Loaiphong"].ToString();
                        lbDonGia.Text = dataTable.Rows[0]["Gia_Phong"].ToString();
                        lbNgayDen.Text = Convert.ToDateTime(dataTable.Rows[0]["Ngay_Nhan"]).ToString("dd/MM/yyyy");

                        int numberOfNights = (Convert.ToDateTime(dataTable.Rows[0]["Ngay_Tra"]) - Convert.ToDateTime(dataTable.Rows[0]["Ngay_Nhan"])).Days;

                        lbSoDem.Text = numberOfNights.ToString();
                        lbSoNguoi.Text = dataTable.Rows[0]["So_Nguoi"].ToString();

                        lbTienPhong.Text = dataTable.Rows[0]["Tien_Phong"].ToString();
                        lbTienDV.Text = dataTable.Rows[0]["Tien_DV"].ToString();
                        lbTongTien.Text = dataTable.Rows[0]["Don_Gia"].ToString();
                        lbGiamGia.Text = dataTable.Rows[0]["Giam_Gia"].ToString();
                        lbThanhTien.Text = dataTable.Rows[0]["Thanh_Tien"].ToString();


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));

            // Vẽ bitmap lên trang in
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
