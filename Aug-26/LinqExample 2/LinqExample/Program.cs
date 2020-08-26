using College;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExample
{
    class Program
    {
        static void Main()
        {
            //create collection of objects
            List<Student> students = new List<Student>()
            {
                new Student() { StudentID = 1, StudentName = "Scott", Location = "Hyderabad", Branch = BranchOfStudent.IT },
                new Student() { StudentID = 2, StudentName = "Smith", Location = "London", Branch = BranchOfStudent.CSE },
                new Student() { StudentID = 3, StudentName = "Jones", Location = "Hyderabad", Branch = BranchOfStudent.IT },
                new Student() { StudentID = 4, StudentName = "Anna", Location = "London", Branch = BranchOfStudent.CSE },
                new Student() { StudentID = 5, StudentName = "Rahul", Location = "Hyderabad", Branch = BranchOfStudent.CSE },
                new Student() { StudentID = 6, StudentName = "David", Location = "Chennai", Branch = BranchOfStudent.IT }
            };

            //LINQ: First object; exception is not found
            //Student result = students.First(temp => temp.Branch == BranchOfStudent.IT);

            //LINQ: First object; null is not found
            //Student result = students.FirstOrDefault(temp => temp.Branch == BranchOfStudent.IT);

            //LINQ: Last object; exception is not found
            //Student result = students.Last(temp => temp.Branch == BranchOfStudent.IT);

            //LINQ: Last object; null is not found
            //Student result = students.LastOrDefault(temp => temp.Branch == BranchOfStudent.IT);

            //LINQ: Single object; exception is not found
            //Student result = students.Single(temp => temp.Branch == BranchOfStudent.IT);

            //LINQ: Single object; null is not found
            Student result = students.SingleOrDefault(temp => temp.Branch == BranchOfStudent.IT);

            if (result == null)
            {
                Console.WriteLine("StudentID 7 is not found");
            }
            else
            {
                Console.WriteLine(result.StudentID + ", " + result.StudentName + ", " + result.Location + ", " + result.Branch);
            }

            Console.ReadKey();
        }
    }
}

