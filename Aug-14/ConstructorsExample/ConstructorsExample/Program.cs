class Program
{
    static void Main()
    {
        System.Console.WriteLine("Enter customer name:");
        string custName = System.Console.ReadLine();
        System.Console.WriteLine("Enter phone:");
        string ph = System.Console.ReadLine();
        System.Console.WriteLine("Enter email:");
        string email = System.Console.ReadLine();
        Customer customer = new Customer(custName, ph, email);


        System.Console.WriteLine(customer.CustomerName); //get method will be called
        System.Console.WriteLine(customer.Phone); //get method will be called

        customer.CustomerName = "Other name"; //set method will be called
        customer.Phone = "39483948394";

        Customer customer2 = new Customer() { CustomerName = System.Console.ReadLine(), Phone = "7778734873" };


        //create a collection
        System.Collections.Generic.List<Customer> customers = new System.Collections.Generic.List<Customer>();
        customers.Add(customer);
        customers.Add(customer2);

        System.Console.ReadKey();
    }
}

