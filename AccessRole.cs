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
    public partial class AccessRole : Form
    {
        public AccessRole()
        {
            InitializeComponent();
        }

        private void btnLTR_Click(object sender, EventArgs e)
        {
            lst2.Items.Add(lst1.SelectedItems);
        }

        private void btnLTRAll_Click(object sender, EventArgs e)
        {
            for (int i = lst1.Items.Count - 1; i >= 0; i--)
            {
                lst2.Items.Add(lst1.Items[i]);
            }
        }

        private void btnRTL_Click(object sender, EventArgs e)
        {
            lst1.Items.Add(lst2.SelectedItems);
        }

        private void btnRTLAll_Click(object sender, EventArgs e)
        {
            for (int i = lst2.Items.Count - 1; i >= 0; i--)
            {
                lst1.Items.Add(lst2.Items[i]);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
