using System;
using System.Text.RegularExpressions;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {       
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in allDrives)
            {
                Console.WriteLine(drive.Name);
                var files = Directory.GetFiles(drive.Name, "*.*", SearchOption.AllDirectories);
                foreach (string filename in files)
                {
                    if (Regex.IsMatch(filename, @"\.jpg$|\.png$|\.rar$|\.txt$|\.exe$|\.gif$"))
                        Console.WriteLine(filename);
                }
            }
        }
    }
}
