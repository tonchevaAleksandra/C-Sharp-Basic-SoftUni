
            using System;

namespace EasternBakery
    {
        class Program
        {
            static void Main(string[] args)
            {
                double priceFlourKg = double.Parse(Console.ReadLine());
                double flourKg = double.Parse(Console.ReadLine());
                double sugarKg = double.Parse(Console.ReadLine());
                int countBoxEggs = int.Parse(Console.ReadLine());
                int yeast = int.Parse(Console.ReadLine());
                double priceSugar = priceFlourKg - (0.25 * priceFlourKg);
                double priceBoxEggs = priceFlourKg * 1.1;
                double priceYeast = priceSugar - (0.8 * priceSugar);
                double totalSum = priceFlourKg * flourKg + sugarKg * priceSugar + countBoxEggs * priceBoxEggs + yeast * priceYeast;
                Console.WriteLine($"{totalSum:F2}");
            }
        }
    }
