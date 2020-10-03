using System;

namespace OddEvenPoisitions
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double eveMin = double.MaxValue;
            double evenMax = double.MinValue;
            double sumOdd = 0;
            double sumEven = 0;
            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if(i%2!=0)
                {
                    if(number<=oddMin)
                    {
                        oddMin = number;
                    }
                    if(number>=oddMax)
                    {
                        oddMax = number;
                    }
                    sumOdd += number;
                }
                else
                {
                    if(number<=eveMin)
                    {
                        eveMin = number;
                    }
                    if(number>=evenMax)
                    {
                        evenMax = number;
                    }
                    sumEven += number;
                }
            }
           
            Console.WriteLine($"OddSum={sumOdd:f2},");
           
            if (oddMin != double.MaxValue)
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
                
            }
            else
            {
                Console.WriteLine($"OddMin=No,");
            }
            if(oddMax != double.MinValue)
            {
                Console.WriteLine($"OddMax={oddMax:f2},");
            }
            else
            {
                Console.WriteLine($"OddMax=No,");
                
            }

            Console.WriteLine($"EvenSum={sumEven:f2},");
           
            if(eveMin != double.MaxValue)
            {
                Console.WriteLine($"EvenMin={eveMin:f2},");
            }
            else
            {
                Console.WriteLine($"EvenMin=No,");
                
            }
            if(evenMax != double.MinValue)
            {
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
            else
            {
                Console.WriteLine($"EvenMax=No");
                
            }
            
        }
    }
}
