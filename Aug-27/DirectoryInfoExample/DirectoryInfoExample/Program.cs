using System;
using System.IO;

namespace DirectoryInfoExample
{
    class Program
    {
        static void Main()
        {
            //create object of DirectoryInfo class that represents C:\Users\Harsha\Desktop\Training\Csharp
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\Harsha\Desktop\Training\Csharp");

            //properties
            if (directoryInfo.Exists)
            {
                Console.WriteLine(directoryInfo.Exists);
                Console.WriteLine(directoryInfo.FullName);
                Console.WriteLine(directoryInfo.Name);
                Console.WriteLine(directoryInfo.Parent);
                Console.WriteLine(directoryInfo.Root);
                Console.WriteLine(directoryInfo.CreationTime);
                Console.WriteLine(directoryInfo.LastWriteTime);
                Console.WriteLine(directoryInfo.LastAccessTime);

                //create sub folder "Arrays"
                directoryInfo.CreateSubdirectory("arrays");
                Console.WriteLine();

                //GetDirectories
                DirectoryInfo[] directories = directoryInfo.GetDirectories("*a*");
                foreach (DirectoryInfo dir in directories)
                {
                    Console.WriteLine(dir.Name);
                }
                Console.WriteLine();

                //GetFiles
                FileInfo[] files = directoryInfo.GetFiles();
                foreach (FileInfo file in files)
                {
                    Console.WriteLine(file.Name);
                }
            }
            else
            {
                directoryInfo.Create();
            }

            Console.ReadKey();
        }
    }
}
