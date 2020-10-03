using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sum = 0;
            string command = Console.ReadLine();
            while (command !="Stop")
            {
                int number = int.Parse(command);
                sum += number;
                command = Console.ReadLine();
                
            }
            Console.WriteLine($"{sum}");
        }
    }
}
