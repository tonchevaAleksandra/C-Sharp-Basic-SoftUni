using System;

namespace Savings
{
    class Program
    {
        static void Main(string[] args)
        {
            double revenue = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double sumDepenses = double.Parse(Console.ReadLine());
            double sumNeeded = 0.30 * revenue;
            double sumSavings = revenue - (sumDepenses + sumNeeded);
            double totalSavings = months * sumSavings;
            double percentageSavenigs = (sumSavings / revenue) * 100;
            Console.WriteLine($"She can save {percentageSavenigs:F2}%");
            Console.WriteLine($"{totalSavings:F2}");
        }
    }
}
