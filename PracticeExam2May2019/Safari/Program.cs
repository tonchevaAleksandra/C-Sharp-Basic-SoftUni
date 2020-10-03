using System;

namespace Safari
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            double fuelsLtr = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            double priceLFuel = 2.10;
            double priceGuide = 100.00;

            double currPrice = priceLFuel * fuelsLtr + priceGuide;
            double totalPrice = 0;
            //В зависимост от деня има отстъпки от общата цена - за събота 10 %, а за неделя 20 %
            switch (day)
            {
                case "Saturday":
                    totalPrice = currPrice * 0.9;
                    break;
                case "Sunday":
                    totalPrice = currPrice * 0.8;
                    break;
            }

            if(budget>=totalPrice)
            {
                Console.WriteLine($"Safari time! Money left: {budget-totalPrice:f2} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {totalPrice-budget:f2} lv.");
            }

        }
    }
}
