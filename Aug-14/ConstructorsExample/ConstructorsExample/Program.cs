class Program
{
    static void Main()
    {
        System.Console.WriteLine("Enter customer name:");
        string custName = System.Console.ReadLine();
        System.Console.WriteLine("Enter phone:");
        string ph = System.Console.ReadLine();
        Customer customer = new Customer(custName, ph);

        System.Console.WriteLine(customer.GetCustomerName());
        System.Console.WriteLine(customer.GetPhone());

        System.Console.ReadKey();
    }
}

