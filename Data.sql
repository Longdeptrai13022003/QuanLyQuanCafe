CREATE DATABASE QuanLyQuanCafe
GO
USE QuanLyQuanCafe
GO	

CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa có tên',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống'
)
GO

CREATE TABLE Account
(
	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Long',
	UserName NVARCHAR(100) PRIMARY KEY NOT NULL,
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL DEFAULT 0
)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0

	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO	

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL,
	DateCheckOut DATE,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0

	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO	

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0

	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)
GO	

INSERT INTO dbo.Account
(
    DisplayName,
    UserName,
    PassWord,
    Type
)
VALUES
(   N'Trần Đức Long', -- DisplayName - nvarchar(100)
    N'tranduclong1302', -- UserName - nvarchar(100)
    N'long1302', -- PassWord - nvarchar(1000)
    1    -- Type - int
    )
INSERT INTO dbo.Account
(
    DisplayName,
    UserName,
    PassWord,
    Type
)
VALUES
(   N'staff', -- DisplayName - nvarchar(100)
    N'12345', -- UserName - nvarchar(100)
    N'12345', -- PassWord - nvarchar(1000)
    0    -- Type - int
    )
SELECT * FROM dbo.Account

CREATE PROC USP_GetAccountByUserName
@userName nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName=@userName
END
GO
EXEC dbo.USP_GetAccountByUserName @userName=N'tranduclong1302'
GO 
select * from dbo.Account where UserName=N'12345' and PassWord=N'12345'
GO 

CREATE PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName=@userName AND PassWord=@passWord
END
GO 

DECLARE @i INT = 21
WHILE @i<=24
BEGIN
	INSERT INTO dbo.TableFood ( name ) VALUES (N'Bàn '+ CAST(@i AS NVARCHAR(100)))
	SET @i=@i+1
END
GO 

CREATE PROC USP_GetTableList
AS SELECT * FROM dbo.TableFood
GO	

EXEC dbo.USP_GetTableList

--thêm category
INSERT dbo.FoodCategory
(
    name
)
VALUES
(N'Cà phê phin' -- name - nvarchar(100)
    )
INSERT dbo.FoodCategory
(
    name
)
VALUES
(N'PhinDi' -- name - nvarchar(100)
    )
INSERT dbo.FoodCategory
(
    name
)
VALUES
(N'Espresso' -- name - nvarchar(100)
    )
INSERT dbo.FoodCategory
(
    name
)
VALUES
(N'Trà' -- name - nvarchar(100)
    )
INSERT dbo.FoodCategory
(
    name
)
VALUES
(N'Bánh' -- name - nvarchar(100)
    )
INSERT dbo.FoodCategory
(
    name
)
VALUES
(N'Freeze' -- name - nvarchar(100)
    )
INSERT dbo.FoodCategory
(
    name
)
VALUES
(N'Món khác' -- name - nvarchar(100)
    )
--thêm món 
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Phin sữa đá', -- name - nvarchar(100)
    1,   -- idCategory - int
    45000  -- price - float
    )
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Phin đen đá', -- name - nvarchar(100)
    1,   -- idCategory - int
    39000  -- price - float
    )
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Bạc xỉu', -- name - nvarchar(100)
    1,   -- idCategory - int
    45000  -- price - float
    )
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'PhinDi hạnh nhân', -- name - nvarchar(100)
    2,   -- idCategory - int
    55000  -- price - float
    )
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'PhinDi kem sữa', -- name - nvarchar(100)
    2,   -- idCategory - int
    55000  -- price - float
    )
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'PhinDi Choco', -- name - nvarchar(100)
    2,   -- idCategory - int
    55000  -- price - float
    )
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Espresso/Americano', -- name - nvarchar(100)
    3,   -- idCategory - int
    55000  -- price - float
    )
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Cappuccino/Latte', -- name - nvarchar(100)
    3,   -- idCategory - int
    79000  -- price - float
    )
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Mocha/Caramel Macchiato', -- name - nvarchar(100)
    3,   -- idCategory - int
    85000  -- price - float
    )
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Trà sen vàng', -- name - nvarchar(100)
    4,   -- idCategory - int
    65000  -- price - float
    )
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Trà thạch đào', -- name - nvarchar(100)
    4,   -- idCategory - int
    65000  -- price - float
    )
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Trà xanh đậu đỏ', -- name - nvarchar(100)
    4,   -- idCategory - int
    65000  -- price - float
    )
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Bánh chuối', -- name - nvarchar(100)
    5,   -- idCategory - int
    35000  -- price - float
    )
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Bánh phomai chanh dây', -- name - nvarchar(100)
    5,   -- idCategory - int
    35000  -- price - float
    )
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Tiramisu', -- name - nvarchar(100)
    5,   -- idCategory - int
    35000  -- price - float
    )
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Mousse Cacao', -- name - nvarchar(100)
    5,   -- idCategory - int
    35000  -- price - float
    )
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Mousse Đào', -- name - nvarchar(100)
    5,   -- idCategory - int
    35000  -- price - float
    )
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Mousse trà xanh', -- name - nvarchar(100)
    5,   -- idCategory - int
    35000  -- price - float
    )
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Mousse phomai caramel', -- name - nvarchar(100)
    5,   -- idCategory - int
    35000  -- price - float
    )
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Socola Highlands', -- name - nvarchar(100)
    5,   -- idCategory - int
    35000  -- price - float
    )
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Freeze trà xanh', -- name - nvarchar(100)
    6,   -- idCategory - int
    69000  -- price - float
    )
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Caramel phin freeze', -- name - nvarchar(100)
    6,   -- idCategory - int
    69000  -- price - float
    )
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Cookies & Cream', -- name - nvarchar(100)
    6,   -- idCategory - int
    69000  -- price - float
    )
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Freeze socola', -- name - nvarchar(100)
    6,   -- idCategory - int
    69000  -- price - float
    )
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Chanh đá xay', -- name - nvarchar(100)
    7,   -- idCategory - int
    55000  -- price - float
    )
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Chanh dây đá viên', -- name - nvarchar(100)
    7,   -- idCategory - int
    55000  -- price - float
    )
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Socola nóng/đá', -- name - nvarchar(100)
    7,   -- idCategory - int
    65000  -- price - float
    )
