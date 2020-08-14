using System.Windows.Markup;
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

        SetCustomerName(customerName);
        SetPhone(phone);
    }


    /// <summary>
    /// Parameterless constructor
    /// </summary>
    public Customer()
    {
        //not initializing
    }

    /// <summary>
    /// Sets value into CustomerName
    /// </summary>
    /// <param name="customerName">Name of the customer</param>
    public void SetCustomerName(string customerName)
    {
        _customerName = customerName;
    }

    /// <summary>
    /// Returns value of _customerName
    /// </summary>
    /// <returns>Name of the customer</returns>
    public string GetCustomerName()
    {
        return _customerName;
    }

    /// <summary>
    /// Sets value into phone
    /// </summary>
    /// <param name="phone">Phone number of the customer</param>
    public void SetPhone(string phone)
    {
        _phone = phone;
    }

    /// <summary>
    /// Returns Phone number of customer
    /// </summary>
    /// <returns>Phone number</returns>
    public string GetPhone()
    {
        return _phone;
    }
}