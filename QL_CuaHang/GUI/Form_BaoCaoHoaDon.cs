using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_CuaHang.DAO;
namespace QL_CuaHang.GUI
{
    public partial class Form_BaoCaoHoaDon : Form
    {
        private int _maHoaDon;
        public Form_BaoCaoHoaDon(int maHoaDon)
        {
            InitializeComponent();
            _maHoaDon = maHoaDon;
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomPercent = 100;
            reportViewer1.ZoomMode = ZoomMode.Percent;
        }

        private void Form_BaoCaoHoaDon_Load(object sender, EventArgs e)
        {

            reportViewer1.LocalReport.ReportEmbeddedResource = "QL_CuaHang.Report.Report_HoaDon.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            DataTable dt = MenuDAO.LayDuLieuReport(_maHoaDon);
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ChiTietHoaDon", dt));
            reportViewer1.RefreshReport();
        }
    }
}
