using System;

namespace GameNumberWars
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Име на първия играч -текст
            //• Име на втория играч -текст
            //След това, до получаване на команда "End of game", се четат многократно по два реда:
            //1.Карта, която дава първият играч-цяло число в интервала[2…9]
            //2.Карта, която дава вторият играч -цяло число в интервала[2…9]
            //При еднакви карти на двамата играчи се прочитат нови два реда(карта, която дава първият и карта, която
            //дава вторият.)
            string firstPlayer = Console.ReadLine();
            string secondPlayer = Console.ReadLine();
            string command = Console.ReadLine();
            int points1 = 0;
            int points2 = 0;
            while (command != "End of game")
            {
                int card1 = int.Parse(command);
                int card2 = int.Parse(Console.ReadLine());
                
                if(card1==card2)
                {
                    Console.WriteLine($"Number wars!");
                    card1 = int.Parse(Console.ReadLine());
                     card2 = int.Parse(Console.ReadLine());
                    if(card1>card2)
                    {

                        Console.WriteLine($"{firstPlayer} is winner with {points1} points");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{secondPlayer} is winner with {points2} points");
                        break;
                    }

                }
                if(card1>card2)
                {
                    points1 += (card1 - card2);
                }
                else if(card2 > card1)
                {
                    points2 += (card2 - card1);
                }
                command = Console.ReadLine();
            }
                
                
            
            if (command=="End of game")
            {
                Console.WriteLine($"{firstPlayer} has {points1} points");
                Console.WriteLine($"{secondPlayer} has {points2} points");
            }
        }
    }
}
