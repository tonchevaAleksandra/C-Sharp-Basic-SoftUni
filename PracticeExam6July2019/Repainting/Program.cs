using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceNylon = 1.50; //m2
            double pricePaint = 14.50; //litter
            double priceThinner = 5.00; //litter
            double pricePlasticBags = 0.40;

            int nylon = int.Parse(Console.ReadLine()); //+2m
            int paint = int.Parse(Console.ReadLine()); //+10%
            int thinner = int.Parse(Console.ReadLine());
            int hoursWork = int.Parse(Console.ReadLine()); // 1 hour work=0.30 * all expenses

            double totalExpenses = priceNylon * (nylon + 2) + pricePaint * (paint * 1.10) + priceThinner * thinner + pricePlasticBags;
            totalExpenses += 0.3 * totalExpenses * hoursWork;
            Console.WriteLine($"Total expenses: {totalExpenses:f2} lv.");
        }
    }
}
