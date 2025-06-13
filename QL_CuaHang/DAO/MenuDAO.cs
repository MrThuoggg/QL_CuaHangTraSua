using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using Mysqlx.Crud;

namespace QL_CuaHang.DAO
{
    internal class MenuDAO
    {

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
                   GROUP BY hd.MaHoaDon, hd.NgayLap, hd.TongTien, 
                            COALESCE(hd.TenKhachHang, kh.TenKH)
                   ORDER BY hd.NgayLap DESC, hd.MaHoaDon";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }


        public static DataTable ThongTinKhachHang()
        {
            string sql = @"
    SELECT 
        hd.MaHoaDon AS 'Mã HD', 
        CASE 
            WHEN hd.TenKhachHang IS NULL THEN kh.TenKH 
            ELSE hd.TenKhachHang 
        END AS 'Tên Khách Hàng',
        DATE_FORMAT(hd.NgayLap, '%d/%m/%Y') AS 'Ngày Lập', 
        TRIM(TRAILING '.00' FROM FORMAT(hd.TongTien, 2)) AS 'Tổng Tiền'
    FROM HoaDon hd
    LEFT JOIN KhachHang kh ON hd.MaKH = kh.MaKH
    ORDER BY hd.NgayLap DESC, hd.MaHoaDon;
";
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

        // Phần code của UC Đơn hàng
        public static void XoaDonHang(string maHoaDon)
        {
            string sqlChiTietHoaDon = $"DELETE FROM ChiTietHoaDon WHERE MaHoaDon = '{maHoaDon}'";
            KetNoiCSDL.ThucThiTruyVan(sqlChiTietHoaDon);
            string sqlHoaDon = $"DELETE FROM HoaDon WHERE MaHoaDon = '{maHoaDon}'";
            KetNoiCSDL.ThucThiTruyVan(sqlHoaDon);
        }

        public static void CapNhatDonHang(string maHoaDon, string tenKhachHang, DateTime ngayMua)
        {
            string sql = $"UPDATE HoaDon SET TenKhachHang = '{tenKhachHang}', NgayLap = '{ngayMua:yyyy-MM-dd}' WHERE MaHoaDon = '{maHoaDon}'";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }

        //tìm kiếm đơn hàng
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




        // Phần code của UC Nhân viên
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

        //tìm kiếm
        public static DataTable TimKiemNhanVienTheoID(string id)
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
        nv.ID = ln.IDNhanVien
    WHERE 
        nv.ID = '" + id + @"'";

            DataTable dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }


        public static DataTable ThongTinChucVuNhanVien()
        {
            string sql = "SELECT DISTINCT ChucVu AS Chức_Vụ FROM NhanVien";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }

        //thêm
        public static void ThemNhanVien(int id, string tenNhanVien, string chucVu, decimal luongCoBan)
        {
            string sqlNhanVien = "INSERT INTO NhanVien (TenNhanVien, ChucVu) VALUES (@TenNhanVien, @ChucVu)";
            KetNoiCSDL.ThucThiTruyVan(sqlNhanVien, "@TenNhanVien", tenNhanVien, "@ChucVu", chucVu);

            string sqlLuong = "INSERT INTO LuongNhanVien (IDNhanVien, LuongCoBan) VALUES (LAST_INSERT_ID(), @LuongCoBan)";
            KetNoiCSDL.ThucThiTruyVan(sqlLuong, "@IDNhanVien", id, "@LuongCoBan", luongCoBan);
        }

        //cập nhật
        public static void CapNhatNhanVien(int id, string tenNhanVien, string chucVu, decimal luongCoBan)
        {
            string sqlNhanVien = "UPDATE NhanVien SET TenNhanVien = @TenNhanVien, ChucVu = @ChucVu WHERE ID = @ID";
            KetNoiCSDL.ThucThiTruyVan(sqlNhanVien, "@TenNhanVien", tenNhanVien, "@ChucVu", chucVu, "@ID", id);


            string sqlLuong = "UPDATE LuongNhanVien SET LuongCoBan = @LuongCoBan WHERE IDNhanVien = @ID";
            KetNoiCSDL.ThucThiTruyVan(sqlLuong, "@LuongCoBan", luongCoBan, "@ID", id);
        }

