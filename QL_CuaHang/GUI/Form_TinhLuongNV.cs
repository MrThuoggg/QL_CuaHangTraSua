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
    public partial class Form_TinhLuongNV : Form
    {
        private const decimal LUONG_MOT_NGAY = 168000M;
        private const decimal PHU_CAP_CUOI_TUAN = 500000M;
        private const decimal TRU_TIEN_NGAY_NGHI = 50000M;
        public Form_TinhLuongNV()
        {
            InitializeComponent();
            CaiDatNgayThang();
        }
        private void CaiDatNgayThang()
        {
 
            dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
            dtpNgayBatDau.CustomFormat = "dd MMMM, yyyy";
            dtpNgayKetThuc.Format = DateTimePickerFormat.Custom;
            dtpNgayKetThuc.CustomFormat = "dd MMMM, yyyy";
        }
        private int TinhNgayLamViec(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            // Tính tổng số ngày làm việc
            int soNgay = 0;
            for (DateTime ngay = ngayBatDau; ngay <= ngayKetThuc; ngay = ngay.AddDays(1))
            {
                if (ngay.DayOfWeek != DayOfWeek.Saturday && ngay.DayOfWeek != DayOfWeek.Sunday)
                    soNgay++;
                else if (ngay.DayOfWeek == DayOfWeek.Sunday && chkLamChuNhat.Checked)
                    soNgay++;

            }
            return soNgay;
        }


        private void CapNhatSoNgayLam()
        {
            try
            {
                int soNgay = TinhNgayLamViec(dtpNgayBatDau.Value, dtpNgayKetThuc.Value);
                txtsongaylam.Text = $"Số ngày làm việc: {soNgay} ngày";

                int soNgayChuNhat = 0;
                if (chkLamChuNhat.Checked)
                {
                    for (DateTime ngay = dtpNgayBatDau.Value; ngay <= dtpNgayKetThuc.Value; ngay = ngay.AddDays(1))
                    {
                        if (ngay.DayOfWeek == DayOfWeek.Sunday)
                            soNgayChuNhat++;


                    }
                }
                lblSoNgayChuNhat.Text = $"Số ngày Chủ nhật đã làm: {soNgayChuNhat} ngày";
            }
            catch (Exception)
            {
                txtsongaylam.Text = "Số ngày làm việc: 0 ngày";
                lblSoNgayChuNhat.Text = "Số ngày Chủ nhật đã làm: 0 ngày";
            }
        }



        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CapNhatSoNgayLam();
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
            try
            {
                DateTime ngayBatDau = dtpNgayBatDau.Value;
                DateTime ngayKetThuc = dtpNgayKetThuc.Value;
                if (ngayKetThuc < ngayBatDau)
                {
                    MessageBox.Show("Ngày kết thúc phải sau ngày bắt đầu!", "Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int soNgayLam = TinhNgayLamViec(ngayBatDau, ngayKetThuc);

                if (!decimal.TryParse(txtSoNgayNghi.Text, out decimal soNgayNghi))
                    soNgayNghi = 0;

                decimal tongLuong = (soNgayLam * LUONG_MOT_NGAY) - (soNgayNghi * TRU_TIEN_NGAY_NGHI);
                int soNgayChuNhat = 0;
                if (chkLamChuNhat.Checked)
                {
                    for (DateTime ngay = ngayBatDau; ngay <= ngayKetThuc; ngay = ngay.AddDays(1))
                    {
                        if (ngay.DayOfWeek == DayOfWeek.Sunday)
                            soNgayChuNhat++;
                    }
                    tongLuong += soNgayChuNhat * PHU_CAP_CUOI_TUAN;
                }
                txtTongLuong.Text = string.Format("{0:N0} VNĐ", tongLuong);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi!!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dtpNgayKetThuc_ValueChanged(object sender, EventArgs e)
        {
            CapNhatSoNgayLam(); 
        }

        private void chkLamChuNhat_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chkLamChuNhat_CheckedChanged_1(object sender, EventArgs e)
        {
            CapNhatSoNgayLam();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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

        private void lblSoNgayChuNhat_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string idNhanVienText = txtIDNhanVien.Text.Trim();
                string tongLuongText = txtTongLuong.Text.Trim();

                if (!int.TryParse(idNhanVienText, out int idNhanVien))
                {
                    MessageBox.Show("ID Nhân Viên không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(tongLuongText.Replace(" VNĐ", "").Replace(",", ""), out decimal luongCoBan))
                {
                    MessageBox.Show("Tổng lương không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MenuDAO.ThemLuongNhanVien(idNhanVien, luongCoBan);

                MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi!!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
