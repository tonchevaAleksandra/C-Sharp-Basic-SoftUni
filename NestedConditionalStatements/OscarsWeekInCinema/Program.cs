using System;

namespace OscarsWeekInCinema
{
    class Program
    {
        static void Main(string[] args)
        {
            //Първи ред – име на филм – текст ("A Star Is Born", "Bohemian Rhapsody","Green Book" или "The Favourite")
            //Втори ред– вид на залата – текст ("normal", "luxury" или "ultra luxury")
            //Трети ред – брой на закупените билети – цяло число в интервала [1…100]

            string movie = Console.ReadLine();
            string typeHall = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0.0;
            if(movie== "A Star Is Born")
            {
                if(typeHall== "normal") { price = 7.50 * quantity; }
                else if (typeHall == "luxury") { price = 10.50 * quantity; }
                else { price = 13.50 * quantity; }
            }
            else if (movie == "Bohemian Rhapsody")
            {
                if (typeHall == "normal") { price = 7.35 * quantity; }
                else if (typeHall == "luxury") { price = 9.45 * quantity; }
                else { price = 12.75 * quantity; }
            }
            else if (movie == "Green Book")
            {
                if (typeHall == "normal") { price = 8.15 * quantity; }
                else if (typeHall == "luxury") { price = 10.25 * quantity; }
                else { price = 13.25 * quantity; }
            }
            else 
            {
                if (typeHall == "normal") { price = 8.75 * quantity; }
                else if (typeHall == "luxury") { price = 11.55 * quantity; }
                else { price = 13.95 * quantity; }
            }
            Console.WriteLine($"{movie} -> {price:f2} lv.");
        }
    }
}
