using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] phBook = new string[5, 2];
            phBook[0, 0] = "Имя контакта ";
            phBook[0, 1] = "Номер телефона/e-mail контакта";

            for (int i = 1; i < phBook.GetLength(0); i++)
            {
                for (int j = 0; j < phBook.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine("Введите имя контакта");
                        phBook[i, j] = Console.ReadLine();

                    }
                    else
                    {
                        Console.WriteLine("Введите номер телефона/e-mail контакта");
                        phBook[i, j] = Console.ReadLine();

                    }
                    Console.Clear();
                }
            }
            Console.Clear();
            for (int i = 0; i < phBook.GetLength(0); i++)
            {
                for (int j = 0; j < phBook.GetLength(1); j++)
                {
                    Console.Write($"{phBook[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
