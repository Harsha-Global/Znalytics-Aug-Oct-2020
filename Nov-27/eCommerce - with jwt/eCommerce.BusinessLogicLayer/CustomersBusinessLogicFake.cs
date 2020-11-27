using eCommerce.WebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.BusinessLogicLayer
{
    public class CustomersBusinessLogicFake : ICustomersBusinessLogic
    {
        public List<CustomerViewModel> GetCustomers()
        {
            return new List<CustomerViewModel>() { };
        }

        public CustomerViewModel InsertCustomer(InsertCustomerViewModel customer)
        {
            return new CustomerViewModel();
        }

        public CustomerViewModel GetCustomerByCustomerName(string customerName)
        {
            return new CustomerViewModel();
        }
    }
}

