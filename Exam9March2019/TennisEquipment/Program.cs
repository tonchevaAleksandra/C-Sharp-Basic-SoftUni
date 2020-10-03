using System;

namespace TennisEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceRacket = double.Parse(Console.ReadLine());
            int countRackets = int.Parse(Console.ReadLine());
            int countSneakers = int.Parse(Console.ReadLine());
            double price = (priceRacket * countRackets) + (countSneakers * priceRacket / 6);
            double totalPrice = price * 0.2 + price;

            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(totalPrice / 8)}");
            Console.WriteLine($"Price to be paid by sponsors { Math.Ceiling(totalPrice * 7 / 8)}");
        }
    }
}
