using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                int newNum = i;
                int counter = 0;
                while (newNum > 0)
                {
                    int digit = newNum % 10;
                    newNum /= 10;
                    if (digit == 0 || n % digit != 0)
                    {
                        break;
                    }
                    else
                    {
                        counter++;
                    }

                    if (counter == 4)
                    {
                        Console.Write($"{i} ");
                        break;
                    }
                    
                }


            }
        }
    }
}
