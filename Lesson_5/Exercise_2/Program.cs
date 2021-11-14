using System;
using System.IO;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = "startup.txt";
            DateTime curDateTime = DateTime.Now;
            var curTime = curDateTime.ToString().Split(' ');
            File.AppendAllText(fileName, curTime[1]);
        }
    }
}
