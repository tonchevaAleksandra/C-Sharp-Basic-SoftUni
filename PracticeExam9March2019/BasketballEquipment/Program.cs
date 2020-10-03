using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int taxeYear = int.Parse(Console.ReadLine());
           
            double priceSneakers = 0.6 * taxeYear;
            double priceEquip = 0.8 * priceSneakers;
            double priceBall = priceEquip / 4.0;
            double priceAccessories = priceBall / 5.0;
            double totalPrice = taxeYear + priceSneakers + priceEquip + priceBall + priceAccessories;

            Console.WriteLine($"{totalPrice:f2}");
            

        }
    }
}
