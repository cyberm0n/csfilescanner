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
                var files = Directory.GetFiles(drive.Name, "*.*", SearchOption.AllDirectories);

                List<string> imageFiles = new List<string>();
                foreach (string filename in files)
                {
                    if (Regex.IsMatch(filename, @"\.jpg$|\.png$|\.rar$|\.txt$|\.exe$|\.gif$"))
                        imageFiles.Add(filename);
                }

                foreach (string filenames in imageFiles)
                {
                    Console.WriteLine(filenames);
                }
            }


        }
    }
}
