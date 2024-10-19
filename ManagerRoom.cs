using OfficeOpenXml.Style;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;

namespace HotelManage
{
    public partial class ManagerRoom : UserControl
    {
        public ManagerRoom()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
           
        }

        private void ExportExcel(string path)
        {
            //Excel.Application application = new Excel.Application();
            //application.Application.Workbooks.Add(Type.Missing);
            //for (int i = 0; i < dtgListRoom.Columns.Count; i++) {
            //    application.Cells[1, i+1] = dtgListRoom.Columns[i].HeaderText;
            //}
            //for (int i = 0; i <  dtgListRoom.Rows.Count; i++) {
            //    for (int j = 0; j < dtgListRoom.Columns.Count; j++) {
            //        application.Cells[i+2, j+1] = dtgListRoom.Rows[i].Cells[j].Value;
            //    }
            //}
            //application.Columns.AutoFit();
            //application.ActiveWorkbook.SaveCopyAs(path);
            //application.ActiveWorkbook.Saved = true;
        }
    }
}
