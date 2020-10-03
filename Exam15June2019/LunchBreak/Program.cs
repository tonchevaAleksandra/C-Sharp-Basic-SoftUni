using System;

namespace LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string serie = Console.ReadLine();
            int timeEpisode = int.Parse(Console.ReadLine());
            int timeBreak = int.Parse(Console.ReadLine());
            double timeLunch = timeBreak / 8.0;
            double timeRelax = timeBreak / 4.0;
            double restBreak = timeBreak - timeLunch - timeRelax;
            if
                (restBreak >= timeEpisode)
            { Console.WriteLine($"You have enough time to watch {serie} and left with {Math.Ceiling(restBreak - timeEpisode)} minutes free time."); }
            else if
                (restBreak < timeEpisode)
            { Console.WriteLine($"You don't have enough time to watch {serie}, you need {Math.Ceiling(timeEpisode - restBreak)} more minutes."); }

        }
    }
}