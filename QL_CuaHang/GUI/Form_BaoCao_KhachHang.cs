using Microsoft.Reporting.WinForms;
using QL_CuaHang.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CuaHang.GUI
{
    public partial class Form_BaoCao_KhachHang : Form
    {
        public Form_BaoCao_KhachHang()
        {
            InitializeComponent();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomPercent = 100;
            reportViewer1.ZoomMode = ZoomMode.Percent;
        }

        private void Form_BaoCao_KhachHang_Load(object sender, EventArgs e)
        {

            reportViewer1.LocalReport.ReportEmbeddedResource = "QL_CuaHang.Report.Report_KhachHang.rdlc"; // Tên namespace và tên file RDLC ( địa chỉ dẫn )
            reportViewer1.LocalReport.DataSources.Clear();
            DataTable dt = MenuDAO.HoaDonReport();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("KhachHang", dt));
            reportViewer1.RefreshReport();
        }
    }
}
