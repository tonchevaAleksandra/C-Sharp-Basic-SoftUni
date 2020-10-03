using System;

namespace NameGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //            До получаване на командата "Stop" се чете по един ред:
            //• Име на играча с дължина n -текст
            //За всеки играч се четат n на брой реда:
            //• число – цяло число в интервала[0…127]
            string name = Console.ReadLine();
            int winPoints = int.MinValue;
            string winner = "";
            int countWinners = 0;

            while (name !="Stop")
            {
                int totalPoints = 0;
                char[] array = name.ToCharArray();
                for (int i = 0; i <name.Length; i++)
                {
                    char letter = array[i];
                    int currentPoints = int.Parse(Console.ReadLine());
                    if(currentPoints==letter)
                    {
                        totalPoints += 10;
                    }
                    else
                    {
                        totalPoints += 2;
                    }
                }
                if(totalPoints>=winPoints)
                {
                    countWinners++;
                    winPoints = totalPoints;
                    winner = name;

                }
        
                name = Console.ReadLine();
            }

            Console.WriteLine($"The winner is {winner} with {winPoints} points!");

        }
    }
}
