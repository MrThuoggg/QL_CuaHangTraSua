CREATE DATABASE ShopTraSua;
USE ShopTraSua;

CREATE TABLE LoaiTra (
    MaLoaiTra INT PRIMARY KEY,  
    TenLoai VARCHAR(50) NOT NULL 
);

INSERT INTO LoaiTra (MaLoaiTra, TenLoai) 
VALUES 
(1, 'Trà Sữa'),
(2, 'Hồng Trà'),
(3, 'Sữa Tươi'),
(4, 'Milo');

CREATE TABLE TraSua (
    MaTraSua INT PRIMARY KEY AUTO_INCREMENT,  
    TenTraSua VARCHAR(100) NOT NULL,  
    Gia DECIMAL(10, 2) NOT NULL,  
    MaLoaiTra INT, 
    FOREIGN KEY (MaLoaiTra) REFERENCES LoaiTra(MaLoaiTra)
);

CREATE TABLE Topping (
    TenTopping VARCHAR(50) PRIMARY KEY, 
    Gia DECIMAL(10, 2) NOT NULL  
);



CREATE TABLE KhachHang (
    MaKH INT PRIMARY KEY AUTO_INCREMENT,  
    TenKH VARCHAR(100) NOT NULL  
);

CREATE TABLE NGUOIDUNG (
    MaTK INT AUTO_INCREMENT PRIMARY KEY,  
    TenDangNhap VARCHAR(50),             
    MatKhau VARCHAR(20),                
    LoaiTK VARCHAR(20)
);
INSERT INTO NGUOIDUNG (TenDangNhap, MatKhau, LoaiTK) VALUES ('admin', 'admin', 'admin');
INSERT INTO NGUOIDUNG (TenDangNhap, MatKhau, LoaiTK) VALUES ('nhanvien', 'nhanvien', 'nhanvien');


DELIMITER $$ 
CREATE PROCEDURE proc_DS_dangnhap (
    IN tendn VARCHAR(50),  
    IN mkhau VARCHAR(20)  
)
BEGIN
    SELECT * FROM NGUOIDUNG 
    WHERE TenDangNhap = tendn AND MatKhau = mkhau;
END $$
DELIMITER ;

CALL proc_DS_dangnhap('admin', 'admin');


INSERT INTO KhachHang (TenKH) 
VALUES ('Nguyen Van A'), ('Tran Thi B'),
('Tran Minh C'), ('Le Van D');


CREATE TABLE NhanVien (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    TenNhanVien VARCHAR(255) NOT NULL,
    ChucVu VARCHAR(255)
);

CREATE TABLE DiemDanh (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    IDNhanVien INT,
    NgayDiemDanh DATE,
    TrangThai ENUM('CoMat', 'Vang'),
    FOREIGN KEY (IDNhanVien) REFERENCES NhanVien(ID)
);


CREATE TABLE LuongNhanVien (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    IDNhanVien INT,
    LuongCoBan DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (IDNhanVien) REFERENCES NhanVien(ID)
);
select * from luongnhanvien;
CREATE TABLE HoaDon (
    MaHoaDon INT AUTO_INCREMENT PRIMARY KEY,
    NgayLap DATE NOT NULL,
    TongTien DECIMAL(10, 2) NOT NULL,
    TenKhachHang VARCHAR(255),
	MaKH INT, 
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)  
);



CREATE TABLE ChiTietHoaDon (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    MaHoaDon INT,
    MaTraSua INT, 
    SoLuong INT NOT NULL,
    ThanhTien DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),
    FOREIGN KEY (MaTraSua) REFERENCES TraSua(MaTraSua) 
);
ALTER TABLE ChiTietHoaDon
ADD CONSTRAINT fk_chitiethoadon_hoadon
FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon)
ON DELETE CASCADE;


ALTER TABLE ChiTietHoaDon
ADD COLUMN NgayTao DATETIME DEFAULT CURRENT_TIMESTAMP;


CREATE TABLE ChiTietTopping (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    MaChiTietHoaDon INT,
    TenTopping VARCHAR(50),
    FOREIGN KEY (MaChiTietHoaDon) REFERENCES ChiTietHoaDon(ID),
    FOREIGN KEY (TenTopping) REFERENCES Topping(TenTopping)
);

