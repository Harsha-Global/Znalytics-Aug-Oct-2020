using College;
using System;
using System.Collections.Generic;

namespace NullableTypesExample
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student() { RollNo = 101, StudentName = "abc", IsExaminationAttempted = true, SecuredMarks = 80 },
                new Student() { RollNo = 102, StudentName = "def", IsExaminationAttempted = true, SecuredMarks = 60 },
                new Student() { RollNo = 103, StudentName = null, IsExaminationAttempted = false, SecuredMarks = null },
            };

            dynamic x = 100.5154;
            var y = new Student();
            var z = new Dictionary<string, int>();

            //var q; //not valid

            foreach(var stu in students)
            {

            }

            x = "hello world";

            x.ToUpper();
        }
    }
}

