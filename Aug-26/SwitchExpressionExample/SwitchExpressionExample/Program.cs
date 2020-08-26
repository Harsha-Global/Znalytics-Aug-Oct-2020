using System;

namespace SwitchExpressionExample
{
    class Program
    {
        static void Main()
        {
            int monthNumber;
            string monthName;

            Console.WriteLine("Month number: ");
            monthNumber = int.Parse(Console.ReadLine());

            //normal switch case
            monthName = monthNumber switch
            {
                1 => "Jan",
                2 => "Feb",
                3 => "Mar",
                4 => "Apr",
                5 => "May",
                6 => "Jun",
                7 => "Jul",
                8 => "Aug",
                9 => "Sep",
                10 => "Oct",
                11 => "Nov",
                12 => "Dec",
                _ => "Unknown",
            };

            Console.WriteLine(monthName);

            Console.ReadKey();
        }
    }
}
