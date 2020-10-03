using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hourArrival = int.Parse(Console.ReadLine());
            int minutesArrival = int.Parse(Console.ReadLine());
            int hourToMinutesExam = hourExam * 60;
            int hourToMinutesArrival = hourArrival * 60;
            int hour = 0;
            int minutes = 0;
            if ((hourArrival > hourExam) || ((hourArrival == hourExam) && (minutesArrival > minutesExam)))
            {
                Console.WriteLine("Late");
                if ((hourToMinutesArrival + minutesArrival) - (hourToMinutesExam + minutesExam) < 60)
                {
                    Console.WriteLine($"{(hourToMinutesArrival + minutesArrival) - (hourToMinutesExam + minutesExam)} minutes after the start");
                }
                else
                {
                    hour = (((hourToMinutesArrival + minutesArrival) -
                        (hourToMinutesExam + minutesExam)) / 60);
                    minutes = (((hourToMinutesArrival + minutesArrival) - (hourToMinutesExam + minutesExam)) % 60);
                    Console.WriteLine($"{hour}:{minutes:d2} hours after the start");
                }

            }
            else if (((hourArrival == hourExam) && (minutesArrival == minutesExam)) ||
                (((hourToMinutesExam + minutesExam) - (hourToMinutesArrival + minutesArrival)) <= 30))
            {

                Console.WriteLine("On time");
                if ((((hourToMinutesExam + minutesExam) - (hourToMinutesArrival + minutesArrival)) <= 30) && (((hourToMinutesExam + minutesExam) - (hourToMinutesArrival + minutesArrival)) != 0))
                    Console.WriteLine($"{(hourToMinutesExam + minutesExam) - (hourToMinutesArrival + minutesArrival)} minutes before the start");
            }
            else
            {
                Console.WriteLine("Early");
                hour = (((hourToMinutesExam + minutesExam) -
                       (hourToMinutesArrival + minutesArrival)) / 60);
                minutes = (((hourToMinutesExam + minutesExam) -
                       (hourToMinutesArrival + minutesArrival)) % 60);
                if ((((hourToMinutesExam + minutesExam) - (hourToMinutesArrival + minutesArrival)) < 60) && (((hourToMinutesExam + minutesExam) - (hourToMinutesArrival + minutesArrival)) != 0))
                {
                    Console.WriteLine($"{(hourToMinutesExam + minutesExam) - (hourToMinutesArrival + minutesArrival)} minutes before the start");
                }
                else
                {
                    Console.WriteLine($"{hour}:{minutes:d2} hours before the start");
                }
            }

        }
    }
}
