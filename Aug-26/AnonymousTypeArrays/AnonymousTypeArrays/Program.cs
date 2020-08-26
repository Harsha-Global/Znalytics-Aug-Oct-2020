using System;

namespace AnonymousTypeArrays
{
    class Program
    {
        static void Main()
        {
            var customers = new[]
            {
                new { CustomerName = "John", Age = 20, Address = new { City = "Hyderabad", Country = "India" } },
                new { CustomerName = "Jones", Age = 21, Address = new { City = "aaa", Country = "India" } },
                new { CustomerName = "Scott", Age = 18, Address = new { City = "bbb", Country = "India" } },
                new { CustomerName = "Amit", Age = 30, Address = new { City = "ccc", Country = "India" } },
                new { CustomerName = "Sumit", Age = 50, Address = new { City = "ddd", Country = "India" } },
                new { CustomerName = "Ford", Age = 25, Address = new { City = "eee", Country = "India" } }
            };

            foreach (var item in customers)
            {
                Console.WriteLine(item.CustomerName + ", " + item.Age);
                //item.CustomerName = "sdkjfh";
            }

            Console.ReadKey();
        }
    }
}
