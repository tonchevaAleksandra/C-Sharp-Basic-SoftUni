using System;

namespace TravelAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Име на града - текст с възможности("Bansko", "Borovets", "Varna" или "Burgas")
            //2.Вид на пакета -текст с възможности("noEquipment", "withEquipment", "noBreakfast" или
            //"withBreakfast")
            //3.Притежание на VIP отстъпка - текст с възможности "yes" или "no"
            //4.Дни за престой -цяло число в интервала[1 … 10000]

            string city = Console.ReadLine();
            string type = Console.ReadLine();
            string vip = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double price = 0;
            if (days > 7)
            {
                days = days - 1;
            }
            if (days<=1)
            {
                Console.WriteLine($"Days must be positive number!");
                return;
            }
            if (city == "Bansko" || city == "Borovets" )
            {
               
                switch (type)
                {
                    case "noEquipment":
                        price = 80.00 * days;
                        if (vip == "yes")
                        {
                            price *= 0.95;
                        }
                        
                        break;
                    case "withEquipment":
                        price = 100.00 * days;
                        if (vip == "yes")
                        {
                            price *= 0.9;
                        }
                       
                        break;
                    default:
                        Console.WriteLine($"Invalid input!");
                        return;
                }

            }

            else if (city == "Varna" || city == "Burgas" )
            {
               
                switch (type)
                {
                    case "noBreakfast":
                        price = 100.00 * days;
                        if (vip == "yes")
                        {
                            price *= 0.93;
                        }
                        
                        break;
                    case "withBreakfast":
                        price = 130.00 * days;
                        if (vip == "yes")
                        {
                            price *= 0.88;
                        }
                        
                        break;
                    default: Console.WriteLine($"Invalid input!");
                        return;
                }
            }
            else
            {
                Console.WriteLine($"Invalid input!");
                return;
            }

            Console.WriteLine($"The price is {price:f2}lv! Have a nice time!");

        }
    }
}
