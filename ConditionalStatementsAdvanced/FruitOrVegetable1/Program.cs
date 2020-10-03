using System;

namespace FruitOrVegetable1
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            if("banana"==product || "apple"==product || "kiwi"==product || "lemon"==product ||"grapes"==product || "cherry"==product)
            {
                Console.WriteLine("fruit");
            }
            else if("tomato"==product || "cucumber"==product || "pepper"==product || "carrot"==product)
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
