using System;
using System.IO;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь, дерерво каталогов и файлов которого требуется сохранить");
            var path = Console.ReadLine();
            Console.WriteLine(Directory.Exists(path));
            string[] entries = Directory.GetFileSystemEntries(path, "*", SearchOption.AllDirectories);
            var filePath = "filepath.txt";
            for (int i = 0; i < entries.Length; i++)
            {
                File.AppendAllText(filePath, entries[i]);
                File.AppendAllText(filePath, Environment.NewLine);
            }            
        }
    }
}
