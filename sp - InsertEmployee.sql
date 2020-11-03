create database company
go

use company
go

create table Employees(
   EmpID int primary key,
   EmpName nvarchar(max),
   Salary decimal
)
go

insert into Employees values(1, 'Scott', 4000)
insert into Employees values(2, 'Allen', 5000)
insert into Employees values(3, 'Jones', 6500)
insert into Employees values(4, 'James', 7000)
go


create procedure InsertEmployee(
   @EmpID int,
   @EmpName nvarchar(max),
   @Salary decimal
)
as begin
	insert into Employees values(@EmpID, @EmpName, @Salary)
end
go

