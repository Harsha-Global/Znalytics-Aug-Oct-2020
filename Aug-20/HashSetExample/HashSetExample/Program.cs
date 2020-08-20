using System;
using System.Collections.Generic;

namespace HashSetExample
{
    class Program
    {
        static void Main()
        {
            //marks as Hashtable collection
            HashSet<string> marks = new HashSet<string>() { "Maths", "Physics", "English", "Chemistry" };

            Console.WriteLine(marks.Count); //Output: 4
            Console.WriteLine(); //blank line

            //Add
            marks.Add("Java");

            //Remove
            marks.Remove("English");

            //Values
            foreach (string val in marks)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine();

            //Contains
            bool b2 = marks.Contains("English");
            Console.WriteLine("70 exists: " + b2); //Output: True

            Console.ReadKey();
        }
    }
}

