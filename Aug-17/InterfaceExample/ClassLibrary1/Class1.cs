public interface BankAccount
{
    //auto-implemented property
    string AccountNumber { get; set; }

    //abstract methods
    void NewAccount();
    double CalculateInterest(double Balance);
}

public interface OtherInterface: BankAccount
{
    void OtherMethod();
}
public class SavingsAccount : OtherInterface
{
    public double CalculateInterest(double Balance)
    {
        //actual interest calculation of Savings Account
        return 100;
    }

    public void NewAccount()
    {
    }

    public string AccountNumber { get; set; }

    public void OtherMethod()
    {

    }
}

public class CurrentAccount : BankAccount
{
    public double CalculateInterest(double Balance)
    {
        return 0;
    }

    public void NewAccount()
    {
    }

    public string AccountNumber { get; set; }
}

