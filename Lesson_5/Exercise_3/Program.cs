using System;
using System.IO;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольный набор чисел от 0 до 255 через пробел");
            var inputArray = Console.ReadLine().Split(' ');
            var inputByteArray = new byte[inputArray.Length];
            for (var i = 0; i < inputArray.Length; i++)
                inputByteArray[i] = Convert.ToByte(inputArray[i]);
            File.WriteAllBytes("bytes.bin", inputByteArray);
        }
    }
}
