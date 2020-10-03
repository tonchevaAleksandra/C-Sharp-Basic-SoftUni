using System;

namespace FamilyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countNights = int.Parse(Console.ReadLine());
            double priceNight = double.Parse(Console.ReadLine());
            int percentCosts = int.Parse(Console.ReadLine());
            double costs = percentCosts / 100.0 * budget;
            double priceHolliday = (countNights * priceNight) + costs;
            if (countNights > 7)
            {
                priceHolliday = countNights * priceNight * 0.95 + costs;

            }
            else
            {
                priceHolliday = (countNights * priceNight) + costs;
            }
            if (budget >= priceHolliday)
            {
                Console.WriteLine($"Ivanovi will be left with {budget-priceHolliday:f2} leva after vacation.");
            }
            else if(budget<priceHolliday)
            {
                Console.WriteLine($"{ priceHolliday - budget:f2} leva needed.");
            }


        }
    }
}
