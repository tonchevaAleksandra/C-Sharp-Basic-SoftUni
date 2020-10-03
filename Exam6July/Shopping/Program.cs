using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countVideoCards = int.Parse(Console.ReadLine());
            int countProcessors = int.Parse(Console.ReadLine());
            int countRam = int.Parse(Console.ReadLine());
            double priceVideo = countVideoCards * 250;
            double priceProcessors = 0.35 * priceVideo * countProcessors;
            double priceRam = 0.10 * priceVideo * countRam;
            double totalPrice = priceVideo + priceRam + priceProcessors;
            if (countVideoCards > countProcessors)
            {
                totalPrice = totalPrice * 0.85;
            }
            if (budget >= totalPrice)
            {
                Console.WriteLine($"You have {budget - totalPrice:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:f2} leva more!");
            }
        }
    }
}
