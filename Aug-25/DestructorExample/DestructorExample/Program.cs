using System;
using ClassLibrary1;

namespace DestructorExample
{
    class Program
    {
        static void Main()
        {
            //create object
            using (ZnalyticsReader znalyticsReader = new ZnalyticsReader())
            {
                //read the file
                Console.WriteLine(znalyticsReader.GetData()); //Welcome to Znalytics
            } //automatically language calls Dispose method here.



            /////////lot of other code



            Console.ReadKey();
        } //automatically destructor will be called
    }
}


