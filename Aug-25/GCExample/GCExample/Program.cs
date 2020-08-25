using System;

namespace GCExample
{
    class Customer
    {
    }
    class Program
    {
        static void Main()
        {
            Customer c = new Customer(); //dead object (garbage)



            c = new Customer();


            System.GC.Collect(); //to trigger Garbage collection

            //Connection to file
        }
    }
}
