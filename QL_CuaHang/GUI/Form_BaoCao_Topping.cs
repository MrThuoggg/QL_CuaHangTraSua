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
    public partial class Form_BaoCao_Topping : Form
    {
        public Form_BaoCao_Topping()
        {
            InitializeComponent();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomPercent = 100;
            reportViewer1.ZoomMode = ZoomMode.Percent;
        }

        private void Form_BaoCao_Topping_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "QL_CuaHang.Report.Report_Topping.rdlc"; // Tên namespace và tên file RDLC ( địa chỉ dẫn )
            reportViewer1.LocalReport.DataSources.Clear();
            DataTable dt = MenuDAO.ThongTinTopping();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DanhSachTopping", dt));
            reportViewer1.RefreshReport();
        }
    }
}
