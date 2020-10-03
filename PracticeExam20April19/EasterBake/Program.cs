using System;

namespace EasterBake
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int cntEBread = int.Parse(Console.ReadLine());
            //1 pack sugar= 950 grams
            //1 pack flour =750 grams
            int maxSugar = int.MinValue;
            int maxFlour = int.MinValue;
            double neededF = 0;
            double neededS = 0;

            for (int i = 0; i < cntEBread; i++)
            {
                int gramsSugar = int.Parse(Console.ReadLine());
                int gramsFlour = int.Parse(Console.ReadLine());
                neededF += gramsFlour;
                neededS += gramsSugar;
                if (gramsFlour > maxFlour)
                {
                    maxFlour = gramsFlour;
                }
                if (gramsSugar > maxSugar)
                {
                    maxSugar = gramsSugar;
                }

            }

            double packFlour = Math.Ceiling(neededF / 750.00);
            double packSugar = Math.Ceiling(neededS / 950.00);

            Console.WriteLine($"Sugar: {packSugar}");
            Console.WriteLine($"Flour: {packFlour}");
            Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar is {maxSugar} grams.");


        }
    }
}
