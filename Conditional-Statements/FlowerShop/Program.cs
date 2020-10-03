using System;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int countMagnolia = int.Parse(Console.ReadLine());
            int countZumbuls = int.Parse(Console.ReadLine());
            int countRoses = int.Parse(Console.ReadLine());
            int countCapsuls = int.Parse(Console.ReadLine());
            double priceGift = double.Parse(Console.ReadLine());
            double priceMagnolia = 3.25;
            double priceZumbuls = 4;
            double priceRoses = 3.50;
            double priceCapsuls = 8;
            double price = countMagnolia * priceMagnolia + countZumbuls * priceZumbuls + countRoses * priceRoses + countCapsuls * priceCapsuls;
            double profit = 0.95 * price;
            if(profit>=priceGift)
            {
                Console.WriteLine($"She is left with {Math.Floor(profit - priceGift)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(priceGift - profit)} leva.");
            }
        }
    }
}
