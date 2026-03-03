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
    public partial class Form_DiemDanh : Form
    {
        private int idNhanVien;
        public Form_DiemDanh()
        {
            InitializeComponent();
            idNhanVien = Form_DangNhap.idNhanVienHienTai;
            if (idNhanVien == 0)
            {
                MessageBox.Show("Không tìm thấy id nhân viên!", "Lỗi!!!");
                this.Close();
                return;
            }
        }

        private void LoadThongTinNhanVien()
        {
            string sql = "SELECT TenNhanVien, ChucVu FROM NhanVien WHERE ID = @ID";
            var pars = new Dictionary<string, object> { { "@ID", idNhanVien } };
            DataTable dt = KetNoiCSDL.DocDuLieu(sql, pars);

            if (dt.Rows.Count > 0)
            {
                txttennhanvien.Text = dt.Rows[0]["TenNhanVien"].ToString();
                txtchucvu.Text = dt.Rows[0]["ChucVu"].ToString();
            }
        }


        private void LoadSoNgayDiemDanh()
        {

            string sql = @"
                SELECT COUNT(*) AS SoNgay
                FROM DiemDanh 
                WHERE IDNhanVien = @ID AND TrangThai = 'CoMat'";

            var pars = new Dictionary<string, object> { { "@ID", idNhanVien } };

            try
            {
                DataTable dt = KetNoiCSDL.DocDuLieu(sql, pars);

                decimal soNgay = 0;

                if (dt != null && dt.Rows.Count > 0)
                {
                    object value = dt.Rows[0]["SoNgay"];

                    if (value != null && value != DBNull.Value)
                    {
                        decimal.TryParse(value.ToString(), System.Globalization.NumberStyles.Any,
                                         System.Globalization.CultureInfo.InvariantCulture, out soNgay);
                    }
                }

                txtsongaydiemdanh.Text = soNgay.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi số ngày không tính được:\n" + ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsongaydiemdanh.Text = "0";
            }
        }


        private void Form_DiemDanh_Load(object sender, EventArgs e)
        {
            LoadThongTinNhanVien(); 
            LoadSoNgayDiemDanh();
        }



        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Nút điểm danh
        private void btdiemdanh_Click(object sender, EventArgs e)
        {
            string sql = @"
                    INSERT INTO DiemDanh (IDNhanVien, Ngay, TrangThai)
                    VALUES (@ID, CURDATE(), 'CoMat')
                    ON DUPLICATE KEY UPDATE TrangThai = 'CoMat'";

            var pars = new Dictionary<string, object> { { "@ID", idNhanVien } };

            try
            {
                KetNoiCSDL.ThucThiTruyVan(sql, pars);
                MessageBox.Show("Điểm danh thành công!", "Thành công");
                LoadSoNgayDiemDanh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi điểm danh: " + ex.Message);
            }
        }
    }
}
