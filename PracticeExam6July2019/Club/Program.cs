using System;

namespace Club
{
    class Program
    {
        static void Main(string[] args)
        {
            //            На първия ред – желаната печалба на клуба -реално число в интервала[1.00... 15000.00]
            //Поредица от два реда до получаване на командата "Party!" или до достигане на желаната печалба:
            //o Име на коктейла – текст
            //o Брой на коктейлите за поръчката – цяло число в интервала[1… 50]

            double wantedProfit = double.Parse(Console.ReadLine());
            double realProfit = 0;
            string coctail = Console.ReadLine();
            while (coctail!="Party!" && realProfit<wantedProfit)
            {
                double price = 0;
                int drinks = int.Parse(Console.ReadLine());
                int priceCoctail = coctail.Length;
                price= priceCoctail * drinks;
                if(price%2!=0.0)
                {
                    price *= 0.75;
                }
                realProfit += price;
                if(realProfit>=wantedProfit)
                {
                    break;
                }
                coctail = Console.ReadLine();
                
            }

            if(coctail=="Party!" && realProfit < wantedProfit)
            {
                Console.WriteLine($"We need {wantedProfit-realProfit:f2} leva more.");
               
            }
            if(wantedProfit<=realProfit)
            {
                Console.WriteLine($"Target acquired.");
            }
            Console.WriteLine($"Club income - {realProfit:f2} leva.");
        }
    }
}
