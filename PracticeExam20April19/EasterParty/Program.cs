using System;

namespace EasterParty
{
    class Program
    {
        static void Main(string[] args)
        {

            int cntGuests = int.Parse(Console.ReadLine());
            double priceCouvert = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            
            double totalPrice = 0;
            if(cntGuests>=10 && cntGuests <=15)
            {
                totalPrice = cntGuests * (0.85 * priceCouvert) + 0.1 * budget;
            }
            else if (cntGuests>15&& cntGuests<=20)
            {
                totalPrice = cntGuests * (0.8 * priceCouvert) + 0.1 * budget;
            }
            else if(cntGuests>20)
            {
                totalPrice = cntGuests * (0.75 * priceCouvert) + 0.1 * budget;
            }
            else
            {
                totalPrice = cntGuests * priceCouvert + 0.1 * budget;
            }

            if(totalPrice<=budget)
            {
                Console.WriteLine($"It is party time! {budget-totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {totalPrice-budget:f2} leva needed.");
            }
        }
    }
}
