public class Sample
{
    public double GetFactorial(double n)
    {
        if (n == 1)
        {
            return 1;
        }
        else
        {
            return n * GetFactorial(n - 1);
        }
    }
}


