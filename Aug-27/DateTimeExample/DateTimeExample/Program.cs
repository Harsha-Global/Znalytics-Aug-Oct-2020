using System;

namespace DateTimeExample
{
    class Program
    {
        static void Main()
        {
            //create structure instance
            //DateTime dt = new DateTime(2020, 8, 27, 9, 46, 10, 400);
            //DateTime dt =  System.Convert.ToDateTime("2020-08-27 9:46:10.400");
            //DateTime dt = System.Convert.ToDateTime(System.Console.ReadLine());
            DateTime dt = DateTime.Now;

            //to get individual values
            int a = dt.Day;
            int b = dt.Month;
            int c = dt.Year;
            int d = dt.Hour;
            int e = dt.Minute;
            int f = dt.Second;
            int g = dt.Millisecond;
            DayOfWeek h = dt.DayOfWeek;
            string i = dt.ToShortDateString();
            string j = dt.ToLongDateString();
            string k = dt.ToShortTimeString();
            string l = dt.ToLongTimeString();
            string m = dt.ToString();
            string n = dt.ToString("dd/M/yyyy hh:mm:ss tt");

            Console.WriteLine(dt); //8/27/2020 9:54:15 AM
            Console.WriteLine(a); //27
            Console.WriteLine(b); //8
            Console.WriteLine(c); //2020
            Console.WriteLine(d); //9
            Console.WriteLine(e); //54
            Console.WriteLine(f); //15
            Console.WriteLine(g); //100
            Console.WriteLine(h); //Thursday
            Console.WriteLine((int)h); //4
            Console.WriteLine(i); //MM/dd/yyyy
            Console.WriteLine(j); //Thursday, August 27, 2020
            Console.WriteLine(k); //10:02 AM
            Console.WriteLine(l); //10:02:10 AM
            Console.WriteLine(m); //8/27/2020 10:02:10 AM
            Console.WriteLine(n); //27/8/2020 10:02:10 AM

            Console.ReadKey();
        }
    }
}
