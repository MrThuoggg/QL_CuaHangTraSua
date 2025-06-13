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
    public partial class Form_ThemTopping : Form
    {
        public Form_ThemTopping()
        {
            InitializeComponent();
        }
        public void DanhSachTopping()
        {
            dgdanhsachtopping.DataSource = null;
            DataTable dt = MenuDAO.ThongTinTopping();
            dgdanhsachtopping.DataSource = dt;
        }
        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_ThemTopping_Load(object sender, EventArgs e)
        {
            DanhSachTopping();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                string tenTopping = txttentopping.Text.Trim();
                decimal gia = decimal.Parse(txtgia.Text.Trim());

                MenuDAO.ThemTopping(tenTopping, gia);
                MessageBox.Show("Thêm topping thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DanhSachTopping();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm topping!!! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            Form_BaoCao_Topping form_BaoCao_Topping = new Form_BaoCao_Topping();
            form_BaoCao_Topping.ShowDialog();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (dgdanhsachtopping.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string tenTopping = dgdanhsachtopping.SelectedRows[0].Cells["TenTopping"].Value.ToString();
            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa topping '{tenTopping}' không?","Xác nhận xóa",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    MenuDAO.XoaTopping(tenTopping);
                    MessageBox.Show("Xóa topping thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DanhSachTopping();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa topping!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Đã hủy thao tác xóa!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgdanhsachtopping_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgdanhsachtopping.Rows[e.RowIndex];
                txttentopping.Text = row.Cells["TenTopping"].Value.ToString();
                txtgia.Text = row.Cells["Gia"].Value.ToString();
            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttentopping_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
