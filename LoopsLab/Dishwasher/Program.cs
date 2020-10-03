using System;

namespace Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottles = int.Parse(Console.ReadLine());
            int volume = bottles * 750;
            int dishes = 5;
            int pots = 15;
            int neededVolume = 0;
            int toWash = 0;
            int counter = 0;
            int counterDishes = 0;
            int counterPots = 0;

            while (neededVolume <= volume)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                toWash = int.Parse(input);
                counter++;
                if (counter % 3 != 0)
                {
                    neededVolume += dishes * toWash;
                    counterDishes += toWash;

                }
                else if (counter % 3 == 0)
                {
                    neededVolume += pots * toWash;
                    counterPots += toWash;
                }

            }
            if (volume >= neededVolume)
            {
                Console.WriteLine($"Detergent was enough!");
                Console.WriteLine($"{counterDishes} dishes and {counterPots} pots were washed.");
                Console.WriteLine($"Leftover detergent {volume - neededVolume} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {neededVolume - volume} ml. more necessary!");
            }








        }
    }
}
