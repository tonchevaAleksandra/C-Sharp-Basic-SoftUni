using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double priceStudio = 0.0;
            double priceApart = 0.0;
            if (month == "May" || month == "October")
           {
                if (nights > 7 && nights<=14) { priceStudio = 50.0 * 0.95; priceApart = 65; }
                else if(nights > 14) { priceStudio = 50.0 * 0.7; priceApart = 65 * 0.9; }
                else { priceStudio = 50.0 ; priceApart = 65 ; }
            }
            else if(month=="June" || month=="September")
            {
                 if (nights > 14 ) { priceStudio = 75.20 * 0.8; priceApart = 68.7 * 0.9; }
                
                else { priceStudio = 75.20; priceApart = 68.70; }
            }
            else if(month=="July"|| month=="August")
            {
                if (nights > 14 ) { priceApart = 77.0 * 0.9; priceStudio = 76.0; }

                else { priceStudio = 76.0; priceApart = 77.0; }
            }
            Console.WriteLine($"Apartment: {priceApart * nights:f2} lv.");
            Console.WriteLine($"Studio: {priceStudio * nights:f2} lv.");

        }
    }
}
