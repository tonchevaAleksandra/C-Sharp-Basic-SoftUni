using System;

namespace SeriesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int seasons = int.Parse(Console.ReadLine());
            int series = int.Parse(Console.ReadLine());
            double timeSeries = double.Parse(Console.ReadLine());
            double timePub = 0.2 * timeSeries;
            double timePlus = 10 * seasons;
            double totalTime = seasons * (series * (timeSeries + timePub)) + timePlus;
            Console.WriteLine($"Total time needed to watch the {name} series is {Math.Floor(totalTime)} minutes.");
        }
    }
}