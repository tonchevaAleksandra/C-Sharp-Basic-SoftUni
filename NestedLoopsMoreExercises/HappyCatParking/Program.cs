using System;

namespace HappyCatParking
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	Брой дни – цяло число в интервала[1 … 5]
            //•	Брой часове за всеки един от дните - цяло число в интервала[1 … 24]

            int cntDays = int.Parse(Console.ReadLine());
            int cntHours = int.Parse(Console.ReadLine());
            double taxe = 0;
            double totalTaxes = 0;
            double taxePerDay = 0;

            for (int day = 1; day <= cntDays; day++)
            {
                taxePerDay = 0;
                if (day % 2 != 0)
                {
                    for (int hour = 1; hour <= cntHours; hour++)
                    {
                        if (hour % 2 != 0)
                        {
                            taxe = 1.00;
                            taxePerDay += taxe;
                        }
                        else if (hour % 2 == 0)
                        {
                            taxe = 1.25;
                            taxePerDay += taxe;
                        }

                    }

                }
                else if (day % 2 == 0)
                {
                    for (int hour = 1; hour <= cntHours; hour++)
                    {
                        if (hour % 2 != 0)
                        {
                            taxe = 2.50;
                            taxePerDay += taxe;
                        }
                        else if (hour % 2 == 0)
                        {
                            taxe = 1.00;
                            taxePerDay += taxe;
                        }

                    }

                }

                totalTaxes += taxePerDay;
                Console.WriteLine($"Day: {day} - {taxePerDay:f2} leva");
            }

            Console.WriteLine($"Total: {totalTaxes:f2} leva");

        }
    }
}
