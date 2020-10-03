using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double metersYard = double.Parse(Console.ReadLine());
            double meterPrice = 7.61;
            double price = metersYard * meterPrice;
            double discount = 0.18 * price;
            double finalPrice = price - discount;
            Console.WriteLine($"The final price is: {finalPrice:F2} lv.");
            Console.WriteLine($"The discount is: {discount:F2} lv.");
        }
    }
}
