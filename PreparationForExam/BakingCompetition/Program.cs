using System;

namespace BakingCompetition
{
    class Program
    {
        static void Main(string[] args)
        {

            double priceCookie = 1.50;
            double priceCake = 7.80;
            double priceWaffle = 2.30;
            double totalSweets = 0;
            double totalFund = 0;
          
            int cntParticipants = int.Parse(Console.ReadLine());

            for (int i = 1; i <= cntParticipants; i++)
            {
                int cntCookies = 0;
                int countCakes = 0;
                int countWaffles = 0;
               
                string participant = Console.ReadLine();
                string typeSweet = Console.ReadLine();

                while (typeSweet != "Stop baking!")
                {
       
                    int cntSweets = int.Parse(Console.ReadLine());
                    totalSweets += cntSweets;
                    switch (typeSweet)
                    {
                        case "cookies": cntCookies += cntSweets; 
                            break;
                        case "cakes":countCakes += cntSweets;
                            break;
                        case "waffles":countWaffles += cntSweets;
                            break;
                        default:
                            break;
                    }

                    

                    typeSweet = Console.ReadLine();
                }
                Console.WriteLine($"{participant} baked {cntCookies} cookies, {countCakes} cakes and {countWaffles} waffles.");

                totalFund += cntCookies * priceCookie;
                totalFund += countCakes * priceCake;
                totalFund += countWaffles * priceWaffle;
                if(typeSweet=="Stop baking!")
                {
                    continue; 
                }

            }
            Console.WriteLine($"All bakery sold: {totalSweets}");
            Console.WriteLine($"Total sum for charity: {totalFund:f2} lv.");

        }
    }
}
