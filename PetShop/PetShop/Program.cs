using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogCount = int.Parse(Console.ReadLine());
            int animalsCount = int.Parse(Console.ReadLine());
            double dogExpenses = dogCount * 2.50;
            double animalsExpenses = animalsCount * 4;
            double totalExpenses = dogExpenses + animalsExpenses;
            Console.WriteLine($"{ totalExpenses:F2} lv.");
        }
    }
}
