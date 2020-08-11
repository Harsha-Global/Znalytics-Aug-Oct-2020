class Sample
{
    static void Main()
    {
        //read inputs from the user
        double age; //Ex: 20.5
        System.Console.Write("Enter your age: ");
        age = double.Parse(System.Console.ReadLine());

        //get years and months
        int years = System.Convert.ToInt32(age);
        double months = 12 * (age - years);

        //display output
        System.Console.Write("No. of years: ");
        System.Console.WriteLine(years);
        System.Console.Write("No. of months: ");
        System.Console.WriteLine(months);
        System.Console.ReadKey();
    }
}


