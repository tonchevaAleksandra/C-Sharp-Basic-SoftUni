using System;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceVegetables = double.Parse(Console.ReadLine());
            double priceFruits = double.Parse(Console.ReadLine());
            int vegetablesKg = int.Parse(Console.ReadLine());
            int fruitsKg = int.Parse(Console.ReadLine());
            double revenue = priceVegetables * vegetablesKg + priceFruits * fruitsKg;
            double totalDollars = revenue / 1.94;
            Console.WriteLine($"{totalDollars:F2}");
        }
    }
}
