using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int kgFood = int.Parse(Console.ReadLine());
            double dogFoodDay = double.Parse(Console.ReadLine());
            double catFoodDay = double.Parse(Console.ReadLine());
            double turtleFoodDayGram = double.Parse(Console.ReadLine());
            double neededFood = (days * dogFoodDay) + (catFoodDay * days) + (turtleFoodDayGram / 1000 * days);
            if(kgFood>=neededFood)
            {
                Console.WriteLine($"{Math.Floor(kgFood - neededFood)} kilos of food left.");
            }
            else if(kgFood<neededFood)
            {
                Console.WriteLine($"{Math.Ceiling(neededFood - kgFood)} more kilos of food are needed.");
            }

        }
    }
}
