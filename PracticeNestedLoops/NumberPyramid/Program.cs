using System;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            bool isBigger = false;

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    if(counter>n)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write($"{counter} ");
                    counter++;
                }
               if(isBigger)
                {
                    break;
                }
                Console.WriteLine();
                
            }


        }
    }
}
