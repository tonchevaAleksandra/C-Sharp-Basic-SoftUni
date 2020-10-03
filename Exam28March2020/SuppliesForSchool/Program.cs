using System;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Първи ред -брой пакети химикали. Цяло число в интервала[0...100]
            // Втори ред -брой пакети маркери. Цяло число в интервала[0...100]
            // Трети ред -литър препарат за почистване на дъска.Реално число в интервала[0.00…50.00]
            // Четвърти ред -процентът намаление.Цяло число в интервала[0...100]
            int packPensils = int.Parse(Console.ReadLine());
            int packMarkers = int.Parse(Console.ReadLine());
            double preparat1L = double.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());
            
            //            Пакет химикали -5.80 лв
            //• Пакет маркери -7.20 лв
            //• Препарат - 1.20 лв(за литър)

            double pricePensils = packPensils * 5.80;
            double priceMarkers = packMarkers * 7.20;
            double pricePreparat = preparat1L * 1.20;
            double totalPrice = (pricePensils + priceMarkers + pricePreparat);
            double priceAftDis = totalPrice - (percent * totalPrice/100);
            Console.WriteLine($"{priceAftDis:f3}");

        }
    }
}
