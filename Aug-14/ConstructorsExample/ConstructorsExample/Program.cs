class Program
{
    static void Main()
    {
        System.Console.WriteLine("Enter customer name:");
        string custName = System.Console.ReadLine();
        System.Console.WriteLine("Enter phone:");
        string ph = System.Console.ReadLine();
        Customer customer = new Customer(custName, ph);


        System.Console.WriteLine(customer.CustomerName); //get method will be called
        System.Console.WriteLine(customer.Phone); //get method will be called

        customer.CustomerName = "Other name"; //set method will be called
        customer.Phone = "39483948394";

        Customer customer2 = new Customer() { CustomerName = System.Console.ReadLine(), Phone = "7778734873" };

        System.Console.ReadKey();
    }
}

