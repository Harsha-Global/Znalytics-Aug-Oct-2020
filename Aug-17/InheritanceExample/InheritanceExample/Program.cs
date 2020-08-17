class Program
{
    static void Main()
    {
        //read inputs
        System.Console.WriteLine("Enter person name:");
        string s = System.Console.ReadLine();

        System.Console.WriteLine("Enter Emp ID:");
        int n = int.Parse(System.Console.ReadLine());

        //create object of child class (ContractBasedEmployee)
        ContractBasedEmployee emp = new ContractBasedEmployee(s, n);

        //call the method from the child class's object
        emp.Display(100); //Output: Person Name: xxxxx, Emp ID: xxxxxxxxxx

        System.Console.ReadKey();
    }
}

