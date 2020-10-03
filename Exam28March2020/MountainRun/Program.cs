using System;

namespace MountainRun
{
    class Program
    {
        static void Main(string[] args)
        {
            //. Рекордът в секунди – реално число в интервала[0.00 … 100000.00]
            //2.Разстоянието в метри – реално число в интервала[0.00 … 100000.00]
            //3.Времето в секунди, за което изкачва 1 м. – реално число в интервала[0.00 … 1000.00]
            double recordSeconds = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeSecPerMeter = double.Parse(Console.ReadLine());
            double retard = Math.Floor(distance / 50) * 30;
            double totalTime = (distance * timeSecPerMeter) + retard;
            if(totalTime<recordSeconds)
            {
                Console.WriteLine($"Yes! The new record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {(totalTime - recordSeconds):f2} seconds slower.");
            }

        }
    }
}
