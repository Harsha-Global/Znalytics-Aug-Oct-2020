using System;
using ClassLibrary1;
using Company;

namespace EventHandlerExample
{
    //Subscriber class
    class Program
    {
        static void Main()
        {
            //Getting price based on 'sender'
            //Product p = new Product();
            //p.PriceChanged += (sender, e) => {
            //    Product pr = (Product)sender;
            //    Console.WriteLine("Price updated on " + DateTime.Now + ", Updated Price: " + pr.Price);
            //};



            //Getting price based on 'EventArgs'
            Product p = new Product();
            p.PriceChanged += (sender, e) => {
                MyEventArgs myEventArgs = (MyEventArgs)e;
                Console.WriteLine("Price updated on " + DateTime.Now + ", Updated Price: " + myEventArgs.UpdatedPrice);
            };

            p.Price = 1000; //calls set accessor --> raise the event
            p.Price = 2500; //calls set accessor --> raise the event
            p.Price = 1500; //calls set accessor --> raise the event
            p.Price = 10000; //calls set accessor --> raise the event


            Console.ReadKey();
        }
    }
}
