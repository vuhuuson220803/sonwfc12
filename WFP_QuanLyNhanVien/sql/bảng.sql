--- Dữ liệu: Tên (chuỗi), Năm Sinh (số nguyên), Lương (số thực: 20.5 $, 30.0 $)
--    , Nhóm Máu (a,b,o), Giới Tính (Nam/Nữ)
--- Sắp xếp theo tên tăng dần, sắp xếp theo lương giảm dần.
--- Thống kê theo Tỉnh Thành (ví dụ: Hanoi có 2 n.v, Danang có 3 nv)
--- Tìm kiếm (tự sáng tạo)

-- int: số nguyên
-- float: số thực
-- nvarchar: chuỗi tiếng Việt có dấu
-- varchar: chuỗi
-- char: kí tự
-- bit: nhị phân 1/0

-- Sửa mã SQL này theo đề tài của nhóm mình
-- Xóa bảng cũ
IF OBJECT_ID(N'Nhân_Viên', N'U') IS NOT NULL  
   DROP TABLE Nhân_Viên;  
GO

-- Tạo mới bảng
CREATE TABLE Nhân_Viên
(
    Mã_Nhân_Viên  INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Tên_Nhân_Viên NVARCHAR(150),
    Năm_Sinh      INT,
    Lương         FLOAT,
    Nhóm_Máu      CHAR,
    Giới_Tính     BIT,
    Ảnh           VARCHAR(255),
)
GO

-- Khởi tạo 3 dòng bản ghi ban đầu
INSERT INTO Nhân_Viên(Tên_Nhân_Viên, Năm_Sinh, Lương, Nhóm_Máu, Giới_Tính, Ảnh)
VALUES
(N'Nguyễn Bá Trí',  2003, 30.7, 'A', 1, 'images\no image.jpg'),
(N'Lê Văn Lan',     2001, 46.8, 'O', 0, 'images\no image.jpg'),
(N'Nguyễn Hữu Đức', 2002, 53.2, 'B', 1, 'images\no image.jpg')
GO    