        //xóa
        public static void XoaNhanVien(int id)
        {
            string sqlLuong = "DELETE FROM LuongNhanVien WHERE IDNhanVien = @ID";
            KetNoiCSDL.ThucThiTruyVan(sqlLuong, "@ID", id);


            string sqlNhanVien = "DELETE FROM NhanVien WHERE ID = @ID";
            KetNoiCSDL.ThucThiTruyVan(sqlNhanVien, "@ID", id);
        }





        //Phần code của UC Khách hàng
        public static void ThemKhachHang(int maHoaDon, string tenKhachHang, DateTime ngayLap, decimal tongTien)
        {
            string sql = @"INSERT INTO HoaDon (MaHoaDon, TenKhachHang, NgayLap, TongTien) 
                   VALUES (@MaHoaDon, @TenKhachHang, @NgayLap, @TongTien);";
            KetNoiCSDL.ThucThiTruyVan(sql, "@MaHoaDon", maHoaDon, "@TenKhachHang", tenKhachHang, "@NgayLap", ngayLap, "@TongTien", tongTien);

        }


        public static void CapNhatKhachHang(int maHoaDon, string tenKhachHang, DateTime ngayLap, decimal tongTien)
        {
            string sql = @"UPDATE HoaDon SET TenKhachHang = @TenKhachHang,NgayLap = @NgayLap, TongTien = @TongTien WHERE MaHoaDon = @MaHoaDon;";

            KetNoiCSDL.ThucThiTruyVan(sql, "@MaHoaDon", maHoaDon, "@TenKhachHang", tenKhachHang, "@NgayLap", ngayLap, "@TongTien", tongTien);
        }

        public static void XoaKhachHang(int maHoaDon)
        {
            string sqlChiTiet = @"DELETE FROM ChiTietHoaDon WHERE MaHoaDon = @MaHoaDon;";
            KetNoiCSDL.ThucThiTruyVan(sqlChiTiet, "@MaHoaDon", maHoaDon);


            string sqlHoaDon = @"DELETE FROM HoaDon WHERE MaHoaDon = @MaHoaDon;";
            KetNoiCSDL.ThucThiTruyVan(sqlHoaDon, "@MaHoaDon", maHoaDon);
        }

        //tìm kiếm khách hàng
        public static DataTable TimKiemKhachHang(string tenKhachHang)
        {
            if (string.IsNullOrWhiteSpace(tenKhachHang))
                throw new ArgumentException("Tên khách hàng không được để trống.");

            string sql = @"
    SELECT 
        hd.MaHoaDon AS 'Mã HD', 
        CASE 
            WHEN hd.TenKhachHang IS NULL THEN kh.TenKH 
            ELSE hd.TenKhachHang 
        END AS 'Tên Khách Hàng',
        DATE_FORMAT(hd.NgayLap, '%d/%m/%Y') AS 'Ngày Lập', 
        TRIM(TRAILING '.00' FROM FORMAT(hd.TongTien, 2)) AS 'Tổng Tiền'
    FROM HoaDon hd
    LEFT JOIN KhachHang kh ON hd.MaKH = kh.MaKH
    WHERE CASE 
            WHEN hd.TenKhachHang IS NULL THEN kh.TenKH 
            ELSE hd.TenKhachHang 
          END LIKE CONCAT('%', @tenKhachHang, '%')
    ORDER BY hd.NgayLap DESC, hd.MaHoaDon";

            DataTable dt = KetNoiCSDL.DocDuLieu(sql, new Dictionary<string, object> { { "@tenKhachHang", tenKhachHang } });
            return dt;
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




        // Phần code cho form tính lương nhân viên
        // dùng để lưu lương nhân viên vừa tính vào database
        public static void ThemLuongNhanVien(int idNhanVien, decimal luongCoBan)
        {
            string sql = @"INSERT INTO LuongNhanVien (IDNhanVien, LuongCoBan) VALUES (@IDNhanVien, @LuongCoBan)";
            KetNoiCSDL.ThucThiTruyVan(sql, "@IDNhanVien", idNhanVien, "@LuongCoBan", luongCoBan);
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
        public static void ThemChiTietHoaDon(int maHoaDon, string tenTraSua, string tenTopping, int soLuong, decimal giaTraSua, decimal giaTopping, decimal tongGia)
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
        public static DataTable LayDuLieuReport(int maHoaDon)
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
