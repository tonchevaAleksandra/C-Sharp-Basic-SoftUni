using System;

namespace PuppyCare
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodInKg = int.Parse(Console.ReadLine());

            int foodInGrams = foodInKg * 1000;
            int totalEatedFood = 0;

            string command = Console.ReadLine();
            while (command != "Adopted")
            {
                int foodEatedGrams = int.Parse(command);
                totalEatedFood += foodEatedGrams;

                command = Console.ReadLine();
            }

            if (foodInGrams >= totalEatedFood)
            {
                int foodLeft = foodInGrams - totalEatedFood;
                Console.WriteLine($"Food is enough! Leftovers: {foodLeft} grams.");
            }
            else
            {
                int missingQuantityFood = totalEatedFood - foodInGrams;
                Console.WriteLine($"Food is not enough. You need {missingQuantityFood} grams more.");
            }
        }
    }
}
