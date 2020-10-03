using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1111; i < 9999; i++)
            {
                int counter = 0;
                int number = i;
                while (number>0)
                {
                   int digit = number % 10;
                    number /= 10;
                    if (digit == 0 || n % digit != 0)
                    {
                        break;
                    }
                    else
                    {
                        counter++;
                        if (counter == 4)
                        { Console.Write($"{i} "); }
                    }

                }

            }

        }
    }
}
