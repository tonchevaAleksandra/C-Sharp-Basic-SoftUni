using System;

namespace Excursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.	Брой екскурзии до море – цяло число в интервала [1… 500]
            //            2.Брой екскурзии до планина – цяло число в интервала[1… 500]
            //След това се чете по един ред до получаване на команда "Stop" или докато фирмата не продаде всички пакети:
            //•	Име на пакет – текст с възможности "sea" или "mountain"

            int seaExcursions = int.Parse(Console.ReadLine());
            int mountainExcursions = int.Parse(Console.ReadLine());

           
            int profit = 0;
            int seaPrice = 680;
            int mountainPrice = 499;
            string input = Console.ReadLine();
            while (input!="Stop")
            {
                switch (input)
                {
                    case "sea":
                        if (seaExcursions > 0)
                        {
                            seaExcursions--;
                            profit += seaPrice;
                        }
                        else
                        {
                            input = Console.ReadLine();
                            continue;
                        }

                        break;
                    case "mountain":
                        if (mountainExcursions > 0)
                        {
                            mountainExcursions--;
                            profit += mountainPrice;
                        }
                        else
                        {
                            input = Console.ReadLine();
                            continue;
                        }
                        break;
                      
                  
                }
                if(seaExcursions==0 && mountainExcursions==0)
                {
                    Console.WriteLine("Good job! Everything is sold.");
                    break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Profit: {profit} leva.");
        }
    }
}
