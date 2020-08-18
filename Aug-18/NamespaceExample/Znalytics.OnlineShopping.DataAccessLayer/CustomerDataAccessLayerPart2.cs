using System.Collections.Generic;
using Znalytics.OnlineShopping.CustomersModule.Entities;

namespace Znalytics.OnlineShopping.DataAccessLayer
{
    public partial class CustomerDataAccessLayer
    {
        public void AddCustomer(Customer customer)
        {
            //code generating new customer id

            customers.Add(customer);
        }
    }
}

