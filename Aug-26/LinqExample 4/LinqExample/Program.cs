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
                new Student() { StudentID = 1, StudentName = "Scott", Location = "Hyderabad", Branch = BranchOfStudent.IT, Marks= 56 },
                new Student() { StudentID = 2, StudentName = "Smith", Location = "London", Branch = BranchOfStudent.CSE, Marks = 98 },
                new Student() { StudentID = 3, StudentName = "Jones", Location = "Hyderabad", Branch = BranchOfStudent.IT, Marks = 25 },
                new Student() { StudentID = 4, StudentName = "Anna", Location = "London", Branch = BranchOfStudent.CSE, Marks = 88 },
                new Student() { StudentID = 5, StudentName = "Rahul", Location = "Hyderabad", Branch = BranchOfStudent.CSE, Marks = 34 },
                new Student() { StudentID = 6, StudentName = "David", Location = "Chennai", Branch = BranchOfStudent.IT, Marks = 41 }
            };

            //LINQ: Min, Max, Sum, Avg, Count
            int Min = students.Min(temp => temp.Marks);
            int Max = students.Max(temp => temp.Marks);
            int Sum = students.Sum(temp => temp.Marks);
            double Average = students.Average(temp => temp.Marks);
            int Count = students.Count();

            Console.WriteLine("Min: " + Min);
            Console.WriteLine("Max: " + Max);
            Console.WriteLine("Sum: " + Sum);
            Console.WriteLine("Average: " + Average);
            Console.WriteLine("Count: " + Count);

            Console.ReadKey();
        }
    }
}

