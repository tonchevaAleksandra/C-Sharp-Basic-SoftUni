using System;

namespace BeehivePopulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //            На всеки 10 пчели се излюпват нови 2 пчели в началото на всяка година. 
            //В края на всяка година 2 на всеки 20 от пчелите загиват.
            //В началото на всяка 5 - та година след излюпването на новите пчели, 5 на всеки 50 пчели напускат кошера, за да основат собствен такъв.
            //Изчислете каква ще бъде популацията на кошера след съответния брой години.

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
