using System.Collections.Generic;
using Znalytics.OnlineShopping.CustomersModule.Entities;

namespace Znalytics.OnlineShopping.DataAccessLayer
{
    public partial class CustomerDataAccessLayer: ICustomerDataAccessLayer
    {
        //create list
        List<Customer> customers;

        //constructor
        public CustomerDataAccessLayer()
        {
            customers = new List<Customer>();
        }
    }
}

