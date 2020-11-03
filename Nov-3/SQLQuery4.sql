use company
go

create procedure GetAllEmployees
as begin
	select EmpID, EmpName, Salary, DeptNo from company.dbo.Employees
end
