using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmlFormatterExample
{
    [Serializable]
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
            ///////////////////////CUSTOMER DETAILS FROM KEYBOARD/////////////////////
            List<Customer> customers = new List<Customer>()
            {
                new Customer() { CustomerID = 1, CustomerName = "Scott", DateOfBirth = Convert.ToDateTime("2000-06-16"), IsRegistered = true },
                new Customer() { CustomerID = 2, CustomerName = "Allen", DateOfBirth = Convert.ToDateTime("1995-09-30"), IsRegistered = false },
                new Customer() { CustomerID = 3, CustomerName = "Jones", DateOfBirth = Convert.ToDateTime("1986-02-27"), IsRegistered = false },
                new Customer() { CustomerID = 4, CustomerName = "James", DateOfBirth = Convert.ToDateTime("2010-11-12"), IsRegistered = true }
            };


            ////////////////////////////////////WRITING/////////////////
            //create object of BinaryWriter
            FileStream fs = new FileStream(@"C:\Users\Harsha\Desktop\Training\CustomerXml.txt", FileMode.Create, FileAccess.Write);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Customer>));

            //write data into file
            xmlSerializer.Serialize(fs, customers);

            //close the file
            fs.Close();


            ////////////////////////////////READING//////////////////////
            //create object of BinaryReader
            FileStream fs2 = new FileStream(@"C:\Users\Harsha\Desktop\Training\CustomerXml.txt", FileMode.Open, FileAccess.Read);

            //read data from the file
            List<Customer> customers2= (List<Customer>)xmlSerializer.Deserialize(fs2);

            fs2.Close();

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
