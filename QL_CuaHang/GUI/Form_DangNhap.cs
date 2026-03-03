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
    public partial class Form_DangNhap : Form
    {
        public static int idNhanVienHienTai = 0;
        public static string tenDangNhap = "";
        public Form_DangNhap()
        {
            InitializeComponent();

        }
        public static DataTable ThongNguoidung(string ten, string mk)
        {
            //lỗi admin' OR '1'='1
            // string sql = "Select * From NGUOIDUNG where TenDangNhap='" + ten + "' and MatKhau='" + mk + "'";
            // DataTable dt = new DataTable();
            // dt = KetNoiCSDL.DocDuLieu(sql);
            // return dt;


            // sau khi sửa lỗi
            string sql = "SELECT * FROM NGUOIDUNG WHERE TenDangNhap = @ten AND MatKhau = @mk";
            var pars = new Dictionary<string, object>
            {
                {"@ten", ten?.Trim()},
                {"@mk", mk?.Trim()}
            };
            return KetNoiCSDL.DocDuLieu(sql, pars);
        }



        private void Form_DangNhap_Load(object sender, EventArgs e)
        {
            gunaMatKhau.UseSystemPasswordChar = true; 
            btpassword.Text = "Hiện"; 

        }
        public static string loaitk;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ThongNguoidung(gunaTaiKhoan.Text, gunaMatKhau.Text);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu chưa đúng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                loaitk = dt.Rows[0]["LoaiTK"].ToString();
                MessageBox.Show("Đăng nhập thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (loaitk == "admin")
                {
                    Form_QuanLi frmQuanLi = new Form_QuanLi();
                    frmQuanLi.Show();
                }
                else if (loaitk == "nhanvien")
                {
                    tenDangNhap = gunaTaiKhoan.Text.Trim();
                    idNhanVienHienTai = Convert.ToInt32(dt.Rows[0]["IDNhanVien"] ?? 0);
                    Form_Menu frmMenu = new Form_Menu();
                    frmMenu.Show();
                }
                this.Hide();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        // Nút ẩn-hiện password
        private void btpassword_Click(object sender, EventArgs e)
        {
            if (gunaMatKhau.UseSystemPasswordChar)
            {
                gunaMatKhau.UseSystemPasswordChar = false; 
                btpassword.Text = "Ẩn";
            }
            else
            {
                gunaMatKhau.UseSystemPasswordChar = true; 
                btpassword.Text = "Hiện"; 
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form_TaoTaiKhoan frmtaotaikhoan = new Form_TaoTaiKhoan();
            frmtaotaikhoan.Show();
        }
    }
}
