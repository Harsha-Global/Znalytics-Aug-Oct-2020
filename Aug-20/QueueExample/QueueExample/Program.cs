using System;
using System.Collections.Generic;

namespace QueueExample
{
    class Program
    {
        static void Main()
        {
            //create a Queue
            Queue<string> states = new Queue<string>(
                new List<string>() { "Andhra Pradesh", "Telangana", "Tamilnadu" });

            //Push
            states.Enqueue("Kerala");

            //foreach
            foreach (string state in states)
            {
                Console.WriteLine(state);
            }
            Console.WriteLine();

            //Pop
            Console.WriteLine("Pop: " + states.Dequeue()); //Output: Andhra Pradesh
            Console.WriteLine();

            //Peek
            Console.WriteLine("Peek: " + states.Peek()); //Output: Telangana
            Console.WriteLine();

            //foreach
            foreach (string state in states)
            {
                Console.WriteLine(state);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
