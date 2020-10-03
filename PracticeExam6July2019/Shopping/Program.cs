using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Бюджетът на Петър - реално число в интервала[0.0…100000.0]
            //2.Броят видеокарти - цяло число в интервала[0…100]
            //3.Броят процесори - цяло число в интервала[0…100]
            //4.Броят рам памет -цяло число в интервала[0…100]

            double budget = double.Parse(Console.ReadLine());
            int videoCards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ramMemo = int.Parse(Console.ReadLine());

            double priceVCard = 250.0 * videoCards;
            double priceProcessor = (priceVCard * 0.35) * processors;
            double priceRam = ramMemo * (0.1 * priceVCard);
            double totalPrice = priceVCard + priceProcessor + priceRam;

            if(videoCards>processors)
            {
                totalPrice *= 0.85;
            }

            if (budget>=totalPrice)
            {
                Console.WriteLine($"You have {budget-totalPrice:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice-budget:f2} leva more!");
            }

        }
    }
}
