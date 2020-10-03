using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {

            int cntChickenM = int.Parse(Console.ReadLine());
            int cntFishM = int.Parse(Console.ReadLine());
            int cntVegeterianM = int.Parse(Console.ReadLine());
            
            double priceChickenM = 10.35;
            double priceFishM = 12.40;
            double priceVegeterianM = 8.15;

            double cuurPrice = priceChickenM * cntChickenM + priceFishM * cntFishM + priceVegeterianM * cntVegeterianM;
            double priceDessert = 0.2 * cuurPrice;
            double priceDelivery = 2.50;
            double totalPrice = cuurPrice + priceDessert + priceDelivery;

            Console.WriteLine($"Total: {totalPrice:f2}");

        }
    }
}
