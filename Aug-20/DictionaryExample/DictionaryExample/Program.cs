using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program
    {
        static void Main()
        {
            //marks as List collection
            Dictionary<string, int> marks = new Dictionary<string, int>() { { "Maths", 85 }, { "Physics", 81 }, { "English", 36 }, { "Chemistry", 65 } };

            marks["Maths"] = 90; //setting
            Console.WriteLine(marks["Maths"]); //Output: 90 //getting
            Console.WriteLine(marks.Count); //Output: 4
            Console.WriteLine(); //blank line

            //Add
            marks.Add("Java", 70);

            //Remove
            marks.Remove("English");

            //Keys
            foreach (string key in marks.Keys)
            {
                Console.WriteLine(key);
                Console.WriteLine(marks[key]);
            }
            Console.WriteLine();

            //Values
            foreach (int val in marks.Values)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine();

            //ContainsKey
            bool b = marks.ContainsKey("Chemistry");
            Console.WriteLine("Chemistry exists: " + b); //Output: True

            //ContainsValue
            bool b2 = marks.ContainsValue(70);
            Console.WriteLine("70 exists: " + b2); //Output: True

            Console.ReadKey();
        }
    }
}

