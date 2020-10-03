using System;

namespace EasternTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string dates = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double price = 0.0;
            if (destination == "France")
            {
                if (dates == "21-23") { price = 30.0 * nights; }
                else if (dates == "24-27") { price = 35.0 * nights; }
                else { price = nights * 40.0; }
            }
            else if (destination == "Italy")
            {
                if (dates == "21-23") { price = 28.0 * nights; }
                else if (dates == "24-27") { price = 32.0 * nights; }
                else { price = nights * 39.0; }
            }
            else
            {
                if (dates == "21-23") { price = 32.0 * nights; }
                else if (dates == "24-27") { price = 37.0 * nights; }
                else { price = nights * 43.0; }
            }
            Console.WriteLine($"Easter trip to { destination} : { price:f2} leva.");

        }
    }
}
