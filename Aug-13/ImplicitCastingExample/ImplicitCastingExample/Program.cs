class Program
{
    static void Main()
    {
        int a = 127;
        sbyte b;

        if (a <= sbyte.MaxValue)
        {
            b = (sbyte)a;
        }
        else
        {
            b = 0;
        }

        System.Console.WriteLine(b); //Output: 
        System.Console.ReadKey();
    }
}