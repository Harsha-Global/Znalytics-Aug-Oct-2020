using System;

namespace Znalytics.OnlineShopping.PresentationLayer
{
    class Program
    {
        static void Main()
        {
            //Login
            Console.WriteLine("ONLINE SHOPPING");
            Console.WriteLine("==================================");
            Console.Write("\nUsername:");
            string userName = Console.ReadLine();
            System.Console.Write("Password:");
            string password = Console.ReadLine();

            if (userName == "system" && password == "manager")
            {
                MenuPresenter.Menu();
            }

            Console.ReadKey();
        }
    }
}
