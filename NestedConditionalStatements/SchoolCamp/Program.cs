using System;

namespace SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string group = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double price = 0.0;
            string sport = "";
            double totalPrice = 0.0;
            if (season == "Winter")
            {
                if (group == "boys")
                {
                    sport = "Judo";
                    price = 9.60 * students*nights;
                }
                else if (group == "girls")
                {
                    sport = "Gymnastics";
                    price = 9.60 * students * nights;
                }
                else if(group=="mixed")
                {
                    sport = "Ski"; price = 10 * students * nights;
                }
            }
            else if (season == "Spring")
            {
                if (group == "boys")
                {
                    sport = "Tennis";
                    price = 7.20 * students * nights;
                }
                else if (group == "girls")
                {
                    sport = "Athletics";
                    price = 7.20 * students * nights;
                }
                else if (group == "mixed")
                {
                    sport = "Cycling"; price = 9.5 * students * nights;
                }
            }
            else if(season=="Summer")
            {
                if (group == "boys")
                {
                    sport = "Football";
                    price = 15.0 * students * nights;
                }
                else if (group == "girls")
                {
                    sport = "Volleyball";
                    price = 15.0 * students * nights;
                }
                else if(group=="mixed")
                {
                    sport = "Swimming"; price = 20.0 * students * nights;
                }
            }
            if (students >= 50)
            {
                totalPrice = price * 0.5;
            }
            else if (students >= 20 && students < 50)
            {
                totalPrice = price * 0.85;
            }
            else if (students < 20 && students >= 10)
            {
                totalPrice = price * 0.95;
            }
            else
                totalPrice = price * 1.0;
            Console.WriteLine($"{sport} {totalPrice:f2} lv.");
        }
    }
}
