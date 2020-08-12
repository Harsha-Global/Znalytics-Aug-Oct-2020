using System.Runtime.CompilerServices;

public class Customer
{
    //private fields
    private string _customerName;
    private string _email;
    private static string _branchName;

    //public methods
    public void SetCustomerName(string value)
    {
        if (value.Length <= 30)
        {
            this._customerName = value;
        }
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public void SetEmail(string value)
    {
        bool isSpaceFound = false; //local variable
        for (int i = 0; i < value.Length; i++)
        {
            if (value[i] == ' ')
            {
                isSpaceFound = true;
            }
        }

        if (isSpaceFound == false)
        {
            _email = value;
        }
    }

    public string GetEmail()
    {
        return _email;
    }

    public static void SetBranchName(string value)
    {
        if (value.Length <= 20)
        {
            _branchName = value;
        }
    }

    public static string GetBranchName()
    {
        return _branchName;
    }
}

