using System;

namespace MultiDimArraysExample
{
    class Program
    {
        static void Main()
        {
            //multi-dim array
            int[,] marks = new int[5, 3]
                {
                    { 70, 80, 62 },
                    { 45, 50, 16 },
                    { 95, 60, 12 },
                    { 22, 42, 77 },
                    { 17, 60, 90 }
                };

            //read
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(marks[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}


