-- Xuất dữ liệu bảng 'Nhân_Viên'
SELECT        
 Mã_Nhân_Viên, 
 Tên_Nhân_Viên, 
 Năm_Sinh, 
 Lương, 
 Nhóm_Máu, 
 Ảnh,
 Giới_Tính,
 (CASE WHEN Giới_Tính = 1 THEN N'Nam' ELSE N'Nữ' END) AS Giới_Tính_text
FROM Nhân_Viên