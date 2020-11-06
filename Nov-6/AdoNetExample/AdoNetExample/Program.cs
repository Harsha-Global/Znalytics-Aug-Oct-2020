using System;
using System.Collections.Generic;
using DataAccessLayer;

namespace AdoNetExample
{
    class Program
    {
        static void Main()
        {
            //create object of EmployeesDataAccess class
            EmployeesDataAccess employeesDataAccess = new EmployeesDataAccess();

            //create object of Employee class
            Employee emp = new Employee();
            
            //Read values from keyboard
            Console.WriteLine("INSERT EMPLOYEE:::::::::::::::::::::");
            Console.Write("\nEmployee ID: ");
            emp.EmpID = int.Parse(Console.ReadLine());

            Console.Write("\nEmployee Name: ");
            emp.EmpName = Console.ReadLine();

            Console.Write("\nSalary: ");
            emp.Salary = decimal.Parse(Console.ReadLine());

            Console.Write("\nDept No: ");
            emp.DeptNo = int.Parse(Console.ReadLine());

            //call the InsertEmployee() method
            int n = employeesDataAccess.InsertEmployee(emp);

            Console.WriteLine($"{n} row inserted");

            Console.ReadKey();
        }
    }
}
