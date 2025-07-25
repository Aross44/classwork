CREATE TABLE Department
(
-- colum-name 	data-type  	   nullness,
Id int  		Primary Key,
Name  			varchar (25)   not null,
Hiring bit,
Location 		varchar(50)		   
--CONSTRAINT PK_ID_INT PRIMARY KEY (id_ints)
); 	 

INSERT into Department 
       ( name, hiring, id, location) 
values ('Technology', '1', '1', 'null' ) 
;
 --select * from Department

 INSERT into Department 
       ( name, hiring, id, location) 
values ('Shipping & Recieving', '1', '1', 'null' ) 
;

--create table Department (
--Id int Primary Key,
--Name nvarchar (25) not null,
--Hiring bit,
--Location nvarchar(50) not null,);