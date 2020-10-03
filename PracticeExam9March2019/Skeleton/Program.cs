using System;

namespace Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int minutesControl = int.Parse(Console.ReadLine());
            int secondsControl = int.Parse(Console.ReadLine());
            double lenghtMeters = double.Parse(Console.ReadLine());
            int secondsFor100M = int.Parse(Console.ReadLine());
            double totalControl = minutesControl * 60.00 + secondsControl;
            double totalTime = secondsFor100M  * lenghtMeters/100.00;
            double secondsSpend = lenghtMeters / 120 * 2.5;
            totalTime -= secondsSpend;

            if(totalTime<=totalControl)
            {
                Console.WriteLine($"Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {totalTime:f3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {totalTime-totalControl:f3} second slower.");
            }

        }

    }
}
