using System;
using System.IO;

namespace StreamWriterAndStreamReader
{
    class Program
    {
        static void Main()
        {
            /////////////////////////////////FILE WRITING/////////////////////////////////////
            //create object for StreamWriter for c:\Users\Harsha\Desktop\Training\ListOfTopics.txt - C#, SQL Server
            StreamWriter streamWriter = new StreamWriter(@"c:\Users\Harsha\Desktop\Training\ListOfTopics.txt");

            //data
            string data = "The following topics are covered:\nC#, SQL Server";

            //write string into streamWriter
            streamWriter.Write(data);

            //close
            streamWriter.Close();

            Console.WriteLine("File created successfully.");





            /////////////////////////////////FILE WRITING/////////////////////////////////////
            //create object for StreamReader for c:\Users\Harsha\Desktop\Training\ListOfTopics.txt - C#, SQL Server
            StreamReader streamReader = new StreamReader(@"c:\Users\Harsha\Desktop\Training\ListOfTopics.txt");

            //get string from the file
            string s = streamReader.ReadToEnd();
            Console.WriteLine(s); //Output: Actual content of file

            //close
            streamReader.Close();

            Console.WriteLine("File read successfully.");
            Console.ReadKey();
        }
    }
}

