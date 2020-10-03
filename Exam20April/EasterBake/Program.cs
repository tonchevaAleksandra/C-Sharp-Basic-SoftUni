using System;

namespace EasterBake
{
    class Program
    {
        static void Main(string[] args)
        {
            // Броят на козунаците – цяло число в интервала[1... 100]
            //За всеки козунак се чете:
            // Количество изразходвана захар(грамове) – цяло число в интервала[1 … 10000]
            //o Количество изразходвано брашно(грамове) – цяло число в интервала[1 … 10000]
            int breads = int.Parse(Console.ReadLine());
            int totalSugar = 0;
            int totalFlour = 0;
            int maxSugar = 0;
            int maxFlour = 0;

            for (int i = 0; i < breads; i++)
            {
                int sugar = int.Parse(Console.ReadLine());
                int flour = int.Parse(Console.ReadLine());
                totalSugar += sugar;
                totalFlour += flour;
                if (sugar > maxSugar)
                {
                    maxSugar = sugar;
                }
                if (flour > maxFlour)
                {
                    maxFlour = flour;
                }
            }

            double packSugar = totalSugar / 950.0;
            double packFlour = totalFlour / 750.0;

            Console.WriteLine($"Sugar: {Math.Ceiling(packSugar)}");
            Console.WriteLine($"Flour: {Math.Ceiling(packFlour)}");
            Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar is {maxSugar} grams.");
        }
    }
}
