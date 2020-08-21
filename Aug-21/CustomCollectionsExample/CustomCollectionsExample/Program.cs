using System;
using System.Collections.Generic;
using Company;

namespace CustomCollectionsExample
{
    class Program
    {
        static void Main()
        {
            CustomersCollection customersCollection = new CustomersCollection();

            //FindAll
            //List<Customer> matchingCustomers = customersCollection.FindAll(temp => temp.CustomerName.StartsWith("S"));

            //Sort
            customersCollection.Sort();
            foreach (Customer cst in customersCollection)
            {
                Console.WriteLine(cst.CustomerID + ", " + cst.CustomerName + ", " + cst.Age + ", " + cst.CustomerType);
            } //MoveNext


            //Contains - IEquatable
            Customer customerToSearch = new Customer() { CustomerID = 102, CustomerName = "Scott1" };
            //Console.WriteLine(customersCollection.Contains(customerToSearch)); //Output: True

            Console.ReadKey();
        }
    }
}
