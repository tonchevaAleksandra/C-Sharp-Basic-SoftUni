
       
            using System;

namespace EasternParty
    {
        class Program
        {
            static void Main(string[] args)
            {
                int guests = int.Parse(Console.ReadLine());
                double pricePerGuest = double.Parse(Console.ReadLine());
                double budget = double.Parse(Console.ReadLine());
                double priceCake = 0.10 * budget;
                double totalPrice = guests * pricePerGuest;
                if (guests >= 10 && guests <= 15) { totalPrice = 0.85 * totalPrice + priceCake; }
                else if (guests > 15 && guests < +20) { totalPrice = 0.80 * totalPrice + priceCake; }
                else if (guests > 20) { totalPrice = totalPrice * 0.75 + priceCake; }
                else if (guests < 10) { totalPrice = totalPrice + priceCake; }
                if (budget >= totalPrice) { Console.WriteLine($"It is party time! {budget - totalPrice:F2} leva left."); }
                else if (budget < totalPrice) { Console.WriteLine($"No party! {totalPrice - budget:F2} leva needed."); }


            }
        }
    }


