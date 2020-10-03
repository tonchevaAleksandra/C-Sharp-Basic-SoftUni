using System;

namespace EasterLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBread = int.Parse(Console.ReadLine());
            int boxEggs = int.Parse(Console.ReadLine());
            int kgCookies = int.Parse(Console.ReadLine());
            
            double priceEasterBread = 3.20*easterBread;
            double priceEggs = boxEggs * 4.35;
            double priceCookies = kgCookies * 5.40;
            double pricePaint = 0.15 * 12 * boxEggs;
            double totalPrice = priceCookies + priceEasterBread + priceEggs + pricePaint;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
