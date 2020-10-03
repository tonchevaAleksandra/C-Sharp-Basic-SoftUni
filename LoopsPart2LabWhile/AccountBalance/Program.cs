using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double balance = 0.0;
            while (n!=0)
            {
                double amount = double.Parse(Console.ReadLine());
                if(amount<0)
                {
                    Console.WriteLine($"Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {amount:f2}");
                balance += amount;
                n--;
                
            }
            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}
