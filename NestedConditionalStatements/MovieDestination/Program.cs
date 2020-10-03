using System;

namespace MovieDestination
{
    class Program
    {
        static void Main(string[] args)
        {
            //Бюджет на филма – реално число в диапазона [100 000.0… 2 000 000.0]
            //Дестинация – текст, с възможности "Dubai", "Sofia" и "London"
            //Сезон – текст, с възможности "Summer" и "Winter"
            //Брой дни – цяло число в диапазона [1… 40]
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double price = 0.0;
            if(destination=="Dubai")
            {
                if (season == "Winter") { price = (45000 * days) * 0.70; }
                else { price = 40000 * days * 0.70; }
            }
            else if (destination=="Sofia")
            {
                if (season == "Winter") { price = 17000 * days * 1.25; }
                else { price = 12500 * days * 1.25; }
            }
            else
            {
                if (season == "Winter") { price = 24000 * days; }
                else { price = 20250 * days; }
            }
            if (budget >= price)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {(budget - price):f2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {(price - budget):f2} leva more!");
            }
        }
    }
}
