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
                new Student() { StudentID = 1, StudentName = "Scott", Location = "Hyderabad", Branch = BranchOfStudent.CSE },
                new Student() { StudentID = 2, StudentName = "Smith", Location = "London", Branch = BranchOfStudent.IT },
                new Student() { StudentID = 3, StudentName = "Jones", Location = "Hyderabad", Branch = BranchOfStudent.IT },
                new Student() { StudentID = 4, StudentName = "Anna", Location = "London", Branch = BranchOfStudent.CSE },
                new Student() { StudentID = 5, StudentName = "Rahul", Location = "Hyderabad", Branch = BranchOfStudent.CSE },
                new Student() { StudentID = 6, StudentName = "David", Location = "Chennai", Branch = BranchOfStudent.IT }
            };

            //LINQ: To get all students where Location = Hyderabad
            //List<Student> hyderabadStudents = students.Where(temp => temp.Location == "Hyderabad" && temp.Branch == BranchOfStudent.CSE ).ToList();

            //LINQ: To sort students by student name in ascending
            //List<Student> hyderabadStudents = students.OrderBy(temp => temp.StudentName).ToList();

            //LINQ: To sort students by student name in descending
            //List<Student> hyderabadStudentsDesc = students.OrderByDescending(temp => temp.StudentName).ToList();

            //LINQ: To sort students by Location and Student
            List<Student> hyderabadStudents2 = students
                .OrderBy(temp => temp.Location)
                .ThenByDescending(temp => temp.StudentName)
                .ToList();

            foreach (var item in hyderabadStudents2)
            {
                Console.WriteLine(item.StudentID + ", " + item.StudentName + ", " + item.Location);
            }

            Console.ReadKey();
        }
    }
}

