using System;

namespace FootballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Вход
            // От конзолата се четат два реда:
            //• Името на футболния отбор, за който водим статистика - текст
            //• Броя изиграни срещи през настоящия сезон -цяло число в интервала[0… 100]
            //За всяка изиграна среща се прочита отделен ред:
            //o Резултатът от изиграната среща в един от горепосочените формати – символ с възможности
            //'W', 'D' и 'L'

            string team = Console.ReadLine();
            int match = int.Parse(Console.ReadLine());
            if (match == 0)
            {
                Console.WriteLine($"{team} hasn't played any games during this season.");
            }
            double countW = 0.0;
            int countD = 0;
            int countL = 0;
            double points = 0;
           if(match !=0)
            {
                for (int i = 0; i < match; i++)
                {
                    char result = char.Parse(Console.ReadLine());
                    switch (result)
                    {
                        case 'W':countW++;points += 3;
                            break;
                        case 'D': countD++;points += 1;
                            break;
                        case 'L': countL++;points += 0;
                            break;
                        
                    }
                }
                Console.WriteLine($"{team} has won {points} points during this season.");
                Console.WriteLine($"Total stats:");
                Console.WriteLine($"## W: {countW}");
                Console.WriteLine($"## D: {countD}");
                Console.WriteLine($"## L: {countL}");
                double persWin = countW / match * 100.00;
                Console.WriteLine($"Win rate: {persWin:F2}%");
            }

            
        }
    }
}
