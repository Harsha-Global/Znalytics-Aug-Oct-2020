using System;
using System.Collections.Generic;

namespace CollectionsExample
{
    class Program
    {
        static void Main()
        {
            //create collection
            List<int> marks = new List<int>() { 82, 61, 91, 45, 73, 91, 58 };
            List<string> subjects = new List<string>() { "C#", "Java", "Python", "C++", "DS", "SQL", "DBMS" };

            //read all elements
            for (int i = 0; i < marks.Count; i++)
            {
                Console.WriteLine(subjects[i] + ", " + marks[i]);
            }
            Console.WriteLine(); //blank line

            //add
            subjects.Add("ReactJS");
            subjects.AddRange(new List<string>() { "Machine Learning", "Data Science", "AI" });

            //read all elements
            foreach (string sub in subjects)
            {
                Console.WriteLine(sub);
            }
            Console.WriteLine(); //blank line

            //IndexOf
            int n = subjects.IndexOf("Python");
            Console.WriteLine("Index of Python: " + n); //Output: 2

            int n2 = subjects.IndexOf("Angular");
            Console.WriteLine("Index of Angular: " + n2); //Output: -1

            //BinarySearch
            subjects.Sort();
            //read all elements
            foreach (string sub in subjects)
            {
                Console.WriteLine(sub);
            }
            Console.WriteLine(); //blank line

            int n3 = subjects.BinarySearch("Python");
            Console.WriteLine("Binary Search of Python: " + n3); //Output: 2

            int n4 = subjects.BinarySearch("Angular");
            Console.WriteLine("Binary Search of Angular: " + n4); //Output: -1

            //Reverse
            subjects.Reverse();
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


