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
    public partial class Form_ThemDoUong : Form
    {
        public Form_ThemDoUong()
        {
            InitializeComponent();
        }
        public void DanhSachTraSua()
        {
            DataTable dt = new DataTable();
            dt = MenuDAO.ThongTinTraSua();
            dgdanhsachtrasua.DataSource = dt;
        }
        public void DanhSachMaTraSua()
        {
            DataTable dt = new DataTable();
            dt = MenuDAO.LayDanhSachMaLoaiTra();
            cbmaloaitra.DataSource = dt;
            cbmaloaitra.DisplayMember = "MaLoaiTra";
            cbmaloaitra.ValueMember = "MaLoaiTra";
        }

        private void Form_ThemDoUong_Load(object sender, EventArgs e)
        {
            DanhSachMaTraSua();
            DanhSachTraSua();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                int maTraSua = int.Parse(txtmatrasua.Text);
                string tenTraSua = txttentrasua.Text.Trim();
                decimal gia = decimal.Parse(txtgianiemyet.Text);
                int maLoaiTra = (int)cbmaloaitra.SelectedValue;

                MenuDAO.ThemTraSua(maTraSua, tenTraSua, gia, maLoaiTra);
                MessageBox.Show("Thêm trà sữa thành công!", "Thông báo");
                DanhSachTraSua();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể thêm trà sữa!!");
            }
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btghi_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = MenuDAO.MaTraSuaLonNhat();
            string id = dt.Rows[0][0].ToString();
            if (string.IsNullOrEmpty(id))
                txtmatrasua.Text = "1";
            else
                txtmatrasua.Text = (int.Parse(id) + 1).ToString();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                int maTraSua = int.Parse(txtmatrasua.Text);

                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa trà sữa này?","Xác nhận",MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    MenuDAO.XoaTraSua(maTraSua);
                    MessageBox.Show("Xóa trà sữa thành công!", "Thông báo");
                    DanhSachTraSua();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa trà sữa!!", "Thông báo");
            }
        }

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                int maTraSua = int.Parse(txtmatrasua.Text);
                string tenTraSua = txttentrasua.Text.Trim();
                decimal gia = decimal.Parse(txtgianiemyet.Text);
                int maLoaiTra = (int)cbmaloaitra.SelectedValue;

                MenuDAO.CapNhatTraSua(maTraSua, tenTraSua, gia, maLoaiTra);
                MessageBox.Show("Cập nhật trà sữa thành công!", "Thông báo");
                DanhSachTraSua();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể cập nhật!!s", "Thông báo");
            }
        }

        private void btin_Click(object sender, EventArgs e)
        {
            Form_BaoCao_TraSua f = new Form_BaoCao_TraSua();
            f.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgdanhsachtrasua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgdanhsachtrasua.Rows[e.RowIndex];
                txtmatrasua.Text = row.Cells["MaTraSua"].Value.ToString();
                txttentrasua.Text = row.Cells["TenTraSua"].Value.ToString();
                txtgianiemyet.Text = row.Cells["Gia"].Value.ToString();
                cbmaloaitra.Text = row.Cells["MaLoaiTra"].Value.ToString();
            }
        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void txttentrasua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtgianiemyet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
