using eCommerce.DataAccessLayer;
using eCommerce.WebAPI.DomainModels;
using eCommerce.WebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eCommerce.BusinessLogicLayer
{
    /// <summary>
    /// CustomersBusinessLogic class provides business methods for manipulations on "Customers" table
    /// </summary>
    public class CustomersBusinessLogic : ICustomersBusinessLogic
    {
        //private fields
        private ICustomersDataAccess customersDataAccess;

        /// <summary>
        /// Constructor that executes when an object is created for the CustomersBusinessLogic class
        /// </summary>
        public CustomersBusinessLogic(ICustomersDataAccess customersDataAccess)
        {
            //initialize customersDataAccess
            this.customersDataAccess = customersDataAccess;
        }

        /// <summary>
        /// Get all rows from "customers" table
        /// </summary>
        /// <returns>List of customers</returns>
        public List<CustomerViewModel> GetCustomers()
        {
            List<Customer> customers = customersDataAccess.GetCustomers().ToList();

            //Way 1:
            //List<CustomerViewModel> customersViewModels = new List<CustomerViewModel>(); //empty collection
            //foreach (Customer cust in customers) //read and assign each customer into that collection
            //{
            //    customersViewModels.Add(new CustomerViewModel() { CustomerID = cust.CustomerID, CustomerName = cust.CustomerName });
            //}

            //Way 2
            List<CustomerViewModel> customersViewModels = customers
                .Select(temp => 
            new CustomerViewModel() { CustomerID = temp.CustomerID, 
                CustomerName = temp.CustomerName })
                .ToList();

            return customersViewModels;
        }

        /// <summary>
        /// Inserts a new row into customers table
        /// </summary>
        /// <param name="customer">New customer that has to be inserted</param>
        /// <returns>Same customer after inserting</returns>
        public CustomerViewModel InsertCustomer(InsertCustomerViewModel customerViewModel)
        {
            if (customerViewModel.DateOfJoining > Convert.ToDateTime("2000-01-01"))
            {
                //convert ViewModel (InsertCustomerViewModel) to DomainModel (Customer)
                Customer customer = new Customer();
                customer.CustomerName = customerViewModel.CustomerName;
                customer.DateOfJoining = customerViewModel.DateOfJoining;
                //initialize the customer id
                customer.CustomerID = Guid.NewGuid();

                //convert Customer to CustomerViewModel
                Customer customerAfterInsert = customersDataAccess.InsertCustomer(customer);
                CustomerViewModel customerViewModelAfterInsert = new CustomerViewModel()
                {
                    CustomerID = customerAfterInsert.CustomerID,
                    CustomerName = customerAfterInsert.CustomerName
                };

                return customerViewModelAfterInsert;
            }
            else
            {
                //return null;
                throw new Exception("Date of joining should be greater than Jan 01 1950");
            }
        }
    }
}
