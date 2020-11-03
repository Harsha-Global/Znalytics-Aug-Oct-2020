use company
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

