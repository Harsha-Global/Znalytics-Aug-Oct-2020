public abstract class BankAccount
{
    //non-abstract method
    public void NewAccount()
    {
        //code here
    }

    //abstract method
    public abstract double CalculateInterest(double Balance);
}

public class SavingsAccount : BankAccount
{
    public override double CalculateInterest(double Balance)
    {
        //actual interest calculation of Savings Account
        return 100;
    }
}

public class CurrentAccount : BankAccount
{
    public override double CalculateInterest(double Balance)
    {
        return 0;
    }
}

