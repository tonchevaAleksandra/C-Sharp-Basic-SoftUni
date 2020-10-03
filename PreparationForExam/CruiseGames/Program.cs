using System;

namespace DartsTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int startPoints = int.Parse(Console.ReadLine());
            int countMoves = 0;
            bool isWin = false;

            while(startPoints>0 && isWin==false)
            {
                string sector = Console.ReadLine();
                
                countMoves++;
                if(sector=="number section")
                {
                    int currPoints = int.Parse(Console.ReadLine());
                    startPoints -=currPoints;
                }
                else if(sector=="double ring")
                {
                    int currPoints = int.Parse(Console.ReadLine());
                    startPoints -= currPoints * 2;
                }
                else if (sector=="triple ring")
                {
                    int currPoints = int.Parse(Console.ReadLine());
                    startPoints -= currPoints * 3;
                }
                else if (sector== "bullseye")
                {
                    isWin = true;
                    Console.WriteLine($"Congratulations! You won the game with a bullseye in {countMoves} moves!");
                    break;
                }
     
            }

            if(startPoints==0)
            {
                Console.WriteLine($"Congratulations! You won the game in {countMoves} moves!");
            }
            if(startPoints<0)
            {
                Console.WriteLine($"Sorry, you lost. Score difference: {Math.Abs(startPoints)}.");
            }

        }
    }
}
