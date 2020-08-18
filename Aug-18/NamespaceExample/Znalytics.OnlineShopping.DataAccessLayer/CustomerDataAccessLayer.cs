using System.Collections.Generic;
using Znalytics.OnlineShopping.CustomersModule.Entities;

namespace Znalytics.OnlineShopping.DataAccessLayer
{
    public class CustomerDataAccessLayer: ICustomerDataAccessLayer
    {
        //create list
        List<Customer> customers = new List<Customer>();

        public void AddCustomer(Customer customer)
        {
            ////code generating new customer id

            //customers.Add(customer);

            //not done
        }
    }
}

