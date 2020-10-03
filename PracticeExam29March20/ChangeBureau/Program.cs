using System;

namespace ChangeBureau
{
    class Program
    {
        static void Main(string[] args)
        {
            //            1 биткойн = 1168 лева.
            // 1 китайски юан = 0.15 долара.
            // 1 долар = 1.76 лева.
            // 1 евро = 1.95 лева.
            //Обменното бюро има комисионна от 0 до 5 процента от крайната сума в евро.
            //На първия ред – броят биткойни. Цяло число в интервала [0…20]
            // На втория ред – броят китайски юана.Реално число в интервала[0.00… 50 000.00]
            // На третия ред – комисионната.Реално число в интервала[0.00... 5.00]

            int bitCoins = int.Parse(Console.ReadLine());
            double chinaMoney = double.Parse(Console.ReadLine());
            double commmission = double.Parse(Console.ReadLine());

            double leva = bitCoins * 1168.00+(chinaMoney*0.15*1.76);
            double euros = leva / 1.95;
            euros = euros - (commmission / 100 * euros);

            Console.WriteLine($"{euros:f2}");
        }
    }
}
