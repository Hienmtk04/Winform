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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HotelManage
{
    public partial class AccessRole : Form
    {

        private string connectionString = "Data Source=HIENMTK-PC\\SQLEXPRESS;Initial Catalog=Winform_HotelManage;Integrated Security=true;TrustServerCertificate=True";
        public AccessRole()
        {
            InitializeComponent();
            TypeStaff();
            cbLoaiNV.SelectedIndexChanged += cbLoaiNV_SelectedIndexChanged;
        }
        private void TypeStaff()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT ID, Ten_Truy_Cap FROM QUYENTRUYCAP", connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    cbLoaiNV.DataSource = dataTable;
                    cbLoaiNV.DisplayMember = "Ten_Truy_Cap";
                    cbLoaiNV.ValueMember = "ID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void LoadPermissions()
        {
            lst1.Items.Clear();
            lst2.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Load Assigned Permissions (lst2)
                    SqlCommand assignedCommand = new SqlCommand(
                        "SELECT q.Chuc_Nang, q.ID FROM QUYEN q " +
                        "JOIN QUYENSUDUNG qsd ON q.ID = qsd.QuyenID " +
                        "WHERE qsd.NVId = @Ma_LoaiNV", connection);
                    assignedCommand.Parameters.Add(new SqlParameter("@Ma_LoaiNV", cbLoaiNV.SelectedValue));
                    SqlDataAdapter assignedAdapter = new SqlDataAdapter(assignedCommand);
                    DataTable assignedTable = new DataTable();
                    assignedAdapter.Fill(assignedTable);

                    foreach (DataRow row in assignedTable.Rows)
                    {
                        lst1.Items.Add(row["Chuc_Nang"].ToString());
                    }

                    // Load Available Permissions (lst1)
                    SqlCommand availableCommand = new SqlCommand(
                        "SELECT q.Chuc_Nang, q.ID FROM QUYEN q  " +
                        "WHERE q.ID NOT IN " +
                        "(SELECT QuyenId FROM QUYENSUDUNG WHERE NVId = @Ma_LoaiNV)", connection);
                    availableCommand.Parameters.Add(new SqlParameter("@Ma_LoaiNV", cbLoaiNV.SelectedValue));
                    SqlDataAdapter availableAdapter = new SqlDataAdapter(availableCommand);
                    DataTable availableTable = new DataTable();
                    availableAdapter.Fill(availableTable);

                    foreach (DataRow row in availableTable.Rows)
                    {
                        lst2.Items.Add(row["Chuc_Nang"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }



        private void btnLTR_Click(object sender, EventArgs e)
        {
            if (lst1.SelectedItem != null)
            {
                int quyenId = (int)((DataRowView)lst1.SelectedItem)["ID"];

                lst2.Items.Add(lst1.SelectedItem);
                lst1.Items.Remove(lst1.SelectedItem);

                // Gọi hàm cập nhật thêm quyền vào cơ sở dữ liệu
                UpdatePermissionInDatabase(quyenId, true);
            }
        }

        private void btnLTRAll_Click(object sender, EventArgs e)
        {
            while (lst1.Items.Count > 0)
            {
                int quyenId = (int)((DataRowView)lst1.Items[0])["ID"];

                lst2.Items.Add(lst1.Items[0]);
                lst1.Items.RemoveAt(0);

                // Gọi hàm cập nhật thêm quyền vào cơ sở dữ liệu
                UpdatePermissionInDatabase(quyenId, true);
            }
        }

        private void btnRTL_Click(object sender, EventArgs e)
        {
            if (lst2.SelectedItem != null)
            {
                int quyenId = (int)((DataRowView)lst2.SelectedItem)["ID"];

                lst1.Items.Add(lst2.SelectedItem);
                lst2.Items.Remove(lst2.SelectedItem);

                // Gọi hàm cập nhật xóa quyền khỏi cơ sở dữ liệu
                UpdatePermissionInDatabase(quyenId, false);
            }
        }

        private void btnRTLAll_Click(object sender, EventArgs e)
        {
            while (lst2.Items.Count > 0)
            {
                int quyenId = (int)((DataRowView)lst2.Items[0])["ID"];

                lst1.Items.Add(lst2.Items[0]);
                lst2.Items.RemoveAt(0);

                // Gọi hàm cập nhật xóa quyền khỏi cơ sở dữ liệu
                UpdatePermissionInDatabase(quyenId, false);
            }
        }


        private void UpdatePermissionInDatabase(int quyenId, bool isAdding)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command;

                    if (isAdding) // Add permission
                    {
                        command = new SqlCommand("INSERT INTO QUYENSUDUNG (NVId, QuyenID) VALUES (@Ma_LoaiNV, @QuyenID)", connection);
                    }
                    else // Remove permission
                    {
                        command = new SqlCommand("DELETE FROM QUYENSUDUNG WHERE NVId = @Ma_LoaiNV AND QuyenID = @QuyenID", connection);
                    }

                    command.Parameters.Add(new SqlParameter("@Ma_LoaiNV", cbLoaiNV.SelectedValue));
                    command.Parameters.Add(new SqlParameter("@QuyenID", quyenId));

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE QUYENTRUYCAP SET Ten_Truy_Cap = @Loai_NV WHERE ID = @ID", connection);
                    command.Parameters.Add(new SqlParameter("@ID", cbLoaiNV.SelectedValue));
                    command.Parameters.Add(new SqlParameter("@Loai_NV", cbLoaiNV.Text));

                    command.ExecuteNonQuery();

                    connection.Close();
                    MessageBox.Show("Cập nhật thành công");
                    TypeStaff();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO QUYENTRUYCAP (Ten_Truy_Cap) VALUES (@Loai_NV)", connection);

                    command.Parameters.Add(new SqlParameter("@Loai_NV", cbLoaiNV.Text));

                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Thêm thành công");
                    TypeStaff();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("DELETE QUYENTRUYCAP WHERE ID = @ID", connection);
                    command.Parameters.Add(new SqlParameter("@ID", cbLoaiNV.SelectedValue));

                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Xóa thành công");
                    TypeStaff();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void AccessRole_Load(object sender, EventArgs e)
        {
            TypeStaff();
            LoadPermissions();
        }

        private void cbLoaiNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPermissions();
        }
    }
}
