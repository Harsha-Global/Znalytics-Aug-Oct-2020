using System;
using College;

namespace EnumerationsExample
{
    class Program
    {
        static void Main()
        {
            Student stu = new Student();
            stu.StudentName = "Allen";
            stu.Email = "allen@gmail.com";
            stu.Branch = ListOfBranches.Mech;

            Console.WriteLine(stu.StudentName);
            Console.WriteLine(stu.Email);
            Console.WriteLine(stu.Branch);
            Console.ReadKey();
        }
    }
}
