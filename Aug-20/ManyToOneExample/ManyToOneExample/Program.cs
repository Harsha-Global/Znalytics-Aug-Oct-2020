using System;
using System.Collections.Generic;
using Company;

namespace ManyToOneExample
{
    class Program
    {
        static void Main()
        {
            //one department
            Department d = new Department() { DepartmentID = 10, DepartmentName = "Development" }

            //first employee
            Employee emp1 = new Employee() { EmpID = 101, EmployeeName = "John" };
            emp1.Dept = d;

            //second employee
            Employee emp2 = new Employee() { EmpID = 102, EmployeeName = "Jones" };
            emp1.Dept = d;


        }
    }
}

