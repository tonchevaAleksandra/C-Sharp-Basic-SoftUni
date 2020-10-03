using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int countDaysCampaign = int.Parse(Console.ReadLine());
            int countPastryCook = int.Parse(Console.ReadLine());
            int countCakes = int.Parse(Console.ReadLine());
            int countGoffres = int.Parse(Console.ReadLine());
            int countPancakes = int.Parse(Console.ReadLine());
            double priceCakes = countCakes * 45;
            double priceGoffres = countGoffres * 5.80;
            double pricePancakes = countPancakes * 3.20;
            double totalPriceADay = (priceCakes + priceGoffres + pricePancakes) * countPastryCook;
            double totalSum = totalPriceADay * countDaysCampaign;
            double sumAfterCosts = totalSum - (0.125 * totalSum);
            Console.WriteLine($"{sumAfterCosts:F2}");
        }
    }
}
