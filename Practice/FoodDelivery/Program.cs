using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int veganMenu = int.Parse(Console.ReadLine());
            double chickenPrice = 10.35;
            double fishPrice = 12.40;
            double veganPrice = 8.15;
            double deliveryPrice = 2.50;
            double price = (chickenPrice * chickenMenu) + (fishMenu * fishPrice) + (veganMenu * veganPrice);
            double dessertPrice = 0.2 * price;
            double totalPrice = price + dessertPrice + deliveryPrice;
            Console.WriteLine($"Total: {totalPrice:F2}");


        }
    }
}
