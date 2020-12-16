using System;

namespace FootballSouvenirs
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            string souvenirType = Console.ReadLine();
            int countSouvenirs = int.Parse(Console.ReadLine());

            double price = 0.0;

            if (team == "Argentina")
            {
                if (souvenirType == "flags")
                    price = 3.25;
                else if (souvenirType == "caps")
                    price = 7.20;
                else if (souvenirType == "posters")
                    price = 5.10;
                else if (souvenirType == "stickers")
                    price = 1.25;
                else
                    Console.WriteLine("Invalid stock!");

            }

            else if (team == "Brazil")
            {
                if (souvenirType == "flags")
                    price = 4.20;
                else if (souvenirType == "caps")
                    price = 8.50;
                else if (souvenirType == "posters")
                    price = 5.35;
                else if (souvenirType == "stickers")
                    price = 1.20;
                else
                    Console.WriteLine("Invalid stock!");
            }
            else if (team == "Croatia")
            {
                if (souvenirType == "flags")
                    price = 2.75;
                else if (souvenirType == "caps")
                    price = 6.90;
                else if (souvenirType == "posters")
                    price = 4.95;
                else if (souvenirType == "stickers")
                    price = 1.10;
                else
                    Console.WriteLine("Invalid stock!");
            }
            else if (team == "Denmark")
            {
                if (souvenirType == "flags")
                    price = 3.10;
                else if (souvenirType == "caps")
                    price = 6.50;
                else if (souvenirType == "posters")
                    price = 4.80;
                else if (souvenirType == "stickers")
                    price = 0.90;
                else
                    Console.WriteLine("Invalid stock!");
            }
            else
            {
                Console.WriteLine("Invalid country!");
            }

            if (price != 0)
            {
                double totalPrice = price * countSouvenirs;

                Console.WriteLine($"Pepi bought {countSouvenirs} {souvenirType} of {team} for {totalPrice:F2} lv.");
            }
        }
    }
}
