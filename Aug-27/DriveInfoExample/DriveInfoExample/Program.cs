using System;
using System.IO;

namespace DriveInfoExample
{
    class Program
    {
        static void Main()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady)
                {
                    Console.Write(drive.Name + " ");
                    Console.WriteLine(drive.VolumeLabel);
                    Console.WriteLine(drive.IsReady);
                    Console.WriteLine(drive.TotalSize / 1024 / 1024 / 1024 + " GB");
                    Console.WriteLine(drive.AvailableFreeSpace / 1024 / 1024 / 1024 + " GB");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Drive is not ready");
                }
            }
            

            Console.ReadKey();
        }
    }
}
