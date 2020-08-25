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
            Subscriber subscriber = new Subscriber();

            //Every time when a method is added to event
            publisher.MyEvent += subscriber.Add;

            publisher.RaiseEvent();

            Console.ReadKey();
        }
    }
}
