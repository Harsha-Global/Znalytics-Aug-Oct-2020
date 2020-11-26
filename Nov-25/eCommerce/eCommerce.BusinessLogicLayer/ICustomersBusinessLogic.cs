using eCommerce.WebAPI.DomainModels;
using eCommerce.WebAPI.ViewModels;
using System;
using System.Collections.Generic;

namespace eCommerce.BusinessLogicLayer
{
    /// <summary>
    /// Provides business methods for manipulations of "customers" table
    /// </summary>
    public interface ICustomersBusinessLogic
    {
        List<CustomerViewModel> GetCustomers();
        CustomerViewModel InsertCustomer(InsertCustomerViewModel customer);
    }
}

