using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int counter = 0;
            int minNum = int.MaxValue;
            while (counter<num)
            {
                int number = int.Parse(Console.ReadLine());
                counter++;
                if (number < minNum) 
                {
                    minNum = number;
                }
            }
            Console.WriteLine($"{minNum}");
               

                    
        }
    }
}
