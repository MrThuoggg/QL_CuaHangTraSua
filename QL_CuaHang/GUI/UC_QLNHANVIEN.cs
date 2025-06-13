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
    public partial class UC_QLNHANVIEN : UserControl
    {
        public UC_QLNHANVIEN()
        {
            InitializeComponent();
        }
        private void DanhSachNhanVien()
        {
            DataTable dt = new DataTable();
            dt = MenuDAO.ThongTinNhanVien();
            dgdanhsachnhanvien.DataSource = dt;
        }
        public void DanhSachChucVu()
        {
            DataTable dt = new DataTable();
            dt = MenuDAO.ThongTinChucVuNhanVien();
            cbchucvu.DataSource = dt;
            cbchucvu.DisplayMember = "Chức_Vụ";
            cbchucvu.ValueMember = "Chức_Vụ";
        }
        private void UC_QLNHANVIEN_Load(object sender, EventArgs e)
        {
            DanhSachNhanVien();
            DanhSachChucVu();
        }

        private void gunaghi_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = MenuDAO.IDNhanVienLonNhat();
            string id = dt.Rows[0][0].ToString();
            if (string.IsNullOrEmpty(id))
                txtIDnhanvien.Text = "1";
            else
                txtIDnhanvien.Text = (int.Parse(id) + 1).ToString();
        }

        private void gunathem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = MenuDAO.IDNhanVienLonNhat();
                string id = dt.Rows[0][0].ToString();
                int idMoi = string.IsNullOrEmpty(id) ? 1 : int.Parse(id) + 1;
                DataTable dtTatCaID = MenuDAO.LayTatCaIDNhanVien(); 
                List<int> ids = new List<int>();
                foreach (DataRow row in dtTatCaID.Rows)
                    ids.Add(int.Parse(row["ID"].ToString()));
                while (ids.Contains(idMoi))
                    idMoi++;
                string ten = txttennhanvien.Text;
                string chucvu = cbchucvu.Text;
                decimal luong = decimal.Parse(txtluongnhanvien.Text);

                MenuDAO.ThemNhanVien(idMoi, ten, chucvu, luong);

                MessageBox.Show("Thêm nhân viên thành công");
                DanhSachNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm nhân viên thất bại!!");
            }
        }

        private void gunacapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgdanhsachnhanvien.SelectedRows.Count > 0)
                {
                    int id = int.Parse(dgdanhsachnhanvien.SelectedRows[0].Cells["ID"].Value.ToString());
                    string tenNhanVien = txttennhanvien.Text;
                    string chucVu = cbchucvu.Text;
                    decimal luongCoBan = decimal.Parse(txtluongnhanvien.Text);

                    MenuDAO.CapNhatNhanVien(id, tenNhanVien, chucVu, luongCoBan);

                    DanhSachNhanVien();

                    MessageBox.Show("Cập nhật thông tin thành công!");
                }
                else
                    MessageBox.Show("Vui lòng chọn một nhân viên cần cập nhật!");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cập nhật thông tin thất bại!");
            }
        }

        private void gunaxoa_Click(object sender, EventArgs e)
        {
            if (dgdanhsachnhanvien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!");
                return;
            }
            try
            {
                int id = int.Parse(dgdanhsachnhanvien.SelectedRows[0].Cells["ID"].Value.ToString());
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên với ID: {id} không?","Xác nhận xóa",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    MenuDAO.XoaNhanVien(id); 
                    DanhSachNhanVien();     
                    MessageBox.Show("Xóa nhân viên thành công!");
                }
                else
                    MessageBox.Show("Hành động xóa đã bị hủy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa nhân viên thất bại!");
            }
        }



        private void dgdanhsachnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgdanhsachnhanvien.Rows[e.RowIndex];
                txtIDnhanvien.Text = row.Cells["ID"].Value.ToString();
                txttennhanvien.Text = row.Cells["Tên"].Value.ToString();
                cbchucvu.Text = row.Cells["Chức_Vụ"].Value.ToString();
                txtluongnhanvien.Text = row.Cells["Lương"].Value.ToString();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form_BaoCaoNhanVien frm_baocaonhanvien = new Form_BaoCaoNhanVien();
            frm_baocaonhanvien.ShowDialog();

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            string id = txtNhapCanTim.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = MenuDAO.TimKiemNhanVienTheoID(id);

                if (dt.Rows.Count > 0)
                    dgdanhsachnhanvien.DataSource = dt;

                else
                    MessageBox.Show("Không tìm thấy nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DanhSachNhanVien();
        }

        private void bttinhluong_Click(object sender, EventArgs e)
        {
            Form_TinhLuongNV frm_tinhluong = new Form_TinhLuongNV();
            frm_tinhluong.ShowDialog();
        }

        private void txttennhanvien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtluongnhanvien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
                MessageBox.Show("Vui lòng nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNhapCanTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập mã số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtIDnhanvien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttennhanvien_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbchucvu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgdanhsachnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
