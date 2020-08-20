using System;
using System.Collections.Generic;
using College;

namespace OneToManyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //one-to-many
            Student student = new Student();
            student.RollNo = 101;
            student.StudentName = "Allen";
            student.Examinations = new List<Examination>();
            student.Examinations.Add(new Examination() { ExaminationID = 1, ExaminationName = "Module 1 Test" });
            student.Examinations.Add(new Examination() { ExaminationID = 2, ExaminationName = "Module 2 Test" });

            Console.ReadKey();
        }
    }
}
