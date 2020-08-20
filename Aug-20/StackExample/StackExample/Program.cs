using System;
using System.Collections.Generic;

namespace StackExample
{
    class Program
    {
        static void Main()
        {
            //create a stack
            Stack<string> states = new Stack<string>(
                new List<string>() { "Andhra Pradesh", "Telangana", "Tamilnadu" });

            //Push
            states.Push("Kerala");

            //foreach
            foreach (string state in states)
            {
                Console.WriteLine(state);
            }
            Console.WriteLine();

            //Pop
            Console.WriteLine("Pop: " + states.Pop()); //Output: Kerala
            Console.WriteLine();

            //Peek
            Console.WriteLine("Peek: " + states.Peek()); //Output: 
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
