CREATE DATABASE Quanlybenhnhan
GO

USE Quanlybenhnhan
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
	id INT IDENTITY PRIMARY KEY,
	[name] NVARCHAR(100),
	Trieuchung NVARCHAR(100),
)
CREATE TABLE Thuoc
(
	id INT IDENTITY PRIMARY KEY,
	[name] NVARCHAR(100),
	price FLOAT,
	idbenh INT,
	FOREIGN KEY (idbenh) REFERENCES dbo.Benh(id)
)
GO

CREATE TABLE Giuongbenh
(
	id INT IDENTITY PRIMARY KEY,
	[name] NVARCHAR(100),
	[status] NVARCHAR(100)   -- Trống|| Có người
)
GO

CREATE TABLE Khoa
(
	id INT IDENTITY PRIMARY KEY,
	[name] NVARCHAR(100),	
)
GO

CREATE TABLE Bacsi
(
	id INT IDENTITY PRIMARY KEY,
	[name] NVARCHAR(100),
	Khoa NVARCHAR(100),
	Chucvu NVARCHAR(100),
)
GO

CREATE TABLE Yta
(
	id INT IDENTITY PRIMARY KEY,
	[name] NVARCHAR(100),
	Khoa NVARCHAR(100),
	Chucvu NVARCHAR(100),
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	[name] NVARCHAR(100),
	Benh NVARCHAR(100),
	Thuoc NVARCHAR(100),
	DaTT FLOAT,
	ChuaTT FLOAT,
	[status] int, -- 1:đã thanh toán xong||0: chưa thanh toán xong
	idbenhnhan INT,
	idthuoc INT,
	FOREIGN KEY (idbenhnhan) REFERENCES dbo.Benhnhan(id),
	FOREIGN KEY (idthuoc) REFERENCES dbo.Thuoc(id)
)
GO

CREATE TABLE Benhnhan
(
	id INT IDENTITY PRIMARY KEY,
	MaBenhNhan NVARCHAR(50),
	[Name] NVARCHAR(100),
	idkhoa INT,
	idbacsi INT,
	idyta INT,
	CCCD NVARCHAR(20),
	NgaySinh DATE ,
	GioiTinh NVARCHAR(10),
	Phone NVARCHAR(20),
	BHYT NVARCHAR(100),
	idbenh INT,
	idgiuong INT,
	FOREIGN KEY (idkhoa) REFERENCES dbo.Khoa(id),
	FOREIGN KEY (idbacsi) REFERENCES dbo.Bacsi(id),
	FOREIGN KEY (idyta) REFERENCES dbo.Yta(id),
	FOREIGN KEY (idbenh) REFERENCES dbo.Khoa(Benh),
	FOREIGN KEY (idgiuong) REFERENCES dbo.Giuongbenh(id)
)
GO

CREATE TABLE Account
(
	Usename NVARCHAR(100),
	Displayname NVARCHAR(100),
	[Password] NVARCHAR(1000),
	[Type] INT --1:admin || 0:nhanvien
)
GO




