class Program
{
    static void Main()
    {
        int n = 9;
        Sample s = new Sample();
        double d = s.GetFactorial(n);
        System.Console.WriteLine(d);
        System.Console.ReadKey();
    }
}

