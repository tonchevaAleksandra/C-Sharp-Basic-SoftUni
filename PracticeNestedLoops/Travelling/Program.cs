using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
           

            while (destination!="End")
            {
                double neededBudget = double.Parse(Console.ReadLine());
                double budget = 0;
                while (budget<neededBudget)
                {
                    double increasedM = double.Parse(Console.ReadLine());
                    budget += increasedM;
                }
                if (budget >=neededBudget)
                {
                    Console.WriteLine($"Going to {destination}!");
                    
                }
                    destination = Console.ReadLine();
                
            }
            
        }
    }
}
