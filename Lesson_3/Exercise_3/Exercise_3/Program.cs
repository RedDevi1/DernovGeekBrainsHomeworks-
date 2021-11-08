using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();     
            for (int index = s.Length - 1; index >= 0; index--)
                Console.Write(s[index]);
        }
    }
}
