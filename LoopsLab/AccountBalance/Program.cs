using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOper = int.Parse(Console.ReadLine());
            int counter = 0;
            double total = 0.0;


            while (counter<numberOfOper)
            {
                double deposit = double.Parse(Console.ReadLine());
                if (deposit < 0) { 
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {deposit:f2}");
                counter++;
                total += deposit;
            }
            Console.WriteLine($"Total: {total:f2}");
            
        }
    }
}
