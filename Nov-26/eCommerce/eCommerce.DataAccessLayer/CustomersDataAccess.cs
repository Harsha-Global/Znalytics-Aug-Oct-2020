using eCommerce.WebAPI.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.DataAccessLayer
{
    /// <summary>
    /// Implementation class for Customers Data Layer that provides methods to perform CRUD operations on "Customers" table in sql server
    /// </summary>
    public class CustomersDataAccess : ICustomersDataAccess
    {
        //private fields
        private eCommerceDbContext db;

        /// <summary>
        /// Constructor that executes when an object is created for CustomersDataLayer class
        /// </summary>
        public CustomersDataAccess()
        {
            db = new eCommerceDbContext();
        }

        /// <summary>
        /// Returns a list of customers from "customers" table
        /// </summary>
        /// <returns>List of customers</returns>
        public IEnumerable<Customer> GetCustomers()
        {
            IEnumerable<Customer> customers = db.Customers;
            return customers;
        }

        /// <summary>
        /// Inserts a new customer row into "customers" table
        /// </summary>
        /// <param name="customer">New customer to insert</param>
        /// <returns>Returns same customer after inserting</returns>
        public Customer InsertCustomer(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();

            return customer;
        }

        /// <summary>
        /// Returns the customer that has specific customer name
        /// </summary>
        /// <param name="customerName">Customer name to search</param>
        /// <returns>Returns the matching customer</returns>
        public Customer GetCustomerByCustomerName(string customerName)
        {
            Customer customer = db.Customers.Where(temp => temp.CustomerName == customerName).FirstOrDefault();
            return customer;
        }
    }
}

