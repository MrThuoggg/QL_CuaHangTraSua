using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using Mysqlx.Crud;
using System.Drawing;
using System.Globalization;

namespace QL_CuaHang.DAO
{
    internal class MenuDAO
    {

        // Hàm Format datagridView
        public static void FormatDataGridView(DataGridView grid, float fontSize = 10f)
        {
            if (grid == null) return;
            Font defaultFont = new Font("Segoe UI", fontSize, FontStyle.Regular);
            grid.DefaultCellStyle.Font = defaultFont;
            grid.DefaultCellStyle.Font = new Font(defaultFont, FontStyle.Bold);

            var vietCulture = new CultureInfo("vi-VN");
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        // Phần code hiển thị dữ liệu lên DataGridView của các UserControl
        public static DataTable ThongTinTraSua()
        {
            string sql = "select * from TraSua";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable ThongTinTopping()
        {
            string sql = "SELECT * FROM Topping";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable ThongTinNhanVien()
        {
            string sql = @"
        SELECT 
            nv.ID AS ID, 
            nv.TenNhanVien AS Tên, 
            nv.ChucVu AS Chức_Vụ, 
            FORMAT(ln.LuongCoBan, 0) AS Lương 
        FROM 
            NhanVien nv 
        JOIN 
            LuongNhanVien ln 
        ON 
            nv.ID = ln.IDNhanVien";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }

        public static DataTable LoadNhanVien()
        {
            string sql = "SELECT * FROM NhanVien";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }

        public static DataTable ThongTinHoaDon()
        {
            string sql = @"SELECT hd.MaHoaDon AS Ma_Hoa_Don, 
                   DATE_FORMAT(hd.NgayLap, '%d/%m/%Y') AS Ngay_Lap,
                   FORMAT(hd.TongTien, 0) AS Tong_Tien,
                   GROUP_CONCAT(CONCAT(t.TenTraSua, ' (SL: ', ct.SoLuong, ')', 
                       IFNULL(CONCAT(' - Topping: ',
                       (SELECT GROUP_CONCAT(TenTopping SEPARATOR ', ') 
                        FROM ChiTietTopping 
                        WHERE MaChiTietHoaDon = ct.ID)), '')) 
                   ORDER BY ct.ID SEPARATOR '\n') AS Chi_Tiet_Don_Hang,
                   FORMAT(SUM(ct.ThanhTien), 0) AS Thanh_Tien
                   FROM HoaDon hd
                   LEFT JOIN ChiTietHoaDon ct ON hd.MaHoaDon = ct.MaHoaDon
                   LEFT JOIN TraSua t ON ct.MaTraSua = t.MaTraSua
                   GROUP BY hd.MaHoaDon, hd.NgayLap, hd.TongTien
                   ORDER BY hd.NgayLap DESC, hd.MaHoaDon";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }

        public static DataTable ThongTinNguyenLieu()
        {
            string sql = @"
                        SELECT 
                            MaNguyenLieu, 
                            TenNguyenLieu, 
                            DonViTinh, 
                            GiaNhap, 
                            TonKho, 
                            TonKhoToiThieu,
                            IF(TonKho <= TonKhoToiThieu, 'Cảnh báo', 'Bình thường') AS TrangThai
                        FROM NguyenLieu
                        ORDER BY MaNguyenLieu ASC";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }

        public static DataTable HoaDonReport()
        {
            string sql = "Select * from HoaDon";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }


        // Phần code của UC Quản lý Đơn hàng
        public static void XoaDonHang(string maHoaDon)
        {

            string sqlChiTietHoaDon = "DELETE FROM ChiTietHoaDon WHERE MaHoaDon = @MaHoaDon";
            KetNoiCSDL.ThucThiTruyVan(sqlChiTietHoaDon, "@MaHoaDon", maHoaDon);

            string sqlHoaDon = "DELETE FROM HoaDon WHERE MaHoaDon = @MaHoaDon";
            KetNoiCSDL.ThucThiTruyVan(sqlHoaDon, "@MaHoaDon", maHoaDon);
        }


        public static void CapNhatDonHang(string maHoaDon, DateTime ngayMua)
        {
            //sau khi sửa lỗi
            string sql = "UPDATE HoaDon SET NgayLap = @NgayLap WHERE MaHoaDon = @MaHoaDon";
            KetNoiCSDL.ThucThiTruyVan(sql,
                "@NgayLap", ngayMua,
                "@MaHoaDon", maHoaDon?.Trim());
        }


        public static DataTable TimKiemHoaDonTheoMa(string maHoaDon)
        {
            if (string.IsNullOrWhiteSpace(maHoaDon))
                throw new ArgumentException("Mã hóa đơn không được để trống.");
            string sql = @"
    SELECT hd.MaHoaDon AS Ma_Hoa_Don, 
           DATE_FORMAT(hd.NgayLap, '%d/%m/%Y') AS Ngay_Lap,
           FORMAT(hd.TongTien, 0) AS Tong_Tien,
           COALESCE(hd.TenKhachHang, kh.TenKH) AS Ten_Khach_Hang,
           GROUP_CONCAT(CONCAT(t.TenTraSua, ' (SL: ', ct.SoLuong, ')', 
               IFNULL(CONCAT(' - Topping: ',
               (SELECT GROUP_CONCAT(TenTopping SEPARATOR ', ') 
                FROM ChiTietTopping 
                WHERE MaChiTietHoaDon = ct.ID)), '')) 
           ORDER BY ct.ID SEPARATOR '\n') AS Chi_Tiet_Don_Hang,
           FORMAT(SUM(ct.ThanhTien), 0) AS Thanh_Tien
    FROM HoaDon hd
    LEFT JOIN KhachHang kh ON hd.MaKH = kh.MaKH
    LEFT JOIN ChiTietHoaDon ct ON hd.MaHoaDon = ct.MaHoaDon
    LEFT JOIN TraSua t ON ct.MaTraSua = t.MaTraSua
    WHERE hd.MaHoaDon = @maHoaDon
    GROUP BY hd.MaHoaDon, hd.NgayLap, hd.TongTien, 
             COALESCE(hd.TenKhachHang, kh.TenKH)
    ORDER BY hd.NgayLap DESC, hd.MaHoaDon";
            DataTable dt = KetNoiCSDL.DocDuLieu(sql, new Dictionary<string, object> { { "@maHoaDon", maHoaDon } });
            return dt;
        }




        // Phần code của UC Quản lý Nhân viên
        public static DataTable IDNhanVienLonNhat()
        {
            string sql = "SELECT max(ID) As MaxIDNhanVien FROM nhanvien";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable LayTatCaIDNhanVien()
        {
            string sql = "SELECT ID FROM nhanvien ORDER BY ID";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }

        public static DataTable TimKiemNhanVienTheoID(string id)
        {


            // sau khi sửa lỗi
            if (!int.TryParse(id, out int idInt))
            {
                return new DataTable();
            }

            string sql = @"
        SELECT 
            nv.ID AS ID, 
            nv.TenNhanVien AS Tên, 
            nv.ChucVu AS Chức_Vụ, 
            FORMAT(ln.LuongCoBan, 0) AS Lương 
        FROM 
            NhanVien nv 
        JOIN 
            LuongNhanVien ln ON nv.ID = ln.IDNhanVien
        WHERE nv.ID = @ID";

            return KetNoiCSDL.DocDuLieu(sql, "@ID", idInt);
        }

        public static DataTable ThongTinChucVuNhanVien()
        {
            string sql = "SELECT DISTINCT ChucVu AS Chức_Vụ FROM NhanVien";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }

        public static void ThemNhanVien(int id, string tenNhanVien, string chucVu, decimal luongCoBan)
        {
            string sqlNhanVien = "INSERT INTO NhanVien (TenNhanVien, ChucVu) VALUES (@TenNhanVien, @ChucVu)";
            KetNoiCSDL.ThucThiTruyVan(sqlNhanVien, "@TenNhanVien", tenNhanVien, "@ChucVu", chucVu);

            string sqlLuong = "INSERT INTO LuongNhanVien (IDNhanVien, LuongCoBan) VALUES (LAST_INSERT_ID(), @LuongCoBan)";
            KetNoiCSDL.ThucThiTruyVan(sqlLuong, "@IDNhanVien", id, "@LuongCoBan", luongCoBan);
        }

        public static void CapNhatNhanVien(int id, string tenNhanVien, string chucVu, decimal luongCoBan)
        {
            string sqlNhanVien = "UPDATE NhanVien SET TenNhanVien = @TenNhanVien, ChucVu = @ChucVu WHERE ID = @ID";
            KetNoiCSDL.ThucThiTruyVan(sqlNhanVien, "@TenNhanVien", tenNhanVien, "@ChucVu", chucVu, "@ID", id);


            string sqlLuong = "UPDATE LuongNhanVien SET LuongCoBan = @LuongCoBan WHERE IDNhanVien = @ID";
            KetNoiCSDL.ThucThiTruyVan(sqlLuong, "@LuongCoBan", luongCoBan, "@ID", id);
        }

        public static void XoaNhanVien(int id)
        {
            string sqlLuong = "DELETE FROM LuongNhanVien WHERE IDNhanVien = @ID";
            KetNoiCSDL.ThucThiTruyVan(sqlLuong, "@ID", id);


            string sqlNhanVien = "DELETE FROM NhanVien WHERE ID = @ID";
            KetNoiCSDL.ThucThiTruyVan(sqlNhanVien, "@ID", id);
        }

        public static void ThemLuongNhanVien(int idNhanVien, decimal tongLuong)
        {
            string sql = "INSERT INTO LuongNhanVien (IDNhanVien, LuongCoBan) VALUES (@ID, @Luong)";
            KetNoiCSDL.ThucThiTruyVan(sql, "@ID", idNhanVien, "@Luong", tongLuong);
        }





        //Phần code của UC Quản lý nguyên liệu
        public static void ThemNguyenLieu(string ten, string donVi, decimal giaNhap, decimal tonKho, decimal tonKhoToiThieu)
        {
            string sql = @"
        INSERT INTO NguyenLieu (TenNguyenLieu, DonViTinh, GiaNhap, TonKho, TonKhoToiThieu)
        VALUES (@Ten, @DonVi, @GiaNhap, @TonKho, @TonKhoToiThieu)";
            KetNoiCSDL.ThucThiTruyVan(sql,
                "@Ten", ten, "@DonVi", donVi, "@GiaNhap", giaNhap,
                "@TonKho", tonKho, "@TonKhoToiThieu", tonKhoToiThieu);
        }


        public static void CapNhatNguyenLieu(int ma, string ten, string donVi, decimal giaNhap, decimal tonKho, decimal tonKhoToiThieu)
        {
            string sql = @"UPDATE NguyenLieu 
                          SET TenNguyenLieu = @Ten, DonViTinh = @DonVi, GiaNhap = @GiaNhap,
                          TonKho = @TonKho, TonKhoToiThieu = @TonKhoToiThieu
                          WHERE MaNguyenLieu = @Ma";
            KetNoiCSDL.ThucThiTruyVan(sql, 
                "@Ma", ma, "@Ten", ten, "@DonVi", donVi, "@GiaNhap", giaNhap,
                "@TonKho", tonKho, "@TonKhoToiThieu", tonKhoToiThieu);
        }

        public static void XoaNguyenLieu(int ma)
        {
            string sql = @"Delete from NguyenLieu Where MaNguyenLieu = @Ma";
            KetNoiCSDL.ThucThiTruyVan(sql, "@Ma", ma);
        }


        public static DataTable TimKiemNguyenLieu(string tuKhoa)
        {
            string sql = @"
                        SELECT 
                            MaNguyenLieu, 
                            TenNguyenLieu, 
                            DonViTinh, 
                            FORMAT(GiaNhap, 0) AS GiaNhap, 
                            TonKho, 
                            TonKhoToiThieu,
                            IF(TonKho <= TonKhoToiThieu, 'Cảnh báo', 'Bình thường') AS TrangThai
                        FROM NguyenLieu
                        WHERE TenNguyenLieu LIKE @TuKhoa
                        ORDER BY TenNguyenLieu";

            return KetNoiCSDL.DocDuLieu(sql, "@TuKhoa", "%" + tuKhoa + "%");
        }


        public static int LayMaNguyenLieu()
        {
            string sql = "SELECT COALESCE(MAX(MaNguyenLieu), 0) + 1 FROM NguyenLieu";
            object result = KetNoiCSDL.ThucThiTruyVanLayGiaTri(sql);
            if(result != null || result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }
            return 1;
        }

        // phần code của form thêm đồ uống

        public static DataTable LayDanhSachMaLoaiTra()
        {
            string sql = "SELECT DISTINCT MaLoaiTra FROM LoaiTra";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable MaTraSuaLonNhat()
        {
            string sql = "SELECT max(MaTraSua) As MaxMaTraSua FROM trasua";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }

        //hàm thêm trà sữa
        public static void ThemTraSua(int maTraSua, string tenTraSua, decimal gia, int maLoaiTra)
        {
            string sql = @"INSERT INTO TraSua (MaTraSua, TenTraSua, Gia, MaLoaiTra) VALUES (@MaTraSua, @TenTraSua, @Gia, @MaLoaiTra)";
            KetNoiCSDL.ThucThiTruyVan(sql,"@MaTraSua", maTraSua,"@TenTraSua", tenTraSua,"@Gia", gia,"@MaLoaiTra", maLoaiTra);
        }

        //hàm xóa 
        public static void XoaTraSua(int maTraSua)
        {
            string sql = "DELETE FROM TraSua WHERE MaTraSua = @MaTraSua";
            KetNoiCSDL.ThucThiTruyVan(sql, "@MaTraSua", maTraSua);
        }

        // hàm cập nhật
        public static void CapNhatTraSua(int maTraSua, string tenTraSua, decimal gia, int maLoaiTra)
        {
            string sql = @"UPDATE TraSua SET TenTraSua = @TenTraSua, Gia = @Gia, MaLoaiTra = @MaLoaiTra WHERE MaTraSua = @MaTraSua";
            KetNoiCSDL.ThucThiTruyVan(sql,"@MaTraSua", maTraSua,"@TenTraSua", tenTraSua,"@Gia", gia,"@MaLoaiTra", maLoaiTra);
        }



        //Phần code cho thêm topping 
        //Hàm thêm
        public static void ThemTopping(string tenTopping, decimal gia)
        {
            string sql = @"INSERT INTO Topping (TenTopping, Gia) VALUES (@TenTopping, @Gia)";
            KetNoiCSDL.ThucThiTruyVan(sql, "@TenTopping", tenTopping, "@Gia", gia);
        }

        //hàm xóa 
        public static void XoaTopping(string tenTopping)
        {
            string sql = @"DELETE FROM Topping WHERE TenTopping = @TenTopping";
            KetNoiCSDL.ThucThiTruyVan(sql, "@TenTopping", tenTopping);
        }





        // phần code cho in hóa đơn 
        //tạo ra 1 mã hoá đơn mới
        public static int LayMaHoaDonMoiNhat()
        {
            string sql = "SELECT MAX(MaHoaDon) FROM HoaDon";
            object result = KetNoiCSDL.ThucThiTruyVanLayGiaTri(sql);
            return result != DBNull.Value ? Convert.ToInt32(result) : 0;
        }




        // thêm vào CSDL với các dữ liệu đã lấy ra
        public static void ThemChiTietHoaDon(int maHoaDon, string tenTraSua, string tenTopping, int soLuong, decimal giaTraSua, decimal giaTopping)
        {
            string sqlGetMaTraSua = "SELECT MaTraSua FROM TraSua WHERE TenTraSua = @TenTraSua";
            object maTraSuaObj = KetNoiCSDL.ThucThiTruyVanLayGiaTri(sqlGetMaTraSua, "@TenTraSua", tenTraSua);
            if (maTraSuaObj == null || maTraSuaObj == DBNull.Value)
            {
                throw new Exception($"Không tìm thấy trà sữa với tên: {tenTraSua}");
            }
            int maTraSua = Convert.ToInt32(maTraSuaObj);

            string sqlChiTietHoaDon = @"INSERT INTO ChiTietHoaDon (MaHoaDon, MaTraSua, SoLuong, ThanhTien, NgayTao) 
                               VALUES (@MaHoaDon, @MaTraSua, @SoLuong, @ThanhTien, @NgayTao);
                               SELECT LAST_INSERT_ID();";

            decimal thanhTien = soLuong * (giaTraSua + giaTopping);
            object maChiTietHDObj = KetNoiCSDL.ThucThiTruyVanLayGiaTri(sqlChiTietHoaDon,
                "@MaHoaDon", maHoaDon,
                "@MaTraSua", maTraSua,
                "@SoLuong", soLuong,
                "@ThanhTien", thanhTien,
                "@NgayTao", DateTime.Now);

            //kiểm tra tên topping có rỗng không
            if (!string.IsNullOrEmpty(tenTopping))
            {
                int maChiTietHD = Convert.ToInt32(maChiTietHDObj);
                string[] danhSachTopping = tenTopping.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string topping in danhSachTopping)
                {
                    string toppingTrim = topping.Trim();
                    if (!string.IsNullOrEmpty(toppingTrim))
                    {
                        string sqlChiTietTopping = @"INSERT INTO ChiTietTopping (MaChiTietHoaDon, TenTopping) 
                                           VALUES (@MaChiTietHoaDon, @TenTopping)";
                        KetNoiCSDL.ThucThiTruyVan(sqlChiTietTopping,
                            "@MaChiTietHoaDon", maChiTietHD,
                            "@TenTopping", toppingTrim);
                    }
                }
            }
        }



        // lấy dữ liệu để in lên report
        // có kiểm tra kiểu dữ liệu
        public static DataTable LayDuLieuRseport(int maHoaDon)
        {
            string sql = @"SELECT 
        ts.TenTraSua,
        GROUP_CONCAT(DISTINCT ctt.TenTopping SEPARATOR ', ') as TenTopping,
        cthd.SoLuong,
        ts.Gia as GiaTraSua,
        SUM(IFNULL(tp.Gia, 0)) as GiaTopping,
        (cthd.SoLuong * (ts.Gia + SUM(IFNULL(tp.Gia, 0)))) as TongGia
    FROM ChiTietHoaDon cthd
    JOIN TraSua ts ON cthd.MaTraSua = ts.MaTraSua
    LEFT JOIN ChiTietTopping ctt ON cthd.ID = ctt.MaChiTietHoaDon
    LEFT JOIN Topping tp ON LOWER(TRIM(ctt.TenTopping)) = LOWER(TRIM(tp.TenTopping))
    WHERE cthd.MaHoaDon = @MaHoaDon
    AND cthd.NgayTao >= (
        SELECT MAX(NgayTao) 
        FROM ChiTietHoaDon 
        WHERE MaHoaDon = @MaHoaDon
    ) - INTERVAL 1 SECOND
    GROUP BY ts.TenTraSua, cthd.SoLuong, ts.Gia, cthd.ID";

            return KetNoiCSDL.DocDuLieu(sql, "@MaHoaDon", maHoaDon);
        }



        // phần code cho in hóa đơn chi tiết 
        public static DataTable HoaDonChiTietReport()
        {
            string sql = @"SELECT 
    hd.MaHoaDon AS MaHoaDon, 
    ts.TenTraSua AS TenTraSua, 
    ts.MaLoaiTra AS MaLoaiTra, 
    cthd.SoLuong AS SoLuong, 
    cthd.ThanhTien AS ThanhTien, 
    GROUP_CONCAT(ctt.TenTopping SEPARATOR ', ') AS DanhSachTopping
FROM 
    HoaDon hd
JOIN 
    ChiTietHoaDon cthd ON hd.MaHoaDon = cthd.MaHoaDon
JOIN 
    TraSua ts ON cthd.MaTraSua = ts.MaTraSua
LEFT JOIN 
    ChiTietTopping ctt ON ctt.MaChiTietHoaDon = cthd.ID
GROUP BY 
    hd.MaHoaDon, ts.TenTraSua, ts.MaLoaiTra, cthd.SoLuong, cthd.ThanhTien;";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }


        //Phần code cho in danh sách nhân viên
        public static DataTable ReportNhanVien()
        {
            string sql = @"
    SELECT 
        nv.ID AS ID, 
        nv.TenNhanVien AS Tên, 
        nv.ChucVu AS Chức_Vụ, 
        ln.LuongCoBan AS Lương_Cơ_Bản
    FROM 
        NhanVien nv 
    JOIN 
        LuongNhanVien ln 
    ON 
        nv.ID = ln.IDNhanVien";

            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }

















    }
}
