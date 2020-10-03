using System;

namespace TravelAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            //Име на града - текст с възможности ("Bansko", "Borovets", "Varna" или "Burgas")
            //Вид на пакета - текст с възможности ("noEquipment", "withEquipment", "noBreakfast" или "withBreakfast")
            //Притежание на VIP отстъпка - текст с възможности "yes" или "no"
            //Дни за престой - цяло число в интервала [1 … 10000]
            string town = Console.ReadLine();
            string type = Console.ReadLine();
            string vip = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double price = 0.0;

            if (town == "Bansko" || town == "Borovets")
            {
                if (type == "withEquipment" && days <= 7)
                {
                    price = 100 * days;
                }
                else if (type == "withEquipment" && days > 7)
                {
                    price = 100 * (days - 1);
                }
                else if (type == "noEquipment" && days <= 7)
                {
                    price = 80 * days;
                }
                else if (type == "noEquipment" && days > 7) { price = 80 * (days - 1); }
                if (vip == "yes" && type == "withEquipment") { price = price * 0.9; }
                else if (vip == "yes" && type == "noEquipment") { price = price * 0.95; }
            }
            else if (town == "Varna" || town == "Burgas")
            {
                if (type == "withBreakfast" && days <= 7)
                {
                    price = 130 * days;
                }
                else if (type == "withBreakfast" && days > 7)
                {
                    price = 130 * (days - 1);
                }
                else if (type == "noBreakfast" && days <= 7)
                {
                    price = 100 * days;
                }
                else if (type == "noBreakfast" && days > 7) { price = 100 * (days - 1); }
                if (vip == "yes" && type == "withBreakfast") { price = price * 0.88; }
                else if (vip == "yes" && type == "noBreakfast") { price = price * 0.93; }

            }
            //• Когато потребителят е въвел всички данни правилно, отпечатваме:
            // "The price is {цената, форматирана до втория знак}lv! Have a nice time!"
            //• Ако потребителят е въвел по - малко от 1 ден за престой, отпечатваме:
            // "Days must be positive number!"
            //• Когато при въвеждането на града или вида на пакета се въведат невалидни данни, отпечатваме:
            // "Invalid input!"
            if (days <= 1)
            {
                Console.WriteLine($"Days must be positive number!");
            }
            else if (((town != "Bansko") && (town != "Borovets") && (town != "Varna") &&
                (town != "Burgas")) || ((type != "withEquipment") && (type != "noEquipment") && (type != "withBreakfast") && (type != "noBreakfast")))
            {
                Console.WriteLine($"Invalid input!");
            }
            else
            {
                Console.WriteLine($"The price is {price:f2}lv! Have a nice time!");
            }


        }
    }
}
