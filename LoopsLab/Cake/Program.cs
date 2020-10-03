using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int volume = width * length;
            int totalPieces = 0;
            int pieces = 0;
            while (totalPieces<volume)
            {
                string input = Console.ReadLine();
                if(input=="STOP")
                {
                    break;
                }
                    
                pieces = int.Parse(input);
                totalPieces += pieces;

            }
            if(totalPieces>=volume)
            {
                Console.WriteLine($"No more cake left! You need {totalPieces-volume} pieces more.");
            }
            else
            {
                Console.WriteLine($"{volume - totalPieces} pieces are left.");
            }

        }
    }
}
