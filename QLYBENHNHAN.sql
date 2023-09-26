USE QLYBENHNHAN
GO

-- Benhnhan
-- Benh
--Thuoc
-- Guongbenh
-- Khoa
-- Bacsi
-- Yta
-- Bill


CREATE TABLE Benh
(
	MaBenh INT PRIMARY KEY,
	[name] NVARCHAR(100),
	Trieuchung NVARCHAR(100),
)
GO

CREATE TABLE Thuoc
(
	MaThuoc INT PRIMARY KEY,
	[name] NVARCHAR(100),
	price FLOAT,
	MaBenh INT,
	FOREIGN KEY (MaBenh) REFERENCES dbo.Benh(MaBenh)
)
GO

CREATE TABLE Giuongbenh
(
	MaGiuong INT PRIMARY KEY,
	[name] NVARCHAR(100),
	[status] NVARCHAR(100)   -- Trống|| Có người
)
GO

CREATE TABLE Khoa
(
	MaKhoa INT PRIMARY KEY,
	[name] NVARCHAR(100),	
)
GO

CREATE TABLE Bacsi
(
	MaBacSi INT PRIMARY KEY,
	[name] NVARCHAR(100),
	MaKhoa INT,
	Chucvu NVARCHAR(100),
	FOREIGN KEY (MaKhoa) REFERENCES dbo.Khoa(MaKhoa)
)
GO

CREATE TABLE Yta
(
	MaYTa INT PRIMARY KEY,
	[name] NVARCHAR(100),
	MaKhoa INT,
	Chucvu NVARCHAR(100),
	FOREIGN KEY (MaKhoa) REFERENCES dbo.Khoa(MaKhoa)
)
GO

CREATE TABLE Benhnhan
(
	MaBenhNhan INT PRIMARY KEY,
	[Name] NVARCHAR(100),
	CCCD NVARCHAR(20),
	NgaySinh DATE ,
	GioiTinh NVARCHAR(10),
	Phone NVARCHAR(20),
	BHYT NVARCHAR(100),
	NgayNhapVien Date,
	NgayRaVien Date,
	MaKhoa INT,
	MaBacSi INT,
	MaYTa INT,
	MaBenh INT,
	MaGiuong INT,
	FOREIGN KEY (MaKHoa) REFERENCES dbo.Khoa(MaKHoa),
	FOREIGN KEY (MaBenh) REFERENCES dbo.Benh(MaBenh),
	FOREIGN KEY (MaGiuong) REFERENCES dbo.Giuongbenh(MaGiuong),
	FOREIGN KEY (MaBacSi) REFERENCES dbo.Bacsi(MaBacSi),
	FOREIGN KEY (MaYTa) REFERENCES dbo.Yta(MaYTa)
)
GO
CREATE TABLE HoaDon
(
	MaHoaDon INT PRIMARY KEY,
	DaTT FLOAT,
	ChuaTT FLOAT,
	[status] int, -- 1:đã thanh toán xong||0: chưa thanh toán xong
	MaBenhNhan INT,
	FOREIGN KEY (MaBenhNhan) REFERENCES dbo.Benhnhan(MaBenhNhan),
)
GO

CREATE TABLE Account
(
	TenDangNhap NVARCHAR(100),
	TenHienThi NVARCHAR(100),
	MatKhau NVARCHAR(1000),
)
GO




