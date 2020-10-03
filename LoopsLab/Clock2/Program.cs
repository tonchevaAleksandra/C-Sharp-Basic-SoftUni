using System;

namespace Clock2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    for (int s = 0; s < 60; s++)
                    {
                        Console.WriteLine($"{i} : {j} : {s}");
                    }
                }
            }
        }
    }
}
