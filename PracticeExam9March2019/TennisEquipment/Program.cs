using System;

namespace TennisEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            // той трябва да заплати 1 / 8 от цената, а останалите 7 / 8 трябва да бъдат заплатени от
            //неговите спонсори

            double priceRacket = double.Parse(Console.ReadLine());
            int cntRackets = int.Parse(Console.ReadLine());
            int cntSneakers = int.Parse(Console.ReadLine());

            double priceSneakers = priceRacket / 6.00;
            double totalPrice = priceSneakers * cntSneakers + priceRacket * cntRackets;
            double priceElse = 0.2 * totalPrice;
            totalPrice += priceElse;
            double paidByDj = totalPrice / 8.00;
            double paidBySpons = totalPrice * 7 / 8.00;

            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(paidByDj)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(paidBySpons)}");

        }
    }
}
