using System;

namespace CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Първи ред -напитка - текст с възможности"Espresso", "Cappuccino" или "Tea"
            //• Втори ред -захар - текст с възможности "Without", "Normal" или "Extra"
            //• Трети ред -брой напитки - цяло число в интервала[1… 50]
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double price = 0;

            if (drink == "Espresso")
            {
                switch (sugar)
                {
                    case "Without":
                        price = count * 0.90; price *= 0.65;
                        break;
                    case "Normal":
                        price = count * 1.00;
                        break;
                    case "Extra":
                        price = count * 1.20;
                        break;

                }
                if(count>=5)
                {
                    price *= 0.75;
                }
            }
            else if (drink == "Cappuccino")


            {
                switch (sugar)
                {
                    case "Without":
                        price = count * 1.00; price *= 0.65;
                        break;
                    case "Normal":
                        price = count * 1.20;
                        break;
                    case "Extra":
                        price = count * 1.60;
                        break;
                }
            }

            else if (drink == "Tea")
            {
                switch (sugar)

                {
                    case "Without":
                        price = count * 0.50; price *= 0.65;
                        break;
                    case "Normal":
                        price = count * 0.60;
                        break;
                    case "Extra":
                        price = count * 0.70;
                        break;
                }
            }

            if(price>15)
            {
                price *= 0.80;
            }

            Console.WriteLine($"You bought {count} cups of {drink} for {price:f2} lv.");


        }
    }
}
