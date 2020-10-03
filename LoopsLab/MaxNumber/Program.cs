using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int maxNum = int.MinValue;

            while (counter<n)
            {
                int number = int.Parse(Console.ReadLine());
                counter++;
                if (number > maxNum)
                { 
                    maxNum = number; 
                }
            }
            Console.WriteLine($"{maxNum}");
        }
    }
}
