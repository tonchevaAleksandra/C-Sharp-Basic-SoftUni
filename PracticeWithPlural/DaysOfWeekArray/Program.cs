using System;

namespace DaysOfWeekArray
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wedsday",  //replace items in array
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            daysOfWeek[2] = "Wednesday";   //replace items in array
            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }

            //Console.WriteLine($"Which day do you want to display?");
            //Console.Write("(Monday=1, etc.) > ");
            //int iDay = int.Parse(Console.ReadLine());

            //string chosenDay = daysOfWeek[iDay-1];
            //Console.WriteLine($"That day is {chosenDay}");
        }
    }
}
