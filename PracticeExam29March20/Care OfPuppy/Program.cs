using System;

namespace CareOfPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Закупеното количество храна за кученцето в килограми – цяло число в интервала[1 …100]
            //• На всеки следващ ред до получаване на команда Adopted ще получавате колко грама изяжда
            //кученцето на всяко хранене -цяло число в интервала[10 …1000]

            int kgFood = int.Parse(Console.ReadLine());
            int gramFood = kgFood * 1000;
            string command = Console.ReadLine();
            int totalEatenFood = 0;

            while (command!="Adopted")
            {
                int foodPerEat = int.Parse(command);
                totalEatenFood += foodPerEat;
                command = Console.ReadLine();

            }

            if(gramFood>=totalEatenFood)
            {
                Console.WriteLine($"Food is enough! Leftovers: {gramFood - totalEatenFood} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {totalEatenFood - gramFood} grams more.");
            }
        }
    }
}
