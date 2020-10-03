using System;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    counter++;
                    Console.Write($"{counter} ");
                    if(counter==n)
                    {
                        break;
                    }
                }
               
                Console.WriteLine();
                if (counter == n)
                {
                    break;
                }
            }
        }
    }
}
