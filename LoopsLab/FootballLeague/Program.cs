using System;

namespace FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            //            1.Капацитетът на стадиона – цяло число в интервала[1 … 10000];
            //            2.Броят на всички фенове – цяло число в интервала[1 … 10000].
            //За всеки един фен, на отделен ред се прочита:
            //1.Секторът, на който се намира – текст – "A", "B", "V" и "G".
            int capacity = int.Parse(Console.ReadLine());
            int quantityFens = int.Parse(Console.ReadLine());
            double countA = 0;
            double countB = 0;
            double countV = 0;
            double countG = 0;
            for (int i = 0; i < quantityFens; i++)
            {
                string sector = Console.ReadLine();
                if (sector == "A")
                {
                    countA++;
                }
                else if (sector == "B")
                {
                    countB++;
                }
                else if (sector == "V")
                {
                    countV++;
                }
                else if (sector == "G")
                {
                    countG++;
                }
            }
            //            1.Процентът на феновете в сектор А
            //2.Процентът на феновете в сектор Б
            //3.Процентът на феновете в сектор В
            //4.Процентът на феновете в сектор Г
            //5.Процентът на всички фенове, спрямо капацитета на стадиона.
            double persentA = countA / quantityFens * 100;
            double persentB = countB / quantityFens * 100;
            double persentV = countV / quantityFens * 100;
            double persentG = countG / quantityFens * 100;
            double quantity = Convert.ToDouble(quantityFens);
            double capacity1 = Convert.ToDouble(capacity);
            double persentFens = quantity / capacity1 * 100;
            Console.WriteLine($"{persentA:f2}%");
            Console.WriteLine($"{persentB:f2}%");
            Console.WriteLine($"{persentV:f2}%");
            Console.WriteLine($"{persentG:f2}%");
            Console.WriteLine($"{persentFens:f2}%");

        }
    }
}
