using System;
using Znalytics.OnlineShopping.CustomersModule.Entities;

namespace Znalytics.OnlineShopping.DataAccessLayer
{
    public interface ICustomerDataAccessLayer
    {
        void AddCustomer(Customer customer);
    }
}

