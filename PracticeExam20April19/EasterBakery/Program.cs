using System;

namespace EasterBakery
{
    class Program
    {
        static void Main(string[] args)
        {

            double priceKgFlour = double.Parse(Console.ReadLine());
            double kgFlour = double.Parse(Console.ReadLine());
            double kgSugar = double.Parse(Console.ReadLine());
            int cntBoxEggs = int.Parse(Console.ReadLine());
            int leaven = int.Parse(Console.ReadLine());
            
            double priceSugar = (0.75 * priceKgFlour) * kgSugar;
            double priceBoxEggs = (1.10 * priceKgFlour) * cntBoxEggs;
            double priceLeaven = (0.2 * (0.75 * priceKgFlour)) * leaven;
            double priceflour = priceKgFlour * kgFlour;
            double totalPrice = priceSugar +priceBoxEggs +priceLeaven + priceflour;

            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
