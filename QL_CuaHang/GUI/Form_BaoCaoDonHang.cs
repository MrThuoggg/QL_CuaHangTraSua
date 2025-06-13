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
    public partial class Form_BaoCaoDonHang : Form
    {
        public Form_BaoCaoDonHang()
        {
            InitializeComponent();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomPercent = 100;
            reportViewer1.ZoomMode = ZoomMode.Percent;
        }

        private void Form_BaoCaoDonHang_Load(object sender, EventArgs e)
        {

            reportViewer1.LocalReport.ReportEmbeddedResource = "QL_CuaHang.Report.Report_DonHang.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            DataTable dt = MenuDAO.ThongTinHoaDon();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("QLDonHang", dt));
            reportViewer1.RefreshReport();
        }
    }
}
