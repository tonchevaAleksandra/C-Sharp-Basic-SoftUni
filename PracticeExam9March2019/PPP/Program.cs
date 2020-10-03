using System;

namespace SummerShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            double towelPrice = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double umbrela = 2 * towelPrice / 3;
            double slippers = umbrela * 0.75;
            double beachBag = (towelPrice + slippers) / 3;

            double totalAmountProduct = towelPrice + umbrela + slippers + beachBag;
            double discountPrecent = discount / 100.00;
            double totalAmountDiscount = totalAmountProduct - (totalAmountProduct * discountPrecent);

            if (budget >= totalAmountDiscount)
            {
                double amoutLeft = budget - totalAmountDiscount;
                Console.WriteLine($"Annie's sum is {totalAmountDiscount:f2} lv. She has {Math.Abs(amoutLeft):f2} lv. left.");
            }
            else
            {
                double budgetLeft = totalAmountDiscount - budget;
                Console.WriteLine($"Annie's sum is {totalAmountDiscount:f2} lv. She needs {budgetLeft:f2} lv. more.");
            }
        }
    }
}