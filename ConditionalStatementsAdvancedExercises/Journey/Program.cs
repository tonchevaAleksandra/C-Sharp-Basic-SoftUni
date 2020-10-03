using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            double price = 0.0;
            string place = "";
            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer") { price = 0.3 * budget; place = "Camp"; }
                else { price = 0.7 * budget; place = "Hotel"; }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer") { price = 0.4 * budget; place = "Camp"; }
                else { price = 0.8 * budget; place = "Hotel"; }
            }
            else
            {
                destination = "Europe";
                place = "Hotel";
                     price = 0.9 * budget;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {price:f2}");


        }
    }
}
