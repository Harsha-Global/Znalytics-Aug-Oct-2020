using System;
using ClassLibrary1;

namespace EventsExample
{
    class Program
    {
        static void Main()
        {
            //create object of Publisher & Subscriber class
            Publisher publisher = new Publisher();

            //Every time when a method is added to event
            publisher.MyEvent += delegate (int x, int y)
            {
                int result = x + y;
                Console.WriteLine(result);
            };

            //Every time when a method is added to event
            publisher.MyEvent += (int x, int y) =>
            {
                int result = x + y;
                Console.WriteLine(result);
            };


            publisher.RaiseEvent();

            Console.ReadKey();
        }
    }
}
