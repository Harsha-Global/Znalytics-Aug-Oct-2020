using System;
using System.Collections.Generic;

namespace ConvertAllExample
{
    class Program
    {
        static void Main()
        {
            //create character collection
            List<char> digits = new List<char>() { '7', '3', '5', '0' };
            //Output: Seven Three Five Zero


            List<string> words = digits.ConvertAll(ch =>
            {
            string word = "";
                switch (ch)
                {
                    case '1': word = "One "; break;
                    case '2': word = "Two "; break;
                    case '3': word = "Three "; break;
                    case '4': word = "Four "; break;
                    case '5': word = "Five "; break;
                    case '6': word = "Six "; break;
                    case '7': word = "Seven "; break;
                    case '8': word = "Eight "; break;
                    case '9': word = "Nine "; break;
                    case '0': word = "Zero "; break;
                }
                return word;
            });

            foreach (string w in words)
            {
                Console.Write(w);
            }

            Console.ReadKey();
        }
    }
}
