using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BinaryFormatterExample
{
    [Serializable]
    class Customer
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
            Customer customer = new Customer();
            Console.Write("Customer ID: ");
            customer.CustomerID = int.Parse(Console.ReadLine());
            Console.Write("Customer Name: ");
            customer.CustomerName = Console.ReadLine();
            Console.Write("Date of Birth: ");
            customer.DateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.Write("Is Registered (true / false): ");
            customer.IsRegistered = Convert.ToBoolean(Console.ReadLine());


            ////////////////////////////////////WRITING/////////////////
            //create object of BinaryWriter
            FileStream fs = new FileStream(@"C:\Users\Harsha\Desktop\Training\CustomerBinary.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            //write data into file
            binaryFormatter.Serialize(fs, customer);
            
            //close the file
            fs.Close();


            ////////////////////////////////READING//////////////////////
            //create object of BinaryReader
            FileStream fs2 = new FileStream(@"C:\Users\Harsha\Desktop\Training\CustomerBinary.txt", FileMode.Open, FileAccess.Read);

            //read data from the file
            Customer cust2 = (Customer)binaryFormatter.Deserialize(fs2);

            fs2.Close();

            Console.WriteLine("Customer ID: " + cust2.CustomerID);
            Console.WriteLine("Customer Name: " + cust2.CustomerName);
            Console.WriteLine("Date of Birth: " + cust2.DateOfBirth.ToShortDateString());
            Console.WriteLine("Is Registered: " + cust2.IsRegistered);

            Console.ReadKey();
        }
    }
}
