using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeProjection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            double pricePremiere = 12.00;
            double priceNormal = 7.50;
            double pricediscount = 5.00;
            double income = 0.0;

            if(typeProjection=="Premiere")
            {
                income = rows * colums * 12.00;
            }
            else if(typeProjection=="Normal")
            {
                income = rows * colums * 7.50;
            }
            else if(typeProjection=="Discount")
            {
                income = rows * colums * 5.00;
            }
            Console.WriteLine($"{income:f2} leva");

        }
    }
}
