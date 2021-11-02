using System;

namespace Exercise_1
{
    class Program
    {
        enum AllLetters
        {
            I = 1,
            V = 5,
            X = 10,
            L = 50,
            C = 100,
            D = 500,
            M = 1000
        }
        static void Main(string[] args)
        {
            string setValue = Console.ReadLine();
            var curNum = 0; // current number
            AllLetters[] enumArray = new AllLetters[setValue.Length]; // array of enums by the set value
            for (int i = 0; i < setValue.Length; i++)
            {
                switch (setValue[i])
                {
                    case 'I': enumArray[i] = AllLetters.I; break;
                    case 'V': enumArray[i] = AllLetters.V; break;
                    case 'X': enumArray[i] = AllLetters.X; break;
                    case 'L': enumArray[i] = AllLetters.L; break;
                    case 'C': enumArray[i] = AllLetters.C; break;
                    case 'D': enumArray[i] = AllLetters.D; break;
                    case 'M': enumArray[i] = AllLetters.M; break;
                }
            }
            int j = 0;
            while (j < enumArray.Length - 1)
            {
                if (enumArray[j] >= enumArray[j + 1])
                {
                    curNum += (int)enumArray[j];
                    j++;
                }
                else
                {
                    curNum += ((int)enumArray[j + 1] - (int)enumArray[j]);
                    j += 2;
                }
            }
            if (j != enumArray.Length)
                curNum += (int)enumArray[enumArray.Length - 1];

            Console.Write(curNum);

        }
    }
}
