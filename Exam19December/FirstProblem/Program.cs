using System;

namespace FirstProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int percentFat = int.Parse(Console.ReadLine());
            int percentProtein = int.Parse(Console.ReadLine());
            int percentCarbohydrates = int.Parse(Console.ReadLine());
            int totalCalories = int.Parse(Console.ReadLine());
            int percentWater = int.Parse(Console.ReadLine());

            int caloriesInFat = 9;
            int caloriesInProtein = 4;
            int caloriesInCarboHydrates = 4;


            //            (60 % от  2500) / 9 = 166.6 - общите грамове от мазнини
            //(25 % от  2500) / 4 = 156.25 - общите грамове от протеини
            //(15 % от 2500) / 4 = 93.75 - общите грамове от въглехидрати

            double totalGramsOfFat = ((percentFat * 1.00 / 100) * totalCalories) / caloriesInFat;
            double totalGramsOfProtein = ((percentProtein * 1.00 / 100) * totalCalories) / caloriesInProtein;
            double totalGramsOfCarboHydrates= ((percentCarbohydrates * 1.00 / 100) * totalCalories) / caloriesInCarboHydrates;

            double totalGrams = totalGramsOfFat + totalGramsOfProtein + totalGramsOfCarboHydrates;

            double caloriesPerGramFood = totalCalories * 1.00 / totalGrams;

            caloriesPerGramFood = (((100-percentWater) * 1.00 / 100) * caloriesPerGramFood);

            Console.WriteLine($"{caloriesPerGramFood:F4}");

        }
    }
}
