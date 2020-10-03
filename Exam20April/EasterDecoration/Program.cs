using System;

namespace EasterDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int countClients = int.Parse(Console.ReadLine());
            double totalSum = 0;
            double priceBasket = 1.50;
            double priceWreath = 3.80;
            double priceChBunny = 7.00;

            for (int i = 1; i <= countClients; i++)
            {
                int counterPurchase = 0;
                double sumPerClient = 0;
                string command = Console.ReadLine();
                while (command != "Finish")
                {
                    string choice = command;
                    counterPurchase++;
                    switch (choice)
                    {
                        case "basket": sumPerClient += priceBasket;
                            break;
                        case "wreath":
                            sumPerClient += priceWreath;
                            break;
                        case "chocolate bunny":
                            sumPerClient += priceChBunny;
                            break;

                    }

                    command = Console.ReadLine();
                }
                
                if(counterPurchase%2==0)
                {
                    sumPerClient *= 0.80;
                }
                totalSum += sumPerClient;
                if (command=="Finish")
                {
                    Console.WriteLine($"You purchased {counterPurchase} items for {sumPerClient:f2} leva.");
                }
            }

            double averageSumPerClient = totalSum / countClients;
            Console.WriteLine($"Average bill per client is: {averageSumPerClient:f2} leva.");
        }
    }
}
