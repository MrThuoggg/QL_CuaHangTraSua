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
    public partial class UC_QLKHANG : UserControl
    {
        public UC_QLKHANG()
        {
            InitializeComponent();
        }
        public void ThongTinKhachHang()
        {
            DataTable dt = new DataTable();
            dgdanhsachnguyenlieu.DataSource = dt;
        }
        private void CapNhatThongKe()
        {
            try
            {
                //luôn lấy dữ liệu từ datagrid mới nhất
                DataTable dt = (DataTable)dgdanhsachnguyenlieu.DataSource;
                int tongKhachHang = dgdanhsachnguyenlieu.Rows.Count -1;
                decimal tongDoanhThu = 0;

                foreach (DataGridViewRow row in dgdanhsachnguyenlieu.Rows)
                {
                    if (row.Cells["Tổng Tiền"].Value != null && decimal.TryParse(row.Cells["Tổng Tiền"].Value.ToString(), out decimal tongTien))
                    {
                        tongDoanhThu += tongTien;
                    }
                }
                tongkhachhang.Text = tongKhachHang.ToString();
                tongdoanhthu.Text = tongDoanhThu.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi tính toán thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UC_QLKHANG_Load(object sender, EventArgs e)
        {
            ThongTinKhachHang();
        }

        private void dgdanhsachkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgdanhsachnguyenlieu.Rows[e.RowIndex];
                txtmanguyenlieu.Text = row.Cells["Mã HD"].Value?.ToString();
                txttennguyenlieu.Text = row.Cells["Tên Khách Hàng"].Value?.ToString();
                if (decimal.TryParse(row.Cells["Tổng Tiền"].Value?.ToString(), out decimal tongTien))
                    txttonkho.Text = tongTien.ToString("0");

                else
                    txttonkho.Text = "0";

                if (row.Cells["Ngày Lập"].Value != null && DateTime.TryParse(row.Cells["Ngày Lập"].Value.ToString(), out DateTime ngayLap))
                    dtngaymua.Value = ngayLap;

                else
                    dtngaymua.Value = DateTime.Now;
            }
        }

        private void gunathemKH_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtmanguyenlieu.Text.Trim(), out int maHoaDon))
            {
                MessageBox.Show("Mã hóa đơn phải là số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string tenKhachHang = txttennguyenlieu.Text.Trim();
            DateTime ngayLap = dtngaymua.Value;

            if (!decimal.TryParse(txttonkho.Text.Trim(), out decimal tongTien))
            {
                MessageBox.Show("Tổng tiền không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                MenuDAO.ThemKhachHang(maHoaDon, tenKhachHang, ngayLap, tongTien);
                MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ThongTinKhachHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm hóa đơn: ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gunacapnhatKH_Click(object sender, EventArgs e)
        {
            try
            {
                int maHoaDon = int.Parse(txtmanguyenlieu.Text.Trim());
                string tenKhachHang = txttennguyenlieu.Text.Trim();
                DateTime ngayLap = dtngaymua.Value;
                decimal tongTien = decimal.Parse(txttonkho.Text.Trim());
                MenuDAO.CapNhatKhachHang(maHoaDon, tenKhachHang, ngayLap, tongTien);
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ThongTinKhachHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gunaxoaKH_Click(object sender, EventArgs e)
        {
            try
            {
                int maHoaDon = int.Parse(txtmanguyenlieu.Text.Trim());
                DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    MenuDAO.XoaKhachHang(maHoaDon);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ThongTinKhachHang();
                    CapNhatThongKe();

                    txtmanguyenlieu.Clear();
                    txttennguyenlieu.Clear();
                    dtngaymua.Value = DateTime.Now;
                    txttonkho.Clear();
                }
                else
                    MessageBox.Show("Hóa đơn không bị xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: "+ ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btthongke_Click(object sender, EventArgs e)
        {
            ThongTinKhachHang();
            CapNhatThongKe();
        }

        private void InBaoCao_Click(object sender, EventArgs e)
        {
            Form_BaoCao_KhachHang frm = new Form_BaoCao_KhachHang();
            frm.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            string tenKH = txttencantim.Text.Trim();
            DataTable dt =MenuDAO.TimKiemKhachHang(tenKH);

            if (dt.Rows.Count > 0)
                dgdanhsachnguyenlieu.DataSource = dt;

            else
                MessageBox.Show("Không tìm thấy khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ThongTinKhachHang();
            txttencantim.Clear();
        }

        private void txtmahoadon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmahoadon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txttenkhachhang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txttongtien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txttencantim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
