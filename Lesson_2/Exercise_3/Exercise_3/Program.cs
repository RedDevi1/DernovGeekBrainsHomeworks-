using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер текущего месяца");
            var numOfMonth = Convert.ToInt32(Console.ReadLine());
            if (numOfMonth < 1 || numOfMonth > 12)
                Console.WriteLine("Некорректно введен номер. Порядковый номер ткущего месяца должен быть от 1 до 12");
            else
            {
                Console.WriteLine("Введите минимальную температуру за сутки");
                var minTemp = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите максимальную температуру за сутки");
                var maxTemp = Convert.ToInt32(Console.ReadLine());
                switch (numOfMonth)
                {
                    case 1: 
                        if ((double)(minTemp + maxTemp)/2 > 0)
                        {
                            Console.Write("Текущий месяц - январь. Дождливая зима"); break;
                        }                     
                        Console.Write("Текущий месяц - январь"); break;                        
                    case 2:
                        if ((double)(minTemp + maxTemp) / 2 > 0)
                        {
                            Console.Write("Текущий месяц - февраль. Дождливая зима"); break;
                        }
                            Console.Write("Текущий месяц - февраль"); break;
                    case 3: Console.Write("Текущий месяц - март"); break;
                    case 4: Console.Write("Текущий месяц - апрель"); break;
                    case 5: Console.Write("Текущий месяц - май"); break;
                    case 6: Console.Write("Текущий месяц - июнь"); break;
                    case 7: Console.Write("Текущий месяц - июль"); break;
                    case 8: Console.Write("Текущий месяц - август"); break;
                    case 9: Console.Write("Текущий месяц - сентябрь"); break;
                    case 10: Console.Write("Текущий месяц - октябрь"); break;
                    case 11: Console.Write("Текущий месяц - ноябрь"); break;
                    case 12:
                        if ((double)(minTemp + maxTemp) / 2 > 0)
                        {
                            Console.Write("Текущий месяц - декабрь. Дождливая зима"); break;
                        }
                            Console.Write("Текущий месяц - декабрь"); break;
                }
            }

        }
    }
}
