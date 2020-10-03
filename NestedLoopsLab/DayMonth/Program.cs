using System;

namespace DayMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            //month -> 12 January  February March April May June July August September October November December
            //day => 31 max -> 31 28 31 30 31 30 31 31 30 31 30 31
            int year = 2020;
            string month = "";
            for (int m = 1; m <=12; m++)
            {
                for (int day = 1; day <31; day++)
                {
                    if (m == 1) { month = "January"; }
                    if (m == 2) { month = "February"; }
                    if (m == 3) { month = "March"; }
                    if (m == 4) { month = "April"; }
                    if (m == 5) { month = "May"; }
                    if (m == 6) { month = "June"; }
                    if (m == 7) { month = "Julyy"; }
                    if (m == 8) { month = "August"; }
                    if (m == 9) { month = "September"; }
                    if (m == 10) { month = "October"; }
                    if (m == 11) { month = "November"; }
                    if (m == 12) { month = "December"; }
                    if (m==4 || m==6 || m ==9 || m==11 && day==30)
                    {
                        Console.WriteLine($"The day is {day} {month} of {year} year.");
                        break;
                    }
                    if(m==2 && day==28)
                    {
                        Console.WriteLine($"The day is {day} {month} of {year} year.");
                        Console.Beep(277,1600);
                        break;
                    }

                    Console.WriteLine($"The day is {day} {month} of {year} year.");
                }
            }
        }
    }
}
