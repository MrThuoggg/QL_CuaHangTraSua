using QL_CuaHang.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace QL_CuaHang.GUI
{
    public partial class UC_QLNGUYENLIEU : UserControl
    {
        public UC_QLNGUYENLIEU()
        {
            InitializeComponent();
            dgdanhsachnguyenlieu.RowHeadersVisible = false;
        }
        
        private void ClearForm()
        {
            txtmanguyenlieu.Clear();
            txttennguyenlieu.Clear();
            txttonkho.Clear();
            txtgianhap.Clear();
            txtdonvitinh.Clear();
            txttonkhotoithieu.Clear();
        }

        public void LoadDanhSachNguyenLieu()
        {
            try
            {
                DataTable dt = MenuDAO.ThongTinNguyenLieu();
                dgdanhsachnguyenlieu.DataSource = dt;
                MenuDAO.FormatDataGridView(dgdanhsachnguyenlieu);

                // Định dạng hiển  thị
                if (dgdanhsachnguyenlieu.Columns.Count > 0)
                {
                    dgdanhsachnguyenlieu.Columns["GiaNhap"].DefaultCellStyle.Format = "N0";
                    dgdanhsachnguyenlieu.Columns["TonKho"].DefaultCellStyle.Format = "N0";
                    dgdanhsachnguyenlieu.Columns["TonKhoToiThieu"].DefaultCellStyle.Format = "N0";

                    // Highlight cảnh báo tồn kho thấp (màu đỏ)
                    foreach (DataGridViewRow row in dgdanhsachnguyenlieu.Rows)
                    {
                        if (row.Cells["TrangThai"].Value?.ToString() == "Cảnh báo")
                        {
                            row.DefaultCellStyle.BackColor = Color.LightPink;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                    }
                }
                CapNhatThongKe();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Lỗi khi tải danh sách nguyên liệu:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }


        // Hàm cập nhật lại dữ liệu thống kê
        private void CapNhatThongKe()
        {
            try
            {
                //luôn lấy dữ liệu từ datagrid mới nhất
                DataTable dt = (DataTable)dgdanhsachnguyenlieu.DataSource;
                int tongNguyenLieu = dgdanhsachnguyenlieu.Rows.Count - 1;
                decimal tongGiaTri = 0;

                if(dt == null || dt.Rows.Count == 0)
                {
                    tongnguyenlieu.Text = "0";
                    tonggiatri.Text = "0 đ";
                }

                foreach (DataRow row in dt.Rows)
                {
                    decimal tonKho = Convert.ToDecimal(row["TonKho"] ?? 0);
                    decimal giaNhap = Convert.ToDecimal(row["GiaNhap"].ToString().Replace(",", ""));
                    tongGiaTri += tonKho * giaNhap;
                }
                tongnguyenlieu.Text = tongNguyenLieu.ToString();
                tonggiatri.Text = tongGiaTri.ToString("N0") + " đ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi tính toán thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Sự kiện click vào danh sách 
        private void dgdanhsachkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgdanhsachnguyenlieu.Rows[e.RowIndex];
                txtmanguyenlieu.Text = row.Cells["MaNguyenLieu"].Value?.ToString();

                txttennguyenlieu.Text = row.Cells["TenNguyenLieu"].Value?.ToString();

                txtdonvitinh.Text = row.Cells["DonViTinh"].Value?.ToString();

                decimal giaNhap = Convert.ToDecimal(row.Cells["GiaNhap"].Value ?? 0);
                txtgianhap.Text = giaNhap.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));

                decimal tonKho = Convert.ToDecimal(row.Cells["TonKho"].Value ?? 0);
                txttonkho.Text = tonKho.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));

                decimal tonKhoToiThieu = Convert.ToDecimal(row.Cells["TonKhoToiThieu"].Value ?? 0);
                txttonkhotoithieu.Text = tonKhoToiThieu.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));

            }
        }
        
        // Nút thêm
        private void gunathemKH_Click(object sender, EventArgs e)
        {
            string ten = txttennguyenlieu.Text.Trim();
            string donVi = txtdonvitinh.Text.Trim();
            decimal giaNhap = decimal.Parse(txtgianhap.Text.Trim());
            decimal tonKho = decimal.Parse(txttonkho.Text.Trim());
            decimal tonKhoToiThieu = decimal.Parse(txttonkhotoithieu.Text.Trim());


            if (!decimal.TryParse(txttonkho.Text.Trim(), out decimal soLuongtonKho))
            {
                MessageBox.Show("Số lượng tồn kho không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                MenuDAO.ThemNguyenLieu(ten, donVi, giaNhap, tonKho, tonKhoToiThieu);
                MessageBox.Show("Thêm nguyên liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachNguyenLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nguyên liệu! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Nút cập nhật
        private void gunacapnhatKH_Click(object sender, EventArgs e)
        {
            try
            {
                int ma = int.Parse(txtmanguyenlieu.Text.Trim());
                string ten = txttennguyenlieu.Text.Trim();
                string donVi = txtdonvitinh.Text.Trim();
                decimal giaNhap = decimal.Parse(txtgianhap.Text.Trim());
                decimal tonKho = decimal.Parse(txttonkho.Text.Trim());
                decimal tonKhoToiThieu = decimal.Parse(txttonkhotoithieu.Text.Trim());
                MenuDAO.CapNhatNguyenLieu(ma, ten, donVi, giaNhap, tonKho, tonKhoToiThieu);
                MessageBox.Show("Cập nhật nguyên liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachNguyenLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra!! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Nút xóa
        private void gunaxoaKH_Click(object sender, EventArgs e)
        {
            try
            {
                int maHoaDon = int.Parse(txtmanguyenlieu.Text.Trim());
                DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    MenuDAO.XoaNguyenLieu(maHoaDon);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadDanhSachNguyenLieu();
                    CapNhatThongKe();
                    ClearForm();
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
            LoadDanhSachNguyenLieu();
            CapNhatThongKe();
        }

        private void InBaoCao_Click(object sender, EventArgs e)
        {
            Form_BaoCao_NguyenLieu frm = new Form_BaoCao_NguyenLieu();
            frm.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txttencantim.Text.Trim();
            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                LoadDanhSachNguyenLieu(); // tải lại
                return;
            }

            try
            {
                DataTable dt = MenuDAO.TimKiemNguyenLieu(tuKhoa);
                dgdanhsachnguyenlieu.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show($"Không tìm thấy nguyên liệu nào chứa '{tuKhoa}'",
                        "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex) {
           
                MessageBox.Show("Đã xảy ra lỗi tìm kiếm!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            LoadDanhSachNguyenLieu();
            txttencantim.Clear();
        }


        // Định nghĩa kiểu nhập vào Textbox
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


        // Nút tạo mã tiếp theo
        private void gunataoma_Click(object sender, EventArgs e)
        {
            ClearForm();
            int maMoi = MenuDAO.LayMaNguyenLieu();
            txtmanguyenlieu.Text = maMoi.ToString();
            txtmanguyenlieu.ReadOnly = true;
            txttennguyenlieu.Focus();

        }



        private void UC_QLNGUYENLIEU_Load(object sender, EventArgs e)
        {
            txtmanguyenlieu.ReadOnly = true;
            LoadDanhSachNguyenLieu();
        }
    }
}
