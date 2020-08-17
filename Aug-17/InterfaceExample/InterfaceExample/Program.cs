class Program
{
    static void Main()
    {
        //reference variable of interface (can store address of object of child classes)
        BankAccount bankAccount;

        bankAccount = new SavingsAccount();
        System.Console.WriteLine(bankAccount.CalculateInterest(1000)); //Output: 100 //calls SavingsAccount.CalculateInterest

        bankAccount = new CurrentAccount();
        System.Console.WriteLine(bankAccount.CalculateInterest(1000)); //Output: 0 //calls CurrentAccount.CalculateInterest

        System.Console.ReadKey();
    }
}


