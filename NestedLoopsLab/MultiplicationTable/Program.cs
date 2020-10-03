using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //table multiplication

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int multiSum = i * j;
                    Console.WriteLine($"{i} * {j} = {multiSum}");
                }
            }
        }
    }
}
