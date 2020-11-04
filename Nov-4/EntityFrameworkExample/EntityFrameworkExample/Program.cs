using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkExample
{
    class Program
    {
        static void Main()
        {
            companyEntities company = new companyEntities();
            List<Employee> employees = company.Employees
                .ToList(); //SELECT * FROM EMPLOYEES

            List<Employee> employees2 = company.Employees
                .Where(temp => temp.EmpName == "Scott")
                .ToList(); //SELECT * FROM EMPLOYEES where EmpName = 'Scott'

            List<Employee> employees3 = company.Employees
                .OrderBy(temp => temp.Salary)
                .ToList(); //SELECT * FROM EMPLOYEES order by Salary

            decimal? maxSal = company.Employees
                .Max(temp => temp.Salary); //SELECT MAX(SALARY) FROM EMPLOYEES


            //foreach (Employee emp in employees)
            //{
            //    Console.Write(emp.EmpID + ", " + emp.abc + ", " + emp.Salary + ", " + emp.DeptNo);
            //    Console.WriteLine();
            //}

            Console.ReadKey();
        }
    }
}

