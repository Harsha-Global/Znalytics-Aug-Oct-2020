using System;
using System.IO;

namespace ClassLibrary1
{
    public class ZnalyticsReader : System.IDisposable
    {
        //private field
        StreamReader _sr;

        //open file connection: constructor
        public ZnalyticsReader()
        {
            _sr = new StreamReader("C:\\Users\\Harsha\\Desktop\\Znalytics.txt");
        }

        //read file: method
        public string GetData()
        {
            string s = _sr.ReadToEnd();
            return s;
        }

        //close file connection: destructor
        //~ZnalyticsReader()
        //{
        //    Console.WriteLine("Destructor");
        //    _sr.Close();
        //}

        //close file connection: Dispose
        public void Dispose()
        {
            Console.WriteLine("Dispose");
            _sr.Close();
        }
    }
}


