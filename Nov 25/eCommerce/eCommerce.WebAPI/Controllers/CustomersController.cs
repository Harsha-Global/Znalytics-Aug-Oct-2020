using eCommerce.BusinessLogicLayer;
using eCommerce.WebAPI.DomainModels;
using eCommerce.WebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace eCommerce.WebAPI.Controllers
{
    /// <summary>
    /// Contains methods to receive HTTP requests from the client for manipulation on "customers" table
    /// </summary>
    [EnableCors("http://localhost:4200", "*", "GET,POST")]
    public class CustomersController : ApiController
    {
        //private fields
        private ICustomersBusinessLogic customersBusinessLogic;

        /// <summary>
        /// Constructor executes when an object is created for the CustomersController
        /// </summary>
        public CustomersController(ICustomersBusinessLogic bussiness)
        {
            customersBusinessLogic = bussiness;
        }

        //GET: /api/Customers
        public List<CustomerViewModel> Get()
        {
            List<CustomerViewModel> customers = customersBusinessLogic.GetCustomers();
            return customers;
        }

        //POST: /api/Customers
        public CustomerViewModel Post(InsertCustomerViewModel customerViewModel)
        {
            CustomerViewModel customerAfterInsert = customersBusinessLogic.InsertCustomer(customerViewModel);
            return customerAfterInsert;
        }
    }
}

