using ClassLibrary1;
using System;

namespace MyNamespace
{
    static class CustomerBLLExtensions
    {
        public static void DeleteCustomer(this CustomerBusinessLogicLayer cbll)
        {
            //cbll.AddCustomer();
            Console.WriteLine("DeleteCustomer extension method");
        }
    }
}

