using Mysqlx.Crud;
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
    public partial class UC_QLDONHANG : UserControl
    {
        public UC_QLDONHANG()
        {
            InitializeComponent();
        }
        private void ThongTinHoaDon()
        {
            DataTable dt = new DataTable();
            dt = MenuDAO.ThongTinHoaDon();
            dgdanhsachhoadon.DataSource = dt;
        }
        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UC_QLDONHANG_Load(object sender, EventArgs e)
        {
            ThongTinHoaDon();
        }

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgdanhsachhoadon.SelectedRows.Count > 0)
                {
                    string maHoaDon = dgdanhsachhoadon.SelectedRows[0].Cells["Mã Hóa Đơn"].Value.ToString();

                    string tenKhachHang = txttenkhachhang.Text.Trim();
                    DateTime ngayMua = dtngaymua.Value;
                    MenuDAO.CapNhatDonHang(maHoaDon, tenKhachHang, ngayMua);
                    ThongTinHoaDon();

                    MessageBox.Show("Cập nhật hóa đơn thành công!");
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hóa đơn để cập nhật.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi cập nhật hóa đơn: " + ex.Message);
            }
        }

        private void btxoadon_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgdanhsachhoadon.SelectedRows.Count > 0)
                {
                    string maHoaDon = dgdanhsachhoadon.SelectedRows[0].Cells["Mã Hóa Đơn"].Value.ToString();

                    // Hiển thị hộp thoại xác nhận
                    DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa đơn hàng với mã hóa đơn: {maHoaDon} không?","Xác nhận xóa",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        MenuDAO.XoaDonHang(maHoaDon);
                        ThongTinHoaDon(); 
                        MessageBox.Show("Đơn hàng đã được xóa thành công!");
                    }
                    else
                        MessageBox.Show("Hành động xóa đã bị hủy");
                }
                else
                    MessageBox.Show("Vui lòng chọn một đơn hàng để xóa!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xóa đơn hàng!!");
            }

        }
        private void btthongke_Click(object sender, EventArgs e)
        {
            try
            {

                int soLuongDon = dgdanhsachhoadon.Rows.Count - 1;
                txtsoluongdon.Text = soLuongDon.ToString();

                decimal tongTien = 0;
                foreach (DataGridViewRow row in dgdanhsachhoadon.Rows)
                {

                    string giaTriTien = row.Cells["Tong_Tien"].Value?.ToString().Replace(",", "");
                    if (!string.IsNullOrEmpty(giaTriTien))
                    {
                        decimal tien;
                        if (decimal.TryParse(giaTriTien, out tien))
                            tongTien += tien;

                    }
                }
                txttongtien.Text = tongTien.ToString("#,##0") + " VND";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra!!!", "Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form_BaoCaoDonHang frm_baocaodonhang = new Form_BaoCaoDonHang();
            frm_baocaodonhang.ShowDialog();
        }

        private void dgdanhsachhoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgdanhsachhoadon.Rows[e.RowIndex];
                txttenkhachhang.Text = row.Cells["Ten_Khach_Hang"].Value.ToString();
                dtngaymua.Text = row.Cells["Ngay_Lap"].Value.ToString();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string maHoaDon = txtNhapCanTim.Text.Trim();
            if (string.IsNullOrEmpty(maHoaDon))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn cần tìm!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = MenuDAO.TimKiemHoaDonTheoMa(maHoaDon);
                if (dt != null && dt.Rows.Count > 0)
                {
                    dgdanhsachhoadon.DataSource = null; 
                    dgdanhsachhoadon.Columns.Clear();   
                    dgdanhsachhoadon.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ThongTinHoaDon();
        }

        private void txttenkhachhang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNhapCanTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
