using System;

namespace ArraysExample
{
    class Program
    {
        static void Main()
        {
            //create array
            int[] marks = new int[7] { 82, 61, 91, 45, 73, 80, 58 };
            string[] subjects = new string[7] { "C#", "Java", "Python", "C++", "DS", "SQL", "DBMS" };

            //read all elements
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(subjects[i] + ", " + marks[i]);
            }
            Console.WriteLine(); //blank line

            //read all elements
            foreach (string sub in subjects)
            {
                Console.WriteLine(sub);
            }
            Console.WriteLine(); //blank line

            //IndexOf
            int n = System.Array.IndexOf(subjects, "Python");
            Console.WriteLine("Index of Python: " + n); //Output: 2

            int n2 = System.Array.IndexOf(subjects, "Angular");
            Console.WriteLine("Index of Angular: " + n2); //Output: -1

            //BinarySearch
            System.Array.Sort(subjects);
            //read all elements
            foreach (string sub in subjects)
            {
                Console.WriteLine(sub);
            }
            Console.WriteLine(); //blank line

            int n3 = System.Array.BinarySearch(subjects, "Python");
            Console.WriteLine("Binary Search of Python: " + n3); //Output: 2

            int n4 = System.Array.BinarySearch(subjects, "Angular");
            Console.WriteLine("Binary Search of Angular: " + n4); //Output: -1

            //Reverse
            System.Array.Reverse(subjects);
            //read all elements
            foreach (string sub in subjects)
            {
                Console.WriteLine(sub);
            }
            Console.WriteLine(); //blank line

            Console.ReadKey();
        }
    }
}


