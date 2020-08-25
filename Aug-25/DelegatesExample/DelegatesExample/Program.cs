using System;
using ClassLibrary1;

namespace DelegatesExample
{
    class Program
    {
        static void Main()
        {
            //create object of Sample class
            Sample s = new Sample();

            //create delegate object
            //MyDelegateType myDelegate = new MyDelegateType(s.Add);
            MyDelegateType myDelegate = s.Add;
            myDelegate += s.Subtract;

            //call the method indirectly using delegate object
            myDelegate.Invoke(10, 7);

            Console.ReadKey();
        }
    }
}

