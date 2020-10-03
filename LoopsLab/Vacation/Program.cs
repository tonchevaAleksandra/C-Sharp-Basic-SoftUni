using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int dayscounter = 0;
            int spendingCounter = 0;
            while (budget<neededMoney && spendingCounter<5)
            {
                string options = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());
                dayscounter++;
                if (options == "spend")
                {
                    budget -= sum;
                    spendingCounter++;
                    if (budget < 0)
                    {
                        budget = 0;
                    }
                }
                else if(options=="save")
                {
                    budget += sum;
                    spendingCounter = 0;
                    
                }
            }
            if(spendingCounter==5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine($"{dayscounter}");
            }
            if(budget>=neededMoney)
            {
                Console.WriteLine($"You saved the money for {dayscounter} days.");
            }
        }
    }
}
