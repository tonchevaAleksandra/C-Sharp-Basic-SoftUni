using System;

namespace PrimePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstStart = int.Parse(Console.ReadLine());
            int secondStart = int.Parse(Console.ReadLine());
            int endToIncrease1 = int.Parse(Console.ReadLine());
            int endToIncrease2 = int.Parse(Console.ReadLine());
     
            for (int first = firstStart; first <= firstStart + endToIncrease1; first++)
            {
                bool isPrime1 = true;
                for (int i = 2; i < first; i++)
                {
                    if (first % i == 0)
                    {
                        isPrime1 = false;
                        break;
                    }
                   
                }
                if(isPrime1)
                {
                    for (int second = secondStart; second <= secondStart + endToIncrease2; second++)
                    {
                        bool isPrime2 = true;
                        for (int j = 2; j < second; j++)
                        {
                            if (second % j == 0)
                            {
                                isPrime2 = false;
                                break;
                            }
                           
                        }

                        if (isPrime2)
                        {
                            Console.WriteLine($"{first}{second}");
                            continue;
                        }
                    }         

                }

            }
    
        }
    }
}
