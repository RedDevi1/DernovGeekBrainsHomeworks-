using System;

namespace Exercise_1_hard
{
    class Program
    {
        static void Main(string[] args)
        {
            var curNum = 1; // current number
            for (int i = 0; i < 7; i++)
            {
                if (curNum <= 90)
                    Console.Write($"{curNum} {curNum + 1 } Fizz {curNum + 3 } Buzz Fizz {curNum + 6 } {curNum + 7 } " +
                        $"Fizz Buzz {curNum + 10 } Fizz {curNum + 12 } {curNum + 13 } FizzBuzz ");
                else
                    Console.Write("91 92 Fizz 94 Buzz Fizz 97 98 Fizz Buzz");
                curNum += 15;
            }
        }
    }
}
