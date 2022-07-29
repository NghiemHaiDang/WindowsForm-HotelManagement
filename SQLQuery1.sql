CREATE DATABASE HotelManagement
GO

USE HotelManagement
GO 

-------------------- Tạo bảng ----------------------

-----Tạo Bảng Account------
CREATE TABLE Account
(
	userName nchar(100) NOT NULL PRIMARY KEY,
	displayName nvarchar(100) NOT NULL DEFAULT N'Account',
	[password] nchar(1000) NOT NULL,
	[type] int NOT NULL, -----1: Admin, 0: Staff----------
)
GO

----Tạo Bảng Loại Phòng--------
CREATE	TABLE RoomType
(
	id INT IDENTITY PRIMARY KEY,
	nameType nvarchar(100) NOT NULL,
	price INT NOT NULL,
)
GO

--Tạo Bảng Phòng------
CREATE TABLE Room
(
	id INT IDENTITY PRIMARY KEY,
	name nvarchar(100) NOT NULL,
	[status] BIT NOT NULL DEFAULT 0,
	idType INT NOT NULL REFERENCES RoomType (id)
)
GO

-------Tạo Bảng Dịch Vụ---------
CREATE TABLE [Service]
(
	id INT IDENTITY PRIMARY KEY,
	nameService nvarchar(100) NOT NULL,
	price INT NOT NULL,
)
GO

-------------Tạo bảng Khách hàng--------
CREATE TABLE Customer
(
	id INT IDENTITY PRIMARY KEY,
	name nvarchar(100) NOT NULL,
	addDate DATETIME NOT NULL,
	gender nvarchar(5) NOT NULL,
	[address] nvarchar(100),
	idCardNumber nchar(15) NOT NULL,
	phoneNumber Nchar(10)
)
GO


-----Tạo Bảng Bill-----
CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	customerId INT REFERENCES Customer(id),
	roomId INT REFERENCES Room(id),
	dateCheckIn Date NOT NULL DEFAULT GETDATE(),
	dateCheckOut Date,
	extraCharge INT NOT NULL DEFAULT 0,
	[status] BIT NOT NULL, ------1: Đã Thanh Toán, 0: Chưa Thanh Toán.
)
GO

------------Relationship------------
CREATE TABLE Bill_Service
(
	billID INT REFERENCES Bill(id),
	serviceID INT REFERENCES Service(id),
	[count] INT NOT NULL
)
GO
--------------Update dựa vào Bill - có bill là phòng có người
CREATE TRIGGER UTG_UpdatePhong
ON Bill FOR INSERT, UPDATE
AS
BEGIN 
	DECLARE @idRoom int
	SELECT @idRoom = roomId FROM Inserted

	Update Room SET Status = 1 WHERE id = @idRoom
END
GO
-------------Thanh toán bill thì phòng thành phòng trống
CREATE TRIGGER UTG_UpdateBill
ON Bill FOR UPDATE
AS
BEGIN 
	DECLARE @idBill int
	SELECT @idBill = id FROM Inserted
	DECLARE @idRoom int
	SELECT @idRoom = roomId FROM Bill WHERE id = @idBill
	DECLARE @count int = 0
	SELECT @count = COUNT(*) FROM Bill WHERE roomId = @idRoom and Status = 0
	if(@count = 0)
		Update Room SET Status = 0 where id = @idRoom
END
GO

---------------------------------------------------------------------------------------------------
------------------- Thêm dữ liệu vào bảng ------------

------------------- Thêm dữ liệu vào bảng RoomType ----------
SET IDENTITY_INSERT [dbo].[RoomType] ON
INSERT INTO RoomType ([id], [nameType], [price]) Values (1, N'Phòng VIP', 720000)
INSERT INTO RoomType ([id], [nameType], [price]) Values (2, N'Phòng thường', 120000)
INSERT INTO RoomType ([id], [nameType], [price]) Values (3, N'Phòng đôi', 180000)
INSERT INTO RoomType ([id], [nameType], [price]) Values (4, N'Phòng ba', 200000)
SET IDENTITY_INSERT [dbo].[RoomType] OFF
GO

--------------------------Thêm dữ liệu vào bảng phòng ------------------------
SET IDENTITY_INSERT [dbo].[Room] ON
INSERT INTO Room([id], [name], [Status], [idType]) Values (1, N'Phòng VIP 1', 0, 1)
INSERT INTO Room([id], [name], [Status], [idType]) Values (2, N'Phòng VIP 2', 0, 1)
INSERT INTO Room([id], [name], [Status], [idType]) Values (3, N'Phòng VIP 3', 0, 1)
INSERT INTO Room([id], [name], [Status], [idType]) Values (4, N'Phòng 10', 0, 2)
INSERT INTO Room([id], [name], [Status], [idType]) Values (5, N'Phòng 11', 0, 2)
INSERT INTO Room([id], [name], [Status], [idType]) Values (6, N'Phòng 12', 0, 2)
INSERT INTO Room([id], [name], [Status], [idType]) Values (7, N'Phòng 13', 0, 2)
INSERT INTO Room([id], [name], [Status], [idType]) Values (8, N'Phòng 14', 0, 2)
INSERT INTO Room([id], [name], [Status], [idType]) Values (9, N'Phòng 20', 0, 3)
INSERT INTO Room([id], [name], [Status], [idType]) Values (10, N'Phòng 21', 0, 3)
INSERT INTO Room([id], [name], [Status], [idType]) Values (11, N'Phòng 22', 0, 3)
INSERT INTO Room([id], [name], [Status], [idType]) Values (12, N'Phòng 23', 0, 3)
INSERT INTO Room([id], [name], [Status], [idType]) Values (13, N'Phòng 24', 0, 3)
INSERT INTO Room([id], [name], [Status], [idType]) Values (14, N'Phòng 31', 0, 4)
INSERT INTO Room([id], [name], [Status], [idType]) Values (15, N'Phòng 32', 0, 4)
INSERT INTO Room([id], [name], [Status], [idType]) Values (16, N'Phòng 33', 0, 4)
SET IDENTITY_INSERT [dbo].[Room] OFF
GO

