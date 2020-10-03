using System;

namespace CruiseShip
{
    class Program
    {
        static void Main(string[] args)
        {
            //Първият ред – вид круиз – текст с възможности: "Mediterranean", "Adriatic", "Aegean"
            //Вторият ред – вид каюта – текст с възможности : "standard cabin", "cabin with balcony","apartment"
            //Третият ред – брой нощувки – цяло число в интервала [1… 50]

            string cruise = Console.ReadLine();
            string cabin = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double price = 0.0;

            if(cruise== "Mediterranean")
            {
                if(cabin=="standard cabin")
                {
                    price = 27.50 * 4 * nights;
                }
                else if(cabin=="cabin with balcony")
                {
                    price = 30.20 * 4 * nights;
                }
                else if (cabin == "apartment")
                {
                    price = 40.50 * 4 * nights;
                }
            }
            else if (cruise == "Adriatic")
            {
                if (cabin == "standard cabin")
                {
                    price = 22.99 * 4 * nights;
                }
                else if (cabin == "cabin with balcony")
                {
                    price = 25.00 * 4 * nights;
                }
                else if(cabin=="apartment")
                {
                    price = 34.99 * 4 * nights;
                }
            }
            else if(cruise=="Aegean")
            {
                if (cabin == "standard cabin")
                {
                    price = 23.00 * 4 * nights;
                }
                else if (cabin == "cabin with balcony")
                {
                    price = 26.60 * 4 * nights;
                }
                else if (cabin == "apartment")
                {
                    price = 39.80 * 4 * nights;
                }
            }
            if(nights>7)
            {
                price = price * 0.75;
            }
            Console.WriteLine($"Annie's holiday in the {cruise} sea costs {price:f2} lv.");
        }
    }
}
