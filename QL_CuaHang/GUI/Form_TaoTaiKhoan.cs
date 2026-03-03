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
    public partial class Form_TaoTaiKhoan : Form
    {
        public Form_TaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearForm()
        {
            txttendangnhap.Clear();
            txtmatkhau.Clear();
            cboNhanVien.SelectedIndex = 0;
        }
        private void LoadDanhSachNhanVien()
        {
            DataTable dt = MenuDAO.LoadNhanVien(); 
            cboNhanVien.DataSource = dt;
            cboNhanVien.DisplayMember = "TenNhanVien";
            cboNhanVien.ValueMember = "ID";
        }
        private void LoadDanhSachChucVu()
        {
            DataTable dt = new DataTable();
            dt = MenuDAO.ThongTinChucVuNhanVien();
            cboChucVu.DataSource = dt; 
            cboChucVu.DisplayMember = "Chức_Vụ";
            cboChucVu.ValueMember = "Chức_Vụ";

        }
        private void Form_TaoTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien();
            LoadDanhSachChucVu();
        }

        // Nút tạo tài khoản
        private void bttaotaikhoan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txttendangnhap.Text) ||
                string.IsNullOrWhiteSpace(txtmatkhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Cảnh báo");
                return;
            }

            int idNhanVien = Convert.ToInt32(cboNhanVien.SelectedValue);
            string tenDangNhap = txttendangnhap.Text.Trim();
            string matKhau = txtmatkhau.Text.Trim();
            string chucVu = cboChucVu.Text;

            // Kiểm tra trùng tên đăng nhập
            string sqlCheck = "SELECT COUNT(*) FROM NGUOIDUNG WHERE TenDangNhap = @Ten";
            object count = KetNoiCSDL.ThucThiTruyVanLayGiaTri(sqlCheck, "@Ten", tenDangNhap);

            if (Convert.ToInt32(count) > 0)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thêm tài khoản
            string sqlInsert = @"
                INSERT INTO NGUOIDUNG (TenDangNhap, MatKhau, LoaiTK, IDNhanVien, ChucVu, HoTen)
                VALUES (@Ten, @MK, 'nhanvien', @IDNV, @ChucVu, 
                        (SELECT TenNhanVien FROM NhanVien WHERE ID = @IDNV))";

            KetNoiCSDL.ThucThiTruyVan(sqlInsert,
                "@Ten", tenDangNhap,
                "@MK", matKhau,
                "@IDNV", idNhanVien,
                "@ChucVu", chucVu);

            MessageBox.Show("Tạo tài khoản thành công!", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearForm();
        }
    }
}
