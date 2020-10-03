using System;

namespace FamilyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Бюджетът, с който разполагат – реално число в интервала[1.00 … 10000.00]
            //• Брой нощувки – цяло число в интервала[0 … 1000]
            //• Цена за нощувка – реално число в интервала[1.00 … 500.00]
            //• Процент за допълнителни разходи – цяло число в интервала[0 … 100]

            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
            int persentExtraExpenses = int.Parse(Console.ReadLine());

            double totalPrice = persentExtraExpenses / 100.00 * budget + (pricePerNight * nights);
            if(nights>7)
            {
                totalPrice= persentExtraExpenses / 100.00 * budget + ((pricePerNight*0.95) * nights);
            }

            if (budget>=totalPrice)
            {
                Console.WriteLine($"Ivanovi will be left with {(budget-totalPrice):f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{totalPrice-budget:f2} leva needed.");
            }
        }
    }
}
