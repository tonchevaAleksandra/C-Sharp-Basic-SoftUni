using System;

namespace CareOfPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            food = food * 1000;
            string input = "";
            double totalNeededFood = 0;
            while (input != "Adopted")
            {
                input = Console.ReadLine();
                if(input=="Adopted")
                {
                    break;
                }
                int foodDog = int.Parse(input);
                totalNeededFood += foodDog;
            }
            if(totalNeededFood<=food)
            {
                Console.WriteLine($"Food is enough! Leftovers: {food - totalNeededFood} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {totalNeededFood - food} grams more.");
            }
            



        }
    }
}
