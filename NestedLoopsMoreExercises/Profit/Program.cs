using System;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Брой монети по 1лв. - цяло положително число;
            //2.Брой монети по 2лв. - цяло положително число;
            //3.Брой банкноти по 5лв. - цяло положително число;
            //4.Сума - цяло положително число в интервала[1…1000];

            int count1lv = int.Parse(Console.ReadLine());
            int count2lv = int.Parse(Console.ReadLine());
            int count5lv = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());
            int sum1lv = 0;
            int sum2lv = 0;
            int sum5lv = 0;

            for (int i = 0; i <=count1lv; i++)
            {
                for (int j = 0; j <=count2lv; j++)
                {
                    for (int k = 0; k <= count5lv; k++)
                    {
                        sum1lv = i * 1;
                        sum2lv = j * 2;
                        sum5lv = k * 5;
                        if(sum1lv+sum2lv+sum5lv==sum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {sum} lv.");
                        }

                    }
                }
            }

        }
    }
}
