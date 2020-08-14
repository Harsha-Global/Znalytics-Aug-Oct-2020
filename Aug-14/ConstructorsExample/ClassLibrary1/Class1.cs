using System;
/// <summary>
/// Represents customer
/// </summary>
public class Customer
{
    //private fields
    private string _customerName;
    private string _phone;
    private static string _branchName;
    
    //automatic property (or) auto-implemented property
    public string Email { set; get; }
    public string City { get; set; } = "Hyderabad";

    /// <summary>
    /// Constructor that initializes details of Customer
    /// </summary>
    /// <param name="customerName">Represents name of the customer</param>
    /// <param name="phone">Phone number of the customer</param>
    public Customer(string customerName, string phone, string email)
    {
        //_customerName = customerName;
        //_phone = phone;

        CustomerName = customerName; //set method will be called
        Phone = phone; //set method will be called
        Email = email;
    }


    /// <summary>
    /// Parameterless constructor
    /// </summary>
    public Customer()
    {
        //not initializing
    }


    /// <summary>
    /// Static constructor
    /// </summary>
    static Customer()
    {
        _branchName = "ABC Branch";
    }

    /// <summary>
    /// Represents name of the customer
    /// </summary>
    public string CustomerName
    {
        set
        {
            //Name should be less than 30 stringacters
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
            else
            {
                throw new Exception("Phone number should contain 10 digits only");
            }
        }
        get
        {
            return _phone;
        }
    }
}