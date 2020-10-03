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

            string command = Console.ReadLine();
            int maxResult = int.MinValue;
            string winner = "";

            while (command != "Stop")
            {
                int pointsPlayer = 0;
                string name = command;
                char[] array = name.ToCharArray();
                for (int i = 0; i < name.Length; i++)
                {
                    int currPoints = int.Parse(Console.ReadLine());
                    char letter = array[i];
                    if (currPoints == letter)
                    {
                        pointsPlayer += 10;
                    }
                    else
                    {
                        pointsPlayer += 2;
                    }
                }
                if (pointsPlayer>=maxResult)
                {
                    maxResult = pointsPlayer;
                    winner = name;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"The winner is {winner} with {maxResult} points!");
        }
    }
}
