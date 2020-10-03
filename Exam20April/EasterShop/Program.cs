using System;

namespace EasterShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //На първи ред - Началното количество яйца в магазина -цяло число в интервала[1… 10000]
            //• След това поредица от два реда(до получаване на команда "Close" или при заявка за
            //купуване на повече от наличните в магазина яйца) :
            //o Команда за купуване или допълване на яйца в магазина – текст("Buy" или "Fill")
            //o Брой на яйца, които да бъдат купени или допълнени в магазина – цяло число в интервала
            //[1… 1000]
            int quantity = int.Parse(Console.ReadLine());
            string input = "";
            int soldEggs = 0;
            
            while (input !="Close")
            {
                input = Console.ReadLine();
                if (input== "Close")
                {
                    Console.WriteLine($"Store is closed!");
                    Console.WriteLine($"{soldEggs} eggs sold.");
                    break;
                }
                if( input=="Fill")
                {
                    
                    int fillEggs = int.Parse(Console.ReadLine());
                    quantity += fillEggs;
                }
                if(input=="Buy")
                {
                  
                    int buyEggs = int.Parse(Console.ReadLine());
                    if (buyEggs>quantity)
                    {
                        Console.WriteLine($"Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {quantity}.");
                        break;
                    }
                    else 
                    {
                        quantity -= buyEggs;
                        soldEggs += buyEggs;
                    }
                    
                }
                    
            }



        }
    }
}
