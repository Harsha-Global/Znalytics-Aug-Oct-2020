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
                return result;
            };

            //Every time when a method is added to event
            publisher.MyEvent += (int x, int y) =>
            {
                int result = x + y;
                return result;
            };

            //Every time when a method is added to event
            publisher.MyEvent += (x, y) => x + y ;

            publisher.RaiseEvent();

            Console.ReadKey();
        }
    }
}
