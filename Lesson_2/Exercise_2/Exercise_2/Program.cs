using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную температуру за сутки");
            var minTemp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру за сутки");
            var maxTemp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Среднесуточная температура: {(double)(minTemp + maxTemp)/2}");
        }
    }
}
