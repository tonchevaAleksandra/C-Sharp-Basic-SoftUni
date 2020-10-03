using System;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            double taxiPrice = 0.70;
            double bus = 0.09;
            double train = 0.06;
            if (km < 20 && km > 0) //TAXI CHEK
            {
                if (dayOrNight == "day")
                {
                    double tarifs = 0.79;
                    double price = taxiPrice + tarifs * km;
                    Console.WriteLine($"{price:F2}");
                }
                else
                {
                    double price = taxiPrice + km * 0.90;
                    Console.WriteLine($"{price:F2}");
                }
            }
            else if (km >= 100)
            {
                if (dayOrNight == "day" || dayOrNight == "night")
                {
                    double price = km * train;
                    Console.WriteLine($"{price:F2}");
                }
            }
            if (km >= 20 && km < 100)
            {
                if (dayOrNight == "day" || dayOrNight == "night")
                {
                    double price = bus * km;
                    Console.WriteLine($"{price:F2}");
                }
            }
        }
    }
}








