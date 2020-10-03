using System;

namespace BeehivePopulation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int startPopulation = int.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());

            for (int i = 1; i <= years; i++)
            {
                startPopulation += startPopulation / 10 * 2;

                if(i%5==0)
                {
                    startPopulation -= startPopulation / 50 * 5;
                }

                startPopulation -= startPopulation / 20 * 2;
            }

            Console.WriteLine($"Beehive population: {startPopulation}");

        }
    }
}
