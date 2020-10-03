using System;

namespace ChallengeTheWedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int mens = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int maxTables = int.Parse(Console.ReadLine());

            int counterTables = 0;
           


            for (int i = 1; i <= mens; i++)
            {
                for (int j = 1; j <= women; j++)
                {

                    if (counterTables == maxTables)
                    {
                        return;
                       
                    }
                    counterTables++;
                    Console.Write($"({i} <-> {j}) ");
                }
               
            }
           
        }
    }
}

