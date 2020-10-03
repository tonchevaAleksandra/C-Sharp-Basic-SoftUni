using System;

namespace CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            double surface = 2 * Math.PI * r;
            Console.WriteLine($"{area:F2}");
            Console.WriteLine($"{surface:F2}");


;
        }
    }
}
