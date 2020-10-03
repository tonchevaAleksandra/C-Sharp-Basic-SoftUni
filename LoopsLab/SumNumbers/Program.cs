using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
               int currentNum = int.Parse(Console.ReadLine());
                sum += currentNum;

            }

            Console.WriteLine(sum);
        }
    }
}
