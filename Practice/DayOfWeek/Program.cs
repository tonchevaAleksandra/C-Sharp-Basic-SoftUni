using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayOfWeek = int.Parse(Console.ReadLine());
            switch (dayOfWeek)
            {
                case 1: Console.WriteLine("Monday"); break;
                case 2: Console.WriteLine("Tu"); break;
                case 3: Console.WriteLine("Wed"); break;
                case 4: Console.WriteLine("thur"); break;
                case 5: Console.WriteLine("Fr"); break;
                case 6: Console.WriteLine("st"); break;
                case 7: Console.WriteLine("sun"); break;

                default:
                    Console.WriteLine("Error");
                    break;
            }

        }
    }
}
