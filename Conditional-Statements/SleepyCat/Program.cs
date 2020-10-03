using System;

namespace SleepyCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int hollydays = int.Parse(Console.ReadLine());
            int minutesNorme = 30000;
            int year = 365;
            int workDays = year - hollydays;
            int minutesPlayWD = workDays * 63;
            int minutesPlayHD = hollydays * 127;
            int totalMinutes = minutesPlayWD + minutesPlayHD;
            if(totalMinutes>minutesNorme)
            {
                Console.WriteLine($"Tom will run away");
                double result = totalMinutes - minutesNorme;
                double minutes = result % 60;
                double hour = Math.Floor(result / 60);
                Console.WriteLine($"{hour} hours and {minutes} minutes more for play");
            }
            else
            {
                Console.WriteLine($"Tom sleeps well");
                double result = minutesNorme - totalMinutes;
                double minutes = result % 60;
                double hours = Math.Floor(result / 60);
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }

            

        }
    }
}
