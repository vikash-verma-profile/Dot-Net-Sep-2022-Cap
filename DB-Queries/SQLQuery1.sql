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