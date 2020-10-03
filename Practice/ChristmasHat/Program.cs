using System;

namespace ChristmasHat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //for first two rows
            Console.Write(new string('.', 2*n-1));
            Console.Write($"/|\\");
            Console.WriteLine(new string('.', 2 * n - 1));
            //for second row
            Console.Write(new string('.', 2 * n - 1));
            Console.Write($"\\|/");
            Console.WriteLine(new string('.', 2 * n - 1));
            int point = 2 * n - 1;
            int stars = 3;
            int dash = 1;
            for (int row = 1; row <=2*n; row++)
            {
                for (int col = 1; col <= 4*n+1; col++)
                {
                    

                    if (row>=2)
                    {
                        Console.Write(new string('.', point));
                        Console.Write("*");
                        Console.Write(new string('-', dash));
                        Console.Write("*");
                        Console.Write(new string('-', dash));
                        Console.Write("*");
                        Console.WriteLine(new string('.', point));
                        dash++;
                    }
                    else
                    {
                        Console.Write(new string('.', point));
                        Console.Write(new string('*', stars));
                        Console.WriteLine(new string('.', point));
                    }
                    point--;
                    if(point==0)
                    {
                        break;
                    }
                }
                if (point == 0)
                {
                    break;
                }
            }
        }
    }
}
