using System;
using System.Text.RegularExpressions;

namespace RegularExpressionsValidationsExample
{
    class Customer
    {
        private string _email;

        public string Email
        {
            set
            {
                Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                if (regex.IsMatch(value) == true)
                {
                    _email = value;
                }
                else
                {
                    throw new Exception("Email should not contain spaces and should include @ symbol.");
                }
            }

            get
            {
                return _email;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            try
            {
                Customer customer = new Customer();

                //reading email from keyboard
                Console.WriteLine("Email: ");
                customer.Email = Console.ReadLine();

                Console.WriteLine(customer.Email);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
