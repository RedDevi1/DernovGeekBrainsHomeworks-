using System;

namespace Exercise_4
{
    class Program
    {
        [Flags]
        public enum DaysOfTheWeek
        {
            Monday = 0b_0000001,
            Tuesday = 0b_0000010,
            Wednesday = 0b_0000100,
            Thursday = 0b_0001000,
            Friday = 0b_0010000,
            Saturday = 0b_0100000,
            Sunday = 0b_1000000
        }
        static void Main(string[] args)
        {
            /* var maskOfOffice = 0;
             Console.WriteLine("Введите номер вашего офиса");
             var numOfOffice = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Ваш офис работает по понедельникам? (да/нет)");
             var answer1 = Console.ReadLine();
             if (answer1 == "да")
                 maskOfOffice |= 0b_0000001;
             Console.WriteLine("Ваш офис работает по вторникам? (да/нет)");
             var answer2 = Console.ReadLine();
             if (answer2 == "да")
                 maskOfOffice |= 0b_0000010;
             Console.WriteLine("Ваш офис работает по средам? (да/нет)");
             var answer3 = Console.ReadLine();
             if (answer3 == "да")
                 maskOfOffice |= 0b_0000100;
             Console.WriteLine("Ваш офис работает по четвергам? (да/нет)");
             var answer4 = Console.ReadLine();
             if (answer4 == "да")
                 maskOfOffice |= 0b_0001000;
             Console.WriteLine("Ваш офис работает по пятницам? (да/нет)");
             var answer5 = Console.ReadLine();
             if (answer5 == "да")
                 maskOfOffice |= 0b_0010000; */
            DaysOfTheWeek office_1 = (DaysOfTheWeek)0b_0011111;
            DaysOfTheWeek office_2 = (DaysOfTheWeek)0b_1111111;
            DaysOfTheWeek office_3 = (DaysOfTheWeek)0b_0110010;
            DaysOfTheWeek office_4 = (DaysOfTheWeek)0b_1001110;

            Console.WriteLine($"Офис номер 1 работает: {office_1}");
            Console.WriteLine($"Офис номер 2 работает: {office_2}");
            Console.WriteLine($"Офис номер 3 работает: {office_3}");
            Console.WriteLine($"Офис номер 4 работает: {office_4}");
        }
    }
}
