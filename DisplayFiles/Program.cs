using System;
using System.IO;

namespace DisplayFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayFiles();
        }

        public static void DisplayFiles()
        {
            string directoryPath = @"C:\Users\slupi\source\repos\week12 - WorkingWithFiles\myData\";
            string[] allFiles = Directory.GetFiles(directoryPath, "*.*");

            foreach (string file in allFiles)
            {
                string fileName = new FileInfo(file).Name;
                string fileCreationDate = new FileInfo(file).CreationTime.ToString();
                Console.WriteLine($"{fileName} {fileCreationDate}");
            }
        }
    }
}