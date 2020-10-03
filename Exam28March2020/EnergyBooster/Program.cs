using System;

namespace EnergyBooster
{
    class Program
    {
        static void Main(string[] args)
        {
            // Плод - текст с възможности: "Watermelon", "Mango", "Pineapple" или "Raspberry"
            //2.Размерът на сета -текст с възможности: "small" или "big"
            //3.Брой на поръчаните сетове - цяло число в интервала[1 … 10000]
            string fruit = Console.ReadLine();
            string set = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double price = 0;
            if(fruit=="Watermelon")
            {
                if(set=="small")
                {
                    price = 56.00 * count *2;
                }
                else
                {
                    price = 28.70 * count *5;
                }
            }
            else if(fruit=="Mango")
            {
                if(set=="small")
                {
                    price = 36.66 * count*2;
                }
                else
                {
                    price = count * 5 * 19.60;
                }
            }
            else if(fruit== "Pineapple")
            {
                if(set=="small")
                {
                    price = count * 2 * 42.10;
                }
                else
                {
                    price = count * 5 * 24.80;
                }
            }
            else
            {
                if(set=="small")
                {
                    price = count * 2 * 20.00;
                }
                else
                {
                    price = count * 5 * 15.20;
                }
            }
            if(price>=400 && price<=1000)
            {
                price *= 0.85;
            }
            else if(price>1000)
            {
                price *= 0.5;
            }

            Console.WriteLine($"{price:f2} lv.");
        }
    }
}
