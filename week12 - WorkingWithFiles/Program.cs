using System;
using System.IO;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //приложение позволяет пользователю выбрать операцию с файлом
            //create - программа создаст для пользователя файл с введенным пользователем
            //именем в папке Data
            //move - программа переместит выбранный пользователем файл в папку myData
            //delete - программа удалит выбранный пользователем файл из
            //папки Data
            //* приложение должно работать с помощью функций, вызываемых в методе
            //Main название github репозитория: week12 - WorkingWithFiles

            Console.WriteLine("What do you want to do with your file?");
            Console.WriteLine("Choose one operation: Create (press C), Move (press M), Delete (press D):");
            char operation = Convert.ToChar(Console.ReadLine().ToLower().ToUpper());

            switch (operation)
            {
                case 'C': createFile(); break;
                case 'M': moveFile(); break;
                case 'D': deleteFile(); break;
                default: break;
            }

        }

        private static void createFile()
        {

            Console.WriteLine("Please, input a file name:");
            string fileName = Console.ReadLine().ToUpper().ToLower();

            string fileRoot = @"C:\Users\slupi\source\repos\week12 - WorkingWithFiles\Data\";
            string filePath = fileRoot + fileName + ".txt";

            if (File.Exists(filePath))
            {
                Console.WriteLine($"File {fileName}.txt already exists in {fileRoot}.");
            }
            else
            {
                File.Create(filePath);
                Console.WriteLine($"File {fileName}.txt has been successfully created in {fileRoot}.");
            }

        }

        private static void moveFile()
        {
            Console.WriteLine("Please, input a file name to be moved from Data to myData:");
            string fileName = Console.ReadLine().ToUpper().ToLower();

            string sourceDirectory = @"C:\Users\slupi\source\repos\week12 - WorkingWithFiles\Data\";
            string destinationDirectory = @"C:\Users\slupi\source\repos\week12 - WorkingWithFiles\myData\";

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

        private static void deleteFile()
        {

            Console.WriteLine("Please, input the name of the file to delete:");
            string fileName = Console.ReadLine().ToUpper().ToLower();

            string fileRooth = @"C:\Users\slupi\source\repos\week12 - WorkingWithFiles\Data\";
            string filePath = fileRooth + fileName + ".txt";

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine($"File {fileName}.txt has been deleted.");
            }
            else
            {
                Console.WriteLine($"{fileName}.txt was not found.");
            }
        }
    }
}