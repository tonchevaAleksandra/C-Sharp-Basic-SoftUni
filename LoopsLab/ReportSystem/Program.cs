using System;

namespace ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededSum = int.Parse(Console.ReadLine());
           double sumIncreased = 0.0;
            int counter = 0;
            double cashSum = 0.0;
            double cardSum = 0.0;
            int counterCash = 0;
            int counterCard = 0;
            double totalSum = 0.0;

            while (totalSum<neededSum)
            {
                string input = Console.ReadLine();
                if(input=="End")
                {
                    Console.WriteLine($"Failed to collect required money for charity.");
                    break;
                }
                sumIncreased = double.Parse(input);
                counter++;
                if (counter%2!=0)
                {
                    if(sumIncreased>100.0)
                    {
                        Console.WriteLine($"Error in transaction!");
                    }
                    else if(sumIncreased<=100.0)
                    {
                        Console.WriteLine($"Product sold!");
                        cashSum += sumIncreased;
                        counterCash++;
                        totalSum += sumIncreased;

                    }
                }
                    
                else if(counter%2 ==0)
                {
                    if(sumIncreased<10.0)
                    {
                        Console.WriteLine($"Error in transaction!");
                    }
                    else if(sumIncreased>=10.0)
                    {
                        Console.WriteLine($"Product sold!");
                        cardSum += sumIncreased;
                        counterCard++;
                        totalSum += sumIncreased;
                    }
                }
                
            }
            if(neededSum<=totalSum)
            {
                Console.WriteLine($"Average CS: {cashSum / counterCash:f2}");
                Console.WriteLine($"Average CC: {cardSum / counterCard:f2}");

            }
        }
    }
}
