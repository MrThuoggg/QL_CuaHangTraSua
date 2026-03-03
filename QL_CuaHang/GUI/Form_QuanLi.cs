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
    public partial class Form_QuanLi : Form
    {
        public Form_QuanLi()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        // Định nghĩa loại tài khoản
        private void Form_QuanLi_Load(object sender, EventArgs e)
        {
            string loaitk = Form_DangNhap.loaitk;
            if (loaitk == "nhanvien")
            {
                đỒUỐNGToolStripMenuItem.Enabled = false;
                qUẢNLÍToolStripMenuItem.Enabled = false;
                qUẢNLÍToolStripMenuItem.Visible = false;
                tHỐNGKÊDOANHTHUToolStripMenuItem.Enabled = false;
                tHỐNGKÊDOANHTHUToolStripMenuItem.Visible = false;
                hỆTHỐNGToolStripMenuItem.Enabled = true;
            }
            else if (loaitk == "admin")
            {
                đỒUỐNGToolStripMenuItem.Enabled = true;
                đỒUỐNGToolStripMenuItem.Visible = true;
                tHỐNGKÊDOANHTHUToolStripMenuItem.Enabled = true;
                qUẢNLÍToolStripMenuItem.Enabled = true;
                hỆTHỐNGToolStripMenuItem.Enabled = true;
            }
        }


        // Load MenuStrip
        private void qUẢNLÝĐƠNHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UC_QLDONHANG ucqldonhang = new UC_QLDONHANG();
            ucqldonhang.Dock = DockStyle.Fill;
            panel2.Controls.Add(ucqldonhang);
        }

        private void qUẢNLÝKHÁCHHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UC_QLNGUYENLIEU ucqlkhachhang = new UC_QLNGUYENLIEU();
            ucqlkhachhang.Dock = DockStyle.Fill;
            panel2.Controls.Add(ucqlkhachhang);
        }

        private void qUẢNLÝNHÂNVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UC_QLNHANVIEN ucqlnhanvien = new UC_QLNHANVIEN();
            ucqlnhanvien.Dock = DockStyle.Fill;
            panel2.Controls.Add(ucqlnhanvien);
        }

        private void đĂNGNHẬPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DangNhap frmdangnhap = new Form_DangNhap();
            frmdangnhap.Show();
        }

        private void đĂNGXUẤTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bÁOCÁOCHITIẾTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_BaoCaoChiTiet frm_baocaochitiet = new Form_BaoCaoChiTiet();
            frm_baocaochitiet.Show();
        }

        private void tHÊMĐỒUỐNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ThemDoUong frm_themdoUong = new Form_ThemDoUong();
            frm_themdoUong.Show();
        }




        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tHÊMTOPPINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ThemTopping form_ThemTopping = new Form_ThemTopping();
            form_ThemTopping.Show();
        }

        private void đỒUỐNGToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tẠOTÀIKHOẢNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_TaoTaiKhoan frmtaotaikhoan = new Form_TaoTaiKhoan();
            frmtaotaikhoan.Show();
        }
    }
}
