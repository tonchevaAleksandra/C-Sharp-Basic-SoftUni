using System;

namespace DivisionWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            double cntDBy2 = 0;
            double cntDBy3 = 0;
            double cntDBy4 = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    cntDBy2++;
                }
                if (num % 3 == 0)
                {
                    cntDBy3++;
                }
                if (num % 4 == 0)
                {
                    cntDBy4++;
                }
            }

            Console.WriteLine($"{(cntDBy2 / n * 100):f2}%");
            Console.WriteLine($"{(cntDBy3 / n * 100):f2}%");
            Console.WriteLine($"{(cntDBy4 / n * 100):f2}%");
        }
    }
}
