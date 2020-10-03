using System;

namespace Club
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Вход
            // От конзолата се четат:
            //• На първия ред – желаната печалба на клуба -реално число в интервала[1.00... 15000.00]
            //Поредица от два реда до получаване на командата "Party!" или до достигане на желаната печалба:
            //o Име на коктейла – текст
            //o Брой на коктейлите за поръчката – цяло число в интервала[1… 50]
            double profit = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double price = 0;
            double total = 0;
            while (command != "Party!")
            {
                string coctail = command;
                int count = int.Parse(Console.ReadLine());
                double a = coctail.Length;
                price = a * count;
                if (price % 2 != 0)
                {
                    price *= 0.75;
                }
                total += price;
                if (profit <= total)
                {
                    break;
                }
                command = Console.ReadLine();
            }
            if ( profit <= total)
            {
                Console.WriteLine($"Target acquired.");
            }
            else if (profit > total)
            {
                Console.WriteLine($"We need {profit - total:f2} leva more.");
            }
            Console.WriteLine($"Club income - {total:f2} leva.");

        }




    }
}
