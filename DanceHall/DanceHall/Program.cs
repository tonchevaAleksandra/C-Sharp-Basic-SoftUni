using System;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double sideA = double.Parse(Console.ReadLine());
            double totalAreaHall = length * 100 * width * 100;
            double areaWardrobe = sideA * 100 * sideA * 100;
            double benchArea = totalAreaHall / 10;
            double freeSpaceHall = totalAreaHall - (areaWardrobe + benchArea);
            double countDancers = freeSpaceHall / (40 + 7000);
           
            Console.WriteLine(Math.Floor(countDancers));
        }
    }
}
