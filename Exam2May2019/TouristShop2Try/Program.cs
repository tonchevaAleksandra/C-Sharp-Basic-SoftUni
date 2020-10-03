using System;

namespace TouristShop2Try
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int counter = 0;
            double price = 0;
            double totalPrice = 0;
            string product = Console.ReadLine();
            while (product != "Stop")
            {
                 
                price = double.Parse(Console.ReadLine());
                counter++;
                if (counter % 3 == 0)
                {
                    price /= 2;
                }
                if (price > budget)
                {

                    break;
                }
                totalPrice += price;
                budget -= price;
                product = Console.ReadLine();

            }
                
                
                
            if (budget>=price)
            {

                Console.WriteLine($"You bought {counter} products for {totalPrice:f2} leva.");
            }
           else
            {
                Console.WriteLine($"You don't have enough money!");
                Console.WriteLine($"You need {Math.Abs(budget-price):f2} leva!");

                
            }
        }
    }
}
