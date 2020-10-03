using System;

namespace EasternGuests
{
    class Program
    {
        static void Main(string[] args)
        {
            int countGuests = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double priceBread = 4;
            double priceEgg = 0.45;
            double  countBreads = Math.Ceiling(countGuests / 3.00);
           
            int counEggs = countGuests * 2;
            double totalPrice = countBreads * priceBread + counEggs * priceEgg;
            if (budget >= totalPrice)
            {
                Console.WriteLine($"Lyubo bought {countBreads} Easter bread and {counEggs} eggs.");
                Console.WriteLine($"He has {budget - totalPrice:F2} lv. left.");
            }
            else if (budget < totalPrice)
            {
                Console.WriteLine($"Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {totalPrice - budget:F2} lv. more.");
            }


        }
    }
}
