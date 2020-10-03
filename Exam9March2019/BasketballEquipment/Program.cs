using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int taxeYear = int.Parse(Console.ReadLine());
            double sneakers = taxeYear * 0.6;
            double equip = sneakers * 0.8;
            double ball = equip / 4;
            double access = ball / 5;
            Console.WriteLine($"{taxeYear + sneakers + equip + ball + access:F2}");
        }
    }
}
