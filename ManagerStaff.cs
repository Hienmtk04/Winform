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
    public partial class ManagerStaff : UserControl
    {
        public ManagerStaff()
        {
            InitializeComponent();
        }

        private void btnAccessRole_Click(object sender, EventArgs e)
        {
            AccessRole accessRole = new AccessRole();
            accessRole.Show();
        }
    }
}
