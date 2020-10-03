using System;

namespace Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesControl = int.Parse(Console.ReadLine());
            int secondsControl = int.Parse(Console.ReadLine());
            double lengthMeters = double.Parse(Console.ReadLine());
            int seconds100Meters = int.Parse(Console.ReadLine());
            double lostsSeconds = lengthMeters / 120 * 2.5;
            double totalTimeControl = minutesControl * 60 + secondsControl;
            double timePlayer = lengthMeters / 100 * seconds100Meters - lostsSeconds;
            if(timePlayer<=totalTimeControl)
            {
                Console.WriteLine($"Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {timePlayer:F3}.");
            }
            else if(timePlayer>totalTimeControl)
            {
                Console.WriteLine($"No, Marin failed! He was {timePlayer - totalTimeControl:f3} second slower.");
            }
        }
    }
}
