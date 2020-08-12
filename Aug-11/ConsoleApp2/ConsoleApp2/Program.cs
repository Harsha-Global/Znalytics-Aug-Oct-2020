//child class at other assembly
class PriviligedCustomer : Customer
{
    public void method1()
    {
        customerID = 101; //not accessible
        customerName = "john"; //accessible
        phone = 98989898; //not accessible
        email = "john@gmail.com"; //not accessible
        address = "hyderabad"; //accessible
    }
}

//other class at other assembly
class Program
{
    static void Main()
    {
        Customer c; //create reference variable
        c = new Customer(); //create object
        c.customerID = int.Parse(System.Console.ReadLine()); //not accessible
        c.customerName = System.Console.ReadLine(); //not accessible
        c.phone = 98989898; //not accessible
        c.email = "osidjf@gmail.com"; //not accessible
        c.address = "slkjdf"; //not accessible

        System.Console.WriteLine(c.customerID); //Output: 1
        System.Console.WriteLine(c.customerName); //Output: Harsha
        System.Console.ReadKey();
    }
}

