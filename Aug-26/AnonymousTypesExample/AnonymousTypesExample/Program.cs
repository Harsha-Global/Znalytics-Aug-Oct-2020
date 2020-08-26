using System;

namespace AnonymousTypesExample
{
    class Program
    {
        static void Main()
        {
            var cust1 = new { CustomerName = "John", Age = 20 };
            var cust2 = new { CustomerName = "John", Age = 20, Email = "john@gmail.com" };

            Console.WriteLine(cust1.CustomerName);
            Console.WriteLine(cust1.Age);
            Console.WriteLine(cust2.CustomerName);
            Console.WriteLine(cust2.Age);

            Console.ReadKey();
        }
    }
}
