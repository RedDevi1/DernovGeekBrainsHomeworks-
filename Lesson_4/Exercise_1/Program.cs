using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сколько человек требуется вывести на экран");
            int numOfMen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите поочередно {numOfMen} ФИО:");
            var contactArray = new string [numOfMen, 3]; // массив с ФИО
            for (int i = 0; i < contactArray.GetLength(0); i++)
            {
                for (int j = 0; j < contactArray.GetLength(1); j++)
                {
                    switch (j)
                    {
                        case 0: 
                            Console.WriteLine($"Введите {i + 1}-ую фамилию");
                            contactArray[i, j] = Console.ReadLine();                            
                            break;
                        case 1:
                            Console.WriteLine($"Введите {i + 1}-ое имя");
                            contactArray[i, j] = Console.ReadLine();                            
                            break;
                        case 2:
                            Console.WriteLine($"Введите {i + 1}-ое отчество");
                            contactArray[i, j] = Console.ReadLine();                            
                            break;
                    }
                }
                Console.Clear();
            }
            for (int i = 0; i < numOfMen; i++)
            {
                var fullName = GetFullName(contactArray[i, 1], contactArray[i, 0], contactArray[i, 2]);
                Console.WriteLine(fullName);
            }
            static string GetFullName(string firstName, string lastName, string patronymic)
            {
                string fullName = $"{lastName} {firstName} {patronymic}";
                return fullName;
            }

        }
    }
}
