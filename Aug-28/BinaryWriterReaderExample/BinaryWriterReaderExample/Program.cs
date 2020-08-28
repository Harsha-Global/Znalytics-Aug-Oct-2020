using System;
using System.IO;

namespace BinaryWriterReaderExample
{
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
            FileStream fs = new FileStream(@"C:\Users\Harsha\Desktop\Training\Customer.txt", FileMode.Create, FileAccess.Write);
            BinaryWriter binaryWriter = new BinaryWriter(fs);

            //write data into file
            binaryWriter.Write(customer.CustomerID);
            binaryWriter.Write(customer.CustomerName);
            binaryWriter.Write(customer.DateOfBirth.ToString("dd/MM/yyyy"));
            binaryWriter.Write(customer.IsRegistered);

            //close the file
            binaryWriter.Close();


            ////////////////////////////////READING//////////////////////
            //create object of BinaryReader
            FileStream fs2 = new FileStream(@"C:\Users\Harsha\Desktop\Training\Customer.txt", FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fs2);

            //read data from the file
            string b = binaryReader.ReadString();
            int a = binaryReader.ReadInt32();
            string c = binaryReader.ReadString();
            bool d = binaryReader.ReadBoolean();

            binaryReader.Close();

            Console.WriteLine("Customer ID: " + a);
            Console.WriteLine("Customer Name: " + b);
            Console.WriteLine("Date of Birth: " + c);
            Console.WriteLine("Is Registered: " + d);

            Console.ReadKey();
        }
    }
}
