using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение большее, либо равное нулю");
            var value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Число Фибоначчи для значения {value} равно {Fibo(value)}");
            static int Fibo(int value)
            {
                if (value == 0)
                    return 0;
                if (value == 1 || value == 2)
                    return 1;
                return Fibo(value - 1) + Fibo(value - 2);
            }
        }
    }
}
