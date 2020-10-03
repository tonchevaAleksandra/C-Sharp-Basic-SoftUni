using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Вход
            //От конзолата се четат:
            //• На първия ред - капацитет на залата -цяло число в интервала[50... 150]
            //На всеки следващ ред до команда "Movie time!":
            //o Брой хора влизащи в киното -цяло число в интервала[1… 15]
            int capacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int totalClients = 0;
            double priceTicket = 5.00;
            double currentPrice = 0;
            double income = 0;
            while (command != "Movie time!")
            {
                int clients = int.Parse(command);
                if (clients > (capacity - totalClients))
                { 
                    Console.WriteLine($"The cinema is full.");
                    break;
                }
                if (clients % 3 == 0)
                {
                    currentPrice = (clients * priceTicket) - 5;
                    income += currentPrice;
                    totalClients += clients;
                }
                else
                {
                    currentPrice = (clients * priceTicket);
                    income += currentPrice;
                    totalClients += clients;
                }
                
                command = Console.ReadLine();
                  
            }
            if(command== "Movie time!")
            {
                Console.WriteLine($"There are {capacity - totalClients} seats left in the cinema.");
            }
            Console.WriteLine($"Cinema income - {income} lv.");
        }
    }
}
