using System;

namespace HoneyHarvest
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string flower = Console.ReadLine();
            int countF = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double totalHoney = 0;

            switch (season)
            {
                case "Spring":
                    switch (flower)
                    {
                        case "Sunflower":
                            totalHoney = 10 * countF;
                            break;
                        case "Daisy":
                            totalHoney = 12 * 1.1 * countF;
                            break;
                        case "Lavender":
                            totalHoney = 12 * countF;
                            break;
                        case "Mint":
                            totalHoney = 10 * 1.1 * countF;
                            break;

                    }
                    break;
                case "Summer":
                    switch (flower)
                    {
                        case "Sunflower":
                            totalHoney = 8 *1.1 * countF;
                            break;
                        case "Daisy":
                            totalHoney = 8 * 1.1 * countF;
                            break;
                        case "Lavender":
                            totalHoney = 8 * 1.1 * countF;
                            break;
                        case "Mint":
                            totalHoney = 12 * 1.1 * countF;
                            break;

                    }
                    break;
                case "Autumn":
                    switch (flower)
                    {
                        case "Sunflower":
                            totalHoney = 12 * 0.95 * countF;
                            break;
                        case "Daisy":
                            totalHoney = 6 * 0.95 * countF;
                            break;
                        case "Lavender":
                            totalHoney = 6 * 0.95 * countF;
                            break;
                        case "Mint":
                            totalHoney = 6 * 0.95 * countF;
                            break;

                    }
                    break;
                
            }
            Console.WriteLine($"Total honey harvested: {totalHoney:f2}");


        }
    }
}
