using System;
using System.Collections.Generic;
using Znalytics.EmpMgmt.BusinessLogicLayer;
using Znalytics.EmpMgmt.Entities;

namespace Znalytics.EmpMgmt
{
    class Program
    {
        static void Main()
        {
            EmployeesPresentation();
            Console.ReadKey();
        }

        static void EmployeesPresentation()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("EMPLOYEES MENU");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. View Employees");
                Console.WriteLine("3. Update Employee");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddEmployee(); break;
                    case 2: ViewEmployees(); break;
                    case 3: UpdateEmployee(); break;
                }
            } while (choice != 4);
        }

        static void AddEmployee()
        {
            EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic();
            Employee employee = new Employee();

            Console.Write("Enter Emp ID: ");
            employee.EmployeeID = int.Parse(Console.ReadLine());
            Console.Write("Enter Emp Name: ");
            employee.EmployeeName = Console.ReadLine();

            employeeBusinessLogic.Add(employee);
            Console.WriteLine("Employee Added.\n");
        }

        static void ViewEmployees()
        {
            EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic();
            List<Employee> emps = employeeBusinessLogic.GetEmployees();

            foreach (Employee emp in emps)
            {
                Console.WriteLine(emp.EmployeeID + ", " + emp.EmployeeName);
            }
        }

        static void UpdateEmployee()
        {
            EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic();
            Employee employee = new Employee();

            Console.Write("Enter Existing Emp ID: ");
            employee.EmployeeID = int.Parse(Console.ReadLine());
            Console.Write("Enter New Emp Name: ");
            employee.EmployeeName = Console.ReadLine();

            employeeBusinessLogic.UpdateEmployee(employee);
            Console.WriteLine("Employee Updated.\n");
        }
    }
}
