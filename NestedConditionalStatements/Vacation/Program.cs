using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = "";
            string type = "";
            double price = 0.0;
            if(budget<=1000)
            {
                type = "Camp";
                switch (season)
                {
                    case "Summer": 
                        place = "Alaska"; price = 0.65 * budget;
                        break;
                    default:
                        place = "Morocco"; price = 0.45 * budget;
                        break;
                }
            }
            else if(budget>1000 && budget<=3000)
            {
                type = "Hut";
                switch (season)
                {
                    case "Summer":
                        place = "Alaska"; price = 0.8 * budget;
                        break;
                    default:place = "Morocco"; price = 0.6 * budget;
                        break;
                }
            }
            else
            {
                type = "Hotel";
                switch (season)
                {
                    case "Summer":
                        place = "Alaska"; price = 0.9 * budget;
                        break;
                    default:
                        place = "Morocco"; price = 0.9 * budget;
                        break;

                }
            }
            Console.WriteLine($"{place} - {type} - {price:f2}");
        }
    }
}
