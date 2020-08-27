using System;

namespace DateDifferenceExample
{
    class Program
    {
        static void Main()
        {
            //Date difference
            DateTime dateOfBirth = Convert.ToDateTime("1998-07-03 7:00 am");
            DateTime presentDate = DateTime.Now;
            TimeSpan timeSpan = presentDate - dateOfBirth;
            int yearsOfAge = Convert.ToInt32(timeSpan.TotalDays / 365);
            double monthsOfAge = Math.Floor((Math.Round(timeSpan.TotalDays / 365, 1) - yearsOfAge) * 10);
            Console.WriteLine(yearsOfAge + " years and " + monthsOfAge + " months");

            Console.ReadKey();
        }
    }
}
