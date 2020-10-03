using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int minNum = int.MaxValue;
            while (n != 0)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < minNum)
                {
                    minNum = number;
                }

                n--;
            }
            Console.WriteLine(minNum);
        }
    }
}
