using System;

namespace OscarsCeremony
{
    class Program
    {
        static void Main(string[] args)
        {
            int rentHall = int.Parse(Console.ReadLine());
            double priceStatuettes = 0.70 * rentHall;
            double priceCatering = 0.85 * priceStatuettes;
            double priceSound = 0.5 * priceCatering;
            double totalPrice = rentHall + priceCatering + priceSound + priceStatuettes;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
