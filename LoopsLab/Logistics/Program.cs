using System;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	На първия ред – броя на товарите за превоз – цяло число в интервала [1...1000]
            //•	За всеки един товар на отделен ред – тонажа на товара – цяло число в интервала[1...1000]
            // •	До 3 тона – микробус(200 лева на тон)
            //•	От 4 до 11 тона – камион(175 лева на тон)
            //•	12 и повече тона – влак(120 лева на тон)

            int n = int.Parse(Console.ReadLine());
            double priceBus = 0;
            double priceCamion = 0;
            double priceTrain = 0;
            double totalVolume = 0;
            double totalPrice = 0;
            double volumeBus = 0;
            double volumeCamion = 0;
            double volumeTrain = 0;
            for (int i = 0; i < n; i++)
            {
                int volume = int.Parse(Console.ReadLine());
                if (volume <=3)
                {
                    priceBus += volume * 200;
                    
                    volumeBus += volume;
                }
                else if (volume >= 4 && volume <= 11)
                {
                    priceCamion += volume * 175;
                   
                    volumeCamion += volume;
                }
                else
                {
                    priceTrain += volume * 120;
                    
                    volumeTrain += volume;
                }
                totalVolume += volume;

            }
            totalPrice = priceBus + priceCamion + priceTrain;
            double averagePricePerTon = totalPrice / totalVolume;
            double percentBus = volumeBus / totalVolume * 100;
            double percentCamion = volumeCamion / totalVolume * 100;
            double percentTrain = volumeTrain / totalVolume * 100;
            Console.WriteLine($"{averagePricePerTon:f2}");
            Console.WriteLine($"{percentBus:f2}%");
            Console.WriteLine($"{percentCamion:f2}%");
            Console.WriteLine($"{percentTrain:f2}%");


        }
    }
}
