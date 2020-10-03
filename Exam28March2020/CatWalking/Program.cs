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
            int countWalk = int.Parse(Console.ReadLine());
            int calories = int.Parse(Console.ReadLine());
            int lostCalories = minutesWalk * 5 * countWalk;
            if(lostCalories>=calories/2)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {lostCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {lostCalories}."); 
  
            }
        }
    }
}
