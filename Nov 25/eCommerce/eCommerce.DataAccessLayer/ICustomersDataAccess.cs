using eCommerce.WebAPI.DomainModels;
using System;
using System.Collections.Generic;

namespace eCommerce.DataAccessLayer
{
    /// <summary>
    /// Interface for Customers Data Layer that provides methods to perform CRUD operations on "Customers" table in sql server
    /// </summary>
    public interface ICustomersDataAccess
    {
        IEnumerable<Customer> GetCustomers();
        Customer InsertCustomer(Customer customer);
    }
}

