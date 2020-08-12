class Program
{
    static void Main()
    {
        //create reference variable & object
        Customer c1 = new Customer();

        //access methods
        System.Console.WriteLine("Enter customer name:");
        c1.SetCustomerName(System.Console.ReadLine());
        System.Console.WriteLine(c1.GetCustomerName());

        System.Console.WriteLine("Enter email:");
        c1.SetEmail(System.Console.ReadLine());
        System.Console.WriteLine(c1.GetEmail());

        Customer c2;
        c2 = new Customer();
        c2.SetCustomerName(System.Console.ReadLine());

        Customer.SetBranchName(System.Console.ReadLine());
        System.Console.WriteLine(Customer.GetBranchName());

        System.Console.ReadKey();
    }
}

