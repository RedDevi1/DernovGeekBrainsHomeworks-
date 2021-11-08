using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите элементы массива через пробел");
            string s = Console.ReadLine();
            Console.WriteLine("Введите требуемую сумму двух элементов массива");
            int target = Convert.ToInt32(Console.ReadLine());
            string[] inputStringArray = s.Split(' ');
            int[] inputArray = new int[inputStringArray.Length];

            for (int i = 0; i < inputStringArray.Length; i++)                
                inputArray[i] = Convert.ToInt32(inputStringArray[i]);
            Console.Write($"Индексы элементов массива, сумма которых равна {target}: ");
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[j] + inputArray[i] == target)
                    {
                        Console.WriteLine($"{i} и {j} ");
                    }
                }
            }
            
        }
    }
}
