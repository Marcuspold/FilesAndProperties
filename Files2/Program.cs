using System;
using System.Collections.Generic;
using System.IO;

namespace Files2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Góod Morning!");
            //to get the files name only 
            string rootpath = @"C:\Users\opilane\samples";
            string[] files = Directory.GetFiles(rootpath, "*.*", SearchOption.AllDirectories);
            List<string> lines = new List<string>();

            foreach (string file in files)
            {
                Console.WriteLine(file);
                //get file objects
                var FileData = new FileInfo(file);
                Console.WriteLine(FileData);
                string fileName = FileData.Name;
                string FileDirectory = FileData.DirectoryName;
                long FileSize = FileData.Length;

                Console.WriteLine($"File name: {fileName}; location: {FileDirectory}; Size: {FileSize}");
                string line = ($"File name: {fileName}; location: {FileDirectory}; Size: {FileSize} bytes");
                lines.Add(line);
            }

            string FileDataPath = @"C:\Users\opilane\samples\FileData.Txt";
            File.WriteAllLines(FileDataPath, lines);
        }
    }
}
