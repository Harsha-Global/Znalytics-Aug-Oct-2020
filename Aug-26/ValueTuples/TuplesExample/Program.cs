using System;
using ClassLibrary1;

namespace TuplesExample
{
    class Program
    {
        static void Main()
        {
            Sample s = new Sample();
           

            //Value Tuple
            (string CustomerName, int Age) cust = s.GetCustomerDetails();
            //Console.WriteLine(cust.CustomerName);
            //Console.WriteLine(cust.Age);

            //Value Tuple - Deconstruction
            (string CustomerName, int Age) = s.GetCustomerDetails();
            Console.WriteLine(CustomerName);
            Console.WriteLine(Age);

            //Value Tuple - Deconstruction - with Discard
            (string CustomerName2, _ ) = s.GetCustomerDetails();
            Console.WriteLine(CustomerName2);

            Console.ReadKey();
        }
    }
}

