using System;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            //           •	Първи ред – месеците за които се търси средният разход – цяло число в интервала[1...100]
            //•	За всеки месец – сметката за ток – реално число в интервала[1.00...1000.00]

            int months = int.Parse(Console.ReadLine());
            double priceElect = 0;
            double priceWater = 0;
            double priceNet = 0;
            double priceOther = 0;
            double totalElec = 0;
            double totalWater = 0;
            double totalNet = 0;
            double totalOther = 0;
            for (int i = 0; i < months; i++)
            {
                double number = double.Parse(Console.ReadLine());
                priceElect = number;
                priceWater = 20;
                priceNet = 15;
                priceOther = ((priceElect + priceWater + priceNet) * 1.2);
                totalElec += priceElect;
                totalWater += priceWater;
                totalNet += priceNet;
                totalOther += priceOther;
            }
            double costs = totalElec + totalWater + totalNet + totalOther;
            double averageCosts = costs / months;
            Console.WriteLine($"Electricity: {totalElec:f2} lv");
            Console.WriteLine($"Water: {totalWater:f2} lv");
            Console.WriteLine($"Internet: {totalNet:f2} lv");
            Console.WriteLine($"Other: {totalOther:f2} lv");
            Console.WriteLine($"Average: {averageCosts:f2} lv");
        }
    }
}
