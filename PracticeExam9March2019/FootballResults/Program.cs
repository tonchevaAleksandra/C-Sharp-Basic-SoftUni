using System;

namespace FootballResults
{
    class Program
    {
        static void Main(string[] args)
        {



            string firstMatch = Console.ReadLine();
            string secondMatch = Console.ReadLine();
            string thirdMatch = Console.ReadLine();
            int win = 0;
            int lose = 0;
            int draw = 0;

            char[] first = firstMatch.ToCharArray();
            int x1 = first[0];
            int y1 = first[2];
            char[] second = secondMatch.ToCharArray();
            int x2 = second[0];
            int y2 = second[2];
            char[] third = thirdMatch.ToCharArray();
            int x3 = third[0];
            int y3 = third[2];

            if (x1 > y1)
            {
                win++;
            }
            else if (x1 == y1)
            {
                draw++;
            }
            else if (x1 < y1)
            {
                lose++;
            }
            if (x2 > y2)
            {
                win++;
            }
            else if (x2 == y2)
            {
                draw++;
            }
            else if (x2 < y2)
            {
                lose++;
            }
            if (x3 > y3)
            {
                win++;
            }
            else if (x3 == y3)
            {
                draw++;
            }
            else if (x3 < y3)
            {
                lose++;
            }
            Console.WriteLine($"Team won {win} games.");
            Console.WriteLine($"Team lost {lose} games.");
            Console.WriteLine($"Drawn games: {draw}");

        }
    }
}
