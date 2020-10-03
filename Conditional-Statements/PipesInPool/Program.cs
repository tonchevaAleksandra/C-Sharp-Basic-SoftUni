using System;

namespace PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double totalLitres = p1 * h + p2 * h;
            double percentageP1 = p1 * h / totalLitres * 100;
            double percentageP2 = p2 * h / totalLitres * 100;
            double totalPercentage = totalLitres / v * 100;
            if (totalPercentage <=100)
            {
                Console.WriteLine($"The pool is {totalPercentage:F2}% full. Pipe 1: {percentageP1:F2}%. Pipe 2: {percentageP2:F2}%.");
            }
            else if (totalPercentage >100)
            {
                Console.WriteLine($"For {h} hours the pool overflows with {totalLitres - v:F2} liters. ");
            }
        }
    }
}