INSERT INTO TraSua (TenTraSua, Gia, MaLoaiTra) VALUES
('Trà sữa fulltopping (ngọt sẵn)', 25000, 1),
('Trà sữa thái xanh fulltoping', 30000, 1),
('Trà sữa thái đỏ fulltoping', 30000, 1),
('Trà sữa olong fulltopping (ít ngọt)', 30000, 1),
('Trà sữa đậu đậu (ko topping - ngọt)', 20000, 1),
('Trà sữa thái xanh (kèm tchâu)', 20000, 1),
('Trà sữa thái đỏ (kèm tchâu)', 20000, 1),
('Trà sữa bạc hà (kèm tchâu)', 20000, 1),
('Trà sữa dâu (kèm tchâu)', 20000, 1),
('Trà sữa táo', 20000, 1),
('Trà sữa đào', 20000, 1),
('Trà sữa socola (kèm tchâu)', 20000, 1),
('Trà sữa khoai môn (kèm tchâu)', 20000, 1),
('Trà sữa matcha (kèm tchâu)', 20000, 1),
('Trà sữa việt quất (kèm tchâu)', 20000, 1),
('Trà sữa phúc bồn tử (kèm tchâu)', 20000, 1),
('Trà sữa hạnh nhân', 20000, 1),
('Trà sữa olong (ít ngọt)', 20000, 1),
('Trà sữa olong lải (ít ngọt)', 20000, 1),
('Trà sữa milkfoam oreo', 20000, 1),
('Trà sữa milkfoam', 20000, 1),
('Trà sữa kem phô mai mặn', 25000, 1),
('Trà sữa trứng nướng', 25000, 1),
('Trà sữa socola milkfoam', 20000, 1),
('Trà sữa matcha milkfoam', 20000, 1),
('Trà sữa phô mai tươi', 20000, 1),
('Trà sữa siêu phô mai', 20000, 1),
('Trà sữa full khúc bạch', 30000, 1),
('Trà sữa full phô mai viên', 30000, 1);

INSERT INTO TraSua (TenTraSua, Gia, MaLoaiTra) VALUES
('Hồng trà', 10000, 2),
('Hồng trà trân châu', 15000, 2),
('Hồng trà táo', 15000, 2),
('Hồng trà đào', 15000, 2),
('Hồng trà tắc trân châu', 15000, 2),
('Hồng trà kem chesse', 15000, 2),
('Hồng trà sữa', 20000, 2),
('Hồng trà củ năng, trân châu', 20000, 2),
('Hồng trà fulltopping', 20000, 2),
('Hồng trà phô mai viên (6 viên)', 20000, 2);

INSERT INTO TraSua (TenTraSua, Gia, MaLoaiTra) VALUES
('Sữa tươi tchâu đường đen', 15000, 3),
('Sữa tươi tchâu đường đen milkfoam', 15000, 3),
('Sữa tươi tchâu đường đen kem trứng khè', 15000, 3),
('Sữa tươi bạc hà', 15000, 3),
('Sữa tươi socola', 15000, 3),
('Sâm dứa sữa', 15000, 3);

INSERT INTO TraSua (TenTraSua, Gia, MaLoaiTra) VALUES
('Milo dằm', 15000, 4),
('Milo dằm trân châu', 20000, 4),
('Milo dằm bánh plan', 20000, 4),
('Milo dằm trân châu + bánh plan', 25000, 4);

INSERT INTO Topping (TenTopping, Gia) VALUES
('Trân Châu Đen', 5000),
('Trân Châu Olong', 5000),
('Trân Châu Trắng Giòn', 5000),
('Trân Châu Cá Nâng', 5000),
('Trân Châu Khoai Môn', 5000),
('Bánh Flan', 6000),
('Kem Cheese', 5000),
('Kem Phô Mai Mặn', 5000),
('Rau Câu Phô mai', 5000),
('Rau Câu Thái Đỏ', 5000),
('Lava Trứng Muối', 5000),
('Phô Mai Viên', 5000),
('Khoai Dẻo', 5000),
('Khoai Dẻo Phô Mai', 5000),
('Cheese Ball', 6000),
('Khúc Bạch Táng', 5000),
('Phô Mai Mặn', 5000),
('Phô Mai Tươi', 5000),
('Khúc Bạch Matcha', 5000),
('Chân Mèo', 8000),
('Donut (mặn-matcha)', 10000),
('Donut Việt Quốc', 14000),
('Donut Chanh Dây', 14000),
('Donut Dâu', 14000),
('Donut Ổi', 14000),
('Pudding Dưa Lưới', 5000),
('Pudding Trứng', 5000),
('Pudding Khoai môn', 5000),
('Pudding Socola', 5000);


