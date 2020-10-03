using System;

namespace AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceWhiskey = double.Parse(Console.ReadLine());
            double countBeerLittre = double.Parse(Console.ReadLine());
            double countWineLittres = double.Parse(Console.ReadLine());
            double countRakiaLittres = double.Parse(Console.ReadLine());
            double countWhiskeyLttres = double.Parse(Console.ReadLine());
            double priceRakia = priceWhiskey - (priceWhiskey * 0.5);
            double priceWine = priceRakia - (priceRakia * 0.4);
            double priceBeer = priceRakia - (priceRakia * 0.8);
            double totalPrice = (priceWhiskey * countWhiskeyLttres) + (priceBeer * countBeerLittre) + (priceRakia * countRakiaLittres) + (priceWine * countWineLittres);
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
