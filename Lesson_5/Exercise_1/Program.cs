using System;
using System.IO;
namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные");
            var input = Console.ReadLine();
            var fileName = "Data.txt";
            File.WriteAllText(fileName, input);
        }
    }
}
