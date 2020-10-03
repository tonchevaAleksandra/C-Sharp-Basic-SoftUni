using System;

namespace FavoriteMovie
{
    class Program
    {
        static void Main(string[] args)
        {

            string command = Console.ReadLine();
            int counterM = 0;
            int maxResult = int.MinValue;
            string bestMovie = "";
           

            while (command !="STOP"  && counterM<7)
            {
                string movie = command;
                char[] array = movie.ToCharArray();
                counterM++;
                int currentResult = 0;
                for (int i = 0; i < movie.Length; i++)
                {
                   
                        char letter = array[i];
                        if(letter>='A' && letter<='Z')
                    {
                        currentResult +=letter - movie.Length;
                    }
                    else if(letter>='a' && letter<='z')
                    {
                        currentResult += letter - 2 * (movie.Length);
                    }
                    else
                    {
                        currentResult += letter;
                    }
                   
                }
                if(currentResult>maxResult)
                {
                    maxResult = currentResult;
                    bestMovie = movie;
                }

                    command = Console.ReadLine();
            }

            if(counterM>=7)
            {
                Console.WriteLine($"The limit is reached.");
            }

            Console.WriteLine($"The best movie for you is {bestMovie} with {maxResult} ASCII sum.");
        }
    }
}
