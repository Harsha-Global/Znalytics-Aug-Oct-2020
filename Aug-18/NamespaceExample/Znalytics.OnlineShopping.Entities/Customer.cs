namespace Znalytics.OnlineShopping.CustomersModule.Entities
{
    public class Customer
    {
        private string _customerName;
        private string _email;

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

        public string Email
        {
            set
            {
                _email = value;
            }
            get
            {
                return _email;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "Customer Name: " + CustomerName + ", Email: " + Email;
        }

        public override int GetHashCode()
        {
            return 1000;
        }

        public override bool Equals(object obj)
        {
            Customer cust2 = (Customer)obj;
            return this.CustomerName == cust2.CustomerName && this.Email == cust2.Email;
        }
    }
}

