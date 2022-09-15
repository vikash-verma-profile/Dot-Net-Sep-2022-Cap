USE [SampleDB]
GO
/****** Object:  StoredProcedure [dbo].[CreateEmployee]    Script Date: 15/09/2022 12:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[CreateEmployee](@FirstName varchar(200),@LastName varchar(200),@Salary varchar(200),@DepartmentID varchar(200))
As
BEGIN
DECLARE @id int
set @id=(select Max(id) from employee);
Insert into employee values(@id+1,@FirstName,@LastName,@Salary,@DepartmentID,CONCAT('EMP',@id+1))
--EMP1
END
