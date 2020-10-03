using System;

namespace CatWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            //            На първия ред - минути разходка на ден - цяло число в интервала[1...50]
            // На втория ред - броят на разходките дневно - цяло число в интервала[1…10]
            // На третия ред - приетите от котката калории на ден – цяло число в интервала[100…4000]

            int minutesWalk = int.Parse(Console.ReadLine());
            int countWalks = int.Parse(Console.ReadLine());
            int calories = int.Parse(Console.ReadLine());

            int caloriesBurn = minutesWalk * countWalks * 5;
            if(caloriesBurn >=calories/2)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {caloriesBurn}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {caloriesBurn}.");
            }
        }
    }
}
