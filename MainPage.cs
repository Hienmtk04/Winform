using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManage
{
    public partial class MainPage : Form
    {

        private string _username;
        public MainPage(string username)
        {
            InitializeComponent();
            timer1.Interval = 1000; // 1 second interval
            timer1.Start();

            // Assign the Tick event handler to the timer
            timer1.Tick += timer1_Tick;
        }
        public void ShowAdminRecieve(string bookingCode, string customerName, string idNumber, string roomType, int maxOccupancy, decimal price, DateTime checkInDate, DateTime checkOutDate)
        {
            AdminRecieve adminRecieve = new AdminRecieve();

            // Set the booking and room details in AdminRecieve
            adminRecieve.SetBookingDetails(bookingCode, customerName, idNumber, roomType, checkInDate, checkOutDate);

            // Show AdminRecieve in the designated panel (e.g., panel3)
            panel3.Controls.Clear();
            panel3.Controls.Add(adminRecieve);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    DateTime dt = DateTime.Now;
        //    txtTime.Text = dt.ToString("Hôm nay là ddd, dd/MM/yyyy, hh:mm:ss");
        //}
        private void txtTime_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            txtTime.Text = dt.ToString("Hôm nay là ddd, dd/MM/yyyy, hh:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            // Display the date and time in the textBox1
            txtTime.Text = dt.ToString("ddd, dd/MM/yyyy, hh:mm:ss");
        }

        private void btnRecieve_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            AdminRecieve myUserControl = new AdminRecieve();

            myUserControl.Dock = DockStyle.Fill;
            panel3.Controls.Add(myUserControl);
        }
        public void ShowAdminRecieve(string bookingCode, string customerName, string idNumber, string roomType, DateTime checkInDate, DateTime checkOutDate)
        {
            AdminRecieve adminRecieve = new AdminRecieve();

            adminRecieve.SetBookingDetails(bookingCode, customerName, idNumber, roomType, checkInDate, checkOutDate);

            // Show AdminRecieve in panel3 (or whichever panel you use)
            panel3.Controls.Clear();
            panel3.Controls.Add(adminRecieve);
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();

            AdminDashboard myUserControl = new AdminDashboard();

            myUserControl.Dock = DockStyle.Fill;
            panel3.Controls.Add(myUserControl);

        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();

            AdminBooking myUserControl = new AdminBooking();

            myUserControl.Dock = DockStyle.Fill;
            panel3.Controls.Add(myUserControl);
        }

        private void btnRoomMng_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();

            ManagerRooms myUserControl = new ManagerRooms();

            myUserControl.Dock = DockStyle.Fill;
            panel3.Controls.Add(myUserControl);
        }

        private void btnBillMng_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();

            ManagerBill myUserControl = new ManagerBill();

            myUserControl.Dock = DockStyle.Fill;
            panel3.Controls.Add(myUserControl);
        }

        private void btnServiceMng_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();

            managerService myUserControl = new managerService();

            myUserControl.Dock = DockStyle.Fill;
            panel3.Controls.Add(myUserControl);
        }

        private void btnUse_Payment_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();

            UseServicePayment myUserControl = new UseServicePayment();

            myUserControl.Dock = DockStyle.Fill;
            panel3.Controls.Add(myUserControl);
        }

        private void btnStaffMng_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();

            ManagerStaff myUserControl = new ManagerStaff();

            myUserControl.Dock = DockStyle.Fill;
            panel3.Controls.Add(myUserControl);
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {

        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();

            Rules myUserControl = new Rules();

            myUserControl.Dock = DockStyle.Fill;
            panel3.Controls.Add(myUserControl);
        }

        private void btnCustomerMng_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();

            ManagerCustomer myUserControl = new ManagerCustomer();

            myUserControl.Dock = DockStyle.Fill;
            panel3.Controls.Add(myUserControl);
        }
    }
}
