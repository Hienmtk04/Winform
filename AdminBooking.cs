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
        public AdminBooking()
        {
            InitializeComponent();
        }

        private void cbRecieve_CheckedChanged(object sender, EventArgs e)
        {
            MainPage mainForm = this.FindForm() as MainPage;

            if (mainForm != null && cbRecieve.Checked)
            {
                // Call the method to show AdminRecieve in panel3
                mainForm.ShowAdminRecieve();
            }
        }
    }
}
