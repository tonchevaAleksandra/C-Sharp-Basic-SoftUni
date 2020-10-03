using System;

namespace TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double km = double.Parse(Console.ReadLine());
            double profit = 0.0;
            double priceForKm = 0.0;
            //season=4 months
            if(km<=5000)
            {
                if(season=="Spring" || season=="Autumn")
                {
                    priceForKm = 0.75 * km; profit = priceForKm * 4; 
                }
                else if(season=="Summer")
                {
                    priceForKm = 0.9 * km; profit = priceForKm * 4;
                }
                else
                {
                    priceForKm = 1.05 * km; profit = priceForKm * 4;
                }
            }
            else if(km>5000 && km<=10000)
            {
                if(season== "Spring" || season == "Autumn")
                {
                    priceForKm = 0.95 * km; profit = priceForKm * 4;
                }
                else if(season=="Summer")
                {
                    priceForKm = 1.10 * km; profit = priceForKm * 4;

                }
                else
                {
                    priceForKm = 1.25 * km; profit = priceForKm * 4;
                }
            }
            else
            {
                priceForKm = 1.45 * km; profit = priceForKm * 4;
            }
            Console.WriteLine($"{(profit * 0.9):f2}");




        }
    }
}