INSERT INTO NhanVien (TenNhanVien, ChucVu) VALUES
('Đỗ Minh Thường', 'Nhân viên pha chế'),
('Trần Minh Hưng', 'Nhân viên phục vụ');

SELECT nv.ID AS ID, nv.TenNhanVien AS Tên, nv.ChucVu AS Chức_Vụ, FORMAT(ln.LuongCoBan, 0) AS Lương FROM NhanVien nv JOIN LuongNhanVien ln ON nv.ID = ln.IDNhanVien;





INSERT INTO LuongNhanVien (IDNhanVien, LuongCoBan) VALUES
(1, 5000000),
(2, 4500000);

INSERT INTO HoaDon (NgayLap, TongTien, TenKhachHang) VALUES
('2024-09-22', 90000, 'Trần Thị B'),
('2024-09-22', 120000, 'Nguyễn Văn D'),
('2024-10-15', 115000, 'Tran Minh C'),
('2024-11-03', 98000, 'Le Van D')
;

INSERT INTO ChiTietHoaDon (MaHoaDon, MaTraSua, SoLuong, ThanhTien) VALUES
(1, 1, 2, 50000),
(1, 2, 1, 40000),
(2, 3, 2, 70000),
(2, 1, 1, 50000),
(3, 1, 3, 90000),  
(4, 3, 4, 120000),
(5, 4, 4, 115000),
(6, 5, 4, 98000);

INSERT INTO ChiTietTopping (MaChiTietHoaDon, TenTopping) VALUES
(1, 'Trân Châu Đen'),
(1, 'Kem Cheese'),
(1, 'Bánh Flan'),
(1, 'Trân Châu Olong'),
(5, 'Trân Châu Đen'),
(5, 'Bánh Flan'),
(6, 'Trân Châu Đen'),
(6, 'Kem Cheese'),
(7, 'Trân Châu Olong'),
(7, 'Bánh Flan'),
(8, 'Trân Châu Đen'),
(8, 'Kem Cheese');


SELECT max(MaTraSua) As MaxMaTraSua FROM trasua;

SELECT 
    nv.ID AS 'Mã Nhân Viên', 
    nv.TenNhanVien AS 'Tên Nhân Viên', 
    ln.LuongCoBan AS 'Lương Cơ Bản'
FROM 
    NhanVien nv
JOIN 
    LuongNhanVien ln ON nv.ID = ln.IDNhanVien;



select * from hoadon;
select * from chitiethoadon where MaHoaDon = '7';
select * from nhanvien where ID = '2';
select * from hoadon where TenKhachHang = 'Tran Minh Hung';


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
            WHERE hd.MaHoaDon = '3'
            GROUP BY hd.MaHoaDon, hd.NgayLap, hd.TongTien, 
                     COALESCE(hd.TenKhachHang, kh.TenKH)
            ORDER BY hd.NgayLap DESC, hd.MaHoaDon;






SELECT 
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
    hd.MaHoaDon, ts.TenTraSua, ts.MaLoaiTra, cthd.SoLuong, cthd.ThanhTien;







INSERT INTO Topping (MaTopping, TenTopping) VALUES ('Mã bị thiếu', 'Tên topping');

CREATE USER 'username'@'%' IDENTIFIED BY 'password';
GRANT ALL PRIVILEGES ON *.* TO 'username'@'%';
FLUSH PRIVILEGES;

select max(ID) As MaxIDNhanVien from nhanvien;

select * from nhanvien;
SELECT DISTINCT ChucVu FROM NhanVien;
ALTER TABLE NhanVien AUTO_INCREMENT = 3;

DELETE FROM LuongNhanVien WHERE IDNhanVien IN (7);
DELETE FROM NhanVien WHERE ID IN (7);



SELECT DISTINCT Topping
FROM ChiTietTopping
WHERE Topping NOT IN (SELECT TenTopping FROM Topping);

SELECT COUNT(*) FROM Topping WHERE TenTopping = @TenTopping;


DESCRIBE ChiTietHoaDon;
SHOW COLUMNS FROM ChiTietHoaDon;

SELECT DISTINCT ct.TenTopping
FROM ChiTietTopping ct
LEFT JOIN Topping t ON ct.TenTopping = t.TenTopping
WHERE t.TenTopping IS NULL;

select * from NhanVien;
SELECT max(ID) As MaxIDNhanVien FROM nhanvien;
SHOW TABLE STATUS LIKE 'NhanVien';
ALTER TABLE NhanVien AUTO_INCREMENT = 3;  


















