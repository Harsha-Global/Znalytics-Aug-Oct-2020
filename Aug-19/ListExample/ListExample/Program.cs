using System;
using System.Collections.Generic;

namespace ListExample
{
    class Program
    {
        static void Main()
        {
            //collection
            List<string> states = new List<string>() { "Telangana", "Andhra Pradesh", "Madhya Pradesh" };

            //AddRange
            states.AddRange(new List<string>() { "West Bengal", "Maharashtra", "Gujarat" });

            //Add
            Console.WriteLine("Enter new state: ");
            states.Add(System.Console.ReadLine());

            //Insert
            states.Insert(4, "Chattisgarh");

            //InsertRange
            states.InsertRange(4, new List<string>() { "Tamilnadu", "Kerala", "Karnataka" });

            //Remove
            states.Remove("West Bengal");

            //RemoveAt
            states.RemoveAt(3);

            //RemoveRange
            //states.RemoveRange(4, 3);

            //RemoveAll
            //states.RemoveAll(state => state.Contains("e"));

            //Clear
            //states.Clear();

            //IndexOf
            int n = states.IndexOf("Karnataka");
            Console.WriteLine("Index of Karnataka: " + n); //Output: 4

            //Sort
            states.Sort();

            //BinarySearch
            int n2 = states.BinarySearch("Maharashtra");
            Console.WriteLine("Index of Maharashtra: " + n2); //Output: 6

            //BinarySearch
            int n3 = states.BinarySearch("Tamilnadu");
            Console.WriteLine("Index of Tamilnadu: " + n3); //Output: -9

            //Contains
            bool b = states.Contains("Kerala");
            Console.WriteLine("Contains Kerala " + b); //Output: True

            //Reverse
            states.Reverse();

            System.Console.WriteLine(); //blank line
            foreach (string state in states)
            {
                Console.WriteLine(state);
            }

            Console.ReadKey();
        }
    }
}
