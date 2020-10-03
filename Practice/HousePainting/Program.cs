using System;

namespace HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double walls1 = 2 * (x * x) - 1.2 * 2;
            double walls2 = 2 * (x * y) - 2 * (1.5 * 1.5);
            double green = (walls1 + walls2) / 3.4;
            double roof1 = 2 * (x * y);
            double roof2 = 2 * (x * h / 2);
            double red = (roof1 + roof2) / 4.3;
            Console.WriteLine($"{green:F2}");
            Console.WriteLine($"{red:F2}");
            
        }
    }
}
