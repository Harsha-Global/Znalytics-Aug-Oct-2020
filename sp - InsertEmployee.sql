use company
go

create procedure InsertEmployee(
   @EmpID int,
   @EmpName nvarchar(max),
   @Salary decimal,
   @DeptNo int
)
as begin
	insert into Employees values(@EmpID, @EmpName, @Salary, @DeptNo)
end
go

