using System;

namespace _5_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string bestPlayer = string.Empty;
            int bestGoals = 0;

            string player = Console.ReadLine();

            while(player!="END")
            {
                int goals = int.Parse(Console.ReadLine());
                if(goals>bestGoals)
                {
                    bestGoals = goals;
                    bestPlayer = player;
                }
                if(goals>=10)
                {
                    break;
                }

                player = Console.ReadLine();
            }

            Console.WriteLine($"{bestPlayer} is the best player!");
            if(bestGoals>=3)
            {
                Console.WriteLine($"He has scored {bestGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {bestGoals} goals.");
            }
        }
    }
}
