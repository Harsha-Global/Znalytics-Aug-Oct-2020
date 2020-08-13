class Program
{
    static void Main()
    {
        Sample s = new Sample();
        double c = 6.7;
        int b = 2;
        double a = 10000;

        s.CalculateSimpleInterest(a, b, c);
        System.Console.WriteLine(a); //Output: 20000
        System.Console.ReadKey();
    }
}

