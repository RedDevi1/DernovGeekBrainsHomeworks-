using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string setValue = Console.ReadLine();
            var curNum = 0; // current number
            int[] numArray = new int[setValue.Length]; // array of arabic numerals by the set value
            for (int i = 0; i < setValue.Length; i++)
            {
                switch (setValue[i])
                {
                    case 'I': numArray[i] = 1; break;
                    case 'V': numArray[i] = 5; break;
                    case 'X': numArray[i] = 10; break;
                    case 'L': numArray[i] = 50; break;
                    case 'C': numArray[i] = 100; break;
                    case 'D': numArray[i] = 500; break;
                    case 'M': numArray[i] = 1000; break;
                }
            }
            int j = 0;
            while (j < numArray.Length - 1)
            {
                if (numArray[j] >= numArray[j + 1])
                {
                    curNum += numArray[j];
                    j++;
                }
                else
                {
                    curNum += (numArray[j + 1] - numArray[j]);
                    j += 2;
                }
            }
            if (j != numArray.Length)
                curNum += numArray[numArray.Length - 1];

            Console.Write(curNum);

        }
    }
}
