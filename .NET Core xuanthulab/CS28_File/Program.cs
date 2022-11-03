using System;
using System.IO;

namespace CS28_File
{
    // DriveInfo
    // Directory - Thu muc
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // var drives = DriveInfo.GetDrives();
            // foreach (var drive in drives)
            // {
            //     System.Console.WriteLine($"Drive: {drive.Name}");
            //     System.Console.WriteLine($"Drive Type: {drive.DriveType}");
            //     System.Console.WriteLine($"Label: {drive.VolumeLabel}");
            //     System.Console.WriteLine($"Drive format: {drive.DriveFormat}");
            //     System.Console.WriteLine($"Size: {drive.TotalSize}");
            //     System.Console.WriteLine($"Free: {drive.TotalFreeSpace}");
            //     System.Console.WriteLine("--------------------------------");
            // }
            //vd2
            // string path = "obj";
            // var files = Directory.GetFiles(path);
            // var directories = Directory.GetDirectories(path);
            // foreach (var item in files)
            // {
            //     System.Console.WriteLine(item);
            // }
            // vd3
            Console.WriteLine(Path.DirectorySeparatorChar);
            var path = Path.Combine("Dir1", "Dir2", "Tenfile.txt");
            System.Console.WriteLine(Path.GetDirectoryName(path));
        }
    }
}
