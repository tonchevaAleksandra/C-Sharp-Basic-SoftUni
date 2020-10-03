using System;

namespace EasterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Първи ред -дестинация - текст с възможности"France", "Italy" или "Germany"
            //• Втори ред -дати, през които си е резервирала екскурзията -текст с възможности "21-23",
            //"24-27" или "28-31"
            //• Трети ред -брой нощувки - цяло число в интервала[1… 100]
            string destination = Console.ReadLine();
            string dates = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            
            double price = 0;
            if(dates=="21-23")
            {
                switch (destination)
                {
                    case "France": price = 30.00 * nights;
                        break;
                    case "Italy":
                        price = 28.00 * nights;
                        break;
                    case "Germany":
                        price = 32.00 * nights;
                        break;

                }
            }
            else if(dates == "24-27")
            {
                switch (destination)
                {
                    case "France":
                        price = 35.00 * nights;
                        break;
                    case "Italy":
                        price = 32.00 * nights;
                        break;
                    case "Germany":
                        price = 37.00 * nights;
                        break;

                }
            }
            else if (dates == "28-31")
            {
                switch (destination)
                {
                    case "France":
                        price = 40.00 * nights;
                        break;
                    case "Italy":
                        price = 39.00 * nights;
                        break;
                    case "Germany":
                        price = 43.00 * nights;
                        break;

                }
            }
            Console.WriteLine($"Easter trip to {destination} : {price:f2} leva.");
        }
    }
}
