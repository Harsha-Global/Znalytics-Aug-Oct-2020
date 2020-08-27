using System;
using System.IO;

namespace FileStreamExample
{
    class Program
    {
        static void Main()
        {
            /////////////////////////////////FILE WRITING/////////////////////////////////////
            //create object for FileStream for c:\Users\Harsha\Desktop\Training\ListOfTopics.txt - C#, SQL Server
            FileStream fileStream = new FileStream(@"c:\Users\Harsha\Desktop\Training\ListOfTopics.txt", FileMode.Create, FileAccess.Write);

            //data
            string data = "The following topics are covered:\nC#, SQL Server";

            //convert data into byte[]
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(data);

            //write byte[] into fileStream
            fileStream.Write(bytes, 0, bytes.Length);

            //close
            fileStream.Close();

            Console.WriteLine("File created successfully.");





            /////////////////////////////////FILE WRITING/////////////////////////////////////
            //create object for FileInfo for c:\Users\Harsha\Desktop\Training\ListOfTopics.txt - C#, SQL Server
            FileStream fileStream2 = new FileStream(@"c:\Users\Harsha\Desktop\Training\ListOfTopics.txt", FileMode.Open, FileAccess.Read);

            //create a blank byte[]
            byte[] bytes2 = new byte[fileStream2.Length];

            //get byte[] from the file
            fileStream2.Read(bytes2, 0, bytes2.Length);

            //convert  byte[] into string
            string s = System.Text.Encoding.ASCII.GetString(bytes2);
            Console.WriteLine(s); //Output: Actual content of file

            //close
            fileStream2.Close();

            Console.WriteLine("File read successfully.");
            Console.ReadKey();
        }
    }
}

