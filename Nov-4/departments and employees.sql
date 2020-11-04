use company
go

create procedure dbo.deptemp
as begin
	select DeptNo, DeptName, Loc from company.dbo.Departments
	select EmpID, EmpName, Salary, DeptNo from company.dbo.Employees
end
go
