using System;
using ClassLibrary1;

namespace TuplesExample
{
    class Program
    {
        static void Main()
        {
            Sample s = new Sample();
            Tuple<string, int> cust = s.GetCustomerDetails();
            Console.WriteLine(cust.Item1);
            Console.WriteLine(cust.Item2);

            Console.ReadKey();
        }
    }
}

