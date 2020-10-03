using System;

namespace MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Срок на договор – текст – "one", или "two"
            // 2.Тип на договор – текст – "Small", "Middle", "Large"или "ExtraLarge"
            //3.Добавен мобилен интернет – текст – "yes" или "no"
            //4.Брой месеци за плащане - цяло число в интервала[1 … 24]

            string term = Console.ReadLine();
            string type = Console.ReadLine();
            string net = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());
            double price = 0.0;

            if (term == "one")
            {
                if (type == "Small" && net == "no")
                {
                    price = 9.98 * months;
                }
                else if (type == "Small" && net == "yes")
                {
                    price = (9.98 + 5.50) * months;
                }
                else if (type == "Middle" && net == "no")
                {
                    price = 18.99 * months;
                }
                else if (type == "Middle" && net == "yes")
                {
                    price = (18.99 + 4.35) * months;
                }
                else if (type == "Large" && net == "no")
                {
                    price = 25.98 * months;
                }
                else if (type == "Large" && net == "yes")
                {
                    price = (25.98 + 4.35) * months;
                }
                else if (type == "ExtraLarge" && net == "no")
                {
                    price = 35.99 * months;
                }
                else if (type == "ExtraLarge" && net == "yes")
                {
                    price = (35.99 + 3.85) * months;
                }
            }
            else if (term == "two")
            {
                if (type == "Small" && net == "no")
                {
                    price = (8.58 * months) * 0.9625;
                }
                else if (type == "Small" && net == "yes")
                {
                    price = ((8.58 + 5.50) * months) * 0.9625;
                }
                else if (type == "Middle" && net == "no")
                {
                    price = (17.09 * months) * 0.9625;
                }
                else if (type == "Middle" && net == "yes")
                {
                    price = ((17.09 + 4.35) * months) * 0.9625;
                }
                else if (type == "Large" && net == "no")
                {
                    price = (23.59 * months) * 0.9625;
                }
                else if (type == "Large" && net == "yes")
                {
                    price = ((23.59 + 4.35) * months) * 0.9625;
                }
                else if (type == "ExtraLarge" && net == "no")
                {
                    price = (31.79 * months) * 0.9625;
                }
                else if (type == "ExtraLarge" && net == "yes")
                {
                    price = ((31.79 + 3.85) * months) * 0.9625;
                }
            }
            Console.WriteLine($"{price:f2} lv.");



        }
    }
}
