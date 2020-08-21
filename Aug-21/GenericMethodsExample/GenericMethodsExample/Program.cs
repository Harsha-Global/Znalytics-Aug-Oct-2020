using System;
using MyNamespace;

namespace GenericMethodsExample
{
    class Program
    {
        static void Main()
        {
            Sample s = new Sample();
            s.SampleMethod<int, string>(100, "Hai");
            s.SampleMethod<string, bool>("Hello", true);
            s.SampleMethod<Customer, char>(new Customer(), 'A');

            Console.ReadKey();
        }
    }
}
