using System;

namespace CopyToExample
{
    class Program
    {
        static void Main()
        {
            //create array
            int[] marks = new int[7] { 82, 61, 91, 45, 73, 80, 58 };

            //CopyTo
            //int[] marks2 = new int[7];
            //marks.CopyTo(marks2, 0);

            //Clone
            int[] marks2 = (int[])marks.Clone();

            foreach (int m in marks2)
            {
                Console.WriteLine(m);
            }

            Console.ReadKey();
        }
    }
}
