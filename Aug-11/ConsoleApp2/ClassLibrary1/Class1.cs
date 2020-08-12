//Same class
public class Customer
{
    private int customerID;
    protected string customerName;
    private protected long phone;
    internal string email;
    protected internal string address;

    public void method1()
    {
        customerID = 101; //accessible
        customerName = "john"; //accessible
        phone = 98989898; //accessible
        email = "john@gmail.com"; //accessible
        address = "hyderabad"; //accessible
    }
}

//Child class in the same assembly
public class RegisteredCustomer : Customer
{
    public int RegNo;

    public void method1()
    {
        customerID = 101; //not accessible
        customerName = "john"; //accessible
        phone = 98989898; //accessible
        email = "john@gmail.com"; //accessible
        address = "hyderabad"; //accessible
    }
}

//Other class in the same assembly
public class OtherClass
{
    public void method1()
    {
        Customer c = new Customer();
        c.customerID = 101; //not accessible
        c.customerName = "john"; //not accessible
        c.phone = 98989898; //not accessible
        email = "john@gmail.com"; //accessible
        address = "hyderabad"; //accessible
    }
}

