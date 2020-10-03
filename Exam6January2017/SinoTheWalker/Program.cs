using System;
using System.Linq;

namespace SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] timeLeave = Console.ReadLine().Split(":").Select(int.Parse).ToArray();
            int hour = timeLeave[0];
            int minute = timeLeave[1];
            int seconds = timeLeave[2];
            long totalLeavingSeconds = hour * 60 * 60 + minute * 60 + seconds;
            int stepsToHome = int.Parse(Console.ReadLine());
            int secondsPerStep = int.Parse(Console.ReadLine());
            long totalTimeForArriving = secondsPerStep * stepsToHome;
            long totalSeconds = totalLeavingSeconds + totalTimeForArriving;
            long arrivingHours = totalSeconds / 3600;
            totalSeconds = totalSeconds % 3600;
            long arrivingMinutes = totalSeconds / 60;
            totalSeconds = totalSeconds % 60;

            if(arrivingHours==24)
            {
                arrivingHours = 0;
            }
            else if(arrivingHours>24)
            {
                arrivingHours = arrivingHours % 24;
            }

            Console.WriteLine($"Time Arrival: {arrivingHours:d2}:{arrivingMinutes:d2}:{totalSeconds:d2}");
        }
    }
}
