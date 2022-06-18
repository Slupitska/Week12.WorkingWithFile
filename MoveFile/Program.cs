using System;
using System.IO;

namespace MoveFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceDirectory = @"C:\Users\slupi\source\repos\week12 - WorkingWithFiles\Data\";
            string destinationDirectory = @"C:\Users\slupi\source\repos\week12 - WorkingWithFiles\myData\";

            Console.WriteLine($"Enter the file name to be moved from Data to myData:");
            string fileName = Console.ReadLine();

            string filePath = sourceDirectory + fileName + ".txt";

            if (File.Exists(filePath))
            {
                File.Move(filePath, destinationDirectory + fileName + ".txt");
                Console.WriteLine($"File {fileName} has been moved to a new directory.");
            }
            else
            {
                Console.WriteLine($"{fileName} not found in Data.");
            }
        }
    }
}