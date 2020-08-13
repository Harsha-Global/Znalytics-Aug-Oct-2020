class Program
{
    static void Main()
    {
        int age;
        bool b;
        do
        {
            System.Console.WriteLine("Enter your age:");
            b = int.TryParse(System.Console.ReadLine(), out age);
            if (b == true)
            {
                System.Console.WriteLine("Your age: " + age);
            }
            else
            {
                System.Console.WriteLine("Please enter numerical values");
            }
        } while (b == false);

        System.Console.ReadKey();
    }
}
