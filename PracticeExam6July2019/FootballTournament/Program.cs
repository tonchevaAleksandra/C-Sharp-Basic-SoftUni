using System;

namespace FootballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Името на футболния отбор, за който водим статистика - текст
            //• Броя изиграни срещи през настоящия сезон -цяло число в интервала[0… 100]
            //За всяка изиграна среща се прочита отделен ред:
            //o Резултатът от изиграната среща в един от горепосочените формати – символ с възможности
            //'W', 'D' и 'L'

            string team = Console.ReadLine();
            int cntMatches = int.Parse(Console.ReadLine());
            double cntWin = 0;
            double cntD = 0;
            double cntLose = 0;
            int points = 0;

            for (int i = 1; i <= cntMatches; i++)
            {
               
                char result = char.Parse(Console.ReadLine());
                if (result == 'W')
                {
                    cntWin++; points += 3;
                }
                else if (result == 'D')
                {
                    cntD++; points += 1;
                }
                else if (result == 'L')
                {
                    cntLose++;
                }

            }
            if (cntMatches == 0)
            {
                Console.WriteLine($"{team} hasn't played any games during this season.");
                return;
            }
            else
            {
                Console.WriteLine($"{team} has won {points} points during this season.");
                Console.WriteLine($"Total stats:");
                Console.WriteLine($"## W: {cntWin}");
                Console.WriteLine($"## D: {cntD}");
                Console.WriteLine($"## L: {cntLose}");
                double persentWin = cntWin / cntMatches * 100.00;
                Console.WriteLine($"Win rate: {persentWin:f2}%");
            }

        }
    }
}
