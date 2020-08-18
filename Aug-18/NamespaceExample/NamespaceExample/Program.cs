using static System.Console;

namespace Znalytics
{
    namespace OnlineShopping.PresentationLayer
    {
        class Program
        {
            static void Main()
            {
                //Login
                WriteLine("ONLINE SHOPPING");
                WriteLine("==================================");
                Write("\nUsername:");
                string userName = ReadLine();
                System.Console.Write("Password:");
                string password = ReadLine();

                if (userName == "system" && password == "manager")
                {
                    MenuPresenter.Menu();
                }

                ReadKey();
            }
        }
    }
}
