using System;

namespace EasterEggsBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            //            . Брой яйца, които има първият играч - цяло число в интервала[1 … 99]
            //2.Брой яйца, които има вторият играч -цяло число в интервала[1 … 99]
            //След това до получаване на команда "End of battle" се четe многократно един ред:
            //            3.Победител - текст - "one" или "two"
            int cntEggsOne = int.Parse(Console.ReadLine());
            int cntEggsTwo = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while (command!= "End of battle")
            {
                string winner = command;
                if(winner=="one")
                {
                    cntEggsTwo--;
                }
                else if (winner=="two")
                {
                    cntEggsOne--;
                }
                if (cntEggsOne<=0 || cntEggsTwo<=0)
                {
                    break;
                }
                command = Console.ReadLine();
            }
            if (cntEggsOne <= 0)
            {
                Console.WriteLine($"Player one is out of eggs. Player two has {cntEggsTwo} eggs left.");
            }
            else if(cntEggsTwo <= 0)
            {
                Console.WriteLine($"Player two is out of eggs. Player one has {cntEggsOne} eggs left."); 
            }
            if(command== "End of battle")
            {
                Console.WriteLine($"Player one has {cntEggsOne} eggs left.");
                Console.WriteLine($"Player two has {cntEggsTwo} eggs left.");
            }

        }
    }
}
