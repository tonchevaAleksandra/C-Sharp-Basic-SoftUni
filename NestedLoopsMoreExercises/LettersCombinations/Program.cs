using System;

namespace LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char markExeption = char.Parse(Console.ReadLine());
            //combination with chars != third
            int counter = 0;

            for (char first = start; first <= end; first++)
            {
                if (first != markExeption)
                {
                    for (char second = start; second <= end; second++)
                    {
                        if (second != markExeption)
                        {
                            for (char third = start; third <= end; third++)
                            {
                                if (third != markExeption)

                                {
                                    counter++;
                                    Console.Write($"{first}{second}{third} ");
                                }

                            }
                        }

                    }
                }

            }
            Console.Write(counter);


        }
    }
}
