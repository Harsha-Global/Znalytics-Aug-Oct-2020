public class Sample
{
    public void CalculateSimpleInterest(double principle, int noOfYears, double rateOfInterest)
    {
        //principle = 20000;
        //local variable
        double si = (principle * noOfYears * rateOfInterest) / 100;
        System.Console.WriteLine(si);
    }

    public void CalculateSimpleInterest(double principle, double rateOfInterest)
    {
        //local variable
        double si = (principle * 1 * rateOfInterest) / 100;
        System.Console.WriteLine(si);
    }

    public void CalculateSimpleInterest(double rateOfInterest)
    {
        //local variable
        double si = (10000 * 1 * rateOfInterest) / 100;
        System.Console.WriteLine(si);
    }
}

