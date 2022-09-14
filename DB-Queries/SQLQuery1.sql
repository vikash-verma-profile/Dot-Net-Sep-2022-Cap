Create Database SampleDB;

use SampleDB
--DDL

/*
Create table <table-name>(<column-name>)
*/
Create table SAMPLE(id int,Text varchar(200))
select * from Sample
select id,TEXT from Sample
insert into Sample values(1,'Vikash')
insert into Sample values(2,'Vikash')
insert into Sample values(3,'Vikash')
insert into Sample values(4,'Vikash')
select * from Sample where id=1
select * from sample where id in (1,2)
select * from sample where id not in (1)

update SAMPLE set Text='suresh' where id=1

delete  from sample where id=1

drop table Sample;
alter table sample drop column SAlary 
alter table sample add  SAlary int
select * from sample
truncate table sample
select * from Sample

--truncate vs delete command

Create table employee(id int,FirstName varchar(200),LastName varchar(200),Salary int,DepartmentId int)
Create table department(id int,DepartmentName varchar(200))

insert into employee values(1,'Vikash','Verma',10000,1)
insert into employee values(2,'Ravi','Verma',5000,1)
insert into employee values(3,'Roshan','Verma',2000,1)
insert into employee values(4,'Suresh','Verma',20000,1)
insert into employee values(5,'Rakesh','Verma',4000,1)
insert into employee values(6,'Anjali','Verma',3000,5)

select  * from employee
select * from department
insert into department values(1,'IT')
insert into department values(2,'CS')
insert into department values(3,'Admin')
insert into department values(4,'Support')

select e.id,e.FirstName,e.LastName,d.DepartmentName from employee e  inner join department d on d.id=e.DepartmentId

update employee set DepartmentId=4 where id=3

select e.id,e.FirstName,e.LastName,d.DepartmentName from employee e  LEFT OUTER join department d on d.id=e.DepartmentId
select e.id,e.FirstName,e.LastName,d.DepartmentName from employee e  RIGHT OUTER join department d on d.id=e.DepartmentId
select e.id,e.FirstName,e.LastName,d.DepartmentName from employee e  FULL OUTER join department d on d.id=e.DepartmentId

--used for searching
select * from department where DepartmentName like '%I' --it should end with I
select * from department where DepartmentName like '%T' --it should end with T
select * from department where DepartmentName like 'I%' -- it will end with anything but should star with I
select * from department where DepartmentName like '%I%' -- it will serach anywhere in the string it matches I letter

select * from department order by id --by default its always asc
select * from department order by id desc
select * from department order by id asc


Create function GetFullName(@id int) 
RETURNS varchar(200) as
BEGIN
 return (select CONCAT(FIRSTNAME,' ',LASTNAME) from employee where id=@id);
END

select dbo.GetFullName(id) as FULLNAME from employee
