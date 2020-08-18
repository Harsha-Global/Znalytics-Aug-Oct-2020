using System;
using ClassLibrary1;

namespace StructuresExample
{
    class Program
    {
        static void Main()
        {
            Month m = new Month(1, "January");

            Console.WriteLine(m.MonthNumber);
            Console.WriteLine(m.MonthName);

            //Month m2 = null;

            int x = 10;
            string y = "hai";

            Console.ReadKey();
        }
    }
}
