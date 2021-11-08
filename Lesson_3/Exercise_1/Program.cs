using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,]array = new int[5, 5];
            for (int i = 0; i < array.GetLength(0);i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                        Console.WriteLine(array[i,j]);
                    else
                        continue;
                }
            }

        }
    }
}
