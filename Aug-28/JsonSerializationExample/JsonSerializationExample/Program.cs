using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace XmlFormatterExample
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsRegistered { get; set; }
    }

    class Program
    {
        static void Main()
        {
            ///////////////////////CUSTOMER DETAILS/////////////////////
            List<Customer> customers = new List<Customer>()
            {
                new Customer() { CustomerID = 1, CustomerName = "Scott", DateOfBirth = Convert.ToDateTime("2000-06-16"), IsRegistered = true },
                new Customer() { CustomerID = 2, CustomerName = "Allen", DateOfBirth = Convert.ToDateTime("1995-09-30"), IsRegistered = false },
                new Customer() { CustomerID = 3, CustomerName = "Jones", DateOfBirth = Convert.ToDateTime("1986-02-27"), IsRegistered = false },
                new Customer() { CustomerID = 4, CustomerName = "James", DateOfBirth = Convert.ToDateTime("2010-11-12"), IsRegistered = true }
            };


            ////////////////////////////////////WRITING/////////////////
            //convert data into Json
            string s = JsonConvert.SerializeObject(customers);

            //write data into file
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Harsha\Desktop\Training\CustomerJson.txt");
            streamWriter.Write(s);
            streamWriter.Close();

            ////////////////////////////////READING//////////////////////
            //read data from the file
            StreamReader streamReader = new StreamReader(@"C:\Users\Harsha\Desktop\Training\CustomerJson.txt");
            string s2 = streamReader.ReadToEnd();
            List<Customer> customers2 = JsonConvert.DeserializeObject<List<Customer>>(s2);

            foreach (var item in customers2)
            {
                Console.WriteLine("Customer ID: " + item.CustomerID);
                Console.WriteLine("Customer Name: " + item.CustomerName);
                Console.WriteLine("Date of Birth: " + item.DateOfBirth.ToShortDateString());
                Console.WriteLine("Is Registered: " + item.IsRegistered);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
