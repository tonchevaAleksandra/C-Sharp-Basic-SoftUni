using System;

namespace EasterCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Първоначално от конзолата се прочита броя на козунаците – цяло число в интервала[1… 100]
            //След това за всеки козунак се прочита:
            //• Името на пекаря, който е направил козунака – текст
            //• До получаване на командата "Stop" се прочита
            //o оценка за козунак от един човек – цяло число в интервала[1... 10]
            int cntEasterBread = int.Parse(Console.ReadLine());
            int maxPoints = int.MinValue;
            string winner = "";

            for (int i = 0; i < cntEasterBread; i++)
            {
                string baker = Console.ReadLine();
                string command = Console.ReadLine();
                int currPoints = 0;

                while (command != "Stop")
                {
                    int currGrade = int.Parse(command);
                    currPoints += currGrade;
                    command = Console.ReadLine();
                }

                if (command == "Stop")
                {
                    Console.WriteLine($"{baker} has {currPoints} points.");
                }

                if (currPoints > maxPoints)
                {
                    maxPoints = currPoints;
                    winner = baker;
                    Console.WriteLine($"{winner} is the new number 1!");
                }

            }

            Console.WriteLine($"{winner} won competition with {maxPoints} points!");
        }

    }
}
