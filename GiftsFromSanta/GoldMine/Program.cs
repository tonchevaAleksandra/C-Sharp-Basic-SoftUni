using System;

namespace GoldMine
{
    class Program
    {
        static void Main(string[] args)
        {
            int locationsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < locationsCount; i++)
            {
                double expectedGoldYield = double.Parse(Console.ReadLine());
                int daysCountOnLocation = int.Parse(Console.ReadLine());

                double totalGoldForLocation = 0;
                for (int j = 0; j < daysCountOnLocation; j++)
                {
                    double yieldForTheDay = double.Parse(Console.ReadLine());
                    totalGoldForLocation += yieldForTheDay;
                }

                double averageYield = totalGoldForLocation / daysCountOnLocation;

                if (averageYield >= expectedGoldYield)
                { 
                    Console.WriteLine($"Good job! Average gold per day: {averageYield:F2}.");
                }

                else
                {
                    double diffYieldPerDay = expectedGoldYield - averageYield;
                    Console.WriteLine($"You need {diffYieldPerDay:f2} gold.");
                }
            }
        }
    }
}
