use company
go

create procedure GetEmployeesCount
as begin
	select count(*) from Employees
	--select EmpName from Employees where EmpID=1
end
