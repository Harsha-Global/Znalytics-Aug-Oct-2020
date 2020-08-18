namespace Znalytics.OnlineShopping.CustomersModule.Entities
{
    public class Customer
    {
        public string _customerName;

        public string CustomerName
        {
            set
            {
                if (value.Length <= 30)
                {
                    _customerName = value;
                }
            }
            get
            {
                return _customerName;
            }
        }
    }
}

