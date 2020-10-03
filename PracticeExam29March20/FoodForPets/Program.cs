using System;

namespace FoodForPets
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Брой дни – цяло число в диапазона[1…30]
            // Общо количество храна – реално число в диапазона[0.00…10000.00]
            //След това за всеки ден се чете:
            //            o Количество изядена храна от кучето – цяло число в диапазона[10…500]
            //o Количество изядена храна от котката – цяло число в диапазона[10…500]

            int days = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double totalCat = 0.0;
            double totalDog = 0.0;
            double totalEatan = 0.0;
            double cookies = 0.0;

            for (int i = 1; i <= days; i++)
            {
                int foodDogPerDay = int.Parse(Console.ReadLine());
                totalDog += foodDogPerDay;
                int foodCatPerDay = int.Parse(Console.ReadLine());
                totalCat += foodCatPerDay;
                double sumEatenPerDay = foodCatPerDay + foodDogPerDay;
                totalEatan += sumEatenPerDay;
                if (i % 3 == 0)
                {
                    cookies += 0.1 * sumEatenPerDay;
                }
            }
            Console.WriteLine($"Total eaten biscuits: {Math.Round(cookies)}gr.");
            double persentEatan = totalEatan / food * 100;
            Console.WriteLine($"{persentEatan:f2}% of the food has been eaten.");
            double persentEatenByDog = totalDog / totalEatan * 100;
            Console.WriteLine($"{persentEatenByDog:f2}% eaten from the dog.");
            double persentEatenByCat = totalCat / totalEatan * 100;
            Console.WriteLine($"{persentEatenByCat:f2}% eaten from the cat.");

            

        }
    }
}
