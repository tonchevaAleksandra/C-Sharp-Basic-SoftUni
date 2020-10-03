using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int naylonMeters = int.Parse(Console.ReadLine());
            int litersPaint = int.Parse(Console.ReadLine());
            int litersThinner = int.Parse(Console.ReadLine());
            int hoursForPaint = int.Parse(Console.ReadLine());
            double priceNaylon = 1.50 *(naylonMeters + 2);
            double pricePaint = 14.50 * (1.1*litersPaint);
            double priceThinner = 5.0*litersThinner;
            double totalPriceProducts = priceNaylon + pricePaint + priceThinner + 0.40;
            double totalPrice = (0.3 * totalPriceProducts) * hoursForPaint + totalPriceProducts;
            Console.WriteLine($"Total expenses: {totalPrice:f2} lv.");

        }
    }
}
