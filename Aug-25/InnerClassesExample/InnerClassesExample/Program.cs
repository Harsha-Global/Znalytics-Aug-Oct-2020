using System;

namespace InnerClassesExample
{
    //outer class (performs a larger task)
    class MarksCalculator
    {
        public int GetAverageMarks(int marks1, int marks2, int mark3)
        {
            //create object of inner class
            Addition addition = new Addition();
            int total = addition.Add(marks1, marks2, mark3);
            return total / 3;
        }

        //inner class (performs a smaller task)
        internal class Addition
        {
            public int Add(int n1, int n2, int n3)
            {
                int sum = n1 + n2 + n3;
                return sum;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            //invoke inner class
            MarksCalculator.Addition addition = new MarksCalculator.Addition();
            Console.WriteLine(addition.Add(10, 20, 30));

            //invoke outer class
            MarksCalculator marksCalculator = new MarksCalculator();
            int avg = marksCalculator.GetAverageMarks(67, 80, 90);
            Console.WriteLine("Average marks: " + avg);

            Console.ReadKey();
        }
    }
}

struct struct1
{
    struct struct2
    {

    }
}

