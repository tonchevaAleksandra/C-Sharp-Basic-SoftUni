using System;

namespace SummerShopping
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int budget= int.Parse(Console.ReadLine());
            double priceTowel = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());
            double persentDiscount = discount/ 100.00;
            double priceUmbrella = 2 * priceTowel/3.00;
            double priceFlipFlops = 0.75 * priceUmbrella;
            double priceBag =  (priceFlipFlops + priceTowel) / 3;
            double price = priceTowel + priceUmbrella + priceFlipFlops+ priceBag;
            double totalPrice = price -  (persentDiscount * price);
            if (budget >= totalPrice)
            {  
                Console.WriteLine($"Annie's sum is {totalPrice:f2} lv. She has {budget-totalPrice:f2} lv. left."); 
            }
            else
            {
                Console.WriteLine($"Annie's sum is {totalPrice:f2} lv. She needs {totalPrice-budget:f2} lv. more.");
            }
        }
    }
}
