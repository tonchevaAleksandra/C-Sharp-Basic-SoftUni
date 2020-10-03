using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());
            int volume = length * width * height;
            double litres = volume * 0.001;
            double realPercentage = percentage * 0.01;
            double realLitres = double.Parse($"{litres * (1 - realPercentage)}");
            Console.WriteLine($"{realLitres:F3}");
        }
    }
}
