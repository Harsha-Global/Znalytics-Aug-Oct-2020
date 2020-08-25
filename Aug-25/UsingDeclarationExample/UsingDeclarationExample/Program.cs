using System;
using ClassLibrary1;

namespace SampleNamespace
{
    class OtherClass
    {
        public void OtherMethod()
        {
            //create object
            using ZnalyticsReader znalyticsReader = new ZnalyticsReader();

            //read the file
            Console.WriteLine(znalyticsReader.GetData()); //Welcome to Znalytics

        } //automatically language calls Dispose method here.
    }

    class Program
    {
        static void Main()
        {
            OtherClass oc = new OtherClass();
            oc.OtherMethod();



            /////////lot of other code



            Console.ReadKey();
        } //automatically destructor will be called
    }
}


