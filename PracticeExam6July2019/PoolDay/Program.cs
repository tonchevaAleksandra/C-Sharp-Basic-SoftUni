using System;

namespace PoolDay
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int clients = int.Parse(Console.ReadLine());
            double taxe = double.Parse(Console.ReadLine());
            double priceChaise = double.Parse(Console.ReadLine());
            double priceUmbre = double.Parse(Console.ReadLine());
     
            double totalPrice = clients * taxe + (Math.Ceiling(0.75 * clients) * priceChaise) + (priceUmbre * (Math.Ceiling(clients / 2.0)));
            
            Console.WriteLine($"{totalPrice:f2} lv.");

        }
    }
}
