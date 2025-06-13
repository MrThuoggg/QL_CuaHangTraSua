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
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
            dgdanhsachtrasua.RowHeadersVisible = false;
            dgdanhsachtopping.RowHeadersVisible = false;
            dgOrder.RowHeadersVisible = false;
        }

        private void DanhSachTraSua()
        {
            DataTable dt = new DataTable();
            dt = MenuDAO.ThongTinTraSua();
            dgdanhsachtrasua.DataSource = dt;

            dgdanhsachtrasua.Columns["MaTraSua"].Width = 80;
            dgdanhsachtrasua.Columns["TenTraSua"].Width = 200;
            dgdanhsachtrasua.Columns["Gia"].Width = 120;
            dgdanhsachtrasua.Columns["MaLoaiTra"].Width = 60;

        }
        private void DanhSachTopping()
        {
            DataTable dt = new DataTable();
            dt = MenuDAO.ThongTinTopping();
            dgdanhsachtopping.DataSource = dt;
        }

        private void DanhSachOrder()
        {
            dgOrder.Columns.Add("TenTraSua", "Tên trà sữa");
            dgOrder.Columns.Add("MaTraSua", "Mã trà sữa");
            dgOrder.Columns.Add("Topping", "Topping");
            dgOrder.Columns.Add("SoLuong", "Số lượng");
            dgOrder.Columns.Add("GiaTopping", "Giá topping");
            dgOrder.Columns.Add("GiaTraSua", "Giá trà sữa");
            dgOrder.Columns.Add("TongGia", "Tổng giá");


            dgOrder.Columns["TenTraSua"].Width = 170;
            dgOrder.Columns["MaTraSua"].Width = 60;
            dgOrder.Columns["Topping"].Width = 309;
            dgOrder.Columns["GiaTopping"].Width = 100;
            dgOrder.Columns["SoLuong"].Width = 55;
            dgOrder.Columns["TongGia"].Width = 100;


            dgOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {
            DanhSachTraSua();
            DanhSachTopping();
            DanhSachOrder();
            dgdanhsachtrasua.Columns["Gia"].DefaultCellStyle.Format = "N0";
            dgdanhsachtrasua.Columns["Gia"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("vi-VN");
            dgdanhsachtopping.Columns["Gia"].DefaultCellStyle.Format = "N0";
            dgdanhsachtopping.Columns["Gia"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("vi-VN");
            dgOrder.Columns["GiaTopping"].DefaultCellStyle.Format = "N0";
            dgOrder.Columns["GiaTopping"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("vi-VN");

            dgOrder.Columns["GiaTraSua"].DefaultCellStyle.Format = "N0";
            dgOrder.Columns["GiaTraSua"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("vi-VN");

            dgOrder.Columns["TongGia"].DefaultCellStyle.Format = "N0";
            dgOrder.Columns["TongGia"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("vi-VN");



            string loaitk = Form_DangNhap.loaitk;
            if (loaitk == "nhanvien")
            {
                hỆTHỐNGToolStripMenuItem.Enabled = true;
                hỆTHỐNGToolStripMenuItem.Visible = true;

                đỒUỐNGToolStripMenuItem.Enabled = false;
                đỒUỐNGToolStripMenuItem.Visible = false;

                qUẢNLÍToolStripMenuItem.Enabled = false;
                qUẢNLÍToolStripMenuItem.Visible = false;

                tHỐNGKÊDOANHTHUToolStripMenuItem.Enabled = false;
                tHỐNGKÊDOANHTHUToolStripMenuItem.Visible = false;
                menuStrip1.Refresh();

            }
            else if (loaitk == "admin")
            {
                đỒUỐNGToolStripMenuItem.Enabled = true;
                đỒUỐNGToolStripMenuItem.Visible = true;

                tHỐNGKÊDOANHTHUToolStripMenuItem.Enabled = true;
                tHỐNGKÊDOANHTHUToolStripMenuItem.Visible = true;

                qUẢNLÍToolStripMenuItem.Enabled = true;
                qUẢNLÍToolStripMenuItem.Visible = true;

                hỆTHỐNGToolStripMenuItem.Enabled = true;
                hỆTHỐNGToolStripMenuItem.Visible = true;
            }
        }

        private void qUẢNLÍToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dgdanhsachtrasua_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgdanhsachtrasua.Columns[0].Frozen = true;
            dgdanhsachtrasua.Columns[1].Frozen = true;
            dgdanhsachtrasua.Columns[2].Frozen = true;
        }
        private void UpdateTongTien()
        {
            decimal tongTien = 0;

            foreach (DataGridViewRow row in dgOrder.Rows)
            {
                if (row.Cells["TongGia"].Value != null && row.Cells["TongGia"].Value != DBNull.Value)
                {
                    decimal tong;
                    bool isValid = decimal.TryParse(row.Cells["TongGia"].Value.ToString(), out tong);

                    if (isValid)
                    {
                        tongTien += tong;
                    }
                }
            }

            txttongtien1.Text = tongTien.ToString("N0") + " VND";
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            if (dgdanhsachtrasua.CurrentRow != null && dgdanhsachtopping.CurrentRow != null)
            {
                string tenTraSua = dgdanhsachtrasua.CurrentRow.Cells["TenTraSua"].Value?.ToString() ?? string.Empty;
                string maTraSua = dgdanhsachtrasua.CurrentRow.Cells["MaTraSua"].Value?.ToString() ?? string.Empty;
                decimal giaTraSua = Convert.ToDecimal(dgdanhsachtrasua.CurrentRow.Cells["Gia"].Value ?? 0);


                int soLuong = 1;
                string tenToppingGop = "";
                decimal tongGiaTopping = 0;

                foreach (DataGridViewRow selectedRow in dgdanhsachtopping.SelectedRows)
                {
                    string tenTopping = selectedRow.Cells["TenTopping"].Value?.ToString() ?? string.Empty;
                    decimal giaTopping = Convert.ToDecimal(selectedRow.Cells["Gia"].Value ?? 0);


                    tenToppingGop += tenTopping + ", ";
                    tongGiaTopping += giaTopping;

                }
                if (tenToppingGop.EndsWith(", "))
                {
                    tenToppingGop = tenToppingGop.Remove(tenToppingGop.Length - 2);
                }
                decimal tongGia = (Convert.ToDecimal(giaTraSua) + tongGiaTopping) * soLuong;

                dgOrder.Rows.Add(tenTraSua, maTraSua, tenToppingGop, soLuong, tongGiaTopping, giaTraSua, tongGia);

                UpdateTongTien();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn trà sữa và topping trước khi thêm.");
            }
        }

        private void đĂNGXUẤTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DangNhap frmdangnhap = new Form_DangNhap();
            frmdangnhap.Show();
        }

        private void đĂNGXUẤTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btinHoaDon_Click(object sender, EventArgs e)
        {
            //tạo ra 1 mã hoá đơn mới
            int maHoaDon = MenuDAO.LayMaHoaDonMoiNhat();

            // lấy dữ liệu ra từ datagridvew
            foreach (DataGridViewRow row in dgOrder.Rows)
            {
                if (!row.IsNewRow)
                {
                    string tenTraSua = row.Cells["TenTraSua"].Value?.ToString() ?? "";
                    string tenTopping = row.Cells["Topping"].Value?.ToString() ?? "";
                    int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value ?? 0);
                    decimal giaTraSua = Convert.ToDecimal(row.Cells["GiaTraSua"].Value ?? 0);
                    decimal giaTopping = Convert.ToDecimal(row.Cells["GiaTopping"].Value ?? 0);
                    decimal tongGia = Convert.ToDecimal(row.Cells["TongGia"].Value ?? 0);   
                    MenuDAO.ThemChiTietHoaDon(maHoaDon, tenTraSua, tenTopping, soLuong, giaTraSua, giaTopping, tongGia);
                }
            }


            // Gọi cái form report
            Form_BaoCaoHoaDon frmBaoCaoHoaDon = new Form_BaoCaoHoaDon(maHoaDon);
            frmBaoCaoHoaDon.Show();


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            
            try
            {
                // Kiểm tra nếu có dòng nào được chọn không 
                if (dgOrder.CurrentRow != null && !dgOrder.CurrentRow.IsNewRow)
                {
                    DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (kq == DialogResult.Yes)
                    {
                        dgOrder.Rows.Remove(dgOrder.CurrentRow);
                    }
                }
                else
                    MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Không thể xóa do không có sản phầm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgdanhsachtopping_MouseClick(object sender, MouseEventArgs e)
        {


        }

        private void dgdanhsachtopping_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
