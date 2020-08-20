using System;
using System.Collections;

namespace HashtableExample
{
    class Program
    {
        static void Main()
        {
            //marks as Hashtable collection
            Hashtable marks = new Hashtable() { { "Maths", 85 }, { "Physics", 81 }, { "English", 36 }, { "Chemistry", false }, { "Other", 'A' } };

            marks["Maths"] = 90; //setting
            int mathsMarks = (int)marks["Maths"]; //not allowed
            Console.WriteLine(mathsMarks); //Output: 90 //getting
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
                Console.WriteLine(key.GetHashCode());
                if (marks[key].GetType() == typeof(bool))
                {
                    bool temp = (bool)marks[key];
                    Console.WriteLine(temp);
                }
                else if (marks[key].GetType() == typeof(int))
                {
                    int temp = (int)marks[key];
                    Console.WriteLine(temp);
                }
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

