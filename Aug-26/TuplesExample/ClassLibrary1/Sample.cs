using System;

namespace ClassLibrary1
{
    public class Sample
    {
        public Tuple<string, int> GetCustomerDetails()
        {
            return new Tuple<string, int>("Scott", 20);
        }
    }
}

