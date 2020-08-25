using System;

namespace ClassLibrary1
{
    public class Sample
    {
        //target method 1
        public void Add(int a, int b)
        {
            double result;
            result = a + b;
            Console.WriteLine(result);
        }

        //target method 2
        public void Subtract(int a, int b)
        {
            double result;
            result = a - b;
            Console.WriteLine(result);
        }
    }
}

