using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceExcursion = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int countSpend = 0;
            int counterDays = 0;
            while (countSpend<5 && budget<priceExcursion)
            {
                string text = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                counterDays++;
                if(text=="spend")
                {
                    budget -= money;
                    countSpend++;

                    if (budget<0)
                    {
                        budget = 0.0;

                    }
                   
                }
                        
                else
                {
                    budget += money;
                    countSpend = 0;

                }

                if(budget>=priceExcursion)
                {
                    break;
                }

            }
            if (budget >= priceExcursion)
            {
                Console.WriteLine($"You saved the money for {counterDays} days.");
            }

            if (countSpend==5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine($"{counterDays}");
            }

        }
    }
}
