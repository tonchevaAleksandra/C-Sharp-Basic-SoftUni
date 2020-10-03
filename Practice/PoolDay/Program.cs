using System;

namespace PoolDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            double taxe = double.Parse(Console.ReadLine());
            double priceChaiseLong = double.Parse(Console.ReadLine());
            double priceUmbrela = double.Parse(Console.ReadLine());
            double countChaiseLong = Math.Ceiling(countPeople * 0.75);
            double countUmbrela = Math.Ceiling(countPeople / 2.0);
            double totalPrice = countPeople * taxe + countChaiseLong * priceChaiseLong + countUmbrela * priceUmbrela;
            Console.WriteLine($"{totalPrice:f2} lv.");

        }
    }
}
