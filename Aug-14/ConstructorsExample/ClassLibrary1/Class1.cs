/// <summary>
/// Represents customer
/// </summary>
public class Customer
{
    //private fields
    private string _customerName;
    private string _phone;

    /// <summary>
    /// Constructor that initializes details of Customer
    /// </summary>
    /// <param name="customerName">Represents name of the customer</param>
    /// <param name="phone">Phone number of the customer</param>
    public Customer(string customerName, string phone)
    {
        //_customerName = customerName;
        //_phone = phone;

        //SetCustomerName(customerName);
        //SetPhone(phone);

        CustomerName = customerName;
        Phone = phone;
    }


    /// <summary>
    /// Parameterless constructor
    /// </summary>
    public Customer()
    {
        //not initializing
    }


    /// <summary>
    /// Represents name of the customer
    /// </summary>
    public string CustomerName
    {
        set
        {
            //Name should be less than 30 characters
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

    /// <summary>
    /// Phone number of the customer
    /// </summary>
    public string Phone
    {
        set
        {
            //Phone number should contain 10 digits only
            if (value.Length == 10)
            {
                _phone = value;
            }
        }
        get
        {
            return _phone;
        }
    }
}