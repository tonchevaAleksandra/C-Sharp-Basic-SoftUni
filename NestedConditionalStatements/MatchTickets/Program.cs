using System;

namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string categorie = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            double priceVIP = 499.99;
            double priceNormal = 249.99;
            double priceTransport = 0.0;
            if(people>=1 && people<=4)
            {
                priceTransport = 0.75 * budget;
            }
            else if (people >= 5 && people <= 9)
            {
                priceTransport = 0.60 * budget;
            }
            else if (people >= 10 && people <= 24)
            {
                priceTransport = 0.50 * budget;
            }
            else if (people >= 25 && people <= 49)
            {
                priceTransport = 0.40 * budget;
            }
            else
            {
                priceTransport = 0.25 * budget;
            }
           
            if(categorie=="VIP")
            {
                if((budget-priceTransport)>=priceVIP*people)
                {
                    Console.WriteLine($"Yes! You have {(budget - priceTransport) - priceVIP*people:f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {(priceVIP*people - (budget - priceTransport)):F2} leva.");
                }
            }
            if (categorie == "Normal")
            {
                if ((budget - priceTransport)>=priceNormal*people)
                {
                    Console.WriteLine($"Yes! You have {(budget - priceTransport) - priceNormal*people:f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {(priceNormal*people - (budget - priceTransport)):F2} leva.");
                }
            }

        }
    }
}
