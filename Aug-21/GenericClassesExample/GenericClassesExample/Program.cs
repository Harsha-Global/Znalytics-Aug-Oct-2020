using System;

namespace GenericClassesExample
{
    class Program
    {
        static void Main()
        {
            Sample<Customer> sample = new Sample<Customer>();
            sample.X = new Customer() { CustomerID = 1, CustomerName = "abc" };

            Sample<RegisteredCustomer> sample2 = new Sample<RegisteredCustomer>();
            sample2.X = new RegisteredCustomer() { CustomerID = 2, CustomerName = "xyz", RegNo = 1234 };

            Console.WriteLine(sample.X);
            Console.WriteLine(sample2.X);

            Console.ReadKey();
        }
    }
}

