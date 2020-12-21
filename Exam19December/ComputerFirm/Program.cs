using System;

namespace ComputerFirm
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double totalRate = 0;
            double totalSales = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                int rate = number % 10;
                int sales = number / 10;
                totalRate += rate;

                if (rate == 2)
                {
                    totalSales = totalSales + (sales * 0);
                }
                else if (rate == 3)
                {
                    totalSales = totalSales + (sales * 0.5);
                }
                else if (rate == 4)
                {
                    totalSales = totalSales + (sales * 0.7);
                }
                else if (rate == 5)
                {
                    totalSales = totalSales + (sales * 0.85);
                }
                else if (rate == 6)
                {
                    totalSales = totalSales + sales;
                }
            }


            Console.WriteLine($"{totalSales:F2}");
            double averageRate = totalRate / n;
            Console.WriteLine($"{averageRate:F2}");
        }
    }
}
