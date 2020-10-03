using System;

namespace EasterGuests
{
    class Program
    {
        static void Main(string[] args)
        {

            int cntGuests = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            //            Един козунак струва 4лв. // 1 easterBread for 3 persons закръгли към по-голямото цяло число
            //• Едно яйце струва 0.45лв. //2 eggs for person

            double priceEasterBread = 4.00* Math.Ceiling (cntGuests/3.00);
            double priceEggs = 0.45 * cntGuests * 2;
            double totalPrice = priceEasterBread + priceEggs;
            if (budget>=totalPrice)
            {
                Console.WriteLine($"Lyubo bought {Math.Ceiling(cntGuests / 3.00)} Easter bread and {cntGuests * 2} eggs.");
                Console.WriteLine($"He has {budget-totalPrice:f2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {totalPrice-budget:f2} lv. more.");
            }

        }
    }
}
