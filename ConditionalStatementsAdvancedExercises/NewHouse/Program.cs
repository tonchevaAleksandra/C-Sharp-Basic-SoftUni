using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double priceRose = 5.0;
            double priceDahlia = 3.80;
            double priceTulip = 2.80;
            double priceNarcis = 3.0;
            double priceGladiola = 2.50;
            double total = 0.0;
            if (flowers == "Roses")
            {
                if (quantity > 80) { total = (priceRose * quantity) * 0.90; }
                else { total = priceRose * quantity; }
            }
            else if (flowers == "Dahlias")
            {
                if (quantity > 90) { total = priceDahlia * quantity * 0.85; }
                else { total = priceDahlia * quantity; }
            }
            else if (flowers == "Tulips")
            {
                if (quantity > 80) { total = priceTulip * quantity * 0.85; }
                else { total = priceTulip * quantity; }
            }
            else if (flowers == "Narcissus")
            {
                if (quantity < 120) { total = priceNarcis * quantity * 1.15; }
                else { total = priceNarcis * quantity; }
            }
            else if (flowers == "Gladiolus")
            {
                if (quantity < 80) { total = priceGladiola * quantity * 1.20; }
                else { total = priceGladiola * quantity; }
            }
            if (budget >= total)
            {
                Console.WriteLine($"Hey, you have a great garden with {quantity} {flowers} and {budget - total:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {total - budget:f2} leva more.");
            }


        }
    }

}