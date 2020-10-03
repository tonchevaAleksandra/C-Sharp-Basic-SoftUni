using System;

namespace EasterShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //            На първи ред - Началното количество яйца в магазина -цяло число в интервала[1… 10000]
            //• След това поредица от два реда(до получаване на команда "Close" или при заявка за
            //купуване на повече от наличните в магазина яйца) :
            //o Команда за купуване или допълване на яйца в магазина – текст("Buy" или "Fill")
            //o Брой на яйца, които да бъдат купени или допълнени в магазина – цяло число в интервала
            //[1… 1000]
            int startEggs = int.Parse(Console.ReadLine());
            int soldEggs = 0;
            
            string command = Console.ReadLine();
            while (command != "Close")
            {
                int currEggs = int.Parse(Console.ReadLine());
                
                if (command == "Buy")
                {
                    if (startEggs < currEggs)
                    {
                       
                        Console.WriteLine($"Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {startEggs}.");
                        return;
                    }
                    else
                    {
                        soldEggs += currEggs;
                        startEggs -= currEggs;
                    }

                }
                else if (command == "Fill")
                {
                    startEggs += currEggs;
                }

                command = Console.ReadLine();
            }

            if(command=="Close")
            {
                Console.WriteLine($"Store is closed!");
                Console.WriteLine($"{soldEggs} eggs sold.");
            }

        }
    }
}
