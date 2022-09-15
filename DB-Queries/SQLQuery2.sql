create procedure CreateEmployee(@FirstName varchar(200),@LastName varchar(200),@Salary varchar(200),@DepartmentID varchar(200))
As
BEGIN
DECLARE @id int
set @id=(select Max(id) from employee);
Insert into employee values(@id+1,@FirstName,@LastName,@Salary,@DepartmentID,'')


END

--EMP0101

select * from employee

exec CreateEmployee 'Vikash','Verma',10000,2

