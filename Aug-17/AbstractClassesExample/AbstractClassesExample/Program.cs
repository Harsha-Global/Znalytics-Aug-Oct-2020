class Program
{
    static void Main()
    {
        SavingsAccount savingsAccount = new SavingsAccount();
        System.Console.WriteLine(savingsAccount.CalculateInterest(1000)); //Output: 100

        CurrentAccount currentAccount = new CurrentAccount();
        System.Console.WriteLine(currentAccount.CalculateInterest(1000)); //Output: 0

        System.Console.ReadKey();
    }
}


