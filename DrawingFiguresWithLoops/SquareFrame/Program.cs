using System;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row < n; row++)
            {

                for (int col = 2; col < n-2; col++)
                {
                    Console.Write("+ ");
                    for (int i = 2; i < n-2; i++)
                    {
                        Console.Write("- ");
                    }
                    Console.Write("+ ");
                    for (int j = 0; j < length; j++)
                    {

                    }
                }
                
                Console.WriteLine();
            }
        }
    }
}
