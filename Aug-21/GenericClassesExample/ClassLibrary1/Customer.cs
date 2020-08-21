public class Customer
{
    public int CustomerID { get; set; }
    public string CustomerName { get; set; }
}

public class RegisteredCustomer : Customer
{
    public int RegNo { get; set; }
}

