using System;

namespace TaskThreePartTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество карт у Вас на руках");
            string strNumCards = Console.ReadLine();
            int numCards = int.Parse(strNumCards);
            Console.WriteLine("Введите поочередно каждую карту" +
                "\nДля карт с числовым номиналом введите только цифру. " +
                "\nДля «картинок» следует принять обозначения латинскими буквами:" +
                "\nВалет = J" +
                "\nДама = Q" +
                "\nКороль = K" +
                "\nТуз = T");
            int sum = 0;
            for (int i = 0; i < numCards; i++)
            {
                Console.WriteLine("Введите карту № " + (i + 1));
                switch (Console.ReadLine())
                {
                    case "2": sum += 2; break;
                    case "3": sum += 3; break;
                    case "4": sum += 4; break;
                    case "5": sum += 5; break;
                    case "6": sum += 6; break;
                    case "7": sum += 7; break;
                    case "8": sum += 8; break;
                    case "9": sum += 9; break;
                    case "10": sum += 10; break;
                    case "J": sum += 10; break;
                    case "Q": sum += 10; break;
                    case "K": sum += 10; break;
                    case "T": sum += 10; break;
                    default: Console.WriteLine("Вы ввели некоректное значение"); break;
                }
            }
            Console.WriteLine("Сумма карт у Вас на руках составляет {0}", sum);
            Console.ReadKey();

        }
    }
}
