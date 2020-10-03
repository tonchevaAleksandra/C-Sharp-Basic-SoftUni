using System;

namespace FitnessCard
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Сумата, с която разполагаме - реално число в интервала[10.00…1000.00]
            // Пол - символ('m' за мъж и 'f' за жена)
            // Възраст - цяло число в интервала[5…105]
            // Спорт - текст(една от възможностите в таблицата)
            double budget = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();
            double price = 0;
            //Gym Boxing Yoga Zumba Dances Pilates
            if (sport=="Gym")
            {
                if(gender=='m')
                {
                    price = 42;
                }
                else
                {
                    price = 35;
                }
            }
            else if(sport== "Boxing")
            {
                if(gender == 'm')
                {
                    price = 41;
                }
                else
                {
                    price = 37;
                }
            }
            else if (sport == "Yoga")
            {
                if (gender == 'm')
                {
                    price = 45;
                }
                else
                {
                    price = 42;
                }
            }
            else if (sport == "Zumba")
            {
                if (gender == 'm')
                {
                    price = 34;
                }
                else
                {
                    price = 31;
                }
            }
            else if (sport == "Dances")
            {
                if (gender == 'm')
                {
                    price = 51;
                }
                else
                {
                    price = 53;
                }
            }
            else 
            {
                if (gender == 'm')
                {
                    price = 39;
                }
                else
                {
                    price = 37;
                }
            }
            if(age<=19)
            {
                price *= 0.8;
            }
            if(budget>=price)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${price - budget:f2} more.");
            }
        }
    }
}
