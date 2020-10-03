using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countStatist = int.Parse(Console.ReadLine());
            double priceCloth = double.Parse(Console.ReadLine());
            double priceDekor = budget * 0.1;
            if (countStatist > 150)
            {
                priceCloth = priceCloth * 0.9;
            }
            double costs = countStatist * priceCloth + priceDekor;
            if (costs > budget)
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {costs - budget:F2} leva more.");
            }
            else
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {budget - costs:F2} leva left.");
            }
        }
    }
}
