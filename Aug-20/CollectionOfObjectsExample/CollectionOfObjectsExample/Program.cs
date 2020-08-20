using System;
using System.Collections.Generic;
using Company;

namespace CollectionOfObjectsExample
{
    class Program
    {
        static void Main()
        {
            //create collection
            List<Employee> employees = new List<Employee>() {
                new Employee() { EmployeeID = 101, EmployeeName = "Scott" },
                new Employee() { EmployeeID = 102, EmployeeName = "Allen" },
                new Employee() { EmployeeID = 103, EmployeeName = "Smith" },
                new Employee() { EmployeeID = 104, EmployeeName = "Jones" }
            };

            //add employee
            Console.Write("Enter Employee ID: ");
            int empID = int.Parse(Console.ReadLine());
            Console.Write("Enter Employee Name: ");
            string empName = Console.ReadLine();
            if (empName != null)
            {
                employees.Add(new Employee() { EmployeeID = empID, EmployeeName = empName });
            }


            //IEnumerable
            IEnumerable<Employee> employees2 = employees;

            //foreach
            //foreach (Employee emp in employees2)
            //{
            //    Console.WriteLine(emp.EmployeeID + ", " + emp.EmployeeName);
            //}

            //IEnumerator
            IEnumerator<Employee> employees3 = employees2.GetEnumerator();
            while(employees3.MoveNext())
            {
                Console.WriteLine(employees3.Current.EmployeeID + ", " + employees3.Current.EmployeeName);
            }
            Console.ReadKey();
        }
    }
}

