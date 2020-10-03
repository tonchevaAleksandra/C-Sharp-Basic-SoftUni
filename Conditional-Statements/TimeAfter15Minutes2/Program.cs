using System;

namespace TimeAfter15Minutes2
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int allminutes = hours * 60 + minutes + 15;
            int newHours = allminutes / 60;
            if (newHours >= 24)
            {
                newHours = 0;
            }
            int newminutes = allminutes % 60;
            Console.WriteLine($"{newHours}:{newminutes:D2}");
        }
    }
}

