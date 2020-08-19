using System;
using System.Collections.Generic;

namespace ToArrayExample
{
    class Program
    {
        static void Main()
        {
            //create collection
            List<int> marks = new List<int>() { 98, 45, 23, 67, 92, 30 };

            //convert into array
            int[] marks2 = marks.ToArray();

            foreach (int m in marks2)
            {
                Console.WriteLine(m);
            }

            Console.ReadKey();
        }
    }
}
