using System;

namespace TouristShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //            На първи ред – бюджетът - реално число в интервала[1.00… 100000.00]
            //• След това поредица от два реда(до получаване на команда "Stop" или при заявка за купуване на
            //продукт, чиято стойност е по-висока от наличния бюджет) :
            //o Име на продукта – текст
            //o Цена на продукта – реално число в интервала[1.00… 5000.00]
            double budget = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int cntProducts = 0;
            double totalPrice = 0;

            while (command!="Stop")
            {
             
                double priceProduct = double.Parse(Console.ReadLine());
    
                cntProducts++;

                if (cntProducts%3==0)
                {
                    priceProduct *= 0.5;

                }
                if (priceProduct > budget)
                {
                    Console.WriteLine($"You don't have enough money!");
                    Console.WriteLine($"You need {(priceProduct - budget):f2} leva!");
                    break;
                }
                totalPrice += priceProduct;
                budget -= priceProduct;
                
                command = Console.ReadLine();
            }

            if(command=="Stop")
            {
                Console.WriteLine($"You bought {cntProducts} products for {totalPrice:f2} leva.");
            }

        }
    }
}
