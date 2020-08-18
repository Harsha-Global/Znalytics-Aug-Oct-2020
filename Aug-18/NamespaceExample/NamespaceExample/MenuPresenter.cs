using System;
using Znalytics.OnlineShopping.CustomersModule.Entities;
using Znalytics.OnlineShopping.BusinessLogicLayer;

namespace Znalytics.OnlineShopping.PresentationLayer
{
    public class MenuPresenter
    {
        public static void Menu()
        {
            int choice = -1;

            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Customers");
                Console.WriteLine("2. Accounts");
                Console.WriteLine("9. Exit");

                bool b = int.TryParse(Console.ReadLine(), out choice);
                if (b == true)
                {
                    switch(choice)
                    {
                        case 1: CustomersMenu(); break;
                    }
                }
            } while (choice != 9);
        }

        public static void CustomersMenu()
        {
            int choice = -1;

            do
            {
                Console.WriteLine("Customers Menu:");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Update Customer");
                Console.WriteLine("9. Exit");

                bool b = int.TryParse(Console.ReadLine(), out choice);
                if (b == true)
                {
                    switch (choice)
                    {
                        case 1: AddCustomer(); break;
                    }
                }
            } while (choice != 9);
        }

        public static void AddCustomer()
        {
            Customer customer = new Customer();
            Console.Write("Enter customer name: ");
            customer.CustomerName = Console.ReadLine();

            ICustomerBusinessLogicLayer customerBusinessLogicLayer = new CustomerBusinessLogicLayer();
            customerBusinessLogicLayer.AddCustomer(customer); //call BL

            Console.WriteLine(customer.GetType()); //Output: Znalytics.OnlineShopping.CustomersModule.Entities.Customer

            Console.WriteLine(customer.ToString()); //Output: Znalytics.OnlineShopping.CustomersModule.Entities.Customer

            Console.WriteLine(customer.GetHashCode()); //Output: 46104728


            Customer customer1 = new Customer() { CustomerName = "John", Email = "john@gmail.com" };
            Customer customer2 = new Customer() { CustomerName = "John", Email = "john@gmail.com" };
            
            Console.WriteLine(customer1.Equals(customer2)); //Output: True 
        }
    }
}
