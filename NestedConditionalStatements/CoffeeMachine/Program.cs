using System;

namespace CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Първи ред - напитка - текст с възможности"Espresso", "Cappuccino" или "Tea"
            //Втори ред - захар - текст с възможности "Without", "Normal" или "Extra"
            //Трети ред - брой напитки - цяло число в интервала [1… 50]
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0.0;

            if (drink == "Espresso")
            {
                if (sugar == "Without") { price = 0.90 * quantity; }
                else if (sugar == "Normal") { price = 1.00 * quantity; }
                else { price = 1.20 * quantity; }
            }
            else if (drink == "Cappuccino")
            {
                if (sugar == "Without") { price = 1.00 * quantity; }
                else if (sugar == "Normal") { price = 1.20 * quantity; }
                else { price = 1.60 * quantity; }
            }
            else
            {
                if (sugar == "Without") { price = 0.50 * quantity; }
                else if (sugar == "Normal") { price = 0.60 * quantity; }
                else { price = 0.70 * quantity; }
            }
            if (sugar == "Without") { price = price * 0.65; }
            if (drink == "Espresso" && quantity >= 5) { price = price * 0.75; }
            if (price > 15) { price = price * 0.8; }
            Console.WriteLine($"You bought {quantity} cups of {drink} for {price:f2} lv.");



        }
    }
}
