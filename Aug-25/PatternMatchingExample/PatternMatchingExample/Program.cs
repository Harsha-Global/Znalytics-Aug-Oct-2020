using System;
using System.Collections;

namespace PatternMatchingExample
{
    class Customer
    {
        public string CustomerName { get; set; }
    }

    class Product
    {
        public int ProductID { get; set; }
    }

    class Program
    {
        static void Main()
        {
            //ArrayList
            ArrayList arrayList = new ArrayList()
            {
                new Customer() { CustomerName = "Scott" },
                new Product() { ProductID = 101 }
            };

            //foreach
            foreach (var item in arrayList)
            {
                if (item is Customer c)
                {
                    Console.WriteLine(c.CustomerName);
                }
                else if (item is Product)
                {
                    Product p = (Product)item;
                    Console.WriteLine(p.ProductID);
                }
            }

            Console.ReadKey();
        }
    }
}
