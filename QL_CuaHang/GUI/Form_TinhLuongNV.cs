using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_CuaHang.DAO;
namespace QL_CuaHang.GUI
{
    public partial class Form_TinhLuongNV : Form
    {
        private decimal luongNgay = 0M;
        private const decimal TRU_TIEN_NGHI = 50000M;
        private int idNhanVienHienTai = 0;
        private CultureInfo vietCulture = new CultureInfo("vi-VN");
        public Form_TinhLuongNV()
        {
            InitializeComponent();
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form_TinhLuongNV_Load(object sender, EventArgs e)
        {

        }

        private void bttinhluong_Click(object sender, EventArgs e)
        {
            if(idNhanVienHienTai == 0)
            {
                MessageBox.Show("Vui lòng kiểm tra ID nhân viên", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sql = @"
                SELECT Ngay 
                FROM DiemDanh 
                WHERE IDNhanVien = @ID 
                AND TrangThai = 'CoMat'
                AND YEAR(Ngay) = YEAR(CURDATE()) 
                AND MONTH(Ngay) = MONTH(CURDATE())";
            var pars= new Dictionary<string, object> { { "@ID", idNhanVienHienTai} };
            DataTable dt = KetNoiCSDL.DocDuLieu(sql, pars);
            int soNgayCong = dt.Rows.Count;
            int soNgayCN = 0;
            foreach(DataRow row in dt.Rows)
            {
                DateTime ngay = Convert.ToDateTime(row["Ngay"]);
                if (ngay.DayOfWeek == DayOfWeek.Sunday) soNgayCN++;
            }
            // Tính số ngày nghỉ
            int soNgayNghi = 30 - soNgayCong;

            //Tính lương
            decimal tongLuongCoBan = soNgayCong * luongNgay;
            decimal phuCapCN = soNgayCN * luongNgay;
            decimal truNgayNghi = soNgayNghi * TRU_TIEN_NGHI;

            decimal tongLuong = tongLuongCoBan + phuCapCN;

            txtsongaydiemdanh.Text = $"{soNgayCong} ngày";
            txtsongaynghi.Text = $"{soNgayNghi} ngày";
            txtsongaylamCN.Text = $"{soNgayCN} ngày";
            txtTongLuong.Text = tongLuong.ToString("N0", vietCulture) + " VND";
        }



        private void dtpNgayKetThuc_ValueChanged(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void label10_Click_1(object sender, EventArgs e)
        {

        }
        private void txtsongaylam_Click(object sender, EventArgs e)
        {

        }
        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void txtTongLuong_TextChanged(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }



        // Nút lưu lương
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(idNhanVienHienTai == 0 || string.IsNullOrWhiteSpace(txtTongLuong.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra và tính lương trước khi lưu", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int idNhanVien = int.Parse(txtIDNhanVien.Text.Trim());
                string luongStr = txtTongLuong.Text.Replace(" VND", "").Replace(",", "").Trim();
                decimal tongLuong = decimal.Parse(luongStr, vietCulture);
                MenuDAO.ThemLuongNhanVien(idNhanVien, tongLuong);

                MessageBox.Show("Lưu lương thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lưu lương thất bại!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Nút kiểm tra dữ liệu nhân viên
        private void btkiemtra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDNhanVien.Text))
            {
                MessageBox.Show("Vui lòng nhập ID nhân viên đúng!!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!int.TryParse(txtIDNhanVien.Text, out int idNhanVien))
            {
                MessageBox.Show("ID nhân viên phải là số!!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string layChucVu = "Select ChucVu FROM NhanVien Where ID = @ID";
            var pars = new Dictionary<string, object> { {"@ID", idNhanVien} };
            DataTable dt = KetNoiCSDL.DocDuLieu(layChucVu, pars);
            if(dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy nhân viên!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string ChucVu = dt.Rows[0]["ChucVu"].ToString();
            luongNgay = ChucVu == "Nhân viên pha chế" ? 220000M : (ChucVu == "Nhân viên phục vụ" ? 185000M : 0M);

            if(luongNgay == 0M)
            {
                MessageBox.Show("Chức vụ không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }

            int soNgayDiemDanh = LaySoNgayDiemDanh(idNhanVien);
            idNhanVienHienTai = idNhanVien;
            txtsongaydiemdanh.Text = soNgayDiemDanh.ToString();
            txtchucvu.Text = ChucVu;

        }

        private int LaySoNgayDiemDanh(int idNhanVien)
        {
            string sql = @"Select Count(*) as SoNgay From DiemDanh Where IDNhanVien = @ID and TrangThai = 'CoMat'";
            var pars = new Dictionary<string, object> { {"@ID", idNhanVien} };
            object result = KetNoiCSDL.ThucThiTruyVanLayGiaTri(sql, pars);
            return result != null && result != DBNull.Value ? Convert.ToInt32(result) :0;
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
