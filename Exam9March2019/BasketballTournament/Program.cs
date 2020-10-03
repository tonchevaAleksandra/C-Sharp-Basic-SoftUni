using System;

namespace BasketballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            //            От конзолата се четат поредица от турнири до получаване на командата "End of tournaments":
            //• Име на турнира – текст
            //• За всеки турнир n на брой мача – цяло число в интервала[1…15]
            //• За всеки мач се четат по два реда:
            //o Точки, вкарани от отбора на Деси – цяло число в интервала от[0…150]
            //o Точки, вкарани от противниковия отбор – цяло число в интервала от[0…150]
            string nameTour = Console.ReadLine();
            double countWins = 0;
            double countLose = 0;
            double matches = 0;
            while (nameTour != "End of tournaments")
            {
                int n = int.Parse(Console.ReadLine());
                matches += n;
                for (int i = 1; i <= n; i++)
                {
                    int pointsDessi = int.Parse(Console.ReadLine());
                    int pointsOpponent = int.Parse(Console.ReadLine());
                    if(pointsDessi>pointsOpponent)
                    {
                        countWins++;
                        Console.WriteLine($"Game {i} of tournament {nameTour}: win with {pointsDessi - pointsOpponent} points.");
                    }
                    else
                    {
                        countLose++;
                        Console.WriteLine($"Game {i} of tournament {nameTour}: lost with {pointsOpponent - pointsDessi} points.");
                    }
                }

                nameTour = Console.ReadLine();
            }
            if(nameTour=="End of tournaments")
            {
                double persentWin = countWins / matches * 100;
                Console.WriteLine($"{persentWin:f2}% matches win");
                double persentLose = countLose / matches * 100;
                Console.WriteLine($"{persentLose:f2}% matches lost");
            }
        }
    }
}
