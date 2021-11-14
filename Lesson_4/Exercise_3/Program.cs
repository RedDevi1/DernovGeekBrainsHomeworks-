using System;

namespace Exercise_3
{
    class Program
    {        
        enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца");
            var numOfMonth = Convert.ToInt32(Console.ReadLine());
            while (numOfMonth < 1 || numOfMonth > 12)
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12");
                numOfMonth = Convert.ToInt32(Console.ReadLine());
            }
            var enumsValue = ValueOfEnum(numOfMonth);
            Console.WriteLine(NameOfTheSeason(enumsValue));

            static int ValueOfEnum(int numOfTheMonth)
            {
                Season curSeason = Season.Autumn; // current season
                switch (numOfTheMonth)
                {
                    case 12:
                    case 1:
                    case 2:
                        curSeason = Season.Winter;
                        break;
                    case 3:
                    case 4:
                    case 5:
                        curSeason = Season.Spring;
                        break;
                    case 6:
                    case 7:
                    case 8:
                        curSeason = Season.Summer;
                        break;
                    case 9:
                    case 10:
                    case 11:
                        curSeason = Season.Autumn;
                        break;
                }
                return (int)curSeason;
            }
            static string NameOfTheSeason(int valueOfEnum)
            {
                return Enum.GetName(typeof(Season), valueOfEnum);
            }
        }
    }
}
