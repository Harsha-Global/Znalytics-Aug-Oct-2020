using Znalytics.OnlineShopping.CustomersModule.Entities;
using Znalytics.OnlineShopping.DataAccessLayer;

namespace Znalytics.OnlineShopping.BusinessLogicLayer
{
    public class CustomerBusinessLogicLayer: ICustomerBusinessLogicLayer
    {
        private ICustomerDataAccessLayer cdal;

        public CustomerBusinessLogicLayer()
        {
            cdal = new CustomerDataAccessLayer();
        }

        public void AddCustomer(Customer customer)
        {
            if (customer.CustomerName != null)
            {
                cdal.AddCustomer(customer);
            }
        }
    }
}

