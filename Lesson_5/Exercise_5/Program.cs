using System;
using System.IO;
using System.Text.Json;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var toDoFile = @"C:\Users\Nikita\source\repos\RedDevi1\DernovGeekBrainsHomeworks-\Lesson_5\Exercise_5\bin\Debug\netcoreapp3.1\tasks.json";
            var newTask = new ToDo[1];
            if (File.Exists(toDoFile))
            {
                var json = File.ReadAllText("tasks.json");
                ToDo[] taskArray = JsonSerializer.Deserialize<ToDo[]>(json);
                for (var i = 0; i < taskArray.Length; i++)
                {
                    if (taskArray[i].IsDone)
                        Console.WriteLine($"{i + 1}. x {taskArray[i].Title}");
                    else
                        Console.WriteLine($"{i + 1}. {taskArray[i].Title}");
                }                    
                Console.WriteLine("Введите через пробел номера выполненных задач");
                string[] numOfComplTask = Console.ReadLine().Split(' ');
                var numOfCompletedTask = new int[numOfComplTask.Length];
                for (var i = 0; i < numOfComplTask.Length; i++)
                    numOfCompletedTask[i] = Convert.ToInt32(numOfComplTask[i]);
                newTask = CorrectTodoList(numOfCompletedTask, ref taskArray);
            }
            else
            {
                Console.WriteLine("Введите количество задач");
                var numOfTasks = Convert.ToInt32(Console.ReadLine());
                newTask = AddNewTodoList(numOfTasks);
            }
            File.WriteAllText("tasks.json", JsonSerializer.Serialize(newTask));


        }
        static ToDo[] AddNewTodoList(int numOfTasks)
        {           
            var toDoListArray = new ToDo[numOfTasks];
            for (var i = 0; i < toDoListArray.Length; i++)
            {
                var newTask = new ToDo();                
                Console.WriteLine($"Введите название {i + 1}-ой задачи");
                newTask.Title = Console.ReadLine();
                newTask.IsDone = false;
                toDoListArray[i] = newTask;
                Console.WriteLine();
            }
            return toDoListArray;
        }
        static ToDo[] CorrectTodoList(int[] numOfCompletedTask, ref ToDo[] curTodoList)
        {
            var correctedTodoList =  curTodoList;
            for (var i = 1; i <= curTodoList.Length; i++)
            {
                foreach (var num in numOfCompletedTask)
                    if (i == num)
                    {
                        correctedTodoList[i - 1].IsDone = true;
                    }
            }
            return correctedTodoList;
        }
    }
}
