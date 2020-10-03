using System;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int sumPrime = 0;
            int sumNonPrime = 0;
            

            while (command !="stop")
            {
                int number = int.Parse(command);
                if(number<0)
                {
                    Console.WriteLine($"Number is negative.");
                    command = Console.ReadLine();
                    continue;
                }

                bool isprime = true;

                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if(number%i==0)
                    {
                        isprime =false;
                        break;
                    }
                }

                if(isprime)
                {
                    sumPrime += number;
                }
                else
                {
                    sumNonPrime += number;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
