use company
go

create procedure UpdateEmployee
(@EmpID int,
@EmpName varchar(max),
@Salary decimal,
@DeptNo int)
as begin
	update company.dbo.Employees set EmpName = @EmpName, Salary = @Salary, DeptNo = @DeptNo
	where EmpID = @EmpID
end
go

create procedure DeleteEmployee
(@EmpID int)
as begin
	delete from company.dbo.Employees where EmpID = @EmpID
end
go

