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
        public AdminRecieve()
        {
            InitializeComponent();
        }

        private void cusButton3_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn nhận phòng không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                MessageBox.Show("Nhận phòng thành công.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnShowDetail_Click(object sender, EventArgs e)
        {
            ShowDetail showDetail = new ShowDetail();
            showDetail.ShowDialog();
        }

    }
}
