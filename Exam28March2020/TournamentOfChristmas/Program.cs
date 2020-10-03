using System;

namespace TournamentOfChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysTournament = int.Parse(Console.ReadLine());
            double sum = 0;
            
            int cntTotalWin = 0;
            int cntTotalLoose = 0;

            for (int i = 1; i <= daysTournament; i++)
            {
                double sumPerDay = 0;
                int counterWin = 0;
                int counterLoose = 0;
                string sport = Console.ReadLine();
                while (sport != "Finish")
                {
                    string result = Console.ReadLine();
                    if (result == "win")
                    {
                        counterWin++;
                        sumPerDay += 20.00;

                    }
                    else
                    {
                        counterLoose++;
                    }

                    sport = Console.ReadLine();
                }

                if(counterWin>counterLoose)
                {
                    sumPerDay *= 1.1;
                    
                    cntTotalWin++;
                }
                else
                {
                    cntTotalLoose++;
                }
                sum += sumPerDay;
            }

            if(cntTotalWin>cntTotalLoose)
            {
                sum *= 1.20;
                Console.WriteLine($"You won the tournament! Total raised money: {sum:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {sum:f2}");
            }
           
        }
    }
}
