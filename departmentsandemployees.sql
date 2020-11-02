create database company
go

use company
go

create table Departments(
DeptNo int primary key,
DeptName nvarchar(max),
Loc nvarchar(max))
go

create table Employees(
EmpID int primary key,
EmpName varchar(max),
Salary decimal,
DeptNo int references Departments(DeptNo))
go

insert into Departments values(10, 'Acounting', 'New York')
insert into Departments values(20, 'Operations', 'New Delhi')
insert into Departments values(30, 'Sales', 'New Jersy')
go

insert into Employees values(1, 'Scott', 2000, 10)
insert into Employees values(2, 'Allen', 6500, 10)
insert into Employees values(3, 'Jones', 4577, 20)
insert into Employees values(4, 'James', 2500, 20)
insert into Employees values(5, 'Smith', 3345, 30)
insert into Employees values(6, 'Harry', 3600, 30)
go


