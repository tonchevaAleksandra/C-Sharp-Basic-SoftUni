using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermans = int.Parse(Console.ReadLine());
            double priceBoatSpring = 3000.0;
            double priceBoatSummerAutumn = 4200.0;
            double priceBoatWinter = 2600.0;
            double price = 0.0;
            if (fishermans <= 6)
            {
                if (season == "Spring") { price = priceBoatSpring * 0.9; }
                else if (season == "Summer" || season == "Autumn") { price = priceBoatSummerAutumn * 0.9; }
                else { price = priceBoatWinter * 0.9; }
            }
            else if (fishermans > 6 && fishermans <= 11)
            {
                if (season == "Spring") { price = priceBoatSpring * 0.85; }
                else if (season == "Summer" || season == "Autumn") { price = priceBoatSummerAutumn * 0.85; }
                else { price = priceBoatWinter * 0.85; }
            }
            else
            {
                if (season == "Spring") { price = priceBoatSpring * 0.75; }
                else if (season == "Summer" || season == "Autumn") { price = priceBoatSummerAutumn * 0.75; }
                else { price = priceBoatWinter * 0.75; }

            }
            if ((fishermans % 2 == 0) && (season == "Spring" || season == "Summer" || season == "Winter"))
            {
                price = price * 0.95;
            }
            
            if(budget>=price)
            {
                Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");
            }

        }
    }
}
