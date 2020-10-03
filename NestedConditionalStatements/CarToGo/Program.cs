using System;

namespace CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0.0;
            string car = "";
            string typeClass = "";
            
        if(budget<=100)
            {
                typeClass = "Economy class";
                if (season == "Summer") { car = "Cabrio"; price = 0.35 * budget; }
                else { car = "Jeep"; price = 0.65 * budget; }
            }
        else if(budget>100 && budget<=500)
            {
                typeClass = "Compact class";
                if (season == "Summer") { car = "Cabrio"; price = 0.45 * budget; }
                else { car= "Jeep"; price = 0.80 * budget; }
            }
        else
            {
                if (season == "Summer" || season == "Winter")
                { typeClass = "Luxury class"; car = "Jeep"; price = 0.9 * budget; }
            }
            Console.WriteLine($"{typeClass}");
            Console.WriteLine($"{car} - {price:F2}");

        }
    }
}
