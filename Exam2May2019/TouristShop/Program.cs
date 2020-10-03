using System;

namespace TouristShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //На първи ред – бюджетът - реално число в интервала[1.00… 100000.00]
            //• След това поредица от два реда(до получаване на команда "Stop" или при заявка за купуване на
            //продукт, чиято стойност е по-висока от наличния бюджет) :
            //o Име на продукта – текст
            //o Цена на продукта – реално число в интервала[1.00… 5000.00]
            double budget = double.Parse(Console.ReadLine());
            int counter = 0;
            double totalPrice = 0;
            for (int i = 0; i < budget; i++)
            {
                string product = Console.ReadLine();
                if (product == "Stop")
                {
                    Console.WriteLine($"You bought {counter} products for {totalPrice:f2} leva."); 
                    break;
                }
                double price = double.Parse(Console.ReadLine());
                if(price>budget)
                {
                    Console.WriteLine($"You don't have enough money!");
                    Console.WriteLine($"You need {price - budget:f2} leva!");
                    break;
                }
                counter++;
                if (counter%3==0)
                {
                    price *= 0.5 ;
                }
                
                totalPrice += price;
                budget -= price;


            }
        }
    }
}
