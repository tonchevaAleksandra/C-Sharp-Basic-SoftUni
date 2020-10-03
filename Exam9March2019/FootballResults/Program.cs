using System;

namespace FootballResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string match1 = Console.ReadLine();
            string match2 = Console.ReadLine();
            string match3 = Console.ReadLine();
            int removeAsci = 48;
            int win = 0;
            int loose = 0;
            int draw = 0;
            int test = match1[0] - removeAsci;
            int test2 = match1[2] - removeAsci;
            if (match1[0] - removeAsci > match1[2] - removeAsci)
            {
                win += 1;
            }
            else if (match1[0] - removeAsci < match1[2] - removeAsci)
            {
                loose += 1;
            }
            else
            {
                draw += 1;
            }
            if (match2[0] - removeAsci > match2[2] - removeAsci)
            {
                win += 1;
            }
            else if (match2[0] - removeAsci < match2[2] - removeAsci)
            {
                loose += 1;
            }
            else
            {
                draw += 1;
            }
            if (match3[0] - removeAsci > match3[2] - removeAsci)
            {
                win += 1;
            }
            else if (match3[0] - removeAsci < match3[2] - removeAsci)
            {
                loose += 1;
            }
            else
            {
                draw += 1;
            }
            Console.WriteLine($"Team won {win} games.");
            Console.WriteLine($"Team lost {loose} games.");
            Console.WriteLine($"Drawn games: {draw}");

        }
    }
}