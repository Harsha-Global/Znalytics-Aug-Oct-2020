using System;
using System.Collections.Generic;

namespace ListExample2
{
    class Program
    {
        static void Main()
        {
            //create collection
            List<int> marks = new List<int>() { 98, 45, 23, 67, 92, 30 };

            //ForEach
            marks.ForEach(n =>
            {
                Console.Write("n is ");
                Console.WriteLine(n);
            });

            //Exists
            bool result1 = marks.Exists(n => n < 35);
            Console.WriteLine("Exists: " + result1); //Output: True

            //Find
            int result2 = marks.Find(n => n < 35);
            Console.WriteLine("Find: " + result2); //Output: 23

            //FindIndex
            int result3 = marks.FindIndex(n => n < 35);
            Console.WriteLine("FindIndex: " + result3); //Output: 2

            //FindLast
            int result4 = marks.FindLast(n => n < 35);
            Console.WriteLine("FindLast: " + result4); //Output: 30

            //FindLastIndex
            int result5 = marks.FindLastIndex(n => n < 35);
            Console.WriteLine("FindLast: " + result5); //Output: 5
            Console.WriteLine(); //blank line

            //FindAll
            List<int> result6 = marks.FindAll(n => n < 35);
            foreach (int n in result6)
            {
                Console.WriteLine(n); //Output: 23, 30
            }
            Console.ReadKey();
        }
    }
}
