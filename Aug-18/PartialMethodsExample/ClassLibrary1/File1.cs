//Created by: Developer 1
using System;

namespace MyNamespace
{
    public partial class Employee
    {
        public string EmpName { get; set; }
        public string Email { get; set; }


        public void DisplayAllDetails()
        {
            Console.WriteLine("Employee Name: " + EmpName);
            PrintEmail();
        }

        partial void PrintEmail();
    }
}


