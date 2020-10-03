using System;

namespace Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double fuelLit = double.Parse(Console.ReadLine());
            string day = (Console.ReadLine());
            double fuel = fuelLit * 2.10;
            double guide = 100;
            double price = fuel + guide;
            if (day == "Saturday") { price = price * 0.9; }
            else if (day == "Sunday") { price = price * 0.8; }
            if (budget >= price) { Console.WriteLine($"Safari time! Money left: {budget - price:F2} lv."); }
            else if (budget < price) { Console.WriteLine($"Not enough money! Money needed: {price - budget:F2} lv."); }
        }
    }

}