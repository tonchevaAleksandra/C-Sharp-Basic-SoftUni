using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double secondsRecord = double.Parse(Console.ReadLine());
            double distanceM = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());
            double retard = Math.Floor(distanceM / 15) ;
            double time = distanceM * secondsPerMeter + (retard * 12.5);
            if (secondsRecord>time)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {time:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {time - secondsRecord:F2} seconds slower.");
            }
        }
    }
}
