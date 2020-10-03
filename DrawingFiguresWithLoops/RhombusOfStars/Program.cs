using System;

namespace RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int clnsCnt = 1;
            for (int row = 0; row < n-1; row++)
            {
                Console.Write(new string(' ', n-clnsCnt));
                for (int col = 0; col < clnsCnt; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                clnsCnt++;
            }
            for (int col = 0; col < n; col++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();

            clnsCnt = n-1;
            for (int row = 0; row < n - 1; row++)
            {
                Console.Write(new string(' ', n - clnsCnt));
                for (int col = 0; col < clnsCnt; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                clnsCnt--;
            }

        }
    }
}
