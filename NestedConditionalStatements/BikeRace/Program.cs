using System;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            
            string trace = Console.ReadLine();
            double totalExpenses = 0.0;
            double price = 0.0;
            if (trace == "trail") 
            {
                price = (juniors * 5.5) + (seniors * 7.0);
            }
            else if (trace=="cross-country")
            {
                
                if ((seniors + juniors) >= 50) 
                { 
                    price = ((juniors * 8.0 ) + (seniors * 9.5)) * 0.75; 
                }
                else
                {
                    price = (juniors * 8.0) +( seniors * 9.5);
                }
            }
            else if(trace == "downhill")
            {
                price = (juniors * 12.25) + (seniors * 13.75);
            }
            else 
            {
                price = (juniors * 20.0) + (seniors * 21.5);
            }
             totalExpenses = price * 0.95;
            Console.WriteLine($"{totalExpenses:f2}");
        }
    }
}

