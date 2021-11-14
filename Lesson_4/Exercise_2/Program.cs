using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите набор чисел через пробел");
            string numbers = Console.ReadLine();
            string[] stringNumArray = numbers.Split(' ');
            var intNumArray = new int[stringNumArray.Length];
            var sum = 0;
            for (int i = 0; i < stringNumArray.Length; i++)
            {
                intNumArray[i] = Convert.ToInt32(stringNumArray[i]);
                sum += intNumArray[i];
            }
            Console.WriteLine($"Сумма всех чисел равна {sum}");
        }
    }
}
