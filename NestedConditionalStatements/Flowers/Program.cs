using System;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityChris = int.Parse(Console.ReadLine());
            int quantityRoses = int.Parse(Console.ReadLine());
            int quantityTulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string hollyday = Console.ReadLine();
            double price = 0.0;
            double totalPrice = 0.0;
            double totalQuantity = quantityChris + quantityRoses + quantityTulips;
            if ((season == "Spring" || season == "Summer") && hollyday == "N")
            {
                if (totalQuantity >= 20)
                {
                    if (quantityTulips > 7)
                    {
                        price = ((quantityTulips * 2.50 + quantityRoses * 4.10 + quantityChris * 2.0) * 0.95) * 0.8;
                    }
                    else
                    {
                        price = (quantityTulips * 2.50 + quantityRoses * 4.10 + quantityChris * 2.0) * 0.8;
                    }
                }
                else
                {
                    if (quantityTulips > 7)
                    {
                        price = (quantityTulips * 2.50 + quantityRoses * 4.10 + quantityChris * 2.0) * 0.95;
                    }
                    else
                    {
                        price = (quantityTulips * 2.50 + quantityRoses * 4.10 + quantityChris * 2.0);
                    }
                }
            }
            else if ((season == "Spring" || season == "Summer") && hollyday == "Y")
            {
                if (totalQuantity >= 20)
                {
                    if (quantityTulips > 7)
                    {
                        price = (((quantityTulips * 2.50 + quantityRoses * 4.10 + quantityChris * 2.0) * 1.15) * 0.95) * 0.8;
                    }
                    else
                    {
                        price = ((quantityTulips * 2.50 + quantityRoses * 4.10 + quantityChris * 2.0) * 1.15) * 0.8;
                    }
                }
                else
                {
                    if (quantityTulips > 7)
                    {
                        price = ((quantityTulips * 2.50 + quantityRoses * 4.10 + quantityChris * 2.0) * 1.15) * 0.95;
                    }
                    else
                    {
                        price = (quantityTulips * 2.50 + quantityRoses * 4.10 + quantityChris * 2.0) * 1.15;
                    }
                }
            }
            else if ((season == "Autumn" || season == "Winter") && hollyday == "N")
            {
                if (totalQuantity >=20)
                {
                    if (quantityRoses >=10 && season=="Winter")
                    {
                        price = (((quantityTulips * 4.15) +(quantityRoses * 4.50) + (quantityChris * 3.75)) * 0.90) * 0.8;
                    }
                    else 
                    {
                        price = ((quantityTulips * 4.15) + (quantityRoses * 4.50) + (quantityChris * 3.75)) * 0.8;
                    }
                }
                else
                {
                    if (quantityRoses >= 10 && season == "Winter")
                    {
                        price = ((quantityTulips * 4.15 + quantityRoses * 4.50 + quantityChris * 3.75) * 0.90);
                    }
                    else
                    {
                        price = (quantityTulips * 4.15 + quantityRoses * 4.50 + quantityChris * 3.75);
                    }
                }

            }
            else if ((season == "Autumn" || season == "Winter") && hollyday == "Y")
            {
                if (totalQuantity > 20)
                {
                    if (quantityRoses >= 10 && season == "Winter")
                    {
                        price = (((quantityTulips * 4.15 + quantityRoses * 4.50 + quantityChris * 3.75)*1.15 ) * 0.90) * 0.8;
                    }
                    else
                    {
                        price = ((quantityTulips * 4.15 + quantityRoses * 4.50 + quantityChris * 3.75) * 1.15) *0.8;
                    }
                }
                else
                {
                    if (quantityRoses >=10 && season=="Winter")
                    {
                        price = ((quantityTulips * 4.15 + quantityRoses * 4.50 + quantityChris * 3.75) * 1.15) * 0.90;
                    }
                    else
                    {
                        price = (quantityTulips * 4.15 + quantityRoses * 4.50 + quantityChris * 3.75)* 1.15;
                    }
                }

            }
            totalPrice = price + 2.0;
            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
