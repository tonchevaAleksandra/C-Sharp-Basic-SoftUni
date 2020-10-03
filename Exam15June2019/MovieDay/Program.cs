using System;

namespace MovieDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeMovie = int.Parse(Console.ReadLine());
            int countScenes = int.Parse(Console.ReadLine());
            int timeScene = int.Parse(Console.ReadLine());
            double timePrepar = 0.15 * timeMovie;
            double totalTime = countScenes * timeScene + timePrepar;
            if (timeMovie >= totalTime)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(timeMovie - totalTime)} minutes left!");
            }
            else if (timeMovie < totalTime)
            {
                Console.WriteLine($"Time is up! To complete the movie you need {totalTime - timeMovie} minutes.");
            }
        }
    }



}