--thêm bill
INSERT INTO dbo.Bill
(
    DateCheckIn,
    DateCheckOut,
    idTable,
    status
)
VALUES
(   GETDATE(), -- DateCheckIn - date
    NULL, -- DateCheckOut - date
    1,         -- idTable - int
    0          -- status - int
    )
INSERT INTO dbo.Bill
(
    DateCheckIn,
    DateCheckOut,
    idTable,
    status
)
VALUES
(   GETDATE(), -- DateCheckIn - date
    NULL, -- DateCheckOut - date
    2,         -- idTable - int
    0          -- status - int
    )
INSERT INTO dbo.Bill
(
    DateCheckIn,
    DateCheckOut,
    idTable,
    status
)
VALUES
(   GETDATE(), -- DateCheckIn - date
    GETDATE(), -- DateCheckOut - date
    2,         -- idTable - int
    1          -- status - int
    )
--thêm billInfor
INSERT INTO dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   1, -- idBill - int
    1, -- idFood - int
    2  -- count - int
    )
INSERT INTO dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   1, -- idBill - int
    3, -- idFood - int
    4  -- count - int
    )
INSERT INTO dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   1, -- idBill - int
    5, -- idFood - int
    1  -- count - int
    )
INSERT INTO dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   2, -- idBill - int
    6, -- idFood - int
    2  -- count - int
    )
INSERT INTO dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   3, -- idBill - int
    5, -- idFood - int
    2  -- count - int
    )
GO	
SELECT * FROM dbo.TableFood
SELECT * FROM dbo.Food
SELECT *FROM dbo.FoodCategory
SELECT * FROM dbo.Bill
SELECT * FROM dbo.BillInfo

SELECT id FROM dbo.Bill WHERE idTable=3 AND status=1

SELECT * FROM dbo.BillInfo WHERE idBill=3

SELECT f.name, bi.count, f.price, f.price*bi.count AS TotalPrice FROM dbo.BillInfo AS bi, dbo.Bill AS b, dbo.Food AS f
WHERE bi.idBill=b.id AND bi.idFood=f.id AND b.idTable=2
GO 

CREATE PROC USP_InsertBill
@idTable int
AS
BEGIN
INSERT INTO dbo.Bill
(
    DateCheckIn,
    DateCheckOut,
    idTable,
    status,
	discount
)
VALUES
(   GETDATE(), -- DateCheckIn - date
    NULL, -- DateCheckOut - date
    @idTable,         -- idTable - int
    0,          -- status - int
    0
	)
END
GO 

