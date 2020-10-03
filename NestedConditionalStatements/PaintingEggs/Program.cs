using System;

namespace PaintingEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            string color = Console.ReadLine();
            int quantitty = int.Parse(Console.ReadLine());
            double price = 0.0;
            if(size=="Large")
            {
                if(color=="Red")
                {
                    price = 16 * quantitty;
                }
                else if(color=="Green")
                {
                    price = 12 * quantitty;
                }
                else
                {
                    price = 9 * quantitty;
                }
            }
            else if (size == "Medium")
            {
                if (color == "Red")
                {
                    price = 13 * quantitty;
                }
                else if (color == "Green")
                {
                    price = 9 * quantitty;
                }
                else
                {
                    price = 7 * quantitty;
                }
            }
            else 
            {
                if (color == "Red")
                {
                    price = 9 * quantitty;
                }
                else if (color == "Green")
                {
                    price = 8 * quantitty;
                }
                else
                {
                    price = 5 * quantitty;
                }
            }
            Console.WriteLine($"{(price*0.65):f2} leva.");
        }
    }
}
