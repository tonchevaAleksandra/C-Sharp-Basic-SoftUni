using System;

namespace ChangeTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Събраните пари.
            //Широчината на пода.
            //Дължината на пода.
            //Страната на триъгълника.
            //Височината на триъгълника.
            //Цената на една плочка.
            //Сумата за майстора.

            double budget = double.Parse(Console.ReadLine());
            double widthFloor = double.Parse(Console.ReadLine());
            double lenghtFloor = double.Parse(Console.ReadLine());
            double sideTriangle = double.Parse(Console.ReadLine());
            double heightTriangle = double.Parse(Console.ReadLine());
            double pricePerTile = double.Parse(Console.ReadLine());
            double priceForWork = double.Parse(Console.ReadLine());

            double areaFloor = widthFloor * lenghtFloor;
            double areaTile = sideTriangle * heightTriangle / 2;
            double neededTiles = Math.Ceiling(areaFloor / areaTile)+5;
            double neededMoney = neededTiles * pricePerTile + priceForWork;
            if(neededMoney<=budget)
            {
                Console.WriteLine($"{(budget - neededMoney):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"You'll need {(neededMoney - budget):f2} lv more.");
            }
            
        }
    }
}
