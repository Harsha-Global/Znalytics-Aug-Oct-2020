using ClassLibrary1;
using System;
using MyNamespace;

namespace ExtensionMethodsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerBusinessLogicLayer customerBusinessLogicLayer = new CustomerBusinessLogicLayer();
            customerBusinessLogicLayer.DeleteCustomer();

            Console.ReadKey();
        }
    }
}
