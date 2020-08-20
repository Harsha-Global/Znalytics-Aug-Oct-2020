using System;
using System.Collections.Generic;
using College;

namespace OneToOneExample
{
    class Program
    {
        static void Main()
        {
            //one-to-one
            Student student = new Student();
            student.RollNo = 101;
            student.StudentName = "Scott";
            student.StudentBranch = new College.Branch() { BranchID = 1, BranchName = "CSE" };

            Console.ReadKey();
        }
    }
}
