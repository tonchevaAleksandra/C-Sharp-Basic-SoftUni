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
            double cookies = 0;
            double foodPerDay = 0;
            double totalFood = 0;
            double totalCatsFood = 0;
            double totalDogsFood = 0;
            double totalCookies = 0;
            for (int i = 1; i <= days; i++)
            {
                int dogFood = int.Parse(Console.ReadLine());
                int catFood = int.Parse(Console.ReadLine());
                totalDogsFood += dogFood;
                totalCatsFood += catFood;
                foodPerDay = dogFood + catFood;
                
                if (i % 3 == 0)
                {
                    cookies = 0.1 * (foodPerDay);
                    totalCookies += cookies;
                    
                }
                totalFood += foodPerDay;
            }
            // "Total eaten biscuits: {количество изядени бисквитки}gr."
            // "{процент изядена храна}% of the food has been eaten."
            // "{процент изядена храна от кучето}% eaten from the dog."
            // "{процент изядена храна от котката}% eaten from the cat."
            //Количеството изядени бисквитки трябва да бъде закръглено до най – близкото цяло число, а процентът
            //храна трябва да бъде форматиран до втората цифра след десетичния знак.

            
            double persentCatFood = totalCatsFood / totalFood * 100;
            double persentDogFood = totalDogsFood / totalFood * 100;
            double persentEatenFood = totalFood / food * 100;
            Console.WriteLine($"Total eaten biscuits: {Math.Round(totalCookies)}gr.");
            Console.WriteLine($"{persentEatenFood:f2}% of the food has been eaten.");
            Console.WriteLine($"{persentDogFood:f2}% eaten from the dog.");
            Console.WriteLine($"{persentCatFood:f2}% eaten from the cat.");

        }
    }
}
