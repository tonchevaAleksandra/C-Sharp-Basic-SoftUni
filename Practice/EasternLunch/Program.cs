using System;

namespace EasternLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            int bread = int.Parse(Console.ReadLine());
            int boxEggs = int.Parse(Console.ReadLine());
            int cookies = int.Parse(Console.ReadLine());
            double priceBread = 3.20 * bread;
            double priceEggs = 4.35 * boxEggs;
            double priceCookies = 5.40 * cookies;
            double pricePaint = 0.15 * 12 * boxEggs;
            Console.WriteLine($"{priceBread + priceCookies + priceEggs + pricePaint:F2}");
        }
    }
}
