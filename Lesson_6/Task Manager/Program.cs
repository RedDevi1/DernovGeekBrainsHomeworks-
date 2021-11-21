using System;
using System.Diagnostics;

namespace Task_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] processes = Process.GetProcesses();
            for (var i = 0; i < processes.Length; i++)
            {
                Console.WriteLine($"Процесс: {processes[i]}, ID: {processes[i].Id}");
            }
            Console.WriteLine("Введите имя поцесса, либо его ID, который требуется завершить");
            var procForKill = Console.ReadLine();
            bool inputIsName = false;
            foreach (var chars in procForKill)
                if (Char.IsLetter(chars))
                {
                    inputIsName = true;
                    break;
                }                   
            if (inputIsName)
            {
                var processForKill = Process.GetProcessesByName(procForKill);
                foreach (var process in processForKill)
                    process.Kill();
            }
            else
            {
                var processForKill = Process.GetProcessById(Convert.ToInt32(procForKill));
                processForKill.Kill();
            }
                
        }
    }
}
