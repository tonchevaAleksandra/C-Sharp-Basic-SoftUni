using System;

namespace CruiseGames1
{
    class Program
    {
        static void Main(string[] args)
        {
            //            • Име на играч – текст
            //• Брой изиграни игри – цяло число в интервала[1...10]
            //За всяка една игра се четат по два реда:
            //• Име на играта – текст с възможности "volleyball", "tennis", "badminton"
            //• Брой точки – цяло число в интервала[1…100]
            string player = Console.ReadLine();
            int cntGames = int.Parse(Console.ReadLine());
            double pointsTennis = 0;
            double pointsVolley = 0;
            double pointsBadminton = 0;
            double totalPoints = 0;
            int cntTennis = 0;
            int cntVolley = 0;
            int cntBadminton = 0;

            for (int i = 0; i < cntGames; i++)
            {
                string game = Console.ReadLine();
                int points = int.Parse(Console.ReadLine());
                if (game == "volleyball")
                {
                    pointsVolley += points * 1.07;
                    cntVolley++;

                }
                else if (game == "tennis")
                {
                    pointsTennis += points * 1.05;
                    cntTennis++;
                }
                else if (game == "badminton")
                {
                    pointsBadminton += points * 1.02;
                    cntBadminton++;
                }

            }

            totalPoints = Math.Floor(pointsBadminton + pointsVolley + pointsTennis);

            double averagePVolley = (pointsVolley / cntVolley);
            double averagePTennis = (pointsTennis / cntTennis);
            double averagePBadminton = (pointsBadminton / cntBadminton);
            if (averagePBadminton >= 75 && averagePTennis >= 75 && averagePVolley >= 75)
            {

                Console.WriteLine($"Congratulations, {player}! You won the cruise games with {totalPoints} points.");
            }
            else
            {
                Console.WriteLine($"Sorry, {player}, you lost. Your points are only {totalPoints}.");
            }
        }
    }
}