----------------------Thêm dữ liệu vào bảng Service -------------------------
SET IDENTITY_INSERT [dbo].[Service] ON
INSERT INTO Service ([id], [nameService], [price]) Values (1, N'Café', 10000)
INSERT INTO Service ([id], [nameService], [price]) Values (2, N'Spa', 100000)
INSERT INTO Service ([id], [nameService], [price]) Values (3, N'Phòng họp', 120000)
INSERT INTO Service ([id], [nameService], [price]) Values (4, N'Fitness centre', 10000)
SET IDENTITY_INSERT [dbo].[Service] OFF
GO

--------------------------Thêm dữ liệu vào bảng Account--------------------
INSERT INTO Account ([userName], [displayName], [password], [type]) Values ('admin', N'ADMIN', 'admin', 1)
GO
INSERT INTO Account ([userName], [displayName], [password], [type]) Values ('sa', N'MANAGER', '123456', 0)
GO

--------------------------------------------------------------------------------------------------------
-------------------- STORED PROCEDURE  ---------------------

 -------Load đặt phòng
CREATE PROC USP_LoadDatPhong
@onlyNoPaid bit = 0
AS
	IF (@onlyNoPaid = 0)
		BEGIN
			SELECT r.name as roomName, c.name as customerName, c.idCardNumber as idCard, b.DateCheckIn as checkInTime, rt.NameType as roomType, rt.Price as price, CASE b.[status] WHEN 1 THEN N'Đã trả' ELSE N'Chưa trả' END as [status]
			FROM Room as r, RoomType as rt, Bill as b, Customer as c
			Where rt.id = r.idType and r.id = b.roomId and b.customerId = c.id
		END
	ELSE
		BEGIN
			SELECT r.name as roomName, c.name as customerName, c.idCardNumber as idCard, b.DateCheckIn as checkInTime, rt.NameType as roomType, rt.Price as price, CASE b.[status] WHEN 1 THEN N'Đã trả' ELSE N'Chưa trả' END as [status]
			FROM Room as r, RoomType as rt, Bill as b, Customer as c
			Where rt.id = r.idType and r.id = b.roomId and b.customerId = c.id and b.[status] = 0
		END
GO
---------Load khách hàng
CREATE PROC USP_LoadCustomer
AS
	SELECT id, name, addDate, gender, [address], idCardNumber as idNumber, PhoneNumber FROM Customer
GO
--------Đăng nhập tài khoản
CREATE PROCEDURE USP_Login
@userName nchar(100), @passWord nchar(1000)
AS
begin
	select * from Account where UserName = @userName and Password = @passWord
end
GO
-----Lấy ra phòng hiện tại
CREATE PROC USP_GetRoomList
AS
	SELECT Room.id, Room.name, Room.[status], RoomType.nameType as [Loại Phòng]
	FROM Room LEFT JOIN RoomType ON Room.idType = RoomType.id;
GO
--------Check Room's Bill
CREATE PROCEDURE USP_GetBillRoom
@roomId int
AS
begin
	SELECT s.NameService, bi.count, s.Price, s.Price * bi.count AS totalPrice 
	FROM Bill_Service AS bi, Bill AS b, Service AS s 
	WHERE bi.billID = b.id AND bi.serviceID = s.id AND b.Status = 0 AND b.roomId = @roomId
end
GO
-----------Thêm vào Bill_Service
CREATE PROCEDURE USP_AddBillService
@idBill int, @idService int, @intCount int
as
BEGIN
	
	DECLARE @BillId INT
	DECLARE @oldCount INT = 1
	SELECT @BillId = billID, @oldCount = count FROM Bill_Service 
	WHERE billID = @idBill and serviceID = @idService -- coi có BillId chưa và xem có dvu nào đã có trong bill chưa
	IF (@BillId > 0)
		BEGIN
			DECLARE @newCount int = @oldCount + @intCount
			IF(@newCount > 0)
				UPDATE Bill_Service SET count = @newCount WHERE serviceID = @idService and billID = @idBill
			ELSE
				DELETE Bill_Service WHERE billID = @idBill and serviceID = @idService -----ngược lại xoá billInfo 
		END
	ELSE
		BEGIN
			INSERT INTO Bill_Service ([billID], [serviceID], [count])
			VALUES (@idBill, @idService, @intCount)
		END
END
GO