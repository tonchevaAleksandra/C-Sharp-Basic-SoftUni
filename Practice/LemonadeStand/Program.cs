using System;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            double lemonsKg = double.Parse(Console.ReadLine());
            double sugarKg = double.Parse(Console.ReadLine());
            double waterLittres = double.Parse(Console.ReadLine());
            double totalJuiceML = lemonsKg * 980;
            double lemonadeMl = totalJuiceML + waterLittres * 1000 + (0.3 * sugarKg);
            double soldCups = Math.Floor(lemonadeMl / 150);
            double profits = soldCups * 1.20;
            Console.WriteLine($"All cups sold: {soldCups}");
            Console.WriteLine($"Money earned: {profits:F2}");
        }
    }
}
