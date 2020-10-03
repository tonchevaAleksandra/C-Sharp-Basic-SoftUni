using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            double realSpace = x * 0.4;
            double kg = realSpace * y;
            double litersWine = kg / 2.5;
            if (litersWine < z)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(z - litersWine)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(litersWine)} liters.");
                Console.WriteLine($"{Math.Ceiling(litersWine - z)} liters left -> {Math.Ceiling((litersWine - z) / workers)} liters per person.");
            }
        }
    }
}
