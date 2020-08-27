//FileInfo
using System;
using System.IO;

namespace FileInfoExample
{
    class Program
    {
        static void Main()
        {
            //Create an object of FileInfo
            FileInfo fileInfo = new FileInfo(@"C:\Users\Harsha\Desktop\Znalytics.txt");

            //Properties
            Console.WriteLine(fileInfo.Exists); //True
            if (fileInfo.Exists)
            {
                Console.WriteLine(fileInfo.FullName); //C:\Users\Harsha\Desktop\Znalytics2.txt
                Console.WriteLine(fileInfo.Name); //Znalytics2.txt
                Console.WriteLine(fileInfo.DirectoryName); //C:\Users\Harsha\Desktop
                Console.WriteLine(fileInfo.Extension); //txt
                Console.WriteLine(fileInfo.CreationTime.ToString("dd/MM/yyyy hh:mm:ss tt")); //Tuesday, ‎August ‎25, ‎2020, ‏‎10:48:36 AM
                Console.WriteLine(fileInfo.LastWriteTime.ToString("dd/MM/yyyy hh:mm:ss tt")); //Tuesday, ‎August ‎25, ‎2020, ‏‎10:48:36 AM
                Console.WriteLine(fileInfo.LastAccessTime.ToString("dd/MM/yyyy hh:mm:ss tt")); //Tuesday, ‎August ‎25, ‎2020, ‏‎10:48:36 AM
                Console.WriteLine(fileInfo.Length + " bytes"); //Size of the file

                //fileInfo.Delete(); //File will be deleted
            }
            else
            {
                fileInfo.Create();
            }

            Console.ReadKey();
        }
    }
}
