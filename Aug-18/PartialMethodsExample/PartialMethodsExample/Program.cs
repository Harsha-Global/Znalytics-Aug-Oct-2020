using System;
using MyNamespace;

namespace PartialMethodsExample
{
    class Program
    {
        static void Main()
        {
            Employee emp1 = new Employee() { EmpName = "Scott", Email = "scott@gmail.com" };
            emp1.DisplayAllDetails();
            //emp1.PrintEmail(); //not possible

            Console.ReadKey();
        }
    }
}

