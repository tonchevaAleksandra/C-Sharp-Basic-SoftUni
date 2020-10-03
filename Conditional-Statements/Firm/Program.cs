using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededHours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int workersPlus = int.Parse(Console.ReadLine());
            double daysLeft =  0.9 * days;
            double dayHours = daysLeft * 8;
            double workersHours = workersPlus * (2 * days);
            double hours = Math.Floor(dayHours + workersHours);
            if(hours>=neededHours)
            {
                Console.WriteLine($"Yes!{Math.Floor(hours-neededHours)} hours left.");
            }
            else if(hours<neededHours)
            {
                Console.WriteLine($"Not enough time!{Math.Floor(neededHours-hours)} hours needed.");
            }

        }
    }
}
