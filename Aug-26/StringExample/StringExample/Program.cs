//Topic: String Handlng

using System;

namespace StringExample
{
    class Program
    {
        static void Main()
        {
            string a = "Hello World"; //immutable (readonly)
            string b = a.ToUpper(); //converts into upper case
            string c = a.ToLower(); //converts into lower case
            int d = a.Length; //no. of characters (alphabets, digits, spaces, special characters)
            char e = a[0]; //get single character based on index
            string f = a.Substring(6, 3);
            string g = a.Remove(1, 4);
            int h = a.IndexOf("o");
            int i = a.IndexOf("o", 5);
            int j = a.LastIndexOf("l");
            string k = a.Replace("l", "z");
            bool l = a.Equals("Hello World");
            bool m = a.Contains("World");
            bool n = a.StartsWith("Hell");
            bool o = a.EndsWith("Hell");
            string p = "     Hello           ";
            string q = p.Trim();
            string sentence = "Hello how are you";
            char[] r = sentence.ToCharArray();

            Console.WriteLine(a); //Output: Hello World
            Console.WriteLine(b); //Output: HELLO WORLD
            Console.WriteLine(c); //Output: hello world
            Console.WriteLine(d); //Output: 11
            Console.WriteLine(e); //Output: H
            Console.WriteLine(f); //Output: Wor
            Console.WriteLine(g); //Output: H World
            Console.WriteLine(h); //Output: 4
            Console.WriteLine(i); //Output: 7
            Console.WriteLine(j); //Output: 9
            Console.WriteLine(k); //Output: Hezzo Worzd
            Console.WriteLine(k); //Output: Hezzo Worzd
            Console.WriteLine(l); //Output: true
            Console.WriteLine(m); //Output: true
            Console.WriteLine(n); //Output: true
            Console.WriteLine(o); //Output: false
            Console.WriteLine(q); //Output: Hello

            int spacesCount = 0;
            for (i = 0; i < r.Length; i++)
            {
                if (r[i] == ' ')
                {
                    spacesCount++;
                }
            }

            if (spacesCount > 0)
            {
                spacesCount++;
            }

            Console.WriteLine(spacesCount); //Output: 1
            Console.ReadKey();
        }
    }
}

