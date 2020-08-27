using System;
using System.IO;

namespace DirectoryExample
{
    class Program
    {
        static void Main()
        {
            //GetDirectories
            string[] directories = Directory.GetDirectories(@"C:\Users\Harsha\Desktop\Training\Csharp", "*a*");
            foreach (string dir in directories)
            {
                Console.WriteLine(dir);
            }
            Console.WriteLine();

            //GetFiles
            string[] files = Directory.GetFiles(@"C:\Users\Harsha\Desktop\Training\Csharp");
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            Console.ReadKey();
        }
    }
}
