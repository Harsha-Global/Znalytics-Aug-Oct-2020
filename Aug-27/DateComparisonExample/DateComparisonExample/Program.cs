using BusinessLogicLayer;
using EntityLayer;
using System;

namespace DateComparisonExample
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Employee employee = new Employee();
                Console.WriteLine("Enter date of birth:");
                employee.DateOfBirth = Convert.ToDateTime(Console.ReadLine());

                //Console.WriteLine(employee.DateOfBirth);

                EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic();
                employeeBusinessLogic.AddEmployee(employee);
                Console.WriteLine("Employee Added Successfully");
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    Console.WriteLine(ex.InnerException.Message);
                }
                Console.WriteLine();
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine();
                Console.WriteLine(ex.Source);
            }
            finally
            {
                Console.WriteLine("Thank you. Returning to Main menu");
            }

            Console.ReadKey();
        }
    }
}
