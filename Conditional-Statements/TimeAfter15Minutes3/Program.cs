using System;

namespace TimeAfter15Minutes3
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (minutes < 45)
            {
                minutes = minutes + 15;
            }
            else
            {
                minutes = (minutes + 15) % 60;
                hours++;
            }

            if (hours > 23)
            {
                hours = -24;
            }
            string result = minutes < 10 ? $"{hours}:{minutes:D2}" : $"{hours}:{minutes}";
            Console.WriteLine(result);
        }
    }
}
