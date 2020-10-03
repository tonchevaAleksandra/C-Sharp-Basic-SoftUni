using System;

namespace SummerShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            int budgetAni =int.Parse(Console.ReadLine());
            double priceTowel = double.Parse(Console.ReadLine());
            int percentageDiscount = int.Parse(Console.ReadLine());
            double priceUmbre = (2 * priceTowel/3);
            double priceFlipFlops = 0.75 * priceUmbre;
            double priceBag = (1 * (priceTowel + priceFlipFlops)/3);
            double totalSum = priceTowel + priceUmbre + priceFlipFlops + priceBag;
            double sumAfterDiscount = totalSum - (percentageDiscount  * totalSum/100);
            double rest = budgetAni - sumAfterDiscount;
            double neededSum = sumAfterDiscount - budgetAni;
            if (budgetAni >= sumAfterDiscount) { Console.WriteLine($"Annie's sum is {sumAfterDiscount:F2} lv. She has {rest:F2} lv. left."); }
            
            
            else if (sumAfterDiscount >= budgetAni)  { Console.WriteLine($"Annie's sum is {sumAfterDiscount:F2} lv. She needs {neededSum:F2} lv. more."); }

        }
    }
}