CREATE PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN
	DECLARE @isExistBillInfo INT
	DECLARE @foodCount INT = 1
	SELECT @isExistBillInfo = id, @foodCount=b.count FROM dbo.BillInfo AS b WHERE idBill=@idBill AND idFood=@idFood

	IF(@isExistBillInfo>0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF(@newCount>0)
			UPDATE dbo.BillInfo SET count = @foodCount+@count WHERE idFood=@idFood
		ELSE
			DELETE dbo.BillInfo WHERE idBill=@idBill AND idFood=@idFood
		
	END
	ELSE 
		BEGIN
			INSERT INTO dbo.BillInfo
	(
	    idBill,
	    idFood,
	    count
	)
	VALUES
	(   @idBill, -- idBill - int
	    @idFood, -- idFood - int
	    @count  -- count - int
	    )
		
	END
END
GO	

UPDATE dbo.Bill SET status=1 WHERE id=1

CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE 
AS
BEGIN
	DECLARE @idBill INT

	SELECT @idBill = idBill FROM Inserted

	DECLARE @idTable INT

	SELECT @idTable = idTable FROM dbo.Bill WHERE id=@idBill AND status=0

	
		UPDATE dbo.TableFood SET status=N'Có người' WHERE id=@idTable
	
		
END
GO 




CREATE TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT

	SELECT @idBill=id FROM Inserted

	DECLARE @idTable INT

	SELECT @idTable = idTable FROM dbo.Bill WHERE id=@idBill

	DECLARE @count INT=0

	SELECT @count = COUNT(*) FROM dbo.Bill WHERE idTable=@idTable AND status=0

	IF(@count=0)
		UPDATE dbo.TableFood SET status=N'Trống' WHERE id=@idTable
END 
GO

DELETE dbo.BillInfo
DELETE dbo.Bill

ALTER TABLE dbo.Bill ADD discount INT 

UPDATE dbo.Bill SET discount=0
GO 

CREATE PROC USP_SwitchTable
@idTable1 INT, @idTable2 INT
AS BEGIN
	DECLARE @idFirstBill INT
	DECLARE @idSecondBill INT

	SELECT @idSecondBill = id FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
	SELECT @idFirstBill = id FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0

	IF(@idFirstBill IS NULL)
	BEGIN
		INSERT INTO dbo.Bill
		(
		    DateCheckIn,
		    DateCheckOut,
		    idTable,
		    status
		)
		VALUES
		(   GETDATE(), -- DateCheckIn - date
		    NULL, -- DateCheckOut - date
		    @idTable1,         -- idTable - int
		    0          -- status - int
		    )
		SELECT @idFirstBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id=@idTable2
	END

	IF(@idSecondBill IS NULL)
	BEGIN
		INSERT INTO dbo.Bill
		(
		    DateCheckIn,
		    DateCheckOut,
		    idTable,
		    status
		)
		VALUES
		(   GETDATE(), -- DateCheckIn - date
		    NULL, -- DateCheckOut - date
		    @idTable2,         -- idTable - int
		    0          -- status - int
		    )
		SELECT @idSecondBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id=@idTable1
	END

	SELECT id INTO IDBillInfoTable FROM dbo.BillInfo WHERE idBill=@idSecondBill

	UPDATE dbo.BillInfo SET idBill=@idSecondBill WHERE idBill=@idFirstBill

	UPDATE dbo.BillInfo SET idBill=@idFirstBill WHERE id IN (SELECT * FROM dbo.IDBillInfoTable)

	DROP TABLE dbo.IDBillInfoTable
END
GO 

ALTER TABLE dbo.Bill ADD totalPrice FLOAT 

GO 


CREATE PROC USP_GetListBillByDate
@checkIn date, @checkOut date
AS
BEGIN
	SELECT t.name AS [Tên bàn], b.totalPrice AS [Tổng tiền], DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày ra], discount AS [Giảm giá]
	FROM dbo.Bill AS b, dbo.TableFood AS t 
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable
END 
GO 

CREATE PROC USP_UpdateAccount
@userName NVARCHAR(100), @displayName NVARCHAR(100), @password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	
	SELECT @isRightPass = COUNT(*) FROM dbo.Account WHERE UserName = @userName AND PassWord = @password

	IF(@isRightPass=1)
	BEGIN
		IF(@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE dbo.Account SET DisplayName = @displayName WHERE UserName = @userName
		END
		ELSE
		BEGIN
			UPDATE dbo.Account SET DisplayName = @displayName, PassWord = @newPassword WHERE UserName = @userName
		END
	END
END
GO

CREATE TRIGGER UTG_DeleteBillInfo
ON dbo.BillInfo FOR DELETE
AS
BEGIN
    DECLARE @idBillInfo INT
	DECLARE @idBill INT
	SELECT @idBillInfo = id, @idBill=Deleted.idBill FROM Deleted

	DECLARE @idTable INT
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill

	DECLARE @count INT = 0
	SELECT @count = COUNT(*) FROM dbo.BillInfo AS bi, dbo.Bill AS b WHERE b.id=bi.idBill AND b.id=@idBill AND b.status = 0

	IF(@count = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id=@idTable
END
GO 

CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO

SELECT * FROM dbo.Food WHERE dbo.fuConvertToUnsign1(name) LIKE N'%'+dbo.fuConvertToUnsign1(N'Phin')+'%'