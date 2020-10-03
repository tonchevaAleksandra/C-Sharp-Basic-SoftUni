using System;

namespace FishLand
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceSkumlKg = double.Parse(Console.ReadLine());
            double priceCacaKg = double.Parse(Console.ReadLine());
            double palamudKg = double.Parse(Console.ReadLine());
            double safridKg = double.Parse(Console.ReadLine());
            int midiKg = int.Parse(Console.ReadLine());
            double totalPricePalamud = ((0.6 * priceSkumlKg) + priceSkumlKg) * palamudKg;
            double totalPriceSafrid = safridKg * ((0.8 * priceCacaKg) + priceCacaKg);
            double totalPriceMidi = midiKg * 7.50;
            Console.WriteLine($"{(totalPricePalamud + totalPriceSafrid + totalPriceMidi):F2}");
        }
    }
}
