class Program
{
    static void Main()
    {
        Customer c; //create reference variable
        c = new Customer(); //create object
        c.customerID = int.Parse(System.Console.ReadLine());
        c.customerName = System.Console.ReadLine();

        System.Console.WriteLine(c.customerID); //Output: 1
        System.Console.WriteLine(c.customerName); //Output: Harsha
        System.Console.ReadKey();
    }
}

