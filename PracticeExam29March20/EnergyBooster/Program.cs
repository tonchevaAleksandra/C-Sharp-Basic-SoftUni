using System;

namespace EnergyBooster
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Плод - текст с възможности: "Watermelon", "Mango", "Pineapple" или "Raspberry"
            //2.Размерът на сета -текст с възможности: "small" или "big"
            //3.Брой на поръчаните сетове - цяло число в интервала[1 … 10000]

            string fruit = Console.ReadLine();
            string set = Console.ReadLine();
            int sets = int.Parse(Console.ReadLine());
            double price = 0.0;

           if(set=="small")
            {
                switch (fruit)
                {
                    case "Watermelon": price = 2.00 * 56.00 *sets;
                        break;
                    case "Mango":
                        price = 2.00 * 36.66 * sets;
                        break;
                    case "Pineapple":
                        price = 2.00 * 42.10 * sets;
                        break;
                    case "Raspberry":
                        price = 2.00 * 20.00 * sets;
                        break;
                }
            }
            else if (set == "big")
            {
                switch (fruit)
                {
                    case "Watermelon": price = 5.0 * 28.70 * sets;
                        break;
                    case "Mango":
                        price = 5.0 * 19.60 * sets;
                        break;
                    case "Pineapple":
                        price = 5.0 * 24.80 * sets;
                        break;
                    case "Raspberry":
                        price = 5.0 * 15.20 * sets;
                        break;
                }

            }

           if(price>=400.00 && price<=1000.00)
            {
                price *=0.85;
            }
           else if(price>1000.00)
            {
                price *= 0.5;
            }

            Console.WriteLine($"{price:f2} lv.");
        }
    }
}
