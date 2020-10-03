using System;

namespace MovieStars
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Вход
            //От конзолата първо се чете един ред:
            //• Бюджет за актьори - реално число в интервала[1000.0... 2 100 000.0]
            //След това се четат многократно по един или два реда до команда "ACTION" или до изчерпване на бюджета:
            //• Име на актьор - текст
            //Ако името на актьора съдържа по-малко или равно на 15 брой символи:
            //o Възнаграждение -реално число в интервала[250.0… 1 000 000.0]

            double budget = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double neededMoney = 0;
            while (budget > 0 && command != "ACTION")
            {
                string actor = command;
                int a = actor.Length;
                if (a <= 15)
                {
                    double honorarium = double.Parse(Console.ReadLine());
                    budget -= honorarium;
                }
                else
                {
                    budget -= (0.2 * budget);
                }
                if(budget<0)
                {
                    neededMoney = Math.Abs(budget);
                    break;
                }
                command = Console.ReadLine();
            }
            if(budget>=0)
            {
                Console.WriteLine($"We are left with {budget:f2} leva.");
            }
            else
            {
                Console.WriteLine($"We need {neededMoney:f2} leva for our actors.");
            }

           
        }
    }
}