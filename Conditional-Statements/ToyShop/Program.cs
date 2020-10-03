using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceExcursion = double.Parse(Console.ReadLine());
            int countPuzzles = int.Parse(Console.ReadLine());
            int countPuppies = int.Parse(Console.ReadLine());
            int countTeddyBears = int.Parse(Console.ReadLine());
            int countMignons = int.Parse(Console.ReadLine());
            int countCamions = int.Parse(Console.ReadLine());
            double puzzlePrice = 2.60;
            double puppyPrice = 3;
            double teddyPrice = 4.10;
            double mignonPrice = 8.20;
            double camionPrice = 2;
            double totalProfit = countPuzzles * puzzlePrice + countPuppies * puppyPrice +
                countTeddyBears * teddyPrice + countMignons * mignonPrice + countCamions * camionPrice;
            int countToys = countCamions + countMignons + countPuppies + countPuzzles + countTeddyBears;
            if(countToys>=50)
            {
                totalProfit = 0.75 * totalProfit;
            }
            double rent = 0.1 * totalProfit;
            if (totalProfit-rent>=priceExcursion)
            {
                Console.WriteLine($"Yes! {totalProfit - rent - priceExcursion:f2} lv left.");
            }
            if(totalProfit-rent<priceExcursion)
            {
                Console.WriteLine($"Not enough money! {priceExcursion - (totalProfit - rent):f2} lv needed.");
            }

        }
    }
}
