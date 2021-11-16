using System;
using System.IO;

namespace Exercise_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь, дерерво каталогов и файлов которого требуется сохранить");
            var path = Console.ReadLine();
            Console.WriteLine(Directory.Exists(path));
            AppendWithRecursion(new DirectoryInfo(path));
        }
        static void AppendWithRecursion(DirectoryInfo root)
        {
            var filePath = "filepath.txt";
            FileInfo[] files = root.GetFiles("*.*");
            if (files != null)
            {
                foreach (FileInfo nameOfFile in files) //append all the file names to "filepath.txt"
                {
                    File.AppendAllText(filePath, nameOfFile.FullName);
                    File.AppendAllText(filePath, Environment.NewLine);
                }
                DirectoryInfo[] subDir = root.GetDirectories(); //get all the subdirectories
                foreach (DirectoryInfo curDir in subDir)
                    AppendWithRecursion(curDir);
            }
        }
    }
}